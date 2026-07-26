using System; 
public class TwoDDemo2{
    public static void Main(){
       
        int[,] nums = new int[2, 3];
        Console.Write("Enter the number: ");
        nums[0,0] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number: ");
        nums[0,1] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number: ");
        nums[0,2] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number: ");
        nums[1,0] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number: ");
        nums[1,1] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number: ");
        nums[1,2] = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine(nums[0,0]);
        Console.WriteLine(nums[0,1]);
        Console.WriteLine(nums[0,2]);
        Console.WriteLine(nums[1,0]);
        Console.WriteLine(nums[1,1]);
        Console.WriteLine(nums[1,2]);
    }
}