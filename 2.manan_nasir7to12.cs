// //Question#7
 /****************************************************************
 *               CODERBYTE FORMATTED DIVISION CHALLENGE         *
 *                                                              *
 * Problem Statement                                            *
 * Have the function FormattedDivision(num1,num2) take both     *
 * parameters being passed, divide num1 by num2, and return the *
 * result as a string with properly formatted commas and 4      *
 * significant digits after the decimal place.                  * 
 *                                                              *
 * For example: if num1 is 123456789 and num2 is 10000          *
 * the output should be "12,345.6789".                          *
 * The output must contain a number in the one's place even     *
 * if it is a zero.                                             *
 *                                                              *
 * Examples                                                     *
 * Input 1: 2 and 3                                             *
 * Output 1: 0.6667                                             *
 *                                                              *
 * Input 2: 10 and 10                                           *
 * Output 2: 1.0000                                             *
 *                                                              *                                                   
 *                                                              *
 ***************************************************************/

using System;
using System.Globalization;

class MainClass {
    public static string FormattedDivision(int num1, int num2) {
        double result = (double)num1 / num2;
        string resultStr = result.ToString("F4", CultureInfo.InvariantCulture);

        // Split the string into integer and fractional parts
        string[] parts = resultStr.Split('.');

        // Format the integer part with commas
        string integerPart = Int32.Parse(parts[0]).ToString("N0", CultureInfo.InvariantCulture);

        // Combine the formatted integer part and the fractional part
        string formattedResult = integerPart + "." + parts[1];

        return formattedResult;
    }

    static void Main() {
        Console.WriteLine(FormattedDivision(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
    }
}

........................................................................
//Question#8
/****************************************************************
 *             CODERBYTE CAESAR CIPHER CHALLENGE                *
 *                                                              *
 * Problem Statement                                            *
 * Have the function CaesarCipher(str,num) take the str         *
 * parameter and perform a Caesar Cipher shift on it using the  *
 * num parameter as the shifting number. A Caesar Cipher works  *
 * by shifting each letter in the string N places in the        *
 * alphabet (in this case N will be num). Punctuation, spaces,  *
 * and capitalization should remain intact.                     *
 * For example if the string is "Caesar Cipher" and num is 2    *
 * the output should be "Ecguct Ekrjgt".                        *
 *                                                              *
 * Examples                                                     *
 * Input 1: "Hello" and num = 4                                 *
 * Output 1: Lipps                                              *
 *                                                              *
 * Input 2: "abc" and num = 0                                   *
 * Output 2: abc                                                *
 *                                                              *
 *                                                              *
 * Solution Efficiency                                          *
 * The user scored higher than 49.2% of users who solved this   *
 * challenge.                                                   *
 *                                                              *
 ***************************************************************/

using System;

class MainClass {
    public static string CaesarCipher(string str, int num) {
        char[] buffer = str.ToCharArray();
        for (int i = 0; i < buffer.Length; i++) {
            char letter = buffer[i];
            if (char.IsLetter(letter)) {
                char offset = char.IsUpper(letter) ? 'A' : 'a';
                letter = (char)((((letter + num) - offset) % 26) + offset);
            }
            buffer[i] = letter;
        }
        return new string(buffer);
    }

    static void Main() {
        // keep this function call here
        Console.WriteLine(CaesarCipher(Console.ReadLine(), Convert.ToInt32(Console.ReadLine())));
    }
}

............................................................................
//Question#9
 /****************************************************************
 *             CODERBYTE COUNTING MINUTES ONE CHALLENGE         *
 *                                                              *
 * Problem Statement                                            *
 * Have the function CountingMinutesI(str) take the str         *
 * parameter being passed which will be two times               *
 * (each properly formatted with a colon and am or pm)          *
 * separated by a hyphen and return the total number of minutes *
 * between the two times. The time will be in a 12 hour clock   *
 * format.                                                      * 
 * For example: if str is 9:00am-10:00am then the               *
 * output should be 60. If str is 1:00pm-11:00am the output     *
 * should be 1320.                                              *
 *                                                              *
 * Examples                                                     *
 * Input 1: "12:30pm-12:00am"                                   *
 * Output 1: 690                                                *
 *                                                              *
 * Input 2: "1:23am-1:08am"                                     *
 * Output 2: 1425                                               *
 *                                                              *
 * Solution Efficiency                                          *
 * The user scored higher than 44.7% of users who solved this   *
 * challenge.                                                   *
 *                                                              *
 ***************************************************************/

-----------------My Solution----------------
using System;
using System.Text.RegularExpressions;

class MainClass {
    public static int CountingMinutes(string str) {
      char[] arr = str.ToCharArray();
      char first ='$';
      char second ='$';
      bool toAdd = false;

      char[] delimiters = new char[] { ':', '-', 'p', 'a' };
      string[] buffer = str.Split(delimiters);


      int hour_1 = Convert.ToInt32(buffer[0]);
      int min_1 = Convert.ToInt32(buffer[1]);
      int hour_2 = Convert.ToInt32(buffer[3]);
      int min_2 = Convert.ToInt32(buffer[4]);
     

      int total = (hour_2*60 + min_2) - (hour_1*60 + min_1);
      
 

      if(arr[4] == 'a' || arr[5]== 'a'){
        first = 'a';
      }
      if(arr[4] == 'p' || arr[5]== 'p'){
        first = 'p';
      }
      if(arr[arr.Length-2] == 'a'){
        second = 'a';
      }
      if(arr[arr.Length-2] == 'p'){
        second = 'p';
      }
      if(first != second){
        toAdd = true;
      }

      if(toAdd){
        total = total+720;
      }
      if(total<0){
        total = total+1440;
      }


        return total;
    }
    

    

    static void Main() {
        // keep this function call here
        Console.WriteLine(CountingMinutes(Console.ReadLine()));
    }
}

---------------------CHATGPT solution-------------------

using System;
using System.Globalization;

class MainClass {
    public static int CountingMinutes(string str) {
        string[] times = str.Split('-');

        DateTime startTime = DateTime.ParseExact(times[0], "h:mmtt", CultureInfo.InvariantCulture);
        DateTime endTime = DateTime.ParseExact(times[1], "h:mmtt", CultureInfo.InvariantCulture);

        // Calculate the difference in minutes
        TimeSpan difference = endTime - startTime;

        // If the end time is before the start time, add 24 hours to the end time
        if (difference.TotalMinutes < 0) {
            difference += TimeSpan.FromDays(1);
        }

        return (int)difference.TotalMinutes;
    }

    static void Main() {
        // keep this function call here
        Console.WriteLine(CountingMinutes(Console.ReadLine()));
    }
}
..................................................................

  //Question#10
 /****************************************************************
 *               CODERBYTE NUMBER SEARCH CHALLENGE              *
 *                                                              *
 * Problem Statement                                            *
 * Have the function NumberSearch(str) take the str parameter,  *
 * search for all the numbers in the string, add them together, *
 * then return that final number divided by the total amount of *
 * letters in the string. For example: if str is                *
 * "Hello6 9World 2, Nic8e D7ay!" the output should be 2.       *
 * First if you add up all the numbers, 6 + 9 + 2 + 8 + 7       *
 * you get 32. Then there are 17 letters in the string.         *
 * 32 / 17 = 1.882, and the final answer should be rounded to   *
 * the nearest whole number, so the answer is 2. Only single    *
 * digit numbers separated by spaces will be used throughout    *
 * the whole string,                                            *
 * (So this won't ever be the case: hello44444 world).          *
 * Each string will also have at least one letter.              *
 *                                                              *
 * Examples                                                     *
 * Input 1: "H3ello9-9"		                                *
 * Output 1: 4                                                  *
 *                                                              *
 * Input 2: "One Number*1*"                                     *
 * Output 2: 0                                                  *
 *                                                              *
 ***************************************************************/


using System;
using System.Globalization;

class MainClass {
    public static int NumberSearch(string str) {
        
    char[] arr = str.ToCharArray();
    int total = 0;
    int count = 0;
    for(int i=0; i<arr.Length; i++){
      if(char.IsNumber(arr[i])){
        total += arr[i]-'0';
      }
      if(char.IsLetter(arr[i])){
        count++;
      }
    }
    double result = (double) total/count;
    int output = (int)Math.Round(result);


        return output;
    }

    static void Main() {
        // keep this function call here
        Console.WriteLine(NumberSearch(Console.ReadLine()));
    }
}
.......................................................................................
//Question#11

 /****************************************************************
 *             CODERBYTE SWIPE CASE TWO CHALLENGE               *
 *                                                              *
 * Problem Statement                                            *
 * Have the function SwapII(str) take the str parameter and swap*
 * the case of each character. Then, if a letter is between two *
 * numbers (without separation), switch the places of the two   *
 * numbers.                                                     *
 * For example: if str is "6Hello4 -8World, 7 yes3"             *
 * the output should be 4hELLO6 -8wORLD, 7 YES3.                *
 *                                                              *
 * Examples                                                     *
 * Input 1: "Hello -5LOL6"                                      *
 * Output 1: hELLO -6lol5                                       *
 *                                                              *
 * Input 2: "2S 6 du5d4e"                                       *
 * Output 2: 2s 6 DU4D5E                                        *
 *                                                              *
 * Solution Efficiency                                          *
 * The user scored higher than 51.8% of users who solved this   *
 * challenge.                                                   *
 *                                                              *
 ***************************************************************/
using System;

class MainClass {
    public static string SwapII(string str) {
        char[] arr = str.ToCharArray();
        int len = arr.Length;

        // Swap the case of each character
        for (int i = 0; i < len; i++) {
            char c = arr[i];
            if (char.IsLetter(c)) {
                if (char.IsUpper(c)) {
                    arr[i] = char.ToLower(c);
                } else {
                    arr[i] = char.ToUpper(c);
                }
            }
        }

        // Swap digits if a letter is between them
        for (int i = 0; i < len - 2; i++) {
            if (char.IsDigit(arr[i]) && char.IsLetter(arr[i + 1]) && char.IsDigit(arr[i + 2])) {
                // Swap the digits
                char temp = arr[i];
                arr[i] = arr[i + 2];
                arr[i + 2] = temp;

                // Move i forward to skip the swapped digits
                i += 2;
            }
        }

        return new string(arr);
    }

}

............................................................................................
//Question#12
 /****************************************************************
 *             CODERBYTE DASH INSERT TWO CHALLENGE              *
 *                                                              *
 * Problem Statement                                            *
 * Have the function DashInsertII(str) insert dashes ('-')      *
 * between each two odd numbers and insert asterisks ('*')      *
 * between each two even numbers in str.                        *
 *                                                              *
 * For example: if str is 4546793 the output should be          *
 * 454*67-9-3. Don't count zero as an odd or even number.       *
 *                                                              *
 * Examples                                                     *
 * Input 1: 99946                                               *
 * Output 1: 9-9-94*6                                           *
 *                                                              *
 * Input 2: 56647304                                            *
 * Output 2: 56*6*47-304                                        *
 *                                                              *
 * Solution Efficiency                                          *
 * The user scored higher than 36.2% of users who solved this   *
 * challenge.                                                   *
 *                                                              *
 ***************************************************************/

using System;

class MainClass {
    public static string DashInsertII(string str) {
        char[] arr = str.ToCharArray();
        int len = arr.Length;
        string result = "";

        for (int i = 0; i < len; i++) {
            result += arr[i];

            if (i < len - 1) {
                int currentDigit = arr[i] - '0';
                int nextDigit = arr[i + 1] - '0';

                if (currentDigit != 0 && nextDigit != 0) {
                    if (currentDigit % 2 == 0 && nextDigit % 2 == 0) {
                        result += "*";
                    } else if (currentDigit % 2 != 0 && nextDigit % 2 != 0) {
                        result += "-";
                    }
                }
            }
        }

        return result;
    }
}

