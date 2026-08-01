using System;
using System.Collections.Generic;

class Faculty
{
    public string Name;

    public Faculty(string name)
    {
        Name = name;
    }
}

class Department
{
    public string Name;

    public Department(string name)
    {
        Name = name;
    }
}

class University
{
    public List<Department> Departments = new List<Department>();
    public List<Faculty> Faculties = new List<Faculty>();

    public void AddDepartment(string name)
    {
        Departments.Add(new Department(name));
    }

    public void AddFaculty(Faculty faculty)
    {
        Faculties.Add(faculty);
    }

    public void DeleteUniversity()
    {
        Departments.Clear();
        Console.WriteLine("University deleted. Departments removed.");
    }
}

class Program
{
    static void Main()
    {
        University u = new University();

        Faculty f = new Faculty("Dr. Ahmed");

        u.AddFaculty(f);
        u.AddDepartment("Computer Science");

        u.DeleteUniversity();

        Console.WriteLine($"{f.Name} still exists.");
    }
}