using System; 
public class Input{
	public static void Main(){
		string name, fname, gender,email;
		Console.Write("Enter your Name: "); 
		name = Console.ReadLine(); 

		Console.Write("Enter your Father's Name: "); 
		fname = Console.ReadLine(); 
	
		Console.Write("Enter your Gender: "); 
		gender = Console.ReadLine(); 
		
		Console.Write("Enter your Email Id: "); 
		email = Console.ReadLine();
		
		Console.WriteLine(); 

		Console.WriteLine("Name: "+name);
		Console.WriteLine("Father Name: "+fname);
		Console.WriteLine("Gender: "+gender);
		Console.WriteLine("email: "+email); 
	} 
		
}