using System;

public class ArrayDemo5{
    public static void Main(){
        int[] nums = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter the number: ");
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }

        int eCount = 0; 
        int oCount = 0;
        for (int i = 0; i < 10; i++)
        {
            if (nums[i] % 2 == 0){
               eCount ++;
            }
            else
            {
                oCount++; 
            }
        }


        Console.WriteLine("Even Count: " +eCount);
        Console.WriteLine("Odd Count: " +oCount);
    }
}
