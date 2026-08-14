using System;

class Program
{
    static void BubbleSort(int[] marks)
    {
        for (int i = 0; i < marks.Length - 1; i++)
        {
            bool swapped = false;

            for (int j = 0; j < marks.Length - i - 1; j++)
            {
                if (marks[j] > marks[j + 1])
                {
                    int temp = marks[j];
                    marks[j] = marks[j + 1];
                    marks[j + 1] = temp;

                    swapped = true;
                }
            }

            if (!swapped)
                break;
        }
    }

    static void Main()
    {
        int[] marks = { 85, 45, 72, 90, 60 };

        BubbleSort(marks);

        Console.WriteLine("Sorted Student Marks:");
        Console.WriteLine(string.Join(" ", marks));
    }
}