using System;

public class Program2
{
    public static void CharArray(string s)
    {
        for(int i = 0; i < s.Length; i++)
        {
            Console.Write(s[i]+" ");
        }   
        Console.WriteLine();
    }

    public static void Main()
    {
        string s;
        Console.Write("Enter the string: ");
        s = Console.ReadLine();


        Program2.CharArray(s);
        char[] ch = s.ToCharArray();

        Console.WriteLine(s);
        foreach(char c in ch)
        {
            Console.Write(c+" ");
        }

    }
}