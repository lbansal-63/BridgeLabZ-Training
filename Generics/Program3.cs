using System;
using System.Collections.Generic;

// =====================================
// Base Course Type
// =====================================

public abstract class CourseType
{
    public string CourseName { get; set; }

    protected CourseType(string courseName)
    {
        CourseName = courseName;
    }

    public abstract void Evaluate();
}


// =====================================
// Exam Course
// =====================================

public class ExamCourse : CourseType
{
    public int ExamMarks { get; set; }

    public ExamCourse(
        string courseName,
        int examMarks)
        : base(courseName)
    {
        ExamMarks = examMarks;
    }

    public override void Evaluate()
    {
        Console.WriteLine(
            $"{CourseName} evaluated through exam.");
    }
}


// =====================================
// Assignment Course
// =====================================

public class AssignmentCourse : CourseType
{
    public int AssignmentMarks { get; set; }

    public AssignmentCourse(
        string courseName,
        int assignmentMarks)
        : base(courseName)
    {
        AssignmentMarks = assignmentMarks;
    }

    public override void Evaluate()
    {
        Console.WriteLine(
            $"{CourseName} evaluated through assignment.");
    }
}


// =====================================
// Generic Course
// =====================================

public class Course<T>
    where T : CourseType
{
    public int CourseId { get; set; }

    public T CourseType { get; set; }

    public Course(
        int courseId,
        T courseType)
    {
        CourseId = courseId;
        CourseType = courseType;
    }

    public void Display()
    {
        Console.WriteLine(
            $"Course ID: {CourseId}, " +
            $"Course: {CourseType.CourseName}");
    }

    public void Evaluate()
    {
        CourseType.Evaluate();
    }
}


// =====================================
// University
// =====================================

public class University
{
    private List<CourseType> courses =
        new List<CourseType>();

    public void AddCourse(CourseType course)
    {
        courses.Add(course);
    }

    public void DisplayCourses()
    {
        foreach (CourseType course in courses)
        {
            Console.WriteLine(
                $"Course: {course.CourseName}");

            course.Evaluate();
        }
    }
}


// =====================================
// Program
// =====================================

public class Program
{
    public static void Main()
    {
        ExamCourse exam =
            new ExamCourse(
                "C# Programming",
                100);

        AssignmentCourse assignment =
            new AssignmentCourse(
                "Database Management",
                50);


        Course<ExamCourse> examCourse =
            new Course<ExamCourse>(
                101,
                exam);

        Course<AssignmentCourse> assignmentCourse =
            new Course<AssignmentCourse>(
                102,
                assignment);


        examCourse.Display();
        examCourse.Evaluate();

        Console.WriteLine();

        assignmentCourse.Display();
        assignmentCourse.Evaluate();


        Console.WriteLine(
            "\nUniversity Courses:");

        University university =
            new University();

        university.AddCourse(exam);
        university.AddCourse(assignment);

        university.DisplayCourses();
    }
}