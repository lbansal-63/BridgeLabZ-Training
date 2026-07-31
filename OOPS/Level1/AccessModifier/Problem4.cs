using System;

class Employee
{
    public int employeeID;
    protected string department;
    private double salary;

    public Employee(int employeeID, string department)
    {
        this.employeeID = employeeID;
        this.department = department;
    }

    public void SetSalary(double salary)
    {
        this.salary = salary;
    }

    public double GetSalary()
    {
        return salary;
    }
}

class Manager : Employee
{
    public Manager(int employeeID, string department)
        : base(employeeID, department)
    {
    }

    public void Display()
    {
        Console.WriteLine(employeeID);
        Console.WriteLine(department);
    }
}