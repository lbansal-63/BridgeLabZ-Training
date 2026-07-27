using System;
public class Program4
{
    public static int Rounds(int a,int b,int c,int dis)
    {
        int per = (a + b + c);
        int ans = dis / per;
        return ans;
    }

    public static void Main()
    {
        int a,b,c;
        Console.Write("Enter the first side of triangle (in metre): ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second side of triangle (in metre): ");
        b = Convert.ToInt32(Console.ReadLine()); 

        Console.Write("Enter the third side of triangle (in metre): ");
        c = Convert.ToInt32(Console.ReadLine());

        int dis = 5000; 
        double ans = Program4.Rounds(a,b,c,dis); 

        Console.WriteLine("Number of rounds needs to do to complete 5km run: " + ans);
    }
}