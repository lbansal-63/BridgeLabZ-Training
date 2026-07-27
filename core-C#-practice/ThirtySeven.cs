using System;
public class Odd
{
    public static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 1)
            {
                Console.Write(i + " ");
            }
        }
    }
}