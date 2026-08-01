using System;
using System.Collections.Generic;

class Employee
{
    public string Name;

    public Employee(string name)
    {
        Name = name;
    }
}

class Department
{
    public string Name;
    public List<Employee> Employees = new List<Employee>();

    public Department(string name)
    {
        Name = name;
    }

    public void AddEmployee(string name)
    {
        Employees.Add(new Employee(name));
    }
}

class Company
{
    public string Name;
    List<Department> departments = new List<Department>();

    public Company(string name)
    {
        Name = name;
    }

    public void AddDepartment(string deptName)
    {
        departments.Add(new Department(deptName));
    }

    public void DeleteCompany()
    {
        departments.Clear();
        Console.WriteLine("Company deleted with all departments and employees.");
    }
}

class Program
{
    static void Main()
    {
        Company company = new Company("Tech Ltd");

        company.AddDepartment("IT");
        company.AddDepartment("HR");

        company.DeleteCompany();
    }
}