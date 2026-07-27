using System;

public static class StudentVote
{
    public static bool CanVote(int age)
    {
        if (age < 0)
        {
            return false;
        }
        else if (age >= 18)
        {
            return true; 
        }
        else
        {
            return false;
        }
    }

    static void Main()
    {
        int[] age = new int[10]; 

        for(int i = 0; i < 10; i++)
        {
            Console.Write("Enter the age of student: ");
            age[i] = Convert.ToInt32(Console.ReadLine());
            bool check = StudentVote.CanVote(age[i]);


            if (check)
            {
                Console.WriteLine("Student can vote.");
            }
            else
            {
                Console.WriteLine("Student cannot vote.");
            }
        }
        

    }
}
