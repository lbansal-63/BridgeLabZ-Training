using System;
using System.Collections.Generic;

interface IDepartment
{
    void AssignDepartment(string department);
    void GetDepartmentDetails();
}


abstract class Employee
{
    
    private int employeeId;
    private string name;
    private double baseSalary;

    
    public int EmployeeId
    {
        get { 
            return employeeId;
        }
        set { 
            employeeId = value;
        }
    }

    public string Name
    {
        get { 
            return name; 
        }
        set { 
            name = value; 
        }
    }

    public double BaseSalary
    {
        get {
            return baseSalary;
        }
        set {
            baseSalary = value; 
        }
    }

    
    public Employee(int id, string name, double salary)
    {
        EmployeeId = id;
        Name = name;
        BaseSalary = salary;
    }

    
    public abstract double CalculateSalary();

   
    public void DisplayDetails()
    {
        Console.WriteLine("Employee ID : " + EmployeeId);
        Console.WriteLine("Employee Name : " + Name);
        Console.WriteLine("Base Salary : " + BaseSalary);
    }
}


class FullTimeEmployee : Employee, IDepartment
{
    private string department;

    public FullTimeEmployee(int id, string name, double salary)
        : base(id, name, salary)
    {
    }

    public override double CalculateSalary()
    {
        return BaseSalary;
    }

    public void AssignDepartment(string department)
    {
        this.department = department;
    }

    public void GetDepartmentDetails()
    {
        Console.WriteLine("Department : " + department);
    }
}


class PartTimeEmployee : Employee, IDepartment
{
    private string department;
    private int workHours;
    private double hourlyRate;

    public PartTimeEmployee(int id, string name, double hourlyRate, int workHours)
        : base(id, name, 0)
    {
        this.hourlyRate = hourlyRate;
        this.workHours = workHours;
    }

    public override double CalculateSalary()
    {
        return hourlyRate * workHours;
    }

    public void AssignDepartment(string department)
    {
        this.department = department;
    }

    public void GetDepartmentDetails()
    {
        Console.WriteLine("Department : " + department);
    }
}


class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();

        FullTimeEmployee emp1 = new FullTimeEmployee(101, "Rahul", 50000);
        emp1.AssignDepartment("HR");

        PartTimeEmployee emp2 = new PartTimeEmployee(102, "Aman", 500, 80);
        emp2.AssignDepartment("IT");

        employees.Add(emp1);
        employees.Add(emp2);

        Console.WriteLine("===== Employee Details =====\n");

        foreach (Employee emp in employees)
        {
            emp.DisplayDetails();
            Console.WriteLine("Salary : " + emp.CalculateSalary());

            IDepartment dept = (IDepartment)emp;
            dept.GetDepartmentDetails();

            Console.WriteLine("----------------------------");
        }

        Console.ReadLine();
    }
}