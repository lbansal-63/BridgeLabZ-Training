using System; 
public class Number
{
    public static void Main()
    {
        int num;
        Console.Write("Enter the number: "); 
        num = Convert.ToInt32(Console.ReadLine());

        for(int i = 6; i <= 9; i++)
        {
            Console.WriteLine(num + " X " + i + " = " + (num * i));
        }
    }
}