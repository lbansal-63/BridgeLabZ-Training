using System; 

public class Program
{
    public static void Main()
    {
        int num;
        Console.Write("Enter the number: "); 
        num = Convert.ToInt32(Console.ReadLine());

        int div;
        Console.Write("Enter the divisor: ");
        div = Convert.ToInt32(Console.ReadLine());

        int res = num / div;
        Console.WriteLine("Result: {0}",res); // Divide by zero exception


        Console.WriteLine("Remaining statements1");
        Console.WriteLine("Remaining statements2");
        Console.WriteLine("Remaining statements3");
    }
}