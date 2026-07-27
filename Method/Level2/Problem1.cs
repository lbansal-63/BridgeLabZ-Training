using System; 
public class Problem1
{
    public static int[] factor(int num)
    {
        int count = 0; 
        for(int i = 1; i < num; i++)
        {
            if (num % i == 0)
            {
                count++; 
            }
        }

        int[] arr = new int[count];
        int idx = 0; 
        for (int i = 1; i < num; i++)
        {
            if (num % i == 0)
            {
                arr[idx] = i;
                idx++; 
            }
        }
        return arr; 
    }

    public static void Main()
    {
        int num;
        Console.Write("Enter the number: "); 
        num = Convert.ToInt32(Console.ReadLine());

        int[] arr = Problem1.factor(num);

        int sum = 0; 
        for(int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        int prod = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            prod *= arr[i];
        }

        int SumOfSq = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            SumOfSq += (int)Math.Pow(arr[i], 2); 
        }

        Console.WriteLine("Sum of Array: "+sum);
        Console.WriteLine("Product of Array: "+prod);
        Console.WriteLine("Sum of square of Array: "+SumOfSq);
    }
}