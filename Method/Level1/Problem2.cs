using System;
public class Program2
{
    public static int Handshake(int n)
    {
        int res = (n*(n-1)) / 2;
        return res; 
    }

    public static void Main()
    {
        int n;
        Console.Write("Enter the of number of students: ");
        n = Convert.ToInt32(Console.ReadLine());

        int res = Program2.Handshake(n);
        Console.WriteLine("Max. number of handshakes: " + res); 
    }
}