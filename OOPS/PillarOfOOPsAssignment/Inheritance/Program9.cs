using System;


class Person
{
    public string Name;
    public int Age;


    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }


    public virtual void DisplayRole()
    {
        Console.WriteLine("Person");
    }
}



class Teacher : Person
{
    public string Subject;


    public Teacher(
        string name,
        int age,
        string subject)
        : base(name, age)
    {
        Subject = subject;
    }


    public override void DisplayRole()
    {
        Console.WriteLine("Role: Teacher");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Subject: " + Subject);
    }
}



class Student : Person
{
    public string Grade;


    public Student(
        string name,
        int age,
        string grade)
        : base(name, age)
    {
        Grade = grade;
    }


    public override void DisplayRole()
    {
        Console.WriteLine("Role: Student");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Grade: " + Grade);
    }
}



class Staff : Person
{
    public string Department;


    public Staff(
        string name,
        int age,
        string department)
        : base(name, age)
    {
        Department = department;
    }


    public override void DisplayRole()
    {
        Console.WriteLine("Role: Staff");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Department: " + Department);
    }
}



class Program
{
    static void Main(string[] args)
    {

        Person[] people =
        {
            new Teacher("Rahul",35,"C# Programming"),
            new Student("Amit",20,"BCA"),
            new Staff("Neha",40,"Administration")
        };


        foreach (Person p in people)
        {
            p.DisplayRole();
            Console.WriteLine();
        }

    }
}