using System; 
public class Fibo{
	public static void Main(){
		int num1 = 0; 
		int num2 = 1;
		int count=0;  
		while(count<=30){	
			Console.Write(num1+" "); 
			int temp = num1+num2;
			num1 = num2;
			num2 = temp; 
			count++; 
		}
	}
}