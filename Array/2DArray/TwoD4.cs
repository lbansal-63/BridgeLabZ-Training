using System;
public class TwoDDemo4
{
    public static void Main()
    {

        int[,] nums = new int[2, 3];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Enter the number: ");
                nums[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int sum = 0; 
        
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                sum += nums[i, j];
            }
        }

        Console.Write("Sum: "+sum);

    }
}