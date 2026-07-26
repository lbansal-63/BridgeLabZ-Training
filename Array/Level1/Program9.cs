using System;
public class Array
{
    public static void Main()
    {
        int row,col;
        Console.Write("Enter the number of rows: ");
        row = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of cols: ");
        col = Convert.ToInt32(Console.ReadLine());

        int[,] nums = new int[row, col];
        for (int i = 0; i < row; i++)
        {
            for(int j = 0; j < col; j++)
            {
                Console.Write("Enter the number: ");
                nums[i, j] = Convert.ToInt32(Console.ReadLine()); 
            }
        }

        int[] arr = new int[row * col];
        int idx = 0; 
        for(int i = 0; i < row; i++)
        {
            for(int j = 0; j < col; j++)
            {
                arr[idx++] = nums[i, j];
            }
        }

        // Display 1D array
        Console.Write("1D Array: ");

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }

    }
}