using System;

class Program
{
    // Find first missing positive integer
    static int FirstMissingPositive(int[] arr)
    {
        int n = arr.Length;

        // Place every positive number x at index x - 1
        for (int i = 0; i < n; i++)
        {
            while (arr[i] > 0 &&
                   arr[i] <= n &&
                   arr[arr[i] - 1] != arr[i])
            {
                int temp = arr[i];

                arr[i] = arr[temp - 1];
                arr[temp - 1] = temp;
            }
        }

        // Find first position containing incorrect value
        for (int i = 0; i < n; i++)
        {
            if (arr[i] != i + 1)
            {
                return i + 1;
            }
        }

        return n + 1;
    }

    // Binary Search
    static int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                return mid;
            }
            else if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1;
    }

    static void Main()
    {
        int[] arr = { 3, 4, -1, 1 };

        // Make a copy because FirstMissingPositive modifies the array
        int[] copy = (int[])arr.Clone();

        int missing = FirstMissingPositive(copy);

        Console.WriteLine(
            "First missing positive: " + missing);

        // Sort for Binary Search
        Array.Sort(arr);

        Console.WriteLine("Sorted array:");

        foreach (int number in arr)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();

        int target = 3;

        int index = BinarySearch(arr, target);

        Console.WriteLine(
            "Index of " + target + ": " + index);
    }
}