using System;
public class Number
{
    public static void Main()
    {
        int age;
        Console.WriteLine("Enter your age: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (age>=18)
        {
            Console.WriteLine("The person's age is "+age+" and can vote.");
        }
        else
        {
            Console.WriteLine("The person's age is " + age + " and cannot vote.");
        }
    }
}