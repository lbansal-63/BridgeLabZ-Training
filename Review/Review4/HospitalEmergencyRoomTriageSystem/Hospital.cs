using System;
using System.Collections.Generic;

public class Patient
{
    public string Name { get; set; }
    public int Id { get; set; }
    public string Cond { get; set; }

    public Patient(string name, int id, string cond)
    {
        this.Name = name;
        this.Id = id;
        this.Cond = cond;
    }
}

public class Doctor
{
    public string Name { get; set; }
    public Doctor Next { get; set; }
    public bool IsBusy { get; set; }

    public Doctor(string name, bool isBusy)
    {
        this.Name = name;
        this.Next = null;
        this.IsBusy = isBusy;
    }
}

public class Bed
{
    public int BedId { get; set; }
    public Bed Prev { get; set; }
    public Bed Next { get; set; }
    public bool IsAvail { get; set; }

    public Bed(int bedId, bool isAvail)
    {
        BedId = bedId;
        Prev = null;
        Next = null;
        IsAvail = isAvail;
    }
}

public class Hospital
{
    public static void PatientRecord(List<Patient> list)
    {
        Console.WriteLine("--------------------------------");
        Dictionary<int, string> dict = new Dictionary<int, string>();

        foreach (var p in list)
        {
            if (!dict.ContainsKey(p.Id))
                dict.Add(p.Id, p.Name);
        }

        foreach (var entry in dict)
        {
            Console.WriteLine("Patient ID: {0}, Name: {1}", entry.Key, entry.Value);
        }
        Console.WriteLine("--------------------------------");
    }

    public static int PatientSearch(List<Patient> p, int target)
    {
        p.Sort((a, b) => a.Id.CompareTo(b.Id));

        int start = 0;
        int end = p.Count - 1;

        while (start <= end)
        {
            int mid = start + (end - start) / 2;
            if (p[mid].Id == target)
            {
                return mid;
            }
            else if (p[mid].Id < target)
            {
                start = mid + 1;
            }
            else
            {
                end = mid - 1;
            }
        }
        return -1;
    }

    public static void AddDoctor(Patient p, Doctor headDoctor)
    {
        if (headDoctor == null) return;

        Doctor curr = headDoctor;
        do
        {
            if (!curr.IsBusy)
            {
                curr.IsBusy = true;
                Console.WriteLine(curr.Name + " operates the patient " + p.Name);
                return;
            }
            curr = curr.Next;
        } while (curr != headDoctor);

        Console.WriteLine("All our Doctors are busy!!");
    }

    public static void BedOccupancy(Patient p, Bed headBed)
    {
        Bed curr = headBed;
        while (curr != null)
        {
            if (curr.IsAvail)
            {
                curr.IsAvail = false;
                Console.WriteLine("BedId " + curr.BedId + " is occupied by the Patient " + p.Name);
                return;
            }
            curr = curr.Next;
        }
        Console.WriteLine("Bed not available");
    }

    public static void Main()
    {
        List<Patient> li = new List<Patient>
        {
            new Patient("Babita", 123, "Critical"),
            new Patient("Prashansa", 103, "Urgent"),    
            new Patient("Ganesh", 312, "Standard"),
            new Patient("Himanshu", 568, "Urgent"),
            new Patient("Pooja", 293, "Critical")
        };

        Doctor d1 = new Doctor("Anoop", false);
        Doctor d2 = new Doctor("Anisa", false);
        Doctor d3 = new Doctor("Mukesh", false);
        d1.Next = d2;
        d2.Next = d3;
        d3.Next = d1;

        Bed b1 = new Bed(1, true);
        Bed b2 = new Bed(2, true);
        Bed b3 = new Bed(3, true);
        b1.Next = b2; b2.Prev = b1;
        b2.Next = b3; b3.Prev = b2;

        PatientRecord(li);

        Patient targetPatient = li.Find(x => x.Id == 103);
        if (PatientSearch(li, 103) == -1)
        {
            Console.WriteLine("Patient does not exist");
        }
        else
        {
            Console.WriteLine("Patient exists");
            BedOccupancy(targetPatient, b1);
            AddDoctor(targetPatient, d1);
        }
    }
}
