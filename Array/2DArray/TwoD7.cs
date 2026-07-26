using System;
public class SumOfleftDiagonal
{
    public static void Main()
    {
        int n = 4;
        int[,] arr = new int[n, n];

        // taking input the array from user 
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("Enter the number: ");
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // print left diagonal sum 
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if ((i+j)==(n-1))
                {
                    sum += arr[i, j];
                }
            }
        }
        Console.WriteLine("Sum of right diagonal is: " + sum);

    }
}