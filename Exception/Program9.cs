using System;
public class Program
{
    public static void Main()
    {
        Console.Write("Enter your age: "); 
        int age = Convert.ToInt32(Console.ReadLine());

        try
        {
            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote");
            }
            else
            {
                throw new Exception("You are not eligible to vote");
            }
        }

        catch(Exception ex)
        {
            Console.Write(ex.Message);
        }

    }
}