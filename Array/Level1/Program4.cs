using System;
public class Array
{
    public static void Main()
    {
        double[] arr = new double[10];

        double sum = 0.0; 
        int i = 0;

        while(true)
        {
            if (i == 10)
            {
                break; 
            }

            Console.Write("Enter the number " + (i + 1) + " : ");
            double num = Convert.ToDouble(Console.ReadLine());

            if (num <= 0)
            {
                break; 
            }
            else
            {
                arr[i] = num;
                i++;
            }
        }

        
        for (int j = 0; j < i; j++)
        {
            sum += arr[j]; 
        }

        Console.WriteLine("Sum: "+sum);
    }
}