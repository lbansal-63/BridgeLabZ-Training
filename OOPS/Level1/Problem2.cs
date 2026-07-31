using System;

class Circle
{
    private double radius;

    public Circle() : this(1)
    {
    }

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public void Display()
    {
        Console.WriteLine("Radius = " + radius);
    }
}

class Program
{
    static void Main()
    {
        Circle c1 = new Circle();
        Circle c2 = new Circle(10);

        c1.Display();
        c2.Display();
    }
}