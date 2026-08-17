using System;
using System.IO;

class StudentData
{
    static void Main()
    {
        string fileName = "student.dat";

        try
        {
            // Write data
            using (FileStream file = new FileStream(
                fileName, FileMode.Create, FileAccess.Write))
            using (BinaryWriter writer = new BinaryWriter(file))
            {
                Console.Write("Enter Roll Number: ");
                int rollNumber = int.Parse(Console.ReadLine());

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter GPA: ");
                double gpa = double.Parse(Console.ReadLine());

                writer.Write(rollNumber);
                writer.Write(name);
                writer.Write(gpa);
            }

            Console.WriteLine("\nStudent data saved.");

            // Read data
            using (FileStream file = new FileStream(
                fileName, FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(file))
            {
                int rollNumber = reader.ReadInt32();
                string name = reader.ReadString();
                double gpa = reader.ReadDouble();

                Console.WriteLine("\nRetrieved Student Details:");
                Console.WriteLine("Roll Number: " + rollNumber);
                Console.WriteLine("Name: " + name);
                Console.WriteLine("GPA: " + gpa);
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}