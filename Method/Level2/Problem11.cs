using System; 
public class Quad
{
    public static double[] Roots(double a, double b, double c)
    {
        if (a == 0)
        {
            Console.WriteLine("Not a quadratic equation.");
            return new double[0];
        }

        double delta = Math.Pow(b, 2) - 4 * a * c;
        if (delta > 0)
        {
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);

            return new double[] { root1, root2 };
        }
        else if (delta == 0)
        {
            double root = -b / (2 * a);
            return new double[] { root };
        }
        else
        {
            return new double[0];
        }
    }

    public static void Main()
    {
        double a, b, c;
        Console.WriteLine("Enter the value of a: "); 
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the value of b: ");
        b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the value of c: ");
        c = Convert.ToDouble(Console.ReadLine());

        double[] roots = Quad.Roots(a, b, c);

        if (roots.Length==2)
        {
            Console.WriteLine("First Root: " + roots[0]);
            Console.WriteLine("Second Root: " + roots[1]);
        }
        else if (roots.Length == 1)
        {
            Console.WriteLine("Root: " + roots[0]);
        }
        else
        {
            Console.WriteLine("No real roots");
        }
    }
}