using System;
public class TwoDDemo3
{
    public static void Main()
    {

        int[,] nums = new int[2, 3];

        for(int i = 0; i < nums.GetLength(0); i++)
        {
            for(int j = 0; j < nums.GetLength(1); j++)
            {
                Console.Write("Enter the number: ");
                nums[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
       

        Console.WriteLine();

        //Retrieve the value from two-Dimensional Array 
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(nums[i,j]+"\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        foreach (int item in nums)
        {
            Console.Write(item+"\t"); 
        }
        
    }
}