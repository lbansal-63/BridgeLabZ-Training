using System;
using System.Collections.Generic;

// Interface
interface IMedicalRecord
{
    void AddRecord(string diagnosis, string medicalHistory);
    void ViewRecords();
}

// Abstract Class
abstract class Patient
{
    // Encapsulation
    private int patientId;
    private string name;
    private int age;
    private string diagnosis;
    private string medicalHistory;

    // Properties
    public int PatientId
    {
        get { return patientId; }
        set { patientId = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Diagnosis
    {
        get { return diagnosis; }
        set { diagnosis = value; }
    }

    public string MedicalHistory
    {
        get { return medicalHistory; }
        set { medicalHistory = value; }
    }

    // Constructor
    public Patient(int patientId, string name, int age)
    {
        PatientId = patientId;
        Name = name;
        Age = age;
    }

    // Abstract Method
    public abstract double CalculateBill();

    // Concrete Method
    public void GetPatientDetails()
    {
        Console.WriteLine("Patient ID : " + PatientId);
        Console.WriteLine("Name : " + Name);
        Console.WriteLine("Age : " + Age);
    }
}

// InPatient Class
class InPatient : Patient, IMedicalRecord
{
    private int daysAdmitted;

    public InPatient(int patientId, string name, int age, int daysAdmitted)
        : base(patientId, name, age)
    {
        this.daysAdmitted = daysAdmitted;
    }

    public override double CalculateBill()
    {
        return daysAdmitted * 2000;   // ₹2000 per day
    }

    public void AddRecord(string diagnosis, string medicalHistory)
    {
        Diagnosis = diagnosis;
        MedicalHistory = medicalHistory;
    }

    public void ViewRecords()
    {
        Console.WriteLine("Diagnosis : " + Diagnosis);
        Console.WriteLine("Medical History : " + MedicalHistory);
    }
}

// OutPatient Class
class OutPatient : Patient, IMedicalRecord
{
    public OutPatient(int patientId, string name, int age)
        : base(patientId, name, age)
    {
    }

    public override double CalculateBill()
    {
        return 500;   // Fixed Consultation Fee
    }

    public void AddRecord(string diagnosis, string medicalHistory)
    {
        Diagnosis = diagnosis;
        MedicalHistory = medicalHistory;
    }

    public void ViewRecords()
    {
        Console.WriteLine("Diagnosis : " + Diagnosis);
        Console.WriteLine("Medical History : " + MedicalHistory);
    }
}

// Main Class
class Program
{
    static void Main()
    {
        List<Patient> patients = new List<Patient>();

        InPatient p1 = new InPatient(101, "Rahul", 30, 5);
        p1.AddRecord("Dengue", "High Fever");

        OutPatient p2 = new OutPatient(102, "Aman", 25);
        p2.AddRecord("Cold", "Seasonal Allergy");

        patients.Add(p1);
        patients.Add(p2);

        Console.WriteLine("===== Patient Details =====\n");

        foreach (Patient patient in patients)
        {
            patient.GetPatientDetails();

            IMedicalRecord record = (IMedicalRecord)patient;
            record.ViewRecords();

            Console.WriteLine("Bill Amount : " + patient.CalculateBill());

            Console.WriteLine("----------------------------");
        }

        Console.ReadLine();
    }
}