
using System;
public class MatrixAdd
{
    public static void Main()
    {
        int[,] arr1 = new int[3, 3];
        int[,] arr2 = new int[3, 3];

        Console.WriteLine("Enter value from first Array: "); 
        for(int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++) {
                Console.Write("Enter the number: ");
                arr1[i, j] = Convert.ToInt32(Console.ReadLine()); 
            }
        }

        Console.WriteLine("Enter value from second Array: ");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Enter the number: ");
                arr2[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        //Adding and printing elements of both Array
        Console.WriteLine(); 
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write((arr1[i, j] + arr2[i,j])+ "\t");
            }
            Console.WriteLine(); 
        }
            
    }
}