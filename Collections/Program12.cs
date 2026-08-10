using System;
using System.Collections.Generic;

class Program
{
    static void GenerateBinary(int n)
    {
        Queue<string> queue =
            new Queue<string>();

        queue.Enqueue("1");

        for (int i = 0; i < n; i++)
        {
            string current = queue.Dequeue();

            Console.WriteLine(current);

            queue.Enqueue(current + "0");
            queue.Enqueue(current + "1");
        }
    }

    static void Main()
    {
        GenerateBinary(5);
    }
}