using System; 
public class Calculatorl{
	public static void Main(){

		int num1,num2,choice,res=0; 

		do{	
			Console.Write("Enter first number: "); 
			num1  = Convert.ToInt32(Console.ReadLine()); 
			
			Console.Write("Enter second number: "); 
			num2  = Convert.ToInt32(Console.ReadLine()); 

			Console.WriteLine("------- MENU ------");
				Console.WriteLine("1. Add");
				Console.WriteLine("2. Sub");
				Console.WriteLine("3. Multiply");
				Console.WriteLine("4. Divide"); 
				Console.WriteLine("5. Exit"); 
			Console.WriteLine("---------------------");

			Console.Write("Enter your choice(1-5): "); 
			choice  = Convert.ToInt32(Console.ReadLine()); 
			
			switch(choice){
			case 1:	
				res = num1+num2;
				break; 

			case 2:	
				res = num1-num2;
				break;

			case 3:	
				res = num1*num2;
				break;
 
			case 4:
				if(num2==0){
					Console.WriteLine("Division not Possible"); 
					return;
				}
				res = num1/num2;
				break; 
 
			case 5:	
				Console.WriteLine("------- THANK YOU!! ------");
				return; 
			
			default:
				Console.Write("INVALID INPUT"); 
				return; 
		}
		
			Console.WriteLine("Result: "+res);
	
			
		}while(choice!=5); 
	}
}