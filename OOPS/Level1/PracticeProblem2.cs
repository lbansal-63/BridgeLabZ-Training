using System;
public class Program
{
    class Circle
    {
        public int rad;

        public Circle(int rad)
        {
            this.rad = rad;
        }

        public void print()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Circumferance of circle: "+ 2*Math.PI*rad);
            Console.WriteLine("Area of circle: " + Math.PI*rad*rad);
            Console.WriteLine("------------------------");
        }
    }

    public static void Main()
    {
        Circle c1 = new Circle(15);
        Circle c2 = new Circle(10);

        c1.print();
        c2.print();
    }
}