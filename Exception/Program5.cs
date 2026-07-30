using System;

public class FormatExp
{
    public static void Main()
    {
        Console.Write("Enter the number: "); 
        string number = Console.ReadLine();

        try
        {
            int num = Convert.ToInt32(number);
            Console.Write("Number is: {0}", num);
        }
        catch(FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}