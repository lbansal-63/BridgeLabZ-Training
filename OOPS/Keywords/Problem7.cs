using System;

class Patient
{
    public static string HospitalName = "Apollo Hospital";
    private static int totalPatients = 0;

    public string Name;
    public int Age;
    public string Ailment;
    public readonly int PatientID;

    public Patient(string name, int age, string ailment, int patientID)
    {
        this.Name = name;
        this.Age = age;
        this.Ailment = ailment;
        this.PatientID = patientID;
        totalPatients++;
    }

    public void Display()
    {
        Console.WriteLine("Hospital : " + HospitalName);
        Console.WriteLine("Patient : " + Name);
        Console.WriteLine("Age : " + Age);
        Console.WriteLine("Ailment : " + Ailment);
        Console.WriteLine("Patient ID : " + PatientID);
    }

    public static void GetTotalPatients()
    {
        Console.WriteLine("Total Patients : " + totalPatients);
    }
}

class Program
{
    static void Main()
    {
        Patient p = new Patient("Suresh", 45, "Fever", 1001);

        if (p is Patient)
        {
            p.Display();
        }

        Patient.GetTotalPatients();
    }
}