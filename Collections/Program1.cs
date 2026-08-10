using System;
using System.Collections; 
public class Program
{
    public static void Reverse(ArrayList list)
    {
        int left = 0;
        int right = list.Count - 1;
        while (left < right)
        {
            object temp = list[left];
            list[left] = list[right];
            list[right] = temp;
            left++;
            right--;
        }
    }

    public static void Print(ArrayList list)
    {
        for(int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i]+" ");
        }
        Console.WriteLine();
    }

    public static void Main()
    {
        ArrayList list = new ArrayList {1,2,3,4,5};
        Print(list);
        Reverse(list);
        Print(list); 
    }
}