using System; 
public class Cond{
	public static void Main(){
		int price,qty,total,dis = 0,ntotal;

		Console.Write("Enter price: "); 
		price = Convert.ToInt32(Console.ReadLine());

		Console.Write("Enter quantity: "); 
		qty = Convert.ToInt32(Console.ReadLine());

		total = price * qty; 

		if(total>=2000){
			dis = total * 10/100; 
		}
		else{
			dis = total * 5/100; 
		}
		ntotal = total-dis;
 
		Console.WriteLine("Discount: "+dis); 
		Console.WriteLine("Total: "+total); 
		Console.WriteLine("Net Total: "+ntotal); 
	}
} 