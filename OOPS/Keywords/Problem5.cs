using System;

class Student
{
    public static string UniversityName = "Delhi University";
    private static int totalStudents = 0;

    public string Name;
    public readonly int RollNumber;
    public string Grade;

    public Student(string name, int rollNumber, string grade)
    {
        this.Name = name;
        this.RollNumber = rollNumber;
        this.Grade = grade;
        totalStudents++;
    }

    public void Display()
    {
        Console.WriteLine("University : " + UniversityName);
        Console.WriteLine("Name : " + Name);
        Console.WriteLine("Roll No : " + RollNumber);
        Console.WriteLine("Grade : " + Grade);
    }

    public static void DisplayTotalStudents()
    {
        Console.WriteLine("Total Students : " + totalStudents);
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student("Riya", 11, "A");

        if (s is Student)
        {
            s.Display();
        }

        Student.DisplayTotalStudents();
    }
}