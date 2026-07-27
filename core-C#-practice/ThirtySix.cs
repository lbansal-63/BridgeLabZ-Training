using System;
public class Even
{
    public static void Main()
    {
        for(int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}