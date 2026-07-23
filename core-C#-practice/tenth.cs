using System; 
public class Rectangle{
	public static void Main(){
		int l,b,p,a; 
		Console.Write("Enter the length of Rectangle: "); 
		l = Convert.ToInt32(Console.ReadLine());

		Console.Write("Enter the breadth of Rectangle: "); 
		b = Convert.ToInt32(Console.ReadLine()); 	
		
		a = l*b; 
		p = 2*(l+b); 

		Console.WriteLine("Area of Rectangle is: "+a+" sq.unit"); 
		Console.WriteLine("Perimeter of Rectangle is: "+p+" unit");
	}
}