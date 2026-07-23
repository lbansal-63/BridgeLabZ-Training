using System; 
public class SI{
	public static void Main(){
		float p,r,t,si; 
		Console.Write("Enter the principal Amount: "); 
		p = Convert.ToSingle(Console.ReadLine()); 

		Console.Write("Enter the Rate of interest: "); 
		r = Convert.ToSingle(Console.ReadLine()); 

		Console.Write("Enter the time period: "); 
		t = Convert.ToSingle(Console.ReadLine()); 
		
		si = (p*r*t)/100;
		Console.WriteLine(); 
		Console.WriteLine("Simple Interest: "+si);  
	}
}