using System; 
public class SwitchCase{
	public static void Main(){
		char ch; 	
		Console.Write("Enter the character: "); 
		ch = Convert.ToChar(Console.ReadLine()); 
		
		switch(ch){
			case 'a':	
				Console.Write("Vowel"); 
				break; 
			case 'e':	
				Console.Write("Vowel"); 
				break; 
			case 'i':	
				Console.Write("Vowel"); 
				break; 
			case 'o':	
				Console.Write("Vowel"); 
				break; 
			case 'u':	
				Console.Write("Vowel"); 
				break; 
			case 'A':	
				Console.Write("Vowel"); 
				break; 
			case 'E':	
				Console.Write("Vowel"); 
				break; 
			case 'I':	
				Console.Write("Vowel"); 
				break; 
			case 'O':	
				Console.Write("Vowel"); 
				break; 
			case 'U':	
				Console.Write("Vowel"); 
				break; 
			default:
				Console.Write("Consonant"); 
				break; 
		}
	}

}