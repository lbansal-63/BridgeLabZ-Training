using System;

class StudentGrade
{
    static void Main()
    {
        double physics, chemistry, maths, average;
        char grade;
        string remarks;

        Console.Write("Enter Physics marks: ");
        physics = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Chemistry marks: ");
        chemistry = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Maths marks: ");
        maths = Convert.ToDouble(Console.ReadLine());

        average = (physics + chemistry + maths) / 3;

        if (average >= 80)
        {
            grade = 'A';
            remarks = "Level 4, above agency-normalized standards";
        }
        else if (average >= 70)
        {
            grade = 'B';
            remarks = "Level 3, at agency-normalized standards";
        }
        else if (average >= 60)
        {
            grade = 'C';
            remarks = "Level 2, below, but approaching agency-normalized standards";
        }
        else if (average >= 50)
        {
            grade = 'D';
            remarks = "Level 1, well below agency-normalized standards";
        }
        else if (average >= 40)
        {
            grade = 'E';
            remarks = "Level 1-, too below agency-normalized standards";
        }
        else
        {
            grade = 'R';
            remarks = "Remedial standards";
        }

        Console.WriteLine("\n----- Result -----");
        Console.WriteLine("Average Marks : " + average);
        Console.WriteLine("Grade         : " + grade);
        Console.WriteLine("Remarks       : " + remarks);
    }
}
