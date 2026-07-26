using System;
public class Array
{
    public static void Main()
    {
        int num;
        Console.Write("Enter the number: ");
        num = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[10];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = num * (i + 1);
        }

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(num + " X " + (i + 1) + " = " + arr[i]);
        }
    }
}