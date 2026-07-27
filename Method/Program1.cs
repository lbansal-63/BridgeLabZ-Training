using System; 
public class Methods
{
    public void Show() // declaring a method -> this is known as non static/ instance method non parameterized Method
    {
        Console.WriteLine("Welcome to C# Programming");
        Console.WriteLine("Hello Everyone");
    }

    public static void Show1()  // static method // non parameterized Method
    {
        Console.WriteLine("Welcome to C# Programming2");
        Console.WriteLine("Hello Everyone2");
    }

    public static void Add(int num1,int num2) // parameterized method
    {
        int res = num1 + num2;
        Console.WriteLine("Result: " + res); 
    }

    public static void Main()
    {
        Methods m1 = new Methods(); // creating a object of class 
        m1.Show(); // calling the method
        m1.Show();
        m1.Show();


        Methods.Show1(); // calling the static method 
        Methods.Show1();
        Methods.Show1();

        Methods.Add(10, 20);
        Methods.Add(20, 60);

        //taking input and calling method
        Console.WriteLine();  
        Console.Write("Enter the first number: "); 
        int num1 = Convert.ToInt32(Console.ReadLine());


        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Methods.Add(num1, num2);
        
    }
}