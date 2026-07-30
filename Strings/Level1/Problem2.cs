using System;
using System.Text; 

public class Program2
{
    public static string SubString(string s,int strIdx,int endIdx)
    {
        StringBuilder sb = new StringBuilder(); 
        for (int i = strIdx; i <= endIdx; i++) {
            sb.Append(s[i]); 
        }
        return sb.ToString(); 
    }

    public static void Main()
    {
        string s;
        Console.Write("Enter the string: ");
        s = Console.ReadLine();

        int strIdx;
        Console.Write("Enter the starting Index: ");
        strIdx = Convert.ToInt32(Console.ReadLine());


        int endIdx;
        Console.Write("Enter the ending Index: ");
        endIdx = Convert.ToInt32(Console.ReadLine());

        string str = Program2.SubString(s,strIdx,endIdx);
        string str2 = s.Substring(strIdx,endIdx-1);
        +
        Console.WriteLine(str);
        Console.WriteLine(str2);

    }
}