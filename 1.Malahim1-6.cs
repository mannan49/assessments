////...................................................................
////Question#2
///*              CODERBYTE RUN LENGTH CHALLENGE                  *
// *                                                              *
// * Problem Statement                                            *
// * Have the function RunLength(str) take the str parameter being*
// * passed and return a compressed version of the string using   *
// * the Run-length encoding algorithm. This algorithm works by   *
// * taking the occurrence of each repeating character and        *
// * outputting that number along with a single character of the  *
// * repeating sequence.                                          *
// * For example: "wwwggopp" would return 3w2g1o2p.               *
// * The string will not contain any numbers, punctuation,        *
// * or symbols.                                                  *
// *                                                              *
// * Examples                                                     *
// * Input 1: "aabbcde"                                           *
// * Output 1: 2a2b1c1d1e                                         *
// *                                                              *
// * Input 2: "wwwbbbw"                                           *
// * Output 2: 3w3b1w                                             *
// *                                                              *

// ***************************************************************/


//using System;

//class Program
//{
//    public static string RunLength(string str)
//    {
//        // Your code goes here
//        int counter = 1;
//        string trim = string.Empty;
//        for (int i = 1; i < str.Length; i++)
//        {
//            if (str[i] == str[i - 1])
//            {
//                counter++;
//            }
//            else
//            {
//                trim += counter.ToString() + str[i - 1];
//                counter = 1;
//            }

//        }
//        trim += counter.ToString() + str[str.Length - 1];
//        return trim;
//    }

//    static void Main()
//    {
//        // Test cases
//        Console.WriteLine(RunLength("aabbcde"));  // Expected output: 2a2b1c1d1e
//        Console.WriteLine(RunLength("wwwbbbw"));  // Expected output: 3w3b1w
//    }
//}




////............................................................
//// //Question#3
/////****************************************************************
////*             CODERBYTE PALINDROME TWO CHALLENGE               *
////*                                                              *
////* Problem Statement                                            *
////* Have the function PalindromeTwo(str) take the str parameter  * 
////* being passed and return the string true if the parameter is  *
////* a palindrome, (the string is the same forward as it is       *
////* backward) otherwise return the string false. The parameter   *
////* entered may have punctuation and symbols but they should not *
////* affect whether the string is in fact a palindrome.           *
////* For example: "Anne, I vote more cars race Rome-to-Vienna"    *
////* should return true.                                          *
////*                                                              *
////* Examples                                                     *
////* Input 1: "Noel - sees Leon"                                  *
////* Output 1: true                                               *
////*                                                              *
////* Input 2: "A war at Tarawa!"                                  *
////* Output 2: true                                               *
////*                                                              *
////* Solution Efficiency                                          *
////* The user scored higher than 33.1% of users who solved this   *
////* challenge.                                                   *
////*                                                              *
////***************************************************************/

//using System;
//using System.Security.Cryptography;
//using System.Collections.Generic;

//class Program
//{
//    public static string PalindromeTwo(string str)
//    {
//        // Your code goes here
//        string chars = "";
//        for (int i = 0; i < str.Length; i++)
//        {
//            char c = str[i];
//            if (char.IsLetter(c))
//            {
//                chars += c;
//            }
//        }
//        string lower = chars.ToLower();
//        char[] myArray = lower.ToCharArray();
//        Array.Reverse(myArray);
//        string reversedChars = new string(myArray);
//        return lower == reversedChars ? "true" : "false";
//    }
//    static void Main()
//    {
//        // Test cases
//        Console.WriteLine(PalindromeTwo("Noel - sees Leon"));  // Expected output: true
//        Console.WriteLine(PalindromeTwo("A war at Tarawa!"));  // Expected output: true
//        Console.WriteLine(PalindromeTwo("Anne, I vote more cars race Rome-to-Vienna"));  // Expected output: true
//    }
//}



//////.....................................................................................
//// //Question#4
//// /****************************************************************
//// *             CODERBYTE STRING SCRAMBLE CHALLENGE              *
//// *                                                              *
//// * Problem Statement                                            *
//// * Have the function StringScramble(str1,str2) take both        * 
//// * parameters being passed and return the string true if a      *
//// * portion of str1 characters can be rearranged to match str2,  *
//// * otherwise return the string false.                           *
//// * For example: if str1 is "rkqodlw" and str2 is "world" the    *
//// * output should return true. Punctuation and symbols will not  *
//// * be entered with the parameters.                              *
//// *                                                              *
//// * Examples                                                     *
//// * Input 1: "cdore" & "coder"                                   *
//// * Output 1: true                                               *
//// *                                                              *
//// * Input 2: "h3llko" & "hello"                                  *
//// * Output 2: false                                              *
//// *                                                              *
//// * Solution Efficiency                                          *
//// * The user scored higher than 37.5% of users who solved this   *
//// * challenge.                                                   *
//// *                                                              *
//// ***************************************************************/

//using System;

//class Program
//{
//    public static string StringScramble(string str1, string str2)
//    {
//        // Your code goes here
//        int counter = 0;
//        for (int i = 0; i < str2.Length; i++)
//        {
//            for (int j = 0; j < str1.Length; j++)
//            {
//                if (str2[i] == str1[j])
//                {
//                    counter++;
//                }
//            }
//        }
//        if (counter == str2.Length) 
//        {
//            return "true";
//         }
//        else
//        {
//            return "false";
//        }
//    }

//    static void Main()
//    {
//        // Test cases
//        Console.WriteLine(StringScramble("cdore", "coder"));  // Expected output: true
//        Console.WriteLine(StringScramble("h3llko", "hello"));  // Expected output: false
//    }
//}



////Question#6
///****************************************************************
//*              CODERBYTE BINARY CONVERTER CHALLENGE            *
//*                                                              *
//* Problem Statement                                            *
//* Have the function BinaryConverter(str) return the decimal    *
//* form of the binary value. For example: if 101 is passed      *
//* return 5, or if 1000 is passed return 8.                     *
//*                                                              *
//* For example: the number 10 is Happy because 1^2 + 0^2	*
//* converges to 1.       					*
//*                                                              *
//* Examples                                                     *
//* Input 1: "100101" 		                                *
//* Output 1: 37                                                 *
//*                                                              *
//* Input 2: "011"                                               *
//* Output 2: 3                                                  *
//*                                                              *
//***************************************************************/

//using System;

//class Program
//{
//    public static int BinaryConverter(string str)
//    {
//        int decimalValue = 0;
//        int baseValue = 1;  // 2^0

//        // Iterate over the string from the end to the beginning
//        for (int i = str.Length - 1; i >= 0; i--)
//        {
//            if (str[i] == '1')
//            {
//                decimalValue += baseValue;
//            }
//            baseValue *= 2;  // Increase the base value (2^1, 2^2, 2^3, ...)
//        }

//        return decimalValue;
//    }

//    static void Main()
//    {
//        // Test cases
//        Console.WriteLine(BinaryConverter("100101"));  // Expected output: 37
//        Console.WriteLine(BinaryConverter("011"));     // Expected output: 3
//    }
//}


using System;

class Program
{
    public static int BracketCombinations(int num)
    {
        // Function to calculate factorial of a number
        long Factorial(int n)
        {
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        // Catalan number calculation using factorials
        long catalanNumber = Factorial(2 * num) / (Factorial(num + 1) * Factorial(num));
        return (int)catalanNumber;
    }

    static void Main()
    {
        // Test cases
        Console.WriteLine(BracketCombinations(3));  // Expected output: 5
        Console.WriteLine(BracketCombinations(2));  // Expected output: 2
    }
}
