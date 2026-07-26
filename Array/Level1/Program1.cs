using System; 
public class Array
{
    public static void Main()
    {
        int [] arr = new int[10]; 

        for(int i = 0; i < 10; i++)
        {
            Console.Write("Enter the student age " + (i + 1) + " : ");
            arr[i] = Convert.ToInt32(Console.ReadLine());

            if (arr[i] < 0)
            {
                Console.Write("Invalid Age");
                return; 
            }
        }

        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 18)
            {
                Console.WriteLine("The student with the age " + arr[i] + " can vote");

            }
            else
            {
                Console.WriteLine("The student with the age " + arr[i] + " cannot vote");

            }
        }


    }
}