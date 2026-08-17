using System;

class Program
{
    static int FindPeak(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] < arr[mid + 1])
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }

        return left;
    }

    static void Main()
    {
        int[] arr = { 1, 3, 5, 7, 6, 4, 2 };

        int index = FindPeak(arr);

        Console.WriteLine("Peak index: " + index);
        Console.WriteLine("Peak element: " + arr[index]);
    }
}