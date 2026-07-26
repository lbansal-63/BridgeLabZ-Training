using System; 
public class SumOfRightDiagonal
{
    public static void Main()
    {
        int[,] arr = new int[4, 4];

        // taking input the array from user 
        for(int i=0; i < 4; i++)
        {
            for(int j=0; j < 4; j++)
            {
               Console.Write("Enter the number: ");
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // print right diagonal sum 
        int sum = 0;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (i == j) {
                    sum += arr[i, j]; 
                }
            }
        }
        Console.WriteLine("Sum of right diagonal is: " + sum); 

    }
}