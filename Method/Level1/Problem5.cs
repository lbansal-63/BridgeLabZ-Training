using System;
public class Program5
{
    public static int PosNeg(int n)
    {
        if (n < 0)
        {
            return -1;
        }
        else if (n > 0)
        {
            return 1;
        }
        else
        {
            return 0; 
        }
    }

    public static void Main()
    {
        int n;
        Console.Write("Enter the number: ");
        n = Convert.ToInt32(Console.ReadLine());

        int res = Program5.PosNeg(n);

        if (res == -1)
        {
            Console.WriteLine("Negative Number!!"); 
        }
        else if (res == 1)
        {
            Console.WriteLine("Positive Number!!");
        }
        else
        {
            Console.WriteLine("Zero");
        }
    }
}