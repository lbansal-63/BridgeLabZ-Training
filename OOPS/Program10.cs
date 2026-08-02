using System;
public class Program
{
    //public static var show()
    //{
    //    return 0; 
    //}

    public static void show(dynamic a)
    {
        a++; 
        Console.WriteLine(a);
    }

    public static void Main()
    {
        //int a = 20;
        //var b = "laksha";
        //Console.WriteLine(a);
        //Console.WriteLine(b.Length);
        //Console.WriteLine(b.ToUpper());
        //Console.WriteLine(b.GetType());

        dynamic a = "Laksha";
        Console.WriteLine(a.GetType());
        a = 30;
        Console.WriteLine(a.GetType());
        Program.show(a)
    }
}