using System;
using System.Collections.Generic;

class Program
{
    static int CountZeroSumSubarrays(int[] arr)
    {
        Dictionary<int, int> map =
            new Dictionary<int, int>();

        // Sum = 0 initially
        map[0] = 1;

        int sum = 0;
        int count = 0;

        foreach (int num in arr)
        {
            sum += num;

            if (map.ContainsKey(sum))
            {
                count += map[sum];
                map[sum]++;
            }
            else
            {
                map[sum] = 1;
            }
        }

        return count;
    }

    static void Main()
    {
        int[] arr = { 6, 3, -1, -3, 4, -2, 2, 4, 6, -12, -7 };

        Console.WriteLine(CountZeroSumSubarrays(arr));
    }
}