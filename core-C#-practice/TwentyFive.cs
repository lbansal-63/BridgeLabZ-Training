using System; 
public class SwitchCase{
	public static void Main(){
		int num1,num2,ch,res=0; 	

		Console.Write("Enter the first number: "); 
		num1 = Convert.ToInt32(Console.ReadLine()); 
		
		Console.Write("Enter the second number: "); 
		num2 = Convert.ToInt32(Console.ReadLine()); 
		
		Console.WriteLine("------- MENU ------");
			Console.WriteLine("1. Add");
			Console.WriteLine("2. Sub");
			Console.WriteLine("3. Div");
			Console.WriteLine("4. Multiply"); 
		Console.WriteLine("---------------------");
		
		Console.Write("Enter your choice(1-4): "); 
		ch = Convert.ToInt32(Console.ReadLine()); 
		
		switch(ch){
			case 1:	
				res = num1+num2;
				break; 

			case 2:	
				res = num1-num2;
				break;
 
			case 3:
				if(num2==0){
					Console.WriteLine("Division not Possible"); 
					return;
				}
				res = num1/num2;
				break; 

			case 4:	
				res = num1*num2;
				break; 
			
			default:
				Console.Write("INVALID INPUT"); 
				return; 
		}
		
			Console.WriteLine("Result: "+res);
		
	}

}