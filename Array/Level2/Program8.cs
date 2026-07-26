using System;

public class Array
{
    public static void Main()
    {
        int students;

        Console.Write("Enter number of students: ");
        students = Convert.ToInt32(Console.ReadLine());

        int[] physics = new int[students];
        int[] chemistry = new int[students];
        int[] maths = new int[students];

        double[] percentage = new double[students];
        string[] grade = new string[students];


        for (int i = 0; i < students; i++)
        {
            Console.WriteLine("\nStudent " + (i + 1));

            Console.Write("Enter Physics marks: ");
            physics[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Chemistry marks: ");
            chemistry[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Maths marks: ");
            maths[i] = Convert.ToInt32(Console.ReadLine());


            if (physics[i] < 0 || chemistry[i] < 0 || maths[i] < 0)
            {
                Console.WriteLine("Enter positive marks only");
                i--;
            }
        }


        for (int i = 0; i < students; i++)
        {
            int total = physics[i] + chemistry[i] + maths[i];

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
            Console.WriteLine("Physics: " + physics[i]);
            Console.WriteLine("Chemistry: " + chemistry[i]);
            Console.WriteLine("Maths: " + maths[i]);
            Console.WriteLine("Percentage: " + percentage[i]);
            Console.WriteLine("Grade: " + grade[i]);
        }
    }
}
