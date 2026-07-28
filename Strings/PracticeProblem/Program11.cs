using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string s1 = Console.ReadLine().Replace(" ", "").ToLower();

        Console.Write("Enter second string: ");
        string s2 = Console.ReadLine().Replace(" ", "").ToLower();

        if (s1.Length != s2.Length)
        {
            Console.WriteLine("Not Anagrams");
            return;
        }

        char[] a = s1.ToCharArray();
        char[] b = s2.ToCharArray();

        Array.Sort(a);
        Array.Sort(b);

        bool anagram = true;

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != b[i])
            {
                anagram = false;
                break;
            }
        }

        Console.WriteLine(anagram ? "Anagrams" : "Not Anagrams");
    }
}