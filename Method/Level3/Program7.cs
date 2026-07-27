using System;

public class OTPGenerator
{
    // Method to generate 6 digit OTP
    public static int GenerateOTP()
    {
        Random random = new Random();

        // Generate OTP between 100000 and 999999
        int otp = random.Next(100000, 1000000);

        return otp;
    }


    // Method to check OTPs are unique
    public static bool CheckUniqueOTP(int[] otpArray)
    {
        for (int i = 0; i < otpArray.Length; i++)
        {
            for (int j = i + 1; j < otpArray.Length; j++)
            {
                if (otpArray[i] == otpArray[j])
                {
                    return false;
                }
            }
        }

        return true;
    }


    public static void Main()
    {
        int[] otpNumbers = new int[10];

        // Generate OTP 10 times
        for (int i = 0; i < otpNumbers.Length; i++)
        {
            otpNumbers[i] = GenerateOTP();
        }

        Console.WriteLine("Generated OTP Numbers:");

        for (int i = 0; i < otpNumbers.Length; i++)
        {
            Console.WriteLine(otpNumbers[i]);
        }


        // Check uniqueness
        bool isUnique = CheckUniqueOTP(otpNumbers);

        if (isUnique)
        {
            Console.WriteLine("\nAll OTP numbers are unique.");
        }
        else
        {
            Console.WriteLine("\nDuplicate OTP numbers found.");
        }
    }
}
