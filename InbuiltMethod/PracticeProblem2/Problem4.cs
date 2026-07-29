using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of terms: ");
        int terms = int.Parse(Console.ReadLine());

        PrintFibonacci(terms);
    }

    static void PrintFibonacci(int terms)
    {
        int first = 0;
        int second = 1;

        Console.WriteLine("Fibonacci Sequence:");

        for (int i = 1; i <= terms; i++)
        {
            Console.Write(first + " ");

            int next = first + second;
            first = second;
            second = next;
        }
    }
}