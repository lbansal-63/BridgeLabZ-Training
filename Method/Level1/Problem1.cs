using System; 
public class Program
{
    public static void SI(int p,int r,int t)
    {
        double si = (p * r * t) / 100.0;
        Console.WriteLine("The Simple Interest is " + si + " for Principal " + p + ", Rate of Interest " + r + " and Time " + t);
    }

    public static void Main()
    {
        int p, r, t;
        Console.Write("Enter the principal amount: "); 
        p = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the rate of interest: ");
        r = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the time period: ");
        t = Convert.ToInt32(Console.ReadLine());

        Program.SI(p, r, t); 
    }
}