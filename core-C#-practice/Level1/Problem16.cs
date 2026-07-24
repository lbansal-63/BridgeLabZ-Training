using System;

class Program
{
    static void Main()
    {
        int n;

        Console.Write("Enter the number of students: ");
        n = Convert.ToInt32(Console.ReadLine());


        int res = (n*(n-1))/2;
        Console.WriteLine("Number of Handshakes: " + res);
    }
}
