using System; 
public class Ternary2{
	public static void Main(){
		int price,qty,total,dis,ntotal;

		Console.Write("Enter price: "); 
		price = Convert.ToInt32(Console.ReadLine());

		Console.Write("Enter quantity: "); 
		qty = Convert.ToInt32(Console.ReadLine());

		total = price * qty; 
		dis = (total>=1000) ?  total*10/100 :  total*5/100; 
		ntotal = total-dis;

		Console.WriteLine("Discount: "+dis); 
		Console.WriteLine("Total: "+total); 
		Console.WriteLine("Net Total: "+ntotal); 
	}
} 