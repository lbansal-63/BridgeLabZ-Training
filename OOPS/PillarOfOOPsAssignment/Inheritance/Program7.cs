using System;


class Course
{
    public string CourseName;
    public int Duration;


    public Course(string name, int duration)
    {
        CourseName = name;
        Duration = duration;
    }


    public virtual void Display()
    {
        Console.WriteLine("Course Name: " + CourseName);
        Console.WriteLine("Duration: " + Duration + " Months");
    }
}



class OnlineCourse : Course
{
    public string Platform;
    public bool IsRecorded;


    public OnlineCourse(
        string name,
        int duration,
        string platform,
        bool recorded)
        : base(name, duration)
    {
        Platform = platform;
        IsRecorded = recorded;
    }


    public override void Display()
    {
        base.Display();
        Console.WriteLine("Platform: " + Platform);
        Console.WriteLine("Recorded: " + IsRecorded);
    }
}



class PaidOnlineCourse : OnlineCourse
{
    public double Fee;
    public double Discount;


    public PaidOnlineCourse(
        string name,
        int duration,
        string platform,
        bool recorded,
        double fee,
        double discount)
        : base(name, duration, platform, recorded)
    {
        Fee = fee;
        Discount = discount;
    }


    public override void Display()
    {
        base.Display();
        Console.WriteLine("Fee: " + Fee);
        Console.WriteLine("Discount: " + Discount + "%");
    }
}



class Program
{
    static void Main(string[] args)
    {
        PaidOnlineCourse course =
            new PaidOnlineCourse(
                "C# Programming",
                3,
                "Udemy",
                true,
                5000,
                20
            );


        course.Display();
    }
}