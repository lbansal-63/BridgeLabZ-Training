using System;

public class ArrayDemo3
{
    public static void Main()
    {
        int[] nums = new int[5];

        for (int i = 0; i < 5; i++){
            Console.Write("Enter the number: ");
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < 5; i++){
            Console.Write(nums[i] + " ");
        }

    }
}
