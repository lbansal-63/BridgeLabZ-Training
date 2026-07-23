using System; 
public class Grade{
	public static void Main(){
		int marks;

		Console.Write("Enter your marks: "); 
		marks = Convert.ToInt32(Console.ReadLine());

		if(marks>=85){
			Console.WriteLine("A Grade");
		} else if(marks>=70){
			Console.WriteLine("B Grade");
		} else if(marks>=60){
			Console.WriteLine("C Grade");
		} else if(marks>=50){
			Console.WriteLine("D Grade");
		} else if(marks>=33){
			Console.WriteLine("E Grade");
		} else{
			Console.WriteLine("F Grade");
		}

	}
}