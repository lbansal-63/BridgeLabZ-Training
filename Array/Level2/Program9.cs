using System;

public class Array
{
    public static void Main()
    {
        int students;

        Console.Write("Enter number of students: ");
        students = Convert.ToInt32(Console.ReadLine());


        int[,] marks = new int[students, 3];

        double[] percentage = new double[students];
        string[] grade = new string[students];


        for (int i = 0; i < students; i++)
        {
            Console.WriteLine("\nStudent " + (i + 1));

            Console.Write("Enter Physics marks: ");
            marks[i, 0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Chemistry marks: ");
            marks[i, 1] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Maths marks: ");
            marks[i, 2] = Convert.ToInt32(Console.ReadLine());


            if (marks[i, 0] < 0 || marks[i, 1] < 0 || marks[i, 2] < 0)
            {
                Console.WriteLine("Enter positive marks only");
                i--;
            }
        }


        for (int i = 0; i < students; i++)
        {
            int total = marks[i, 0] + marks[i, 1] + marks[i, 2];

            percentage[i] = total / 3.0;


            if (percentage[i] >= 80)
            {
                grade[i] = "A";
            }
            else if (percentage[i] >= 70)
            {
                grade[i] = "B";
            }
            else if (percentage[i] >= 60)
            {
                grade[i] = "C";
            }
            else if (percentage[i] >= 50)
            {
                grade[i] = "D";
            }
            else if (percentage[i] >= 40)
            {
                grade[i] = "E";
            }
            else
            {
                grade[i] = "R";
            }
        }


        for (int i = 0; i < students; i++)
        {
            Console.WriteLine("\nStudent " + (i + 1));
            Console.WriteLine("Physics: " + marks[i, 0]);
            Console.WriteLine("Chemistry: " + marks[i, 1]);
            Console.WriteLine("Maths: " + marks[i, 2]);
            Console.WriteLine("Percentage: " + percentage[i]);
            Console.WriteLine("Grade: " + grade[i]);
        }
    }
}
