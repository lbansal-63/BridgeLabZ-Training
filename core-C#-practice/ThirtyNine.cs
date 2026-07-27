using System;
public class RevNum
{
    public static void Main()
    {
        Console.Write("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int digit = 0;
        int rev = 0;
        while (num != 0)
        {
            digit = num % 10;
            rev = (rev * 10) + digit;
            num /= 10;
        }

        Console.WriteLine("Reverse Number: "+rev);
    }
}