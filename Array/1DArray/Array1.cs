using System; 
public class BasicOfArray{
	public static void Main(){
		int []nums = new int[5]; 
		int []nums2 = new int[] {1,2,30,31};
        int[] nums3 = {1,2,3,4,5};

		//Initialize Array
		nums[0] = 10; 
		nums[2] = 78;
		nums[4] = 12; 
		nums[3] = 20; 
		nums[1] = 50; 		

		// retrieve value from array 
		Console.WriteLine(nums[0]);
		Console.WriteLine(nums[1]);
		Console.WriteLine(nums[2]);
		Console.WriteLine(nums[3]);
		Console.WriteLine(nums[4]);
		
		int sum = nums[3] + nums[1]; 
		Console.WriteLine("Sum: "+sum);

		Console.WriteLine(nums3.Length); 

		foreach(int i in nums3){
			Console.WriteLine(i);
		}
	}
}