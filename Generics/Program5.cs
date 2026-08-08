using System;
using System.Collections.Generic;

// =====================================
// Base Job Role
// =====================================

public abstract class JobRole
{
    public string RoleName { get; set; }

    protected JobRole(string roleName)
    {
        RoleName = roleName;
    }

    public abstract void ScreenResume();
}


// =====================================
// Software Engineer
// =====================================

public class SoftwareEngineer : JobRole
{
    public int ProgrammingScore { get; set; }

    public SoftwareEngineer(
        int programmingScore)
        : base("Software Engineer")
    {
        ProgrammingScore = programmingScore;
    }

    public override void ScreenResume()
    {
        if (ProgrammingScore >= 60)
        {
            Console.WriteLine(
                "Candidate passed Software Engineer screening.");
        }
        else
        {
            Console.WriteLine(
                "Candidate failed Software Engineer screening.");
        }
    }
}


// =====================================
// Data Scientist
// =====================================

public class DataScientist : JobRole
{
    public int StatisticsScore { get; set; }

    public DataScientist(
        int statisticsScore)
        : base("Data Scientist")
    {
        StatisticsScore = statisticsScore;
    }

    public override void ScreenResume()
    {
        if (StatisticsScore >= 60)
        {
            Console.WriteLine(
                "Candidate passed Data Scientist screening.");
        }
        else
        {
            Console.WriteLine(
                "Candidate failed Data Scientist screening.");
        }
    }
}


// =====================================
// Generic Resume
// =====================================

public class Resume<T>
    where T : JobRole
{
    public string CandidateName { get; set; }

    public T JobRole { get; set; }

    public Resume(
        string candidateName,
        T jobRole)
    {
        CandidateName = candidateName;
        JobRole = jobRole;
    }

    public void Screen()
    {
        Console.WriteLine(
            $"\nCandidate: {CandidateName}");

        Console.WriteLine(
            $"Role: {JobRole.RoleName}");

        JobRole.ScreenResume();
    }
}


// =====================================
// Resume Screening System
// =====================================

public class ResumeScreeningSystem
{
    private List<JobRole> candidates =
        new List<JobRole>();

    public void AddCandidate(
        JobRole candidate)
    {
        candidates.Add(candidate);
    }

    public void ScreenAll()
    {
        foreach (JobRole candidate in candidates)
        {
            candidate.ScreenResume();
        }
    }

    // Generic Method
    public void ScreenCandidate<T>(
        T candidate)
        where T : JobRole
    {
        Console.WriteLine(
            $"\nScreening for: {candidate.RoleName}");

        candidate.ScreenResume();
    }
}


// =====================================
// Program
// =====================================

public class Program
{
    public static void Main()
    {
        // =================================
        // Software Engineer Resume
        // =================================

        SoftwareEngineer softwareEngineer =
            new SoftwareEngineer(85);

        Resume<SoftwareEngineer> softwareResume =
            new Resume<SoftwareEngineer>(
                "Rahul",
                softwareEngineer);

        softwareResume.Screen();


        // =================================
        // Data Scientist Resume
        // =================================

        DataScientist dataScientist =
            new DataScientist(70);

        Resume<DataScientist> dataResume =
            new Resume<DataScientist>(
                "Aman",
                dataScientist);

        dataResume.Screen();


        // =================================
        // Screening System
        // =================================

        ResumeScreeningSystem system =
            new ResumeScreeningSystem();

        system.AddCandidate(
            softwareEngineer);

        system.AddCandidate(
            dataScientist);


        Console.WriteLine(
            "\nScreening All Candidates:");

        system.ScreenAll();


        // =================================
        // Generic Method
        // =================================

        Console.WriteLine(
            "\nGeneric Method:");

        system.ScreenCandidate(
            softwareEngineer);

        system.ScreenCandidate(
            dataScientist);
    }
}