using System;
using System.Collections.Generic;

class Program
{
    static void RotateLeft(List<int> list, int k)
    {
        int n = list.Count;

        if (n == 0)
            return;

        k = k % n;

        for (int i = 0; i < k; i++)
        {
            int first = list[0];

            for (int j = 0; j < n - 1; j++)
            {
                list[j] = list[j + 1];
            }

            list[n - 1] = first;
        }
    }

    static void Main()
    {
        List<int> list =
            new List<int> { 10, 20, 30, 40, 50 };

        RotateLeft(list, 2);

        Console.WriteLine(string.Join(", ", list));
    }
}