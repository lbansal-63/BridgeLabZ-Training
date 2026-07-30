using System;

public class NullRefExp
{
    public static void Main()
    {
        try{
            string str = null;
            Console.WriteLine("Length of string: {0}", str.Length);
        }
        catch(NullReferenceException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
} 