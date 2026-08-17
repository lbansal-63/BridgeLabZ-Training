using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}

class EmployeeSerialization
{
    static void Main()
    {
        string fileName = "employees.json";

        try
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Employee employee = new Employee();

                Console.Write("\nEnter Employee ID: ");
                employee.Id = int.Parse(Console.ReadLine());

                Console.Write("Enter Name: ");
                employee.Name = Console.ReadLine();

                Console.Write("Enter Department: ");
                employee.Department = Console.ReadLine();

                Console.Write("Enter Salary: ");
                employee.Salary = double.Parse(Console.ReadLine());

                employees.Add(employee);
            }

            // Serialize
            string json = JsonSerializer.Serialize(
                employees,
                new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(fileName, json);

            Console.WriteLine("\nEmployees saved successfully.");

            // Deserialize
            string savedData = File.ReadAllText(fileName);

            List<Employee> retrievedEmployees =
                JsonSerializer.Deserialize<List<Employee>>(savedData);

            Console.WriteLine("\nRetrieved Employees:");

            foreach (Employee employee in retrievedEmployees)
            {
                Console.WriteLine(
                    $"ID: {employee.Id}, " +
                    $"Name: {employee.Name}, " +
                    $"Department: {employee.Department}, " +
                    $"Salary: {employee.Salary}");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
        catch (JsonException ex)
        {
            Console.WriteLine("Serialization error: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input format.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}