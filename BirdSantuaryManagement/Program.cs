using System;
using System.Collections.Generic; 

abstract class Bird
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public Bird(int id,string name,string gender)
    {
        Id = id; 
        Name = name;
        Gender = gender;
    }

    public void Display()
    {
        Console.WriteLine($"Bird Name: {Name}");
        Console.WriteLine($"Bird Gender: {Gender}");
    }
}

interface IRunnable
{
    void Run();
}

interface IFlyable
{
    void Fly();
}

interface ISwimmable
{
    void Swim();
}

class Eagle : Bird, IFlyable
{
    public Eagle(int id,string name,string gender) : base(id,name,gender){}

    public void Fly()
    {
        Console.WriteLine($"{Name} is flying.");
    }
}


class Duck : Bird, IRunnable, IFlyable, ISwimmable
{
    public Duck(int id,string name,string gender) : base(id,name,gender){}

    public void Run()
    {
        Console.WriteLine($"{Name} is running.");
    }

    public void Fly()
    {
        Console.WriteLine($"{Name} is flying.");
    }

    public void Swim()
    {
        Console.WriteLine($"{Name} is swimming.");
    }
}



class Penguin : Bird, IRunnable, ISwimmable
{
    public Penguin(int id,string name,string gender) : base(id,name,gender){}

    public void Run()
    {
        Console.WriteLine($"{Name} is running.");
    }

    public void Swim()
    {
        Console.WriteLine($"{Name} is swimming.");
    }
}

class BirdSanctuary
{
    private HashSet<Bird> birds = new HashSet<Bird>();

    public void AddBird(Bird bird)
    {
        if (birds.Add(bird))
        {
            Console.WriteLine($"{bird.Name} added sucessfully"); 
        }
        else
        {
            Console.WriteLine("Bird already exist"); 
        }
    }

    public void RemoveBird(Bird bird)
    {
        if (birds.Remove(bird))
        {
            Console.WriteLine($"{bird.Name} has been removed with id {bird.Id} and having gender {bird.Gender}");
        }
        else
        {
            Console.WriteLine($"{bird.Name} was not found in the sanctuary.");
        }
    }

    public void DisplayBirds()
    {
        Console.WriteLine("\nBirds in Sanctuary:");

        foreach (Bird bird in birds)
        {
            Console.WriteLine($"Bird Id: {bird.Id} Bird Name: {bird.Name} Bird Gender: {bird.Gender}");
        }
    }

    public void SearchBirds(Bird bird)
    {
        if (birds.Contains(bird))
        {
            Console.WriteLine($"Bird found with bird Id: {bird.Id}");
        }
        else
        {
            Console.WriteLine("Bird not found");
        }
    }
}

class Program
{
    static void Main()
    {
        BirdSanctuary sanctuary = new BirdSanctuary();

        Bird eagle = new Eagle(101,"Eagle","Male");
        Bird duck = new Duck(203,"Duck","Female");
        Bird penguin = new Penguin(305,"Penguin","Female");

        sanctuary.AddBird(eagle);
        sanctuary.AddBird(duck);
        sanctuary.AddBird(penguin);
        sanctuary.AddBird(duck);

        //sanctuary.DisplayBirds();

        //sanctuary.RemoveBird(duck);

        sanctuary.DisplayBirds();

        sanctuary.SearchBirds(duck); 
    }
}

