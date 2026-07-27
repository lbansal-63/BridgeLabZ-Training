using System;
public class Pallindrome
{
    public static void Main()
    {
        Console.Write("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int temp = num;
        int digit = 0;
        int rev = 0;
        while (num != 0)
        {
            digit = num % 10;
            rev = (rev * 10) + digit;
            num /= 10;
        }

        if (temp == rev)
        {
            Console.WriteLine("Pallindrome Number!!");
        }
        else
        {
            Console.WriteLine("Not a Pallindrome Number"); 
        }
    }
}