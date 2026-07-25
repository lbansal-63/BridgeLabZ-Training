using System;
public class Number
{
    public static void Main()
    {
        int num;
        Console.Write("Enter the number: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num <= 0)
        {
            Console.Write("Enter valid Number");
            return; 
        }

        for (int i = 1; i <= num; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i + " is Even");
            }
            else
            {
                Console.WriteLine(i + " is Odd");
            }
        }

    }
}