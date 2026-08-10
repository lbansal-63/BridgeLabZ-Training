using System;
using System.Collections.Generic;

class Policy
{
    public string PolicyNumber { get; set; }
    public string CustomerName { get; set; }
    public string CoverageType { get; set; }
    public DateTime ExpiryDate { get; set; }

    public override bool Equals(object obj)
    {
        Policy other = obj as Policy;

        if (other == null)
            return false;

        return PolicyNumber == other.PolicyNumber;
    }

    public override int GetHashCode()
    {
        return PolicyNumber.GetHashCode();
    }

    public override string ToString()
    {
        return PolicyNumber + " | " +
               CustomerName + " | " +
               CoverageType + " | " +
               ExpiryDate.ToShortDateString();
    }
}

class Program
{
    static void Main()
    {
        HashSet<Policy> policies = new HashSet<Policy>();

        Policy p1 = new Policy
        {
            PolicyNumber = "P101",
            CustomerName = "Rahul",
            CoverageType = "Health",
            ExpiryDate = DateTime.Now.AddDays(10)
        };

        Policy p2 = new Policy
        {
            PolicyNumber = "P102",
            CustomerName = "Priya",
            CoverageType = "Car",
            ExpiryDate = DateTime.Now.AddDays(45)
        };

        Policy p3 = new Policy
        {
            PolicyNumber = "P103",
            CustomerName = "Aman",
            CoverageType = "Health",
            ExpiryDate = DateTime.Now.AddDays(20)
        };

        // Duplicate policy number
        Policy duplicate = new Policy
        {
            PolicyNumber = "P101",
            CustomerName = "Rahul",
            CoverageType = "Health",
            ExpiryDate = DateTime.Now.AddDays(10)
        };

        policies.Add(p1);
        policies.Add(p2);
        policies.Add(p3);
        policies.Add(duplicate);

        Console.WriteLine("ALL UNIQUE POLICIES:");

        foreach (Policy p in policies)
        {
            Console.WriteLine(p);
        }

        Console.WriteLine("\nPOLICIES EXPIRING WITHIN 30 DAYS:");

        DateTime today = DateTime.Now;
        DateTime next30Days = today.AddDays(30);

        foreach (Policy p in policies)
        {
            if (p.ExpiryDate >= today &&
                p.ExpiryDate <= next30Days)
            {
                Console.WriteLine(p);
            }
        }

        Console.WriteLine("\nHEALTH POLICIES:");

        foreach (Policy p in policies)
        {
            if (p.CoverageType == "Health")
            {
                Console.WriteLine(p);
            }
        }

        Console.WriteLine("\nSORTED BY EXPIRY DATE:");

        SortedSet<Policy> sortedPolicies =
            new SortedSet<Policy>(
                Comparer<Policy>.Create(
                    (x, y) =>
                    {
                        int result =
                            x.ExpiryDate.CompareTo(y.ExpiryDate);

                        if (result == 0)
                            return x.PolicyNumber.CompareTo(y.PolicyNumber);

                        return result;
                    }
                )
            );

        foreach (Policy p in policies)
        {
            sortedPolicies.Add(p);
        }

        foreach (Policy p in sortedPolicies)
        {
            Console.WriteLine(p);
        }
    }
}