/**
Question#1
 * Have the function shortestPath(strArr) take
 * strArr which will be an array of strings which models a non-looping Graph.
 * The structure of the array will be as follows: The first element in the array
 * will be the number of nodes N (points) in the array as a string. The next N
 * elements will be the nodes which can be anything (A, B, C .. Brick Street,
 * Main Street .. etc.). Then after the Nth element, the rest of the elements in
 * the array will be the connections between all of the nodes. They will look
 * like this: (A-B, B-C .. Brick Street-Main Street .. etc.). Although, there
 * may exist no connections at all.
 *
 * An example of strArr may be: ["4","A","B","C","D","A-B","B-D","B-C","C-D"].
 * Your program should return the shortest path from the first Node to the last
 * Node in the array separated by dashes. So in the example above the output
 * should be A-B-D. Here is another example with strArr being
 * ["7","A","B","C","D","E","F","G","A-B","A-E","B-C","C-D","D-F","E-D","F-G"].
 * The output for this array should be A-E-D-F-G. There will only ever be one
 * shortest path for the array. If no path between the first and last node
 * exists, return -1. The array will at minimum have two nodes. Also, the
 * connection A-B for example, means that A can get to B and B can get to A.
 */






















 .....................................
// Question#2

// Have the function ChessboardTraveling(str) read str which will be a string consisting of the location of a space on a standard 8x8 chess board with no pieces on the board along with another space on the chess board. The structure of str will be the following: "(x y)(a b)" where (x y) represents the position you are currently on with x and y ranging from 1 to 8 and (a b) represents some other space on the chess board with a and b also ranging from 1 to 8 where a > x and b > y. Your program should determine how many ways there are of traveling from (x y) on the board to (a b) moving only up and to the right. For example: if str is (1 1)(2 2) then your program should output 2 because there are only two possible ways to travel from space (1 1) on a chessboard to space (2 2) while making only moves up and to the right. 

// Hard challenges are worth 15 points and you are not timed for them.
// Sample Test Cases

// Input:"(1 1)(3 3)"

// Output:6


// Input:"(2 2)(4 3)"

// Output:3
















.........................................................

// Question#3
// Have the function KaprekarsConstant(num) take the num parameter being passed which will be a 4-digit number with at least two distinct digits. Your program should perform the following routine on the number: Arrange the digits in descending order and in ascending order (adding zeroes to fit it to a 4-digit number), and subtract the smaller number from the bigger number. Then repeat the previous step. Performing this routine will always cause you to reach a fixed number: 6174. Then performing the routine on 6174 will always give you 6174 (7641 - 1467 = 6174). Your program should return the number of times this routine must be performed until 6174 is reached. For example: if num is 3524 your program should return 3 because of the following steps: (1) 5432 - 2345 = 3087, (2) 8730 - 0378 = 8352, (3) 8532 - 2358 = 6174. 

// Hard challenges are worth 15 points and you are not timed for them.
// Sample Test Cases

// Input:2111

// Output:5


// Input:9831

// Output:7






















..............................................
// Question#4
// Have the function MaximalSquare(strArr) take the strArr parameter being passed which will be a 2D matrix of 0 and 1's, and determine the area of the largest square submatrix that contains all 1's. A square submatrix is one of equal width and height, and your program should return the area of the largest submatrix that contains only 1's. For example: if strArr is ["10100", "10111", "11111", "10010"] then this looks like the following matrix: 

// 1 0 1 0 0
// 1 0 1 1 1
// 1 1 1 1 1
// 1 0 0 1 0 

// For the input above, you can see the bolded 1's create the largest square submatrix of size 2x2, so your program should return the area which is 4. You can assume the input will not be empty. 

// Hard challenges are worth 15 points and you are not timed for them.

// Sample Test Cases

// Input:["0111", "1111", "1111", "1111"]

// Output:9

// Input:["0111", "1101", "0111"]

// Output:1






















...............................................................................
"""
Question#5
Using the C# language, have the function GasStation(strArr)
take strArr which will be an an array consisting of the following
elements:

N - the number of gas stations in a circular route
each subsequent element will be the string g:c
g - he amount of gas in gallons at that gas station
c - the amount of gallons of gas needed to get to the following gas station

For example strArr may be: ["4","3:1","2:2","1:2","0:1"].

Your goal is to return the index of the starting gas station
that will allow you to travel around the whole route once
otherwise return the string impossible.

For the example above, there are 4 gas stations, and your
program should return the string 1 because starting at station 1 you
receive 3 gallons of gas and spend 1 getting to the next station. Then
you have 2 gallons + 2 more at the next station and you spend 2 so you
have 2 gallons when you get to the 3rd station. You then have 3 but you
spend 2 getting to the final station, and at the final station you
receive 0 gallons and you spend your final gallon getting to your
starting point. Starting at any other gas station would make getting
around the route impossible, so the answer is 1. If there are multiple
gas stations that are possible to start at, return the smallest index
(of the gas station). N will be >= 2. 

Input:"4","1:1","2:2","1:2","0:1"
Output:"impossible"

Input:"4","0:1","2:2","1:2","3:1"
Output:"4"
"""
















 ..................................................................................
 /**
 Question#6
 * Have the function stepWalking(num) take the
 * num parameter being passed which will be an integer between 1 and 15 that
 * represents the number of stairs you will have to climb. You can climb the set
 * of stairs by taking either 1 step or 2 steps, and you can combine these in
 * any order. So for example, to climb 3 steps you can either do: (1 step, 1
 * step, 1 step) or (2, 1) or (1, 2). So for 3 steps we have 3 different ways to
 * climb them, so your program should return 3. Your program should return the
 * number of combinations of climbing num steps.

Input: 1
Output: 1

Input: 3
Output: 3
 */













.........................................................................
/**
Question#7
 * Have the function matchingCouples(arr) take
 * the arr parameter being passed which will be an array of integers in the
 * following format: [B, G, N] where B represents the number of boys, G
 * represents the number of girls, and N represents how many people you want to
 * pair together. Your program should return the number of different ways you
 * can match boys with girls given the different arguments. For example: if arr
 * is [5, 3, 2], N=2 here so you want to pair together 2 people, so you'll need
 * 1 boy and 1 girl. You have 5 ways to choose a boy and 3 ways to choose a
 * girl, so your program should return 15. Another example: if arr is [10, 5,
 * 4], here N=4 so you need 2 boys and 2 girls. We can choose 2 boys from a
 * possible 10, and we can choose 2 girls from a possible 5. Then we have 2
 * different ways to pair the chosen boys and girls. Our program should
 * therefore return 900
 *
 * N will always be an even number and it will never be greater than the maximum
 * of (B, G). B and G will always be greater than zero.
 
 */

 






.........................................................................
/**
Question#8
 * Have the function countingAnagrams(str) take the str parameter and determine
 * how many anagrams exist in the string. An anagram is a new word that is
 * produced from rearranging the characters in a different word, for example:
 * cars and arcs are anagrams. Your program should determine how many anagrams
 * exist in a given string and return the total number. For example: if str is
 * "cars are very cool so are arcs and my os" then your program should return 2
 * because "cars" and "arcs" form 1 anagram and "so" and "os" form a 2nd
 * anagram. The word "are" occurs twice in the string but it isn't an anagram
 * because it is the same word just repeated. The string will contain only
 * spaces and lowercase letters, no punctuation, numbers, or uppercase letters.
 *
 
 */











 ..........................................................
