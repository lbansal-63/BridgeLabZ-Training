using System; 
public class PassFail{
	public static void Main(){
		int marks; 
		
		Console.Write("Enter your marks: "); 
		marks = Convert.ToInt32(Console.ReadLine()); 
		
		if(marks>=33){
			Console.WriteLine("You Passed!!"); 
		}else{
			Console.WriteLine("You Failed!!"); 
		}
	}
}