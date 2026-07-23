using System; 
public class VowelOrNot{
	public static void Main(){
		char ch; 
		Console.Write("Enter a character: "); 
		ch =  Convert.ToChar(Console.Read());

		if(ch=='a' || ch=='e' || ch=='i' || ch=='o' ||  ch=='u' || ch=='A' || ch=='E' || ch=='I' || ch=='O' || ch=='U' ){
			Console.WriteLine("Vowel"); 
		}else{
			Console.WriteLine("Consonants"); 
		}
				
	}
}