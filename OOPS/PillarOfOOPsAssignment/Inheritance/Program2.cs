using System;

class Employee
{
    public string Name;
    public int Id;
    public double Salary;


    public Employee(string name, int id, double salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
    }


    public virtual void DisplayDetails()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Salary: " + Salary);
    }
}


class Manager : Employee
{
    public int TeamSize;


    public Manager(string name, int id, double salary, int teamSize)
        : base(name, id, salary)
    {
        TeamSize = teamSize;
    }


    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Team Size: " + TeamSize);
    }
}



class Developer : Employee
{
    public string ProgrammingLanguage;


    public Developer(string name, int id, double salary, string language)
        : base(name, id, salary)
    {
        ProgrammingLanguage = language;
    }


    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Programming Language: "
                          + ProgrammingLanguage);
    }
}



class Intern : Employee
{
    public string InternshipDuration;


    public Intern(string name, int id, double salary, string duration)
        : base(name, id, salary)
    {
        InternshipDuration = duration;
    }


    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Internship Duration: "
                          + InternshipDuration);
    }
}



class Program
{
    static void Main(string[] args)
    {

        Employee e1 = new Manager(
            "Rahul", 101, 80000, 10);

        Employee e2 = new Developer(
            "Amit", 102, 60000, "C#");

        Employee e3 = new Intern(
            "Ravi", 103, 15000, "6 Months");


        e1.DisplayDetails();
        Console.WriteLine();

        e2.DisplayDetails();
        Console.WriteLine();

        e3.DisplayDetails();
    }
}