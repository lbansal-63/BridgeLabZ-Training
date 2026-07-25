using System; 
public class BMI
{
    public static void Main()
    {
        double weight,height;
        Console.WriteLine("Enter your weight(in Kg): "); 
        weight = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your height(in cm): ");
        height = Convert.ToInt32(Console.ReadLine());

        double BMI = weight / (height * height);

        if (BMI <= 18.4)
        {
            Console.WriteLine("Underweight");
        } 
        else if(BMI>=18.5 && BMI <= 24.9)
        {
            Console.WriteLine("Normal");
        }
        else if (BMI >= 25.0 && BMI <= 39.9)
        {
            Console.WriteLine("Overweight");
        }
        else
        {
            Console.WriteLine("Obese");
        }
    }
}