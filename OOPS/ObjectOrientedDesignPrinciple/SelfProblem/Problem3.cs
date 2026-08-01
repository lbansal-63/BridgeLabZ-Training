using System;
using System.Collections.Generic;

class Patient
{
    public string Name;

    public Patient(string name)
    {
        Name = name;
    }
}

class Doctor
{
    public string Name;

    public Doctor(string name)
    {
        Name = name;
    }

    public void Consult(Patient patient)
    {
        Console.WriteLine($"{Name} is consulting {patient.Name}");
    }
}

class Hospital
{
    public List<Doctor> Doctors = new List<Doctor>();
    public List<Patient> Patients = new List<Patient>();
}

class Program
{
    static void Main()
    {
        Doctor d = new Doctor("Dr. Khan");
        Patient p = new Patient("Ali");

        d.Consult(p);
    }
}