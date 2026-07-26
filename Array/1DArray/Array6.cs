using System; 
public class ArrayDemo6{
    public static void Main()
    {
        int[] roll = new int[5];
        string[] name = new string[5];
        string[] gender = new string[5];

        for (int i = 0; i < 5; i++){
            Console.Write("Enter Roll: ");
            roll[i] = Convert.ToInt32(Console.ReadLine());  

            Console.Write("Enter Name: ");
            name[i] = Console.ReadLine(); 
            
            Console.Write("Enter Gender: ");  
            gender[i] = Console.ReadLine();
        }
        
        for (int i = 0; i < 5; i++){
            Console.WriteLine(roll[i]);
            Console.WriteLine(name[i]);
            Console.WriteLine(gender[i]);
        }
        
    }
}