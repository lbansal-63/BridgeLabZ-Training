														______________________________________________
														## Employee Payroll & Binary Payslip Processor
														______________________________________________


## 1. Project Overview

The Employee Payroll & Binary Payslip Processor is a C# console-based application designed to generate 
## payslips.bin
## payroll_summary.json
## payroll_audit.log. 

by processing data from employees.csv and taxrates.json 

The system demonstrates the use of different data structures:
* Load Tax config using `Dictionary`
* Seen Employee Id using `HashSet`
* `BinaryReader` to verify binary data.
* `BinaryWriter` for binary payslips records.
* `NUnit` unit testing for important operations

The main purpose of the project is to demonstrate how Employee Payroll & Binary Payslip Processing using FileStream, MemoryStream

---

## 2. Objectives

The main objectives of this project are:
1. Stream employee records.
2. Load tax configuration from JSON.
3. Validate Employee ID, duplicate employees, grade and salary.
4. Calculate tax and net salary.
5. Stage payslip records in MemoryStream.
6. Use BinaryWriter for binary payslip records.
7. Use BinaryReader to verify binary data.

---

## 3. Explanation
In this processor we calculate the tax calculation according to the grades and accordingly we calculate the Gross Salary, Tax Amount and Net Salary
using formula 
			`taxAmount = (grossSalary * (taxPercent / 100))
             netSalary = (grossSalary - taxAmount)`

and also it `handles the exception` when the employee Id is empty, Invalid salary format, negative gross salary, and unknown grade 
and we create the audit to write the data in it using: 
						`auditWriter.WriteLine($"[{DateTime.Now}] SUCCESS: Processed {empId} - {name}")`

and this audit data is then stored in the file named as payroll_audit.log by using buffered stream. 