using System;

class Program
{
    static Random random = new Random();

    static void Main()
    {
        Console.WriteLine("Think of a number between 1 and 100.");
        Console.WriteLine("I will try to guess it!");

        int low = 1;
        int high = 100;
        bool guessed = false;

        while (!guessed)
        {
            int guess = GenerateGuess(low, high);

            Console.WriteLine("\nMy guess is: " + guess);

            string feedback = GetFeedback();

            if (feedback == "correct")
            {
                Console.WriteLine("Great! I guessed your number.");
                guessed = true;
            }
            else
            {
                UpdateRange(ref low, ref high, guess, feedback);
            }
        }
    }

    static int GenerateGuess(int low, int high)
    {
        return random.Next(low, high + 1);
    }

    static string GetFeedback()
    {
        Console.Write("Is my guess high, low, or correct? ");
        return Console.ReadLine().ToLower();
    }
    
    static void UpdateRange(ref int low, ref int high, int guess, string feedback)
    {
        if (feedback == "high")
        {
            high = guess - 1;
        }
        else if (feedback == "low")
        {
            low = guess + 1;
        }
        else
        {
            Console.WriteLine("Invalid feedback. Please enter high, low, or correct.");
        }
    }
}