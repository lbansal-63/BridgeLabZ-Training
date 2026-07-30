
using System;
using System.Text; 

public class Program
{
    public static void Main()
    {
        StringBuilder sb = new StringBuilder("Laksha");
        //sb.Append("Bansal");
        //Console.WriteLine(sb);

        //StringBuilder sb = new StringBuilder();
        //sb.Append("Laksha ");
        //sb.AppendLine("Bansal");
        //sb.Append("CSE"); 
        //Console.WriteLine(sb);

        //sb.Append("Your total amount is: ");
        //sb.AppendFormat("{0:C}", 25); // currency 
        sb.AppendFormat("{0:X}", 25);
        Console.WriteLine(sb);

        StringBuilder sb2 = new StringBuilder();
        sb2.Append("Hello World");
        sb2.Insert(5, " C#");
        Console.WriteLine(sb2);

        sb2.Remove(9,5); 
        Console.WriteLine(sb2);

        sb2.Replace("C#", "Laksha"); 
        Console.WriteLine(sb2);

        string s1 = sb2.ToString(); // immutable
        Console.WriteLine(s1);
    }
}