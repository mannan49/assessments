using System;

public class Program
{
    public static int PermutationStep(int num)
    {
        // Convert the number to a character array to easily manipulate digits
        char[] digits = num.ToString().ToCharArray();
        
        // Step 1: Find the pivot (the first digit from the end which is smaller than the digit next to it)
        int pivot = -1;
        for (int i = digits.Length - 2; i >= 0; i--)
        {
            if (digits[i] < digits[i + 1])
            {
                pivot = i;
                break;
            }
        }

        // If no pivot is found, there is no larger permutation
        if (pivot == -1)
        {
            return -1;
        }

        // Step 2: Find the smallest digit on the right of the pivot which is larger than the pivot
        int successor = -1;
        for (int i = digits.Length - 1; i > pivot; i--)
        {
            if (digits[i] > digits[pivot])
            {
                successor = i;
                break;
            }
        }

        // Step 3: Swap the pivot with the successor
        char temp = digits[pivot];
        digits[pivot] = digits[successor];
        digits[successor] = temp;

        // Step 4: Reverse the suffix starting right after the pivot position
        Array.Reverse(digits, pivot + 1, digits.Length - (pivot + 1));

        // Convert the character array back to an integer and return
        return int.Parse(new string(digits));
    }

    public static void Main()
    {
        Console.WriteLine(PermutationStep(123));        // Output: 132
        Console.WriteLine(PermutationStep(12453));      // Output: 12534
        Console.WriteLine(PermutationStep(11121));      // Output: 11211
        Console.WriteLine(PermutationStep(41352));      // Output: 41523
        Console.WriteLine(PermutationStep(897654321));  // Output: 912345678
        Console.WriteLine(PermutationStep(76666666));   // Output: -1
    }
}






using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class Program
{
    public static string MostFreeTime(string[] strArr)
    {
        // Convert time strings to TimeSpan objects and sort events by start time
        List<(TimeSpan start, TimeSpan end)> events = strArr.Select(e => 
        {
            string[] parts = e.Split('-');
            TimeSpan start = DateTime.ParseExact(parts[0], "hh:mmtt", CultureInfo.InvariantCulture).TimeOfDay;
            TimeSpan end = DateTime.ParseExact(parts[1], "hh:mmtt", CultureInfo.InvariantCulture).TimeOfDay;
            return (start, end);
        }).OrderBy(e => e.start).ToList();

        // Initialize variable to track the longest free time
        TimeSpan longestFreeTime = TimeSpan.Zero;

        // Iterate through sorted events to find the longest free time
        for (int i = 1; i < events.Count; i++)
        {
            TimeSpan freeTime = events[i].start - events[i - 1].end;
            if (freeTime > longestFreeTime)
            {
                longestFreeTime = freeTime;
            }
        }

        // Convert the longest free time to the required format hh:mm
        return longestFreeTime.ToString(@"hh\:mm");
    }

    public static void Main()
    {
        string[] input1 = { "10:00AM-12:30PM", "02:00PM-02:45PM", "09:10AM-09:50AM" };
        string[] input2 = { "09:00AM-10:00AM", "11:00AM-12:00PM", "01:00PM-02:00PM", "03:00PM-04:00PM" };
        
        Console.WriteLine(MostFreeTime(input1)); // Output: 01:30
        Console.WriteLine(MostFreeTime(input2)); // Output: 01:00
    }
}









using System;

public class Program
{
    public static int StockPicker(int[] arr)
    {
        if (arr == null || arr.Length < 2)
        {
            return -1;
        }

        int minPrice = arr[0];
        int maxProfit = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            // Update the minimum price encountered so far
            if (arr[i] < minPrice)
            {
                minPrice = arr[i];
            }
            else
            {
                // Calculate the potential profit
                int potentialProfit = arr[i] - minPrice;
                
                // Update the maximum profit
                if (potentialProfit > maxProfit)
                {
                    maxProfit = potentialProfit;
                }
            }
        }

        // If no profit could be made, return -1
        return maxProfit > 0 ? maxProfit : -1;
    }

    public static void Main()
    {
        Console.WriteLine(StockPicker(new int[] { 44, 30, 24, 32, 35, 30, 40, 38, 15 })); // Output: 16
        Console.WriteLine(StockPicker(new int[] { 10, 9, 8, 2 })); // Output: -1
    }
}



using System;

public class Program
{
    public static int BitmapHoles(string[] strArr)
    {
        int rows = strArr.Length;
        int cols = strArr[0].Length;
        char[,] matrix = new char[rows, cols];
        bool[,] visited = new bool[rows, cols];

        // Convert the input strings to a 2D character matrix
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i][j] = strArr[i][j];
            }
        }

        // Function to perform DFS and mark visited cells
        void DFS(int x, int y)
        {
            if (x < 0 || x >= rows || y < 0 || y >= cols || matrix[x, y] == '1' || visited[x, y])
            {
                return;
            }

            visited[x, y] = true;

            // Check all four possible directions
            DFS(x - 1, y); // up
            DFS(x + 1, y); // down
            DFS(x, y - 1); // left
            DFS(x, y + 1); // right
        }

        int holeCount = 0;

        // Iterate through the matrix to find unvisited 0's and perform DFS
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] == '0' && !visited[i, j])
                {
                    holeCount++;
                    DFS(i, j);
                }
            }
        }

        return holeCount;
    }

    public static void Main()
    {
        Console.WriteLine(BitmapHoles(new string[] { "10111", "10101", "11101", "11111" })); // Output: 2
        Console.WriteLine(BitmapHoles(new string[] { "01111", "01101", "00011", "11110" })); // Output: 3
        Console.WriteLine(BitmapHoles(new string[] { "1011", "0010" })); // Output: 2
    }
}










using System;
using System.Linq;

public class Program
{
    public static int FoodDistribution(int[] arr)
    {
        int sandwiches = arr[0];
        int[] hungerLevels = arr.Skip(1).ToArray();

        while (sandwiches > 0)
        {
            // Find the maximum hunger level and its position
            int maxIndex = Array.IndexOf(hungerLevels, hungerLevels.Max());

            // Decrease the hunger level at maxIndex by 1
            hungerLevels[maxIndex]--;

            // Decrease the count of sandwiches
            sandwiches--;

            // If the difference is minimized, break the loop
            if (IsDifferenceMinimized(hungerLevels))
            {
                break;
            }
        }

        // Calculate the total difference
        return CalculateTotalDifference(hungerLevels);
    }

    private static bool IsDifferenceMinimized(int[] hungerLevels)
    {
        // Calculate the differences between consecutive elements
        int[] differences = new int[hungerLevels.Length - 1];
        for (int i = 0; i < hungerLevels.Length - 1; i++)
        {
            differences[i] = Math.Abs(hungerLevels[i] - hungerLevels[i + 1]);
        }

        // Check if the maximum difference is minimized
        return differences.Max() <= 1;
    }

    private static int CalculateTotalDifference(int[] hungerLevels)
    {
        int totalDifference = 0;
        for (int i = 0; i < hungerLevels.Length - 1; i++)
        {
            totalDifference += Math.Abs(hungerLevels[i] - hungerLevels[i + 1]);
        }
        return totalDifference;
    }

    public static void Main()
    {
        Console.WriteLine(FoodDistribution(new int[] { 5, 3, 1, 2, 1 })); // Output: 0
        Console.WriteLine(FoodDistribution(new int[] { 4, 5, 2, 3, 1, 0 })); // Output: 2
    }
}







using System;

public class Program
{
    public static string EightQueens(string[] strArr)
    {
        (int x, int y)[] queens = new (int, int)[strArr.Length];
        
        // Parse the input strings into tuples of integers
        for (int i = 0; i < strArr.Length; i++)
        {
            string[] parts = strArr[i].Trim('(', ')').Split(',');
            queens[i] = (int.Parse(parts[0]), int.Parse(parts[1]));
        }
        
        // Check for any queens attacking each other
        for (int i = 0; i < queens.Length; i++)
        {
            for (int j = i + 1; j < queens.Length; j++)
            {
                if (AreQueensAttacking(queens[i], queens[j]))
                {
                    return strArr[i];
                }
            }
        }
        
        return "true";
    }

    private static bool AreQueensAttacking((int x, int y) queen1, (int x, int y) queen2)
    {
        // Same row check
        if (queen1.x == queen2.x)
            return true;
        
        // Same column check
        if (queen1.y == queen2.y)
            return true;
        
        // Same diagonal check
        if (Math.Abs(queen1.x - queen2.x) == Math.Abs(queen1.y - queen2.y))
            return true;

        return false;
    }

    public static void Main()
    {
        Console.WriteLine(EightQueens(new string[] { "(2,1)", "(4,2)", "(6,3)", "(8,4)", "(3,5)", "(1,6)", "(7,7)", "(5,8)" })); // Output: true
        Console.WriteLine(EightQueens(new string[] { "(1,1)", "(2,2)", "(3,3)", "(4,4)", "(5,5)", "(6,6)", "(7,7)", "(8,8)" })); // Output: "(1,1)"
    }
}


















