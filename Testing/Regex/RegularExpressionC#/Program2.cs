using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions; 

namespace RegularExpressionC_
{
    internal class Program2
    {
        public static void Main()
        {
            //----------------------1
            string myText = "b";
            string pattern = @"^[a-f]$";
            bool IsMatch = Regex.IsMatch(myText, pattern);
            Console.WriteLine($"myText: {myText}, pattern: {pattern}");
            Console.WriteLine($"Valid Text using static method: {IsMatch}");

            //-----------------------2
            myText = "bdg";
            pattern = @"^[a-f]{3}$";
            IsMatch = Regex.IsMatch(myText, pattern);
            Console.WriteLine($"myText: {myText}, pattern: {pattern}");
            Console.WriteLine($"Valid Text using static method: {IsMatch}");

            //------------------------3
            myText = "z*";
            pattern = @"^[a-f]{1,3}$";
            IsMatch = Regex.IsMatch(myText, pattern);
            Console.WriteLine($"myText: {myText}, pattern: {pattern}");
            Console.WriteLine($"Valid Text using static method: {IsMatch}");

            //------------------------4
            myText = "bcde";
            pattern = @"^[a-f]{1,3}$";
            IsMatch = Regex.IsMatch(myText, pattern);
            Console.WriteLine($"myText: {myText}, pattern: {pattern}");
            Console.WriteLine($"Valid Text using static method: {IsMatch}");

            //------------------------5
            myText = "123";
            pattern = @"^[0-9]{1,3}$";
            IsMatch = Regex.IsMatch(myText, pattern);
            Console.WriteLine($"myText: {myText}, pattern: {pattern}");
            Console.WriteLine($"Valid Text using static method: {IsMatch}");

            //------------------------6
            myText = "12";
            pattern = @"^\d{1,3}$";
            IsMatch = Regex.IsMatch(myText, pattern);
            Console.WriteLine($"myText: {myText}, pattern: {pattern}");
            Console.WriteLine($"Valid Text using static method: {IsMatch}");

            //------------------------7
            myText = "a";
            pattern = @"^\d$";
            IsMatch = Regex.IsMatch(myText, pattern);
            Console.WriteLine($"myText: {myText}, pattern: {pattern}");
            Console.WriteLine($"Valid Text using static method: {IsMatch}");

            //------------------------8
            myText = ".com";
            pattern = @"^(.com|.org)$";
            IsMatch = Regex.IsMatch(myText, pattern);
            Console.WriteLine($"myText: {myText}, pattern: {pattern}");
            Console.WriteLine($"Valid Text using static method: {IsMatch}");

            //------------------------9
            myText = "I have an apple and another apple";
            pattern = @"apple";
            string replacement = "orange"; 
            IsMatch = Regex.IsMatch(myText, pattern);
            Console.WriteLine($"myText: {myText}, pattern: {pattern}, replacement: {replacement}");
            string replace = Regex.Replace(myText, pattern, replacement);
            Console.WriteLine(replace);

            //------------------------10
            myText = "ab";
            pattern = @"^ab*$";
            IsMatch = Regex.IsMatch(myText, pattern);
            Console.WriteLine($"myText: {myText}, pattern: {pattern}");
            Console.WriteLine($"Valid Text using static method: {IsMatch}");

            //------------------------11
            myText = "abbb";
            pattern = @"^ab+$";
            IsMatch = Regex.IsMatch(myText, pattern);
            Console.WriteLine($"myText: {myText}, pattern: {pattern}");
            Console.WriteLine($"Valid Text using static method: {IsMatch}"); 

            //------------------------12
            myText = "1234";
            pattern = @"^\d{4}$";
            IsMatch = Regex.IsMatch(myText, pattern);
            Console.WriteLine($"myText: {myText}, pattern: {pattern}");
            Console.WriteLine($"Valid Text using static method: {IsMatch}"); // exactly 4 digit allowed

            //------------------------13
            myText = "1234";
            pattern = @"^\d{4,}$";
            IsMatch = Regex.IsMatch(myText, pattern);
            Console.WriteLine($"myText: {myText}, pattern: {pattern}");
            Console.WriteLine($"Valid Text using static method: {IsMatch}"); // atleast 4 digit allowed

            //------------------------14
            myText = "1234";
            pattern = @"^\d{3,6}$";
            IsMatch = Regex.IsMatch(myText, pattern);
            Console.WriteLine($"myText: {myText}, pattern: {pattern}");
            Console.WriteLine($"Valid Text using static method: {IsMatch}"); // between 3 and 6 digit allowed
        }
    }
}
