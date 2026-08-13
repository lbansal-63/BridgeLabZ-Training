using System;
using System.Collections.Generic;

class Program
{
    static bool HasPair(int[] arr, int target)
    {
        HashSet<int> set = new HashSet<int>();

        foreach (int num in arr)
        {
            int required = target - num;

            if (set.Contains(required))
                return true;

            set.Add(num);
        }

        return false;
    }

    static void Main()
    {
        int[] arr = { 10, 15, 3, 7 };
        int target = 17;

        Console.WriteLine(HasPair(arr, target));
    }
}