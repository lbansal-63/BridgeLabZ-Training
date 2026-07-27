using System; 

public class Methods3
{   
    public static int Add(int num1,int num2){
        int res = num1 + num2; 
        return res;
    }

    public static void Main(){
        int ans = Methods3.Add(30, 40); 
        Console.WriteLine("Addition result is: "+ans); 
    }

}