using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        int maxCount = 0;
        char maxChar = ' ';

        foreach (char ch in str)
        {
            int count = 0;

            foreach (char c in str)
            {
                if (c == ch)
                    count++;
            }

            if (count > maxCount)
            {
                maxCount = count;
                maxChar = ch;
            }
        }

        Console.WriteLine("Most Frequent Character: " + maxChar);
    }
}