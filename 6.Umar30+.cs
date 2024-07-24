using System;
using System.Collections.Generic;

namespace CodeWithMe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 5, 2, 8, 3, 9, 12 };
            int[] arr2 = { 5, 3, 1, 9, 7, 3, 4, 1 };
            int[] arr3 = { 2, 4, 5, 1, 7 };
            int[] arr4 = { -2, 5, -1, 7, -3 };
            int[] arr5 = { 1, 2, 2, 2, 3 };
            int[] arr6 = { 0, -2, -2, 5, 5, 5 };
            int[] arr7 = { 100, 2, 101, 4 };
            int[] arr8 = { -2, 5, -1, 7, -3 };
            string s = "hellosannasmith";
            Console.WriteLine(longestPalindrome(s));
            Console.WriteLine(countDuplicate(arr1));
            Console.WriteLine(countDuplicate(arr2));
            Console.WriteLine(countDuplicate(arr3));
            Console.WriteLine(countDuplicate(arr4));
            Console.WriteLine(countDuplicate(arr5));
            Console.WriteLine(countDuplicate(arr6));
            Console.WriteLine(countDuplicate(arr7));
            Console.WriteLine(maxSubArray(arr4));

            PrintList(smallestNearestValue(arr1));

            // Print results for arr2
            PrintList(smallestNearestValue(arr2));

            // Print results for arr3
            PrintList(smallestNearestValue(arr3));
        }

        static List<int> smallestNearestValue(int[] arr)
        {
            List<int> result = new List<int>();
            result.Add(-1);
            bool foundNearest = false;
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[i] >= arr[j])
                    {
                        result.Add(arr[j]);
                        foundNearest = true;
                        break;
                    }
                }
                if (!foundNearest)
                {
                    result.Add(-1);
                }
                foundNearest = false;
            }
            return result;
        }

        static void PrintList(List<int> list)
        {
            foreach (int num in list)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine(); // Print a newline after each list
        }

        static int maxSubArray(int[] arr)
        {
            int max = arr[0];
            int c = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                c = Math.Max(arr[i], c + arr[i]);
                max = Math.Max(max, c);
            }
            return max;
        }

        static int countDuplicate(int[] arr)
        {
            int c = 0;
            Array.Sort(arr);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    c++;
                }
            }


            return c;
        }
        static string longestPalindrome(string s)
        {
            if (s.Length < 2)
            {
                return "none";
            }
            string r = "";
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j <= s.Length; j++)
                {
                    string sub = s.Substring(i, j - i);
                    if (isPalindrome(sub) && sub.Length > r.Length)
                    {
                        r = sub;
                    }
                }
            }
            return r;
        }

        static bool isPalindrome(string s)
        {
            int l = 0;
            int r = s.Length - 1; // Adjusted to be the index of the last character

            while (l < r)
            {
                if (s[l] != s[r])
                {
                    return false;
                }
                l++;
                r--;
            }
            return true;
        }
    }

    }


