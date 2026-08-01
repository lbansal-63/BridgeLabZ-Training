using System;
using System.Collections.Generic;

class Professor
{
    public string Name;

    public Professor(string name)
    {
        Name = name;
    }

    public void AssignProfessor(Course course)
    {
        course.Professor = this;
    }
}

class Course
{
    public string Name;
    public Professor Professor;
    public List<Student> Students = new List<Student>();

    public Course(string name)
    {
        Name = name;
    }
}

class Student
{
    public string Name;

    public Student(string name)
    {
        Name = name;
    }

    public void EnrollCourse(Course course)
    {
        course.Students.Add(this);
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student("Ali");
        Professor professor = new Professor("Dr. Ahmed");
        Course course = new Course("Programming");

        student.EnrollCourse(course);
        professor.AssignProfessor(course);

        Console.WriteLine($"{student.Name} enrolled in {course.Name}");
        Console.WriteLine($"{course.Professor.Name} teaches {course.Name}");
    }
}