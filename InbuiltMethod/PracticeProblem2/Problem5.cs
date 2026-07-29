using System;

class Program
{
    static void Main()
    {
        string text = GetInput();

        if (IsPalindrome(text))
        {
            DisplayResult(true);
        }
        else
        {
            DisplayResult(false);
        }
    }

    static string GetInput()
    {
        Console.Write("Enter a string: ");
        return Console.ReadLine();
    }

    static bool IsPalindrome(string text)
    {
        text = text.ToLower();

        int left = 0;
        int right = text.Length - 1;

        while (left < right)
        {
            if (text[left] != text[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }

    static void DisplayResult(bool result)
    {
        if (result)
        {
            Console.WriteLine("The string is a palindrome.");
        }
        else
        {
            Console.WriteLine("The string is not a palindrome.");
        }
    }
}