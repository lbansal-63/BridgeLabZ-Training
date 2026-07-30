using System; 
public class Program1
{
    public static bool CompareString(string s1, string s2)
    {
        if(s1.Length != s2.Length) return false;
        for(int i=0; i<s1.Length; i++)
        {
            if (s1[i]!=s2[i]) return false;
        }
        return true;
    }

    public static void Main()
    {
        string s1, s2;
        Console.Write("Enter the first string: ");
        s1 = Console.ReadLine();

        Console.Write("Enter the second string: ");
        s2 = Console.ReadLine();

        bool res1 = Program1.CompareString(s1, s2);
        bool res2 = string.Equals(s1, s2);
        
        Console.WriteLine(res1);
        Console.WriteLine(res2);
        
    }
}