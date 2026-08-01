using System;
using System.Collections.Generic;

class Course
{
    public string Name;
    public List<Student> Students = new List<Student>();

    public Course(string name)
    {
        Name = name;
    }

    public void AddStudent(Student s)
    {
        Students.Add(s);
    }

    public void ShowStudents()
    {
        Console.WriteLine($"\n{Name} Students:");
        foreach (Student s in Students)
            Console.WriteLine(s.Name);
    }
}

class Student
{
    public string Name;
    public List<Course> Courses = new List<Course>();

    public Student(string name)
    {
        Name = name;
    }

    public void Enroll(Course c)
    {
        Courses.Add(c);
        c.AddStudent(this);
    }

    public void ShowCourses()
    {
        Console.WriteLine($"\n{Name}'s Courses:");
        foreach (Course c in Courses)
            Console.WriteLine(c.Name);
    }
}

class School
{
    public string Name;
    public List<Student> Students = new List<Student>();

    public School(string name)
    {
        Name = name;
    }

    public void AddStudent(Student s)
    {
        Students.Add(s);
    }
}

class Program
{
    static void Main()
    {
        School school = new School("ABC School");

        Student s1 = new Student("Ali");
        Student s2 = new Student("Sara");

        school.AddStudent(s1);
        school.AddStudent(s2);

        Course c1 = new Course("Math");
        Course c2 = new Course("Physics");

        s1.Enroll(c1);
        s1.Enroll(c2);
        s2.Enroll(c1);

        s1.ShowCourses();
        c1.ShowStudents();
    }
}