using System;
using System.Collections.Generic;

class Program
{
    static int LongestConsecutive(int[] nums)
    {
        HashSet<int> set = new HashSet<int>(nums);

        int longest = 0;

        foreach (int num in set)
        {
            // Sequence ka starting point
            if (!set.Contains(num - 1))
            {
                int current = num;
                int length = 1;

                while (set.Contains(current + 1))
                {
                    current++;
                    length++;
                }

                longest = Math.Max(longest, length);
            }
        }

        return longest;
    }

    static void Main()
    {
        int[] nums = { 100, 4, 200, 1, 3, 2 };

        Console.WriteLine(LongestConsecutive(nums));
    }
}