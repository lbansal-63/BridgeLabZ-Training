using System;
public class Array
{
    public static void Main()
    {
        int num;
        Console.Write("Enter the number: ");
        num = Convert.ToInt32(Console.ReadLine());

        int maxFac = 10;
        int[] fac = new int[maxFac];
        int index = 0;

        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            { 
                if (index == maxFac)
                {
                    maxFac *= 2;
                    int[] temp = new int[maxFac];
                    for (int j = 0; j < fac.Length; j++)
                    {
                        temp[j] = fac[j];
                    }
                    fac = temp;
                }
            
                fac[index++] = i; 
            }
        }

        Console.Write("Factors of " + num + " are: ");
        for (int i = 0; i < index; i++)
        {
            Console.Write(fac[i] + " ");
        }
    }
}