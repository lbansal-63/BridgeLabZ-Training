using System;
public class Problem1
{
    public static int Sum(int n,int sum)
    {
        if(n == 0) return sum;
        sum += n;
        return Sum(n - 1, sum); 
    }

    public static void Main()
    {
        int num;
        Console.Write("Enter the number: ");
        num = Convert.ToInt32(Console.ReadLine());

        int sum1 = (num * (num + 1)) / 2;
        int sum2 = Problem1.Sum(num,0);

        if (sum1 == sum2)
        {
            Console.WriteLine("Both are true");
        }
        else
        {
            Console.WriteLine("Both are not true");
        }
    }
}