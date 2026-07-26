using System;

public class ArrayDemo4
{
    public static void Main()
    {
        int[] nums = new int[5];

        for (int i = 0; i < nums.Length; i++)
        { 
            Console.Write("Enter the number: ");
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }

        int sum = 0; 
        for (int i = 0; i < nums.Length; i++){
            sum += nums[i];
        }

        Console.Write("Sum: " + sum);

    }
}
