using System;
public class Array
{
    public static void Main()
    {
        int[] arr = new int[5];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter the number " + (i + 1) + " : ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                Console.WriteLine("Positive");

                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }

            }
            else if (arr[i]<0)
            {
                Console.WriteLine("Negative");

            }
            else
            {
                Console.WriteLine("Zero");
            }
        }

        if (arr[0] < arr[4])
        {
            Console.WriteLine("last element is greater than first");
        }
        else if (arr[0] > arr[4])
        {
            Console.WriteLine("first element is greater than last");
        }
        else
        {
            Console.WriteLine("Both are equal");
        }

    }
}