using System;

class Program
{
    static int FindFirstNegative(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                return i;
            }
        }

        return -1;
    }

    static void Main()
    {
        int[] arr = { 10, 5, 8, -3, 7, -9 };

        int index = FindFirstNegative(arr);

        if (index != -1)
            Console.WriteLine("First negative number: " +
                              arr[index] +
                              " at index " + index);
        else
            Console.WriteLine("No negative number found.");
    }
}