using System;
public class TwoDDemo
{
    public static void Main(){
        // declaration of array 
        int [,]arr = new int[2,3];

        int[,] nums = new int[3, 4]
        {
            {10,20,30,40},
            {25,33,27,30},
            {41,55,96,75}
        };

        int[,] nums = new int[]
        {
            {10,20,30,40},
            {25,33,27,30},
            {41,55,96,75}
        };

        int[,] nums = {{10,20,30,40}, {25,33,27,30}, {41,55,96,75} };

        // initialize the array 
        arr[0,0] = 20; arr[0,1] = 30; arr[0,2] = 50;
        arr[1,0] = 30; arr[1,1] = 50; arr[1,2] = 30;

        // retrieve the value of array 
        Console.WriteLine(arr[0,0]);
        Console.WriteLine(arr[0,1]);
        Console.WriteLine(arr[0,2]);
        Console.WriteLine(arr[1,0]);
        Console.WriteLine(arr[1,1]);
        Console.WriteLine(arr[1,2]);

        Console.WriteLine();
        Console.WriteLine(nums[2,2]);

        Console.WriteLine("Rows: " + arr.GetLength(0));
        Console.WriteLine("Cols: " + arr.GetLength(1));
        Console.WriteLine("Dimension of Array: " + arr.Rank);

    }
}