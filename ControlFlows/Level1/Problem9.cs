using System;
public class RocketLaunch
{
    public static void Main()
    {
        int counter;
        Console.Write("Enter the number: ");
        counter = Convert.ToInt32(Console.ReadLine());


        for(int i=counter;i>0;i--)
        {
            Console.WriteLine(counter);
            counter -= 1; 
        }
        Console.WriteLine("Rocket Launch!!");

    }
}