using System;

class Program
{
    static void CountingSort(int[] ages)
    {
        int min = 10;
        int max = 18;

        int[] count = new int[max - min + 1];

        // Count occurrences
        foreach (int age in ages)
        {
            count[age - min]++;
        }

        // Place values back into the array
        int index = 0;

        for (int i = 0; i < count.Length; i++)
        {
            while (count[i] > 0)
            {
                ages[index] = i + min;
                index++;
                count[i]--;
            }
        }
    }

    static void Main()
    {
        int[] ages = { 15, 12, 18, 10, 14, 12, 16, 15 };

        CountingSort(ages);

        Console.WriteLine("Sorted Student Ages:");
        Console.WriteLine(string.Join(" ", ages));
    }
}