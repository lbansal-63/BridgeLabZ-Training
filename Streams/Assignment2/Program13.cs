using System;

class Program
{
    static bool SearchMatrix(int[,] matrix, int target)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            int left = 0;
            int right = columns - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (matrix[i, mid] == target)
                {
                    return true;
                }
                else if (matrix[i, mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
        }

        return false;
    }

    static void Main()
    {
        int[,] matrix =
        {
            { 1, 3, 5, 7 },
            { 10, 11, 16, 20 },
            { 23, 30, 34, 60 }
        };

        int target = 16;

        if (SearchMatrix(matrix, target))
            Console.WriteLine("Target found.");
        else
            Console.WriteLine("Target not found.");
    }
}