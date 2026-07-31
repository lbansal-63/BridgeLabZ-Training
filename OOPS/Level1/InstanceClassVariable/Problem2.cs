using System;

class Course
{
    private string courseName;
    private int duration;
    private double fee;

    private static string instituteName = "ABC Institute";

    public Course(string courseName, int duration, double fee)
    {
        this.courseName = courseName;
        this.duration = duration;
        this.fee = fee;
    }

    public void DisplayCourseDetails()
    {
        Console.WriteLine($"{courseName} | {duration} Months | {fee}");
        Console.WriteLine("Institute: " + instituteName);
    }

    public static void UpdateInstituteName(string newName)
    {
        instituteName = newName;
    }
}