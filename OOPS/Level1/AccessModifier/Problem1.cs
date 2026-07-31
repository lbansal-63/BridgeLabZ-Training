using System;

class Student
{
    public int rollNumber;
    protected string name;
    private double cgpa;

    public void SetCGPA(double cgpa)
    {
        this.cgpa = cgpa;
    }

    public double GetCGPA()
    {
        return cgpa;
    }

    public Student(int roll, string name)
    {
        rollNumber = roll;
        this.name = name;
    }
}

class PostgraduateStudent : Student
{
    public PostgraduateStudent(int roll, string name) : base(roll, name)
    {
    }

    public void Display()
    {
        Console.WriteLine(rollNumber);
        Console.WriteLine(name);
    }
}