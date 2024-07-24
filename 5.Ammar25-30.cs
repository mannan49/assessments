q 25


using System;
using System.Text;
using System.Collections.Generic;

class Program
{
    public static string StringZigzag(string[] strArr)
    {
        string inputString = strArr[0];
        int numRows = int.Parse(strArr[1]);

        if (numRows <= 1 || numRows >= inputString.Length)
        {
            return inputString;
        }

        List<StringBuilder> rows = new List<StringBuilder>();
        for (int i = 0; i < Math.Min(numRows, inputString.Length); i++)
        {
            rows.Add(new StringBuilder());
        }

        int currentRow = 0;
        bool goingDown = true;

        foreach (char c in inputString)
        {
            rows[currentRow].Append(c);
            if (currentRow == 0)
            {
                goingDown = true;
            }
            else if (currentRow == numRows - 1)
            {
                goingDown = false;
            }
            currentRow += goingDown ? 1 : -1;
        }

        StringBuilder result = new StringBuilder();
        foreach (StringBuilder row in rows)
        {
            result.Append(row.ToString());
        }

        return result.ToString();
    }

    static void Main()
    {
        string[] A = { "coderbyte", "3" };
        string[] B = { "cat", "5" };
        string[] C = { "kaamvjjfl", "4" };
        string[] D = { "aeettym", "1" };

        Console.WriteLine(StringZigzag(A)); // creoebtdy
        Console.WriteLine(StringZigzag(B)); // cat
        Console.WriteLine(StringZigzag(C)); // kjajfavlm
        Console.WriteLine(StringZigzag(D)); // aeettym
    }
}


q26


using System;
using System.Linq;

class Program
{
    public static bool ContainsPunctuation(string s)
    {
        return s.Any(ch => char.IsPunctuation(ch));
    }

    public static string SimplePassword(string password)
    {
        if (password.Length <= 7 || password.Length >= 31)
        {
            return "false";
        }

        if (!password.Any(char.IsUpper))
        {
            return "false";
        }

        if (!password.Any(char.IsDigit))
        {
            return "false";
        }

        if (!ContainsPunctuation(password))
        {
            return "false";
        }

        if (password.ToLower().Contains("password"))
        {
            return "false";
        }

        return "true";
    }

    static void Main()
    {
        Console.WriteLine(SimplePassword("apple!M7"));  // Should return "true"
        Console.WriteLine(SimplePassword("applem7"));   // Should return "false"
        Console.WriteLine(SimplePassword("Password123!"));  // Should return "false"
        Console.WriteLine(SimplePassword("P@ssw0rd"));   // Should return "false"
        Console.WriteLine(SimplePassword("Valid1!"));    // Should return "true"
    }
}


q27

using System;
using System.Collections.Generic;

class Program
{
    public static int StringChallenge(string str)
    {
        int maxUniqueCharacters = 0;
        Dictionary<char, int> lastSeen = new Dictionary<char, int>();

        for (int i = 0; i < str.Length; i++)
        {
            if (lastSeen.ContainsKey(str[i]))
            {
                int startIndex = lastSeen[str[i]] + 1;
                int endIndex = i;
                HashSet<char> uniqueChars = new HashSet<char>();

                for (int k = startIndex; k < endIndex; k++)
                {
                    uniqueChars.Add(str[k]);
                }

                maxUniqueCharacters = Math.Max(maxUniqueCharacters, uniqueChars.Count);
            }
            
            lastSeen[str[i]] = i;
        }

        return maxUniqueCharacters;
    }

    static void Main()
    {
        Console.WriteLine(StringChallenge("ahyjakh")); // Should return 4
        Console.WriteLine(StringChallenge("abac")); // Should return 1
        Console.WriteLine(StringChallenge("abcdefg")); // Should return 0
        Console.WriteLine(StringChallenge("aabbccddeeff")); // Should return 0
        Console.WriteLine(StringChallenge("abcabcabc")); // Should return 2
    }
}



q28


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(PalindromicSubstring("abracecars")); // racecar
        Console.WriteLine(PalindromicSubstring("hellosannasmith")); // sannas
        Console.WriteLine(PalindromicSubstring("abcdefgg")); // none
        Console.WriteLine(PalindromicSubstring("acaaca")); // acaaca
    }

    // Function to check if a string is a palindrome
    static bool IsPalindrome(string value)
    {
        int left = 0;
        int right = value.Length - 1;

        while (left < right)
        {
            if (value[left] != value[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }

    // Function to find the longest palindromic substring
    static string PalindromicSubstring(string str)
    {
        string result = "";

        for (int i = 0; i < str.Length; i++)
        {
            string temp = str[i].ToString();

            // Loop to check for a substring palindrome
            for (int j = i + 1; j < str.Length; j++)
            {
                temp += str[j];

                // Only analyze when we have at least 3 characters and the substring is a palindrome
                if (temp.Length >= 3 && IsPalindrome(temp))
                {
                    // Keep track of the longest palindrome substring
                    if (temp.Length > result.Length)
                    {
                        result = temp;
                    }
                }
            }
        }

        return result.Length == 0 ? "none" : result;
    }
}




q29



using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] strArr = { "baseball", "a,all,b,ball,bas,base,cat,code,d,e,quit,z" };
        // string[] strArr = { "hellocat", "apple,bat,cat,goodbye,hello,yellow,why" };
        Console.WriteLine(WordSplit(strArr));
    }

    static string WordSplit(string[] strArr)
    {
        // First Element, with single string   
        string wordToCompare = strArr[0];
        // Second Element, with single string   
        string stringDictionary = strArr[1];

        // Array of split strings   
        string[] singleStrings = stringDictionary.Split(',');
        // Hold Answers   
        string answerWords = "";

        foreach (var firstWord in singleStrings)
        {
            // Split the main word by the firstWord
            string[] splitMainWordArray = wordToCompare.Split(new string[] { firstWord }, StringSplitOptions.None);

            if (splitMainWordArray.Length > 0)
            {
                foreach (var word in splitMainWordArray)
                {
                    string joinedWord = firstWord + word;
                    string reversedWord = new string(joinedWord.Reverse().ToArray());

                    if (joinedWord == wordToCompare || reversedWord == wordToCompare)
                    {
                        // Console.WriteLine($"{firstWord}, {word} winner");
                        answerWords = $"{firstWord}, {word}";
                        break;
                    }
                }
            }
        }

        return string.IsNullOrEmpty(answerWords) ? "Not Possible" : answerWords;
    }
}



q30


using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        var result = Spiral(matrix);
        Console.WriteLine(string.Join(", ", result));
    }

    static List<int> LayerTopRight(ref List<List<int>> matrix)
    {
        var top = matrix[0];
        matrix.RemoveAt(0);

        var right = new List<int>();
        for (int i = 0; i < matrix.Count; i++)
        {
            right.Add(matrix[i].Last());
            matrix[i].RemoveAt(matrix[i].Count - 1);
        }

        return top.Concat(right).ToList();
    }

    static List<int> LayerBottomLeft(ref List<List<int>> matrix)
    {
        var bottom = matrix.Last();
        matrix.RemoveAt(matrix.Count - 1);
        bottom.Reverse();

        var left = new List<int>();
        for (int i = 0; i < matrix.Count; i++)
        {
            left.Add(matrix[i].First());
            matrix[i].RemoveAt(0);
        }

        left.Reverse();
        return bottom.Concat(left).ToList();
    }

    static List<int> Spiral(int[,] matrix)
    {
        var spir = new List<int>();
        var matrixList = MatrixToList(matrix);

        while (matrixList.Count > 0)
        {
            if (matrixList.Count == 1)
            {
                spir.AddRange(matrixList[0]);
                break;
            }

            var tr = LayerTopRight(ref matrixList);
            spir.AddRange(tr);

            var bl = LayerBottomLeft(ref matrixList);
            spir.AddRange(bl);
        }

        return spir;
    }

    static List<List<int>> MatrixToList(int[,] matrix)
    {
        var list = new List<List<int>>();
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            var row = new List<int>();
            for (int j = 0; j < cols; j++)
            {
                row.Add(matrix[i, j]);
            }
            list.Add(row);
        }

        return list;
    }
}

