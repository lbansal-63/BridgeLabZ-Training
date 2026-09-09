using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace PayrollProcessor
{
    public class PayrollException : Exception
    {
        public PayrollException(string message) : base(message) { }
    }

    public class UnknownGradeException : PayrollException
    {
        public UnknownGradeException(string grade) : base($"Unknown grade encountered: '{grade}'") { }
    }

    public class NegativeSalaryException : PayrollException
    {
        public NegativeSalaryException(decimal salary) : base($"Negative salary encountered: {salary}") { }
    }

    public class DuplicateEmployeeException : PayrollException
    {
        public DuplicateEmployeeException(string empId) : base($"Duplicate employee ID detected: '{empId}'") { }
    }

    public class TaxConfig
    {
        public List<GradeTaxInfo> Grades { get; set; } = new();
    }

    public class GradeTaxInfo
    {
        public string Grade { get; set; } = "";
        public decimal TaxPercent { get; set; }
    }

    public class PayslipRecord
    {
        public string EmpId { get; set; } = "";
        public string Name { get; set; } = "";
        public string Grade { get; set; } = "";
        public decimal GrossSalary { get; set; }
        public decimal TaxRate { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal NetSalary { get; set; }
    }

    public class PayrollSummary
    {
        public int TotalProcessed { get; set; }
        public int TotalFailed { get; set; }
        public decimal TotalGrossSalary { get; set; }
        public decimal TotalTaxAmount { get; set; }
        public decimal TotalNetSalary { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string csvPath = @"D:\Emp\employees.csv";
            string jsonTaxPath = @"D:\Emp\taxrates.json";
            string binaryOutPath = @"D:\Emp\payslips.bin";
            string summaryOutPath = @"D:\Emp\payroll_summary.json";
            string auditLogPath = @"D:\Emp\payroll_audit.log";

            var taxRates = LoadTaxConfig(jsonTaxPath);
            var validRecords = new List<PayslipRecord>();
            int failedCount = 0;
            var seenEmpIds = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            using (var logFs = new FileStream(auditLogPath, FileMode.Create, FileAccess.Write))
            using (var bufferedLog = new BufferedStream(logFs))
            using (var auditWriter = new StreamWriter(bufferedLog))
            using (var csvReader = new StreamReader(csvPath))
            {
                auditWriter.WriteLine($"[{DateTime.Now}] Processing Started.");

                string? header = csvReader.ReadLine(); 

                while (!csvReader.EndOfStream)
                {
                    string? line = csvReader.ReadLine();
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    string[] parts = line.Split(',');
                    if (parts.Length < 4) continue;

                    string empId = parts[0].Trim();
                    string name = parts[1].Trim();
                    string grade = parts[2].Trim();

                    try
                    {
                        if (string.IsNullOrWhiteSpace(empId))
                            throw new PayrollException("EmpId cannot be empty.");

                        if (!seenEmpIds.Add(empId))
                            throw new DuplicateEmployeeException(empId);

                        if (!decimal.TryParse(parts[3].Trim(), out decimal grossSalary))
                            throw new PayrollException("Invalid salary format.");

                        if (grossSalary < 0)
                            throw new NegativeSalaryException(grossSalary);

                        if (!taxRates.TryGetValue(grade, out decimal taxPercent))
                            throw new UnknownGradeException(grade);

                        decimal taxAmount = (grossSalary * (taxPercent / 100m));
                        decimal netSalary = (grossSalary - taxAmount);

                        var record = new PayslipRecord
                        {
                            EmpId = empId,
                            Name = name,
                            Grade = grade,
                            GrossSalary = grossSalary,
                            TaxRate = taxPercent,
                            TaxAmount = taxAmount,
                            NetSalary = netSalary
                        };

                        validRecords.Add(record);
                        auditWriter.WriteLine($"[{DateTime.Now}] SUCCESS: Processed {empId} - {name}");
                    }

                    catch (PayrollException ex)
                    {
                        failedCount++;
                        auditWriter.WriteLine($"[{DateTime.Now}] REJECTED ({empId}): {ex.Message}");
                    }
                }

                auditWriter.WriteLine($"[{DateTime.Now}] Processing Completed. Valid: {validRecords.Count}, Failed: {failedCount}");
            }

            using (var memStream = new MemoryStream())
            {
                using (var writer = new BinaryWriter(memStream, Encoding.UTF8, leaveOpen: true))
                {
                    foreach (var record in validRecords)
                    {
                        writer.Write(record.EmpId);
                        writer.Write(record.Name);
                        writer.Write(record.Grade);
                        writer.Write(record.GrossSalary);
                        writer.Write(record.TaxRate);
                        writer.Write(record.TaxAmount);
                        writer.Write(record.NetSalary);
                    }
                }

                File.WriteAllBytes(binaryOutPath, memStream.ToArray());
            }

            List<PayslipRecord> verifiedRecords = VerifyBinaryFile(binaryOutPath);
            Console.WriteLine($"Successfully read {verifiedRecords.Count} records from {binaryOutPath}");

            var summary = new PayrollSummary
            {
                TotalProcessed = validRecords.Count,
                TotalFailed = failedCount,
                TotalGrossSalary = validRecords.Sum(r => r.GrossSalary),
                TotalTaxAmount = validRecords.Sum(r => r.TaxAmount),
                TotalNetSalary = validRecords.Sum(r => r.NetSalary)
            };

            string summaryJson = JsonSerializer.Serialize(summary, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(summaryOutPath, summaryJson);

            Console.WriteLine("Payroll processing finished successfully!");
            Console.ReadLine();
        }

        private static Dictionary<string, decimal> LoadTaxConfig(string jsonPath)
        {
            string json = File.ReadAllText(jsonPath);
            var config = JsonSerializer.Deserialize<TaxConfig>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            var dict = new Dictionary<string, decimal>(StringComparer.OrdinalIgnoreCase);
            if (config?.Grades != null)
            {
                foreach (var item in config.Grades)
                {
                    dict[item.Grade] = item.TaxPercent;
                }
            }
            return dict;
        }

        private static List<PayslipRecord> VerifyBinaryFile(string filePath)
        {
            var records = new List<PayslipRecord>();
            using (var fs = File.OpenRead(filePath))
            using (var reader = new BinaryReader(fs, Encoding.UTF8))
            {
                while (fs.Position < fs.Length)
                {
                    records.Add(new PayslipRecord
                    {
                        EmpId = reader.ReadString(),
                        Name = reader.ReadString(),
                        Grade = reader.ReadString(),
                        GrossSalary = reader.ReadDecimal(),
                        TaxRate = reader.ReadDecimal(),
                        TaxAmount = reader.ReadDecimal(),
                        NetSalary = reader.ReadDecimal()
                    });
                }
            }
            return records;
        }
    }
}