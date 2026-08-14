using System;

class Program
{
    static void InsertionSort(int[] ids)
    {
        for (int i = 1; i < ids.Length; i++)
        {
            int key = ids[i];
            int j = i - 1;

            while (j >= 0 && ids[j] > key)
            {
                ids[j + 1] = ids[j];
                j--;
            }

            ids[j + 1] = key;
        }
    }

    static void Main()
    {
        int[] employeeIds = { 105, 102, 108, 101, 104 };

        InsertionSort(employeeIds);

        Console.WriteLine("Sorted Employee IDs:");
        Console.WriteLine(string.Join(" ", employeeIds));
    }
}