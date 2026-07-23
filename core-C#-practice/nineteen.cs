using System; 
public class ValidMarks{
	public static void Main(){
		int marks; 
		
		Console.Write("Enter your marks: "); 
		marks = Convert.ToInt32(Console.ReadLine()); 
		
		if(marks>=0 && marks<=100){
			Console.WriteLine("Valid Marks!!"); 
		} else{
			Console.WriteLine("Not Valid Marks!!"); 
		}

	}
}