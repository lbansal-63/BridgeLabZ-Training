using System; 
public class Input{
	public static void Main(){
		byte roll;
		string name; 
		short marks; 
		float percent; 
		char grade; 

		Console.Write("Enter your rollno.: ");
		roll = Convert.ToByte(Console.ReadLine());

		Console.Write("Enter your name: ");
		name = Console.ReadLine(); 
		
		Console.Write("Enter your marks: ");
		marks = Convert.ToInt16(Console.ReadLine());
		
		
		Console.Write("Enter your percent: ");
		percent = Convert.ToSingle(Console.ReadLine()); 

		Console.Write("Enter your grade: "); 
		grade = Convert.ToChar(Console.ReadLine()) ;  
		
		Console.WriteLine(); 

		Console.WriteLine("Roll No.: "+roll);
		Console.WriteLine("Name: "+name); 
		Console.WriteLine("Marks: "+marks); 
		Console.WriteLine("Percent: "+percent); 
		Console.WriteLine("Grade: "+grade); 
	}
}