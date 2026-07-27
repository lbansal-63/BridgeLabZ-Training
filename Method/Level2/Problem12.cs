using System;

public class RandomNumber
{
    public int[] Generate4DigitRandomArray(int size)
    {
        int[] numbers = new int[size];
        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(1000, 10000);
        }

        return numbers;
    }

    public double[] FindAverageMinMax(int[] numbers)
    {
        double sum = 0;
        int min = numbers[0];
        int max = numbers[0];

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];

            min = Math.Min(min, numbers[i]);
            max = Math.Max(max, numbers[i]);
        }

        double average = sum / numbers.Length;

        return new double[] { average, min, max };
    }

    public static void Main()
    {
        RandomNumber obj = new RandomNumber();

        int[] numbers = obj.Generate4DigitRandomArray(5);

        Console.WriteLine("Generated Random Numbers:");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        double[] result = obj.FindAverageMinMax(numbers);

        Console.WriteLine("\nAverage = " + result[0]);
        Console.WriteLine("Minimum = " + result[1]);
        Console.WriteLine("Maximum = " + result[2]);
    }
}
