using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        Console.Write("Enter index: ");
        int index = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter divisor: ");
        int divisor = Convert.ToInt32(Console.ReadLine());

        try
        {
            int value = numbers[index];

            try
            {
                int result = value / divisor;
                Console.WriteLine("Division result: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero!");
            }
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid array index!");
        }
    }
}