using System;

class Employee
{
    public static string CompanyName = "ABC Technologies";
    private static int totalEmployees = 0;

    public string Name;
    public readonly int Id;
    public string Designation;

    public Employee(string name, int id, string designation)
    {
        this.Name = name;
        this.Id = id;
        this.Designation = designation;
        totalEmployees++;
    }

    public void Display()
    {
        Console.WriteLine("Company : " + CompanyName);
        Console.WriteLine("Name : " + Name);
        Console.WriteLine("ID : " + Id);
        Console.WriteLine("Designation : " + Designation);
    }

    public static void DisplayTotalEmployees()
    {
        Console.WriteLine("Total Employees : " + totalEmployees);
    }
}

class Program
{
    static void Main()
    {
        Employee e = new Employee("Anita", 101, "Developer");

        if (e is Employee)
        {
            e.Display();
        }

        Employee.DisplayTotalEmployees();
    }
}