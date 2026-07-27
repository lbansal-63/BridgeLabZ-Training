using System;

public class StudentScoreCard
{
    // Method to generate random PCM scores
    public static int[,] GenerateScores(int numberOfStudents)
    {
        int[,] scores = new int[numberOfStudents, 3];

        Random random = new Random();

        for (int i = 0; i < numberOfStudents; i++)
        {
            // Generate marks between 10 and 99
            scores[i, 0] = random.Next(10, 100); // Physics
            scores[i, 1] = random.Next(10, 100); // Chemistry
            scores[i, 2] = random.Next(10, 100); // Maths
        }

        return scores;
    }


    // Method to calculate total, average and percentage
    public static double[,] CalculateResult(int[,] scores)
    {
        double[,] result = new double[scores.GetLength(0), 3];

        for (int i = 0; i < scores.GetLength(0); i++)
        {
            double total = scores[i, 0] + scores[i, 1] + scores[i, 2];

            double average = total / 3;

            double percentage = (total / 300) * 100;

            result[i, 0] = Math.Round(total, 2);
            result[i, 1] = Math.Round(average, 2);
            result[i, 2] = Math.Round(percentage, 2);
        }

        return result;
    }


    // Method to display scorecard
    public static void DisplayScoreCard(int[,] scores, double[,] result)
    {
        Console.WriteLine("\nStudent Score Card");
        Console.WriteLine("--------------------------------------------------------------");

        Console.WriteLine("Student\tPhysics\tChemistry\tMaths\tTotal\tAverage\tPercentage");

        for (int i = 0; i < scores.GetLength(0); i++)
        {
            Console.WriteLine(
                (i + 1) + "\t" +
                scores[i, 0] + "\t" +
                scores[i, 1] + "\t\t" +
                scores[i, 2] + "\t" +
                result[i, 0] + "\t" +
                result[i, 1] + "\t" +
                result[i, 2] + "%"
            );
        }

        Console.WriteLine("--------------------------------------------------------------");
    }


    public static void Main()
    {
        Console.Write("Enter number of students: ");
        int students = Convert.ToInt32(Console.ReadLine());


        // Generate PCM scores
        int[,] scores = GenerateScores(students);


        // Calculate total, average and percentage
        double[,] result = CalculateResult(scores);


        // Display scorecard
        DisplayScoreCard(scores, result);
    }
}
