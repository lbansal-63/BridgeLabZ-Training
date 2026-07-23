using System; 
public class discountPrice{
	public static void Main(){
		float price, qty,disc=0,total,ntotal;	
		Console.Write("Enter the price: "); 
		price = Convert.ToSingle(Console.ReadLine()); 

		Console.Write("Enter the quantity: "); 
		qty = Convert.ToSingle(Console.ReadLine()); 

		total = qty*price; 

		if(total>=10000){
			disc = total * 20/100; 
		}else if(total>=5000){
			disc = total * 15/100; 
		}else if(total>=3000){
			disc = total * 10/100; 
		}else if(total>=1000){
			disc = total * 5/100; 
		}else{
			disc = 0; 
		}
		
		ntotal = total-disc; 
		Console.WriteLine("Price: "+price); 
		Console.WriteLine("Quantity: "+qty); 
		Console.WriteLine("Total: "+total); 
		Console.WriteLine("Discount: "+disc); 
		Console.WriteLine("Net Total: "+ntotal); 
	}
}