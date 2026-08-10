using System;
using System.Collections.Generic;

class Program
{
    static string NthFromEnd(LinkedList<string> list, int n)
    {
        if (n <= 0 || list.First == null)
            return null;

        LinkedListNode<string> first = list.First;
        LinkedListNode<string> second = list.First;

        // Second pointer ko n positions aage le jao
        for (int i = 0; i < n; i++)
        {
            if (second == null)
                return null;

            second = second.Next;
        }

        // Dono pointers ko saath move karo
        while (second != null)
        {
            first = first.Next;
            second = second.Next;
        }

        return first.Value;
    }

    static void Main()
    {
        LinkedList<string> list =
            new LinkedList<string>(
                new string[] { "A", "B", "C", "D", "E" }
            );

        Console.WriteLine(NthFromEnd(list, 2));
    }
}