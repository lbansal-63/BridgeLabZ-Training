using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> small =
            new HashSet<int> { 2, 3 };

        HashSet<int> large =
            new HashSet<int> { 1, 2, 3, 4 };

        bool result = small.IsSubsetOf(large);

        Console.WriteLine(result);
    }
}