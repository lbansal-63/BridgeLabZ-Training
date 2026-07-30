using System;
using System.Diagnostics;
using System.Text;

public class Program
{
    public static void Main()
    {
        string s1 = "Laksha";
        Stopwatch sw1 = new Stopwatch();

        sw1.Start();
        for(int i = 0; i < 100000; i++)
        {
            s1 = s1+ i; // create 1 lakh object of diff string
        }
        sw1.Stop(); 


        StringBuilder sb = new StringBuilder("Laksha");
        Stopwatch sw2 = new Stopwatch();
        sw2.Start();
        for (int i = 0; i < 100000; i++)
        {
            sb.Append(i);  // modification 1 lakh time in same object 
        }
        sw2.Stop();


        Console.WriteLine("Time taken by String: " + sw1.ElapsedMilliseconds);
        Console.WriteLine("Time taken by StringBuilder: " + sw2.ElapsedMilliseconds);
    }
}