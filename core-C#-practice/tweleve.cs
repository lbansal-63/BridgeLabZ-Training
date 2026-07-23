using System; 
public class ArithAssign{
	public static void Main(){
		int x = 10; 	
		int y = 5; 	

		x += 30; 
		Console.WriteLine("X: "+x);

		x-=10;
		Console.WriteLine("X: "+x); 

		x *= y;
		Console.WriteLine("X: "+x);
		Console.WriteLine("Y: "+y);

		y+=25; 
		Console.WriteLine("Y: "+y);
		
		y/=5;
		Console.WriteLine("Y: "+y);
	}
}

