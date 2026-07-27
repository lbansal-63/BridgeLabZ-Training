using System;

public class Method2
{
    public static void showName(string Name = "Unknown") // optional parameter 
    {
        Console.WriteLine("Your name is: "+Name);
    }

    public static void showAge(int age = 18) // optional parameter 
    {
        Console.WriteLine("Your age is: " + age);
    }

    public static void ShowNameAge(string name,int age)
    {
        Console.WriteLine("Your name is: " + name);
        Console.WriteLine("Your age is: " + age);
    }

    public static void Main()
    {
        Method2.showName("Aditya");
        Method2.showName("Laksha");
        Method2.showName(); 

        Method2.showAge(20);
        Method2.showAge();

        Method2.ShowNameAge("Laksha", 21);
        Method2.ShowNameAge(age:30,name:"Pranav"); // named arguments 
    }
}