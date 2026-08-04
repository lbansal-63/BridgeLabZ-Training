using System;


interface Worker
{
    void PerformDuties();
}



class Person
{
    public string Name;
    public int Id;


    public Person(string name, int id)
    {
        Name = name;
        Id = id;
    }
}



class Chef : Person, Worker
{

    public Chef(string name, int id)
        : base(name, id)
    {
    }


    public void PerformDuties()
    {
        Console.WriteLine(
            Name + " is preparing food");
    }
}



class Waiter : Person, Worker
{

    public Waiter(string name, int id)
        : base(name, id)
    {
    }


    public void PerformDuties()
    {
        Console.WriteLine(
            Name + " is serving customers");
    }
}



class Program
{
    static void Main(string[] args)
    {

        Worker w1 = new Chef("Aman", 101);
        Worker w2 = new Waiter("Rohan", 102);


        w1.PerformDuties();
        w2.PerformDuties();

    }
}