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
/*
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

*/
















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

/* Question#9
Have the function PatternChaser(str)
take str which will be a string and return the longest pattern
within the string. A pattern for this challenge will be defined as:
if at least 2 or more adjacent characters within the string repeat
at least twice. So for example "aabecaa" contains the pattern aa,
on the other hand "abbbaac" doesn't contain any pattern. Your program
should return yes/no pattern/null. So if str were "aabejiabkfabed" the
output should be yes abe. If str were "123224" the output should return
no null. The string may either contain all characters (a through z only),
integers, or both. But the parameter will always be a string type.
The maximum length for the string being passed in will be 20 characters.
If a string for example is "aa2bbbaacbbb" the pattern is "bbb" and not "aa".
You must always return the longest pattern possible.

Input:"da2kr32a2"
Output:"yes a2"

Input:"sskfssbbb9bbb"
Output:"yes bbb"

*/

......................................................................................

/*
Question#10
Using the C# language, have the function WeightedPath(strArr) take strArr which
will be an array of strings which models a non-looping weighted Graph. The
structure of the array will be as follows: The first element in the array will
be the number of nodes N (points) in the array as a string. The next N elements
will be the nodes which can be anything (A, B, C .. Brick Street, Main Street ..
etc.). Then after the Nth element, the rest of the elements in the array will be
the connections between all of the nodes along with their weights (integers)
separated by the pipe symbol (|). They will look like this: (A|B|3, B|C|12 ..
Brick Street|Main Street|14 .. etc.). Although, there may exist no connections
at all.

An example of strArr may be:
["4","A","B","C","D","A|B|1","B|D|9","B|C|3","C|D|4"]. Your program should
return the shortest path when the weights are added up from node to node from
the first Node to the last Node in the array separated by dashes. So in the
example above the output should be A-B-C-D. Here is another example with strArr
being
["7","A","B","C","D","E","F","G","A|B|1","A|E|9","B|C|2","C|D|1","D|F|2","E|D|6","F|G|2"].
The output for this array should be A-B-C-D-F-G.
There will only ever be one shortest path for the array.
If no path between the first and last node exists, return -1.
The array will at minimum have two nodes.
Also, the connection A-B for example, means that A can get to B and B can get to
A. A path may not go through any Node more than once.

Sample test cases:

Input:  "4","A","B","C","D", "A|B|2", "C|B|11", "C|D|3", "B|D|2"
Output: "A-B-D"

Input:  "4","x","y","z","w","x|y|2","y|z|14", "z|y|31"
Output: "-1"

*/






.......................................................................................................

/*
Question#11
Have the function IntersectingLines(strArr) take strArr
which will be an array of 4 coordinates in the form: (x,y). Your program should
take these points where the first 2 form a line and the last 2 form a line, and
determine whether the lines intersect, and if they do, at what point. For
example: if strArr is ["(3,0)","(1,4)","(0,-3)","(2,3)"], then the line created
by (3,0) and (1,4) and the line created by (0,-3) (2,3) intersect at (9/5,12/5).
Your output should therefore be the 2 points in fraction form in the following
format: (9/5,12/5). If there is no denominator for the resulting points, then
the output should just be the integers like so: (12,3). If any of the resulting
points is negative, add the negative sign to the numerator like so:
(-491/63,-491/67). If there is no intersection, your output should return the
string "no intersection". The input points and the resulting points can be
positive or negative integers.

Sample test cases:

Input:  "(9,-2)","(-2,9)","(3,4)","(10,11)"
Output: "(3,4)"

Input:  "(1,2)","(3,4)","(-5,-6)","(-7,-8)"
Output: "no intersection"


*/






.......................................................................................................

/*
Question#12

Have the function PolynomialExpansion(str) take str
which will be a string representing a polynomial containing only (+/-) integers,
a letter, parenthesis, and the symbol "^", and return it in expanded form.
For example: if str is "(2x^2+4)(6x^3+3)", then the output should be
"12x^5+24x^3+6x^2+12". Both the input and output should contain no spaces. The
input will only contain one letter, such as "x", "y", "b", etc. There will only
be four parenthesis in the input and your output should contain no parenthesis.
The output should be returned with the highest exponential element first down to
the lowest.

More generally, the form of str will be:
([+/-]{num}[{letter}[{^}[+/-]{num}]]...[[+/-]{num}]...)(copy) where "[]"
represents optional features,
"{}" represents mandatory features, "num" represents integers and "letter"
represents letters such as "x".

Sample test cases:

Input:  "(1x)(2x^-2+1)"
Output: "x+2x^-1"

Input:  "(-1x^3)(3x^3+2)"
Output: "-3x^6-2x^3"



*/






.......................................................................................................

/*
Question#13

Using the C# language, have the function SwitchSort(arr) take arr which will be
an an array consisting of integers 1...size(arr) and determine what the fewest
number of steps is in order to sort the array from least to greatest using the
following technique: Each element E in the array can swap places with another
element that is arr[E] spaces to the left or right of the chosen element. You
can loop from one end of the array to the other. For example: if arr is the
array [1, 3, 4, 2] then you can choose the second element which is the number 3,
and if you count 3 places to the left you'll loop around the array and end up at
the number 4. Then you swap these elements and arr is then [1, 4, 3, 2]. From
here only one more step is required, you choose the last element which is the
number 2, count 2 places to the left and you'll reach the number 4, then you
swap these elements and you end up with a sorted array [1, 2, 3, 4]. Your
program should return an integer that specifies the least amount of steps needed
in order to sort the array using the following switch sort technique.

The array arr will at most contain five elements and will contain at least two
elements.

Sample test cases:

Input:  3,1,2
Output: 2

Input:  1,3,4,2
Output: 2



*/






.......................................................................................................

/*
Question#14
Using the C# language, have the function NoughtsDeterminer(strArr) take the
strArr parameter being passed which will be an array of size eleven. The array
will take the shape of a Tic-tac-toe board with spaces strArr[3] and strArr[7]
being the separators ("<>") between the rows, and the rest of the spaces will be
either "X", "O", or "-" which signifies an empty space. So for example strArr
may be ["X","O","-","<>","-","O","-","<>","O","X","-"]. This is a Tic-tac-toe
board with each row separated by double arrows ("<>"). Your program should
output the space in the array by which any player could win by putting down
either an "X" or "O". In the array above, the output should be 2 because if an
"O" is placed in strArr[2] then one of the players wins. Each board will only
have one solution for a win, not multiple wins. You output should never be 3 or
7 because those are the separator spaces.

Sample test cases:

Input:  "X","O","-","<>","-","O","-","<>","O","X","-"
Output: 2

Input:  "X","-","O","<>","-","-","O","<>","-","-","X"
Output: 5

Input:  "X","O","X","<>","-","O","O","<>","X","X","O"
Output: 4




*/






.......................................................................................................

/*
Question#15
Coderbyte coding challenge: Queen Check

Using the C# language, have the function QueenCheck(strArr) read strArr which
will be an array consisting of the locations of a Queen and King on a standard
8x8 chess board with no other pieces on the board. The structure of strArr will
be the following: ["(x1,y1)","(x2,y2)"] with (x1,y1) representing the position
of the queen and (x2,y2) representing the location of the king with x and y
ranging from 1 to 8. Your program should determine if the king is in check based
on the current positions of the pieces, and if so, return the number of spaces
it can move to in order to get out of check. If the king is not in check, return
-1. For example: if strArr is ["(4,4)","(6,6)"] then your program should
output 6. Remember, because only the queen and king are on the board, if the
queen is checking the king by being directly adjacent to it, technically the
king can capture the queen.

Sample test cases:

Input:  "(1,1)","(1,4)"
Output: "3"

Input:  "(3,1)","(4,4)"
Output: "-1"





*/






.......................................................................................................

/*
Question#16

Coderbyte coding challenge: Matrix Determinant

Using the C# language, have the function MatrixDeterminant(strArr) read strArr
which will be an array of integers represented as strings. Within the array
there will also be "<>" elements which represent break points. The array will
make up a matrix where the (number of break points + 1) represents the number of
rows. Here is an example of how strArr may look: ["1","2","<>","3","4"]. The
contents of this array are row1=[1 2] and row2=[3 4]. Your program should take
the given array of elements, create the proper matrix, and then calculate the
determinant. For the example above, your program should return -2. If the matrix
is not a square matrix, return -1. The maximum size of strArr will be a 6x6
matrix. The determinant will always be an integer.

Sample test cases:

Input:  "5","0","<>","0","5"
Output: 25

Input:  "1","2","4","<>","2","1","1","<>","4","1","1"
Output: -4





*/






.......................................................................................................

/*
Question#17
Coderbyte coding challenge: Connect Four Winner

Using the C# language, have the function ConnectFourWinner(strArr) read the
strArr parameter being passed which will represent a 6x7 Connect Four board. The
rules of the game are: two players alternate turns and place a colored disc down
into the grid from the top and the disc falls down the column until it hits the
bottom or until it hits a piece beneath it. The object of the game is to connect
four of one's own discs of the same color next to each other vertically,
horizontally, or diagonally before your opponent. The input strArr will
represent a Connect Four board and it will be structured in the following
format: ["R/Y","(R,Y,x,x,x,x,x)","(...)","(...)",...)] where R represents the
player using red discs, Y represents the player using yellow discs and x
represents an empty space on the board. The first element of strArr will be
either R or Y and it represents whose turn it is. Your program should determine,
based on whose turn it is, whether a space exists that can give that player a
win. If a space does exist your program should return the space in the following
format: (RxC) where R=row and C=column. If no space exists, return the string
none. The board will always be in a legal setup.

For example, if strArr is:
["R","(x,x,x,x,x,x,x)","(x,x,x,x,x,x,x)","(x,x,x,x,x,x,x)","(x,x,x,R,x,x,x)","(x,x,x,R,x,x,x)","(x,x,x,R,Y,Y,Y)"]
then your program should return (3x4).

Another example, if strArr is:
["Y","(x,x,x,x,x,x,x)","(x,x,x,x,x,x,x)","(x,x,x,x,x,x,x)","(x,x,Y,Y,x,x,x)","(x,R,R,Y,Y,x,R)","(x,Y,R,R,R,Y,R)"]
then your program should return (3x3).





*/






.......................................................................................................

/*
Question#18
Coderbyte coding challenge: Square Figures

Using the C# language, have the function SquareFigures(num) read num which will
be an integer. Your program should return the smallest integer that when squared
has a length equal to num. For example: if num is 6 then your program should
output 317 because 317^2 = 100489 while 316^2 = 99856 which does not have a
length of six.

Sample test cases:

Input:  2
Output: 4

Input:  1
Output: 0





*/






.......................................................................................................

/*
Question#19
Coderbyte coding challenge: Quick Knight

Using the C# language, have the function QuickKnight(str) read str which will
be a string consisting of the location of a knight on a standard 8x8 chess board
with no other pieces on the board and another space on the chess board. The
structure of str will be the following: "(x y)(a b)" where (x y) represents the
position of the knight with x and y ranging from 1 to 8 and (a b) represents
some other space on the chess board with a and b also ranging from 1 to 8. Your
program should determine the least amount of moves it would take the knight to
go from its position to position (a b). For example if str is "(2 3)(7 5)" then
your program should output 3 because that is the least amount of moves it would
take for the knight to get from (2 3) to (7 5) on the chess board.

Sample test cases:

Input:  "(1 1)(8 8)"
Output: 6

Input:  "(2 2)(3 3)"
Output: 2




*/






.......................................................................................................

/*
Question#20
Coderbyte coding challenge: Sudoku Quadrant Checker

Using the C# language, have the function SudokuQuadrantChecker(strArr) read the
strArr parameter being passed which will represent a 9x9 Sudoku board of
integers ranging from 1 to 9. The rules of Sudoku are to place each of the 9
integers integer in every row and column and not have any integers repeat in the
respective row, column, or 3x3 sub-grid. The input strArr will represent a
Sudoku board and it will be structured in the following format:
["(N,N,N,N,N,x,x,x,x)","(...)","(...)",...)] where N stands for an integer
between 1 and 9 and x will stand for an empty cell. Your program will determine
if the board is legal; the board also does not necessarily have to be finished.
If the board is legal, your program should return the string legal but if it
isn't legal, it should return the 3x3 quadrants (separated by commas) where the
errors exist. The 3x3 quadrants are numbered from 1 to 9 starting from top-left
going to bottom-right.

For example, if strArr is:
["(1,2,3,4,5,6,7,8,1)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(1,x,x,x,x,x,x,x,x)",
"(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)"]
then your program should return 1,3,4 since the errors are in quadrants 1, 3 and
4 because of the repeating integer 1.

Another example, if strArr is:
["(1,2,3,4,5,6,7,8,9)","(x,x,x,x,x,x,x,x,x)","(6,x,5,x,3,x,x,4,x)","(2,x,1,1,x,x,x,x,x)",
"(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,9)"]
then your program should return 3,4,5,9.




*/






.......................................................................................................

/*
Question#21
Coderbyte coding challenge: Line Ordering

Using the C# language, have the function LineOrdering(strArr) read the strArr
parameter being passed which will represent the relations among people standing
in a line. The structure of the input will be ["A>B","B>C","A<D",etc..]. The
letters stand for different people and the greater than and less than signs
stand for a person being in front of someone or behind someone. A>B means A is
in front of B and B<C means that B is behind C in line. For example if strArr
is: ["J>B","B<S","D>J"], these are the following ways you can arrange the people
in line: DSJB, SDJB and DJSB. Your program will determine the number of ways
people can be arranged in line. So for this example your program should return
the number 3. It also may be the case that the relations produce an impossible
line ordering, resulting in zero as the answer.

Only the symbols <, >, and the uppercase letters A...Z will be used. The maximum
number of relations strArr will contain is ten.

Sample test cases:

Input:  "A>B","A<C","C<Z"
Output: 1

Input:  "A>B","B<R","R<G"
Output: 3





*/






.......................................................................................................

/*
Question#22
Coderbyte coding challenge: Line Ordering

Using the C# language, have the function LineOrdering(strArr) read the strArr
parameter being passed which will represent the relations among people standing
in a line. The structure of the input will be ["A>B","B>C","A<D",etc..]. The
letters stand for different people and the greater than and less than signs
stand for a person being in front of someone or behind someone. A>B means A is
in front of B and B<C means that B is behind C in line. For example if strArr
is: ["J>B","B<S","D>J"], these are the following ways you can arrange the people
in line: DSJB, SDJB and DJSB. Your program will determine the number of ways
people can be arranged in line. So for this example your program should return
the number 3. It also may be the case that the relations produce an impossible
line ordering, resulting in zero as the answer.

Only the symbols <, >, and the uppercase letters A...Z will be used. The maximum
number of relations strArr will contain is ten.

Sample test cases:

Input:  "A>B","A<C","C<Z"
Output: 1

Input:  "A>B","B<R","R<G"
Output: 3





*/






.......................................................................................................

/*
Question#23
Coderbyte coding challenge: Knight Jumps

Using the C# language, have the function KnightJumps(str) read str which will
be a string consisting of the location of a knight on a standard 8x8 chess board
with no other pieces on the board. The structure of str will be the following:
"(x y)" which represents the position of the knight with x and y ranging from 1
to 8. Your program should determine the number of spaces the knight can move to
from a given location. For example: if str is "(4 5)" then your program should
output 8 because the knight can move to 8 different spaces from position x=4 and
y=5.

Sample test cases:

Input:  "(1 1)"
Output: 2

Input:  "(2 8)"
Output: 3





*/






.......................................................................................................

/*
Question#24
Coderbyte coding challenge: Alphabet Run Encryption

Using the C# language, have the function AlphabetRunEncryption(str) read the
str parameter being passed which will be an encrypted string and your program
should output the original decrypted string. The encryption being used is the
following: For every character i in str up to the second to last character, take
the i and i+1 characters and encode them by writing the letters of the alphabet,
in order, that range in the same direction between those chosen characters. For
example: if the original string were bo then it would be encoded as
cdefghijklmn, but if the string were boa then bo is encoded as cdefghijklmn and
oa is encoded as nmlkjihgfedcb with the final encrypted string being
cdefghijklmnnmlkjihgfedcb. So str may be something like the encrypted string
just written, and your program should decrypt it and output the original
message.

The input string will only contain lowercase characters (a...z).
There are also three important rules to this encryption based on specific
character sequences.

1) If the original string contains only one letter between two chosen
characters, as the string ac then this would be encrypted as bR with R standing
for what direction in the alphabet to go in determining the original characters.
The encrypted string bR represents ac but the encrypted string bL represents ca
(R = right, L = left).

2) If the original string contains zero letters between two chosen characters,
such as the string ab then this would be encrypted as abS, with S representing
the fact that no decryption is needed on the two letters preceding S. For
example, if the original string were aba then the encryption would be abSbaS,
but be careful because decrypting this you get abba, but the actual original
string is aba.

3) If the original string contains a repeat of letters, such as the string acc
then this would be encrypted as bRcN, with N representing the fact that no
change in characters occurred on the character preceding N. The input string
will never only be composed of repeated characters.

Sample test cases:

Input:  "bcdefghijklmnopqrstN"
Output: "att"

Input:  "abSbaSaNbR"
Output: "abaac"





*/






.......................................................................................................

/*
Question#25
Coderbyte coding challenge: Transitivity Relations

Using the C# language, have the function TransitivityRelations(strArr) read the
strArr parameter being passed which will make up an NxN matrix where the rows
are separated by each pair of parentheses (the matrix will range from 2x2 to
5x5). The matrix represents connections between nodes in a graph where each node
corresponds to the Nth element in the matrix (with 0 being the first node). If a
connection exists from one node to another, it will be represented by a 1, if
not it will be represented by a 0. For example: suppose strArr were a 3x3 matrix
with input ["(1,1,1)","(1,0,0)","(0,1,0)"], this means that there is a
connection from node 0->0, 0->1, and 0->2. For node 1 the connections are 1->0,
and for node 2 the connections are 2->1. This can be interpreted as a connection
existing from node X to node Y if there is a 1 in the Xth row and Yth column.
Note: a connection from X->Y does not imply a connection from Y->X.

What your program should determine is whether or not the matrix, which
represents connections among the nodes, is transitive. A transitive relation
means that if the connections 0->1 and 1->2 exist for example, then there must
exist the connection 0->2. More generally, if there is a relation xRy and yRz,
then xRz should exist within the matrix. If a matrix is completely transitive,
return the string transitive. If it isn't, your program should return the
connections needed, in the following format, in order for the matrix to be
transitive: (N1,N2)-(N3,N4)-(...). So for the example above, your program should
return (1,2)-(2,0). You can ignore the reflexive property of nodes in your
answers. Return the connections needed in lexicographical order [e.g.
(0,1)-(0,4)-(1,4)-(2,3)-(4,1)].

Sample test cases:

Input:  "(1,1,1)","(0,1,1)","(0,1,1)"
Output: "transitive"

Input:  "(0,1,0,0)","(0,0,1,0)","(0,0,1,1)","(0,0,0,1)"
Output: "(0,2)-(0,3)-(1,3)"





*/






.......................................................................................................

/*
Question#27
Coderbyte coding challenge: Blackjack Highest

Using the C# language, have the function BlackjackHighest(strArr) take the
strArr parameter being passed which will be an array of numbers and letters
representing blackjack cards. Numbers in the array will be written out. So for
example strArr may be ["two","three","ace","king"]. The full list of
possibilities for strArr is: two, three, four, five, six, seven, eight, nine,
ten, jack, queen, king, ace. Your program should output below, above, or
blackjack signifying if you have blackjack (numbers add up to 21) or not and the
highest card in your hand in relation to whether or not you have blackjack. If
the array contains an ace but your hand will go above 21, you must count the ace
as a 1. You must always try and stay below the 21 mark. So using the array
mentioned above, the output should be below king. The ace is counted as a 1 in
this example because if it wasn't you would be above the 21 mark. Another
example would be if strArr was ["four","ten","king"], the output here should be
above king. If you have a tie between a ten and a face card in your hand, return
the face card as the "highest card". If you have multiple face cards, the order
of importance is jack, queen, then king.

Sample test cases:

Input:  "four","ace","ten"
Output: "below ten"

Input:  "ace","queen"
Output: "blackjack ace"





*/






.......................................................................................................

/*
Question#28
Coderbyte coding challenge: Farthest Nodes

Using the C# language, have the function FarthestNodes(strArr) read strArr
which will be an array of hyphenated letters representing paths between those
two nodes. For example: ["a-b","b-c","b-d"] means that there is a path from node
a to b (and b to a), b to c, and b to d. Your program should determine the
longest path that exists in the graph and return the length of that path. So for
the example above, your program should return 2 because of the paths a-b-c and
d-b-c. The path a-b-c also means that there is a path c-b-a. No cycles will
exist in the graph and every node will be connected to some other node in the
graph.

Sample test cases:

Input:  a-b","b-c","b-d"
Output: 2

Input:  "b-e","b-c","c-d","a-b","e-f"
Output: 4

Input:  "b-a","c-e","b-c","d-c"
Output: 3





*/






.......................................................................................................

/*
Question#29
Coderbyte coding challenge: Nim Winner

Using the C# language, have the function NimWinner(arr) take the array of
integers stored in arr which will represent the amount of coins in each pile.
For example: [2, 4, 1, 3] means there are 4 piles of coins and there are 2 coins
in the first pile, 4 in the second pile, etc. Nim is played by each player
removing any number of coins from only one pile, and the winner is the player
who picks up the last coin. For example: if arr is [1, 2, 3] then for example
player 1 can remove 2 coins from the last pile which results in [1, 2, 1]. Then
player 2 can remove 1 coin from the first pile which results in [0, 2, 1], etc.
The player that has the last possible move taking the last coin(s) from a pile
wins the game. Your program should output either 1 or 2 which represents which
player has a guaranteed win with perfect play for the Nim game.

Sample test cases:

Input:  1,2,3
Output: 2

Input:  1,1,1,4,5,4
Output: 1





*/






.......................................................................................................

/*
Question#30
Coderbyte coding challenge: LCS

Using the C# language, have the function LCS(strArr) take the strArr parameter
being passed which will be an array of two strings containing only the
characters {a,b,c} and have your program return the length of the longest common
subsequence common to both strings. A common subsequence for two strings does
not require each character to occupy consecutive positions within the original
strings. For example: if strArr is ["abcabb","bacb"] then your program should
return 3 because one longest common subsequence for these two strings is "bab"
and there are also other 3-length subsequences such as "acb" and "bcb" but 3 is
the longest common subsequence for these two strings.

Sample test cases:

Input:  "abc","cb"
Output: 1

Input:  "bcacb","aacabb"
Output: 3





*/






.......................................................................................................

/*
Question#31
Using the C# language, have the function ParallelSums(arr) take the array of
integers stored in arr which will always contain an even amount of integers, and
determine how they can be split into two even sets of integers each so that both
sets add up to the same number. If this is impossible return -1. If it's
possible to split the array into two sets, then return a string representation
of the first set followed by the second set with each integer separated by a
comma and both sets sorted in ascending order. The set that goes first is the
set with the smallest first integer.

For example: if arr is [16, 22, 35, 8, 20, 1, 21, 11], then your program should
output 1,11,20,35,8,16,21,22

Sample test cases:

Input:  1,2,3,4
Output: "1,4,2,3"

Input:  1,2,1,5
Output: "-1"





*/






.......................................................................................................

/*
Question#32
Coderbyte coding challenge: Roman Numeral Reduction

Using the C# language, have the function RomanNumeralReduction(str) read str
which will be a string of roman numerals in decreasing order. The numerals being
used are: I for 1, V for 5, X for 10, L for 50, C for 100, D for 500 and M for
1000. Your program should return the same number given by str using a smaller
set of roman numerals. For example: if str is "LLLXXXVVVV" this is 200, so your
program should return CC because this is the shortest way to write 200 using the
roman numeral system given above. If a string is given in its shortest form,
just return that same string.

Sample test cases:

Input:  "XXXVVIIIIIIIIII"
Output: "L"

Input:  "DDLL"
Output: "MC"





*/






.......................................................................................................

/*
Question#





*/






.......................................................................................................

/*
Question#33
Using the C# language, have the function MatrixBorder(strArr) read the strArr
parameter being passed which will represent an NxN matrix filled with 1's and
0's. Your program should determine the number of swaps between two rows or two
columns that must be made to change the matrix such that the border of the
matrix contains all 1's and the inside contains 0's. The format of strArr will
be: ["(n,n,n...)","(...)",...] where n represents either a 1 or 0. The smallest
matrix will be a 3x3 and the largest will be a 6x6 matrix.

For example: if strArr is: ["(0,1,1)","(1,1,1)","(1,1,1)"] then you can swap the
first two columns and then swap the first two rows to create a matrix with the
1's on the border and the 0 on the inside, therefore your program should
output 2.

Sample test cases:

Input:  "(0,1,1)","(1,1,1)","(1,1,1)"
Output: 2

Input:  "(0,1,0,1)","(1,1,1,1)","(0,1,0,1)","(1,1,1,1)"
Output: 2





*/






.......................................................................................................

/*
Question#34
Using the C# language, have the function ArrayJumping(arr) take the array of
numbers stored in arr and first determine the largest element in the array, and
then determine whether or not you can reach that same element within the array
by moving left or right continuously according to whatever integer is in the
current spot. If you can reach the same spot within the array, then your program
should output the least amount of jumps it took. For example: if the input is
[2, 3, 5, 6, 1] you'll start at the spot where 6 is and if you jump 6 spaces to
the right while looping around the array you end up at the last element where
the 1 is. Then from here you jump 1 space to the left and you're back where you
started, so your program should output 2. If it's impossible to end up back at
the largest element in the array your program should output -1. The largest
element in the array will never equal the number of elements in the array. The
largest element will be unique.

Sample test cases:

Input:  1,2,3,4,2
Output: 3

Input:  1,7,1,1,1,1
Output: 2





*/






.......................................................................................................

/*
Question#35
Using the C# language, have the function MaxHeapChecker(arr) take arr
which represents a heap data structure and determine whether or not it is a max
heap. A max heap has the property that all nodes in the heap are either greater
than or equal to each of its children. For example: if arr is [100,19,36,17]
then this is a max heap and your program should return the string max. If the
input is not a max heap then your program should return a list of nodes in
string format, in the order that they appear in the tree, that currently do not
satisfy the max heap property because the child nodes are larger than their
parent. For example: if arr is [10,19,52,13,16] then your program should return
19,52.

Another example: if arr is [10,19,52,104,14] then your program should return
19,52,104

Sample test cases:

Input:  73,74,75,7,2,107
Output: 74,75,107

Input:  1,5,10,2,3,10,1
Output: 5,10





*/






.......................................................................................................



/*
Question#36
Coderbyte coding challenge: Reverse Polish Notation

Using the C# language, have the function ReversePolishNotation(str) read str
which will be an arithmetic expression composed of only integers and the
operators:
+,-,* and / and the input expression will be in postfix notation (Reverse Polish
notation), an example: (1 + 2) * 3 would be 1 2 + 3 * in postfix notation. Your
program should determine the answer for the given postfix expression. For
example: if str is 2 12 + 7 / then your program should output 2.

Sample test cases:

Input:  "1 1 + 1 + 1 +"
Output: 4

Input:  "4 5 + 2 1 + *"
Output: 27





*/






.......................................................................................................



/*
Question#37

Using the C# language, have the function PascalsTriangle(arr) take arr which
will be a partial row from Pascal's triangle. Pascal's triangle starts with a
[1] at the first row of the triangle. Then the second row is [1,1] and the third
row is [1,2,1]. The next row begins with 1 and ends with 1, and the inside of
the row is determined by adding the k-1 and kth elements from the previous row.
The next row in the triangle would then be [1,3,3,1], and so on.
The input, arr will be some almost completed row from the triangle, for example
[1,4,6,4] and your program should return the next element in that row. In this
example your program should return 1. Another example: if arr is [1,5,10] your
program should return 10. If the whole row is entered as input and there is no
next number, your program should return -1. The input array will contain at
least 2 elements and array inputs such as [1] and [1,1] will not occur as
inputs.

Sample test cases:

Input:  1,3
Output: 3

Input:  1,5,10,10
Output: 5




*/






.......................................................................................................



/*
Question#38
Coderbyte coding challenge: Step Walking

Using the C# language, have the function StepWalking(num) take the num
parameter being passed which will be an integer between 1 and 15 that represents
the number of stairs you will have to climb. You can climb the set of stairs by
taking either 1 step or 2 steps, and you can combine these in any order. So for
example, to climb 3 steps you can either do: (1 step, 1 step, 1 step) or (2, 1)
or (1, 2). So for 3 steps we have 3 different ways to climb them, so your
program should return 3. Your program should return the number of combinations
of climbing num steps.

Sample test cases:

Input:  1
Output: 1

Input:  3
Output: 3





*/






.......................................................................................................



/*
Question#39
Using the C# language, have the function VertexCovering(strArr) take strArr
which will be an array of length three. The first part of the array will be a
list of vertices in a graph in the form (A,B,C,...), the second part of the
array will be the edges connecting the vertices in the form (A-B,C-D,...) where
each edge is bidirectional. The last part of the array will be a set of vertices
in the form (X,Y,Z,...) and your program will have to determine whether or not
the set of vertices given covers every edge in the graph such that every edge is
incident to at least one vertex in the set.

For example: if strArr is ["(A,B,C,D)","(A-B,A-D,B-D,A-C)","(A,B)"] then the
vertices (A,B) are in fact one of the endpoints of every edge in the graph, so
every edge has been accounted for. Therefore your program should return the
string yes. But, if for example the last part of the array was (C,B) then these
vertices don't cover all the edges because the edge connecting A-D is left out.
If this is the case your program should return the edges given in the second
part of the array that are left out in the same order they were listed, so for
this example your program should return (A-D).

The graph will have at least 2 vertices and all the vertices in the graph will
be connected. The third part of the array listing the vertices may be empty,
where it would only contain the parenthesis with no values within it: "()"

Sample test cases:

Input:  "(A,B,C,D)","(A-B,A-D,B-D,A-C)","(C)"
Output: "(A-B,A-D,B-D)"

Input:  "(X,Y,Z,Q)","(X-Y,Y-Q,Y-Z)","(Z,Y,Q)"
Output: "yes"





*/






.......................................................................................................



/*
Question#40
Coderbyte coding challenge: Hamiltonian Path

Using the C# language, have the function HamiltonianPath(strArr) take strArr
which will be an array of length three. The first part of the array will be a
list of vertices in a graph in the form (A,B,C,...), the second part of the
array will be the edges connecting the vertices in the form (A-B,C-D,...) where
each edge is bidirectional. The last part of the array will be a set of vertices
in the form (X,Y,Z,...) and your program will have to determine whether or not
the set of vertices given forms a Hamiltonian path on the graph which means that
every vertex in the graph is visited only once in the order given.

For example: if strArr is ["(A,B,C,D)","(A-B,A-D,B-D,A-C)","(C,A,D,B)"] then the
vertices (C,A,D,B) in this order do in fact form a Hamiltonian path on the graph
so your program should return the string yes. If for example the last part of
the array was (D,A,B,C) then this doesn't form a Hamiltonian path because once
you get to B you can't get to C in the graph without passing through the visited
vertices again. Here your program should return the vertex where the path had to
terminate, in this case your program should return B.

The graph will have at least 2 vertices and all the vertices in the graph will
be connected.

Sample test cases:

Input:  "(A,B,C,D)","(A-B,A-D,B-D,A-C)","(C,A,D,B)"
Output: "yes"

Input:  "(A,B,C)","(B-A,C-B)","(C,B,A)"
Output: "yes"

Input:  "(X,Y,Z,Q)","(X-Y,Y-Q,Y-Z)","(Z,Y,Q,X)"
Output: "Q"





*/






.......................................................................................................



/*
Question#41
Coderbyte coding challenge: Optimal Assignments

Using the C# language, have the function OptimalAssignments(strArr) read strArr
which will represent an NxN matrix and it will be in the following format:
["(n,n,n...)","(...)",...] where the n's represent integers. This matrix
represents a machine at row i performing task at column j. The cost for this is
matrix[i][j]. Your program should determine what machine should perform what
task so as to minimize the whole cost and it should return the pairings of
machines to tasks in the following format: (i-j)(...)... Only one machine can
perform one task. For example: if strArr is ["(5,4,2)","(12,4,3)","(3,4,13)"]
then your program should return (1-3)(2-2)(3-1) because assigning the machines
to these tasks gives the least cost. The matrix will range from 2x2 to 6x6,
there will be no negative costs in the matrix, and there will always be a unique
answer.

Sample test cases:

Input:  "(1,2,1)","(4,1,5)","(5,2,1)"
Output: "(1-1)(2-2)(3-3)"

Input:  "(13,4,7,6)","(1,11,5,4)","(6,7,2,8)","(1,3,5,9)"
Output: "(1-2)(2-4)(3-3)(4-1)"





*/






.......................................................................................................



/*
Question#42
Using the C# language, have the function Wildcards(str) read str which will
contain two strings separated by a space. The first string will consist of the
following sets of characters: +, *, $, and {N} which is optional. The plus (+)
character represents a single alphabetic character, the ($) character represents
a number between 1-9, and the asterisk (*) represents a sequence of the same
character of length 3 unless it is followed by {N} which represents how many
characters should appear in the sequence where N will be at least 1. Your goal
is to determine if the second string exactly matches the pattern of the first
string in the input.

For example: if str is "++*{5} jtggggg" then the second string in this case does
match the pattern, so your program should return the string true. If the second
string does not match the pattern your program should return the string false.

Hard challenges are worth 15 points and you are not timed for them.

Sample test cases:

Input:  "+++++* abcdehhhhhh"
Output: "false"

Input:  "$**+*{2} 9mmmrrrkbb"
Output: "true"





*/






.......................................................................................................



/*
Question#43
Coderbyte coding challenge: Tetris Move

Using the C# language, have the function TetrisMove(strArr) take strArr
parameter being passed which will be an array containing one letter followed by
12 numbers representing a Tetris piece followed by the fill levels for the 12
columns of the board. Calculate the greatest number of horizontal lines that can
be completed when the piece arrives at the bottom assuming it is dropped
immediately after being rotated and moved horizontally from the top.
Tricky combinations of vertical and horizontal movements are excluded. The piece
types are represented by capital letters.

For example, with an input of
["L","3","4","4","5","6","2","0","6","5","3","6","6"], the board will look
something like this:

|            |
|            |
|            |
|    #  #  ##|
|   ##  ## ##|
| ####  ## ##|
|#####  #####|
|###### #####|
|###### #####|

Your result should be 3 because the L piece can be rotated and dropped in column
6-7 which will complete 3 full rows of blocks.

Sample test cases:

Input:  "I", "2", "4", "3", "4", "5", "2", "0", "2", "2", "3", "3", "3"
Output: 2

Input:  "O", "4", "3", "2", "3", "5", "1", "0", "1", "2", "4", "3", "4"
Output: 0





*/






.......................................................................................................



/*
Question#44
Coderbyte coding challenge: Wildcard Characters

Using the C# language, have the function WildcardCharacters(str) read str which
will contain two strings separated by a space. The first string will consist of
the following sets of characters: +, *, and {N} which is optional. The plus (+)
character represents a single alphabetic character, the asterisk (*) represents
a sequence of the same character of length 3 unless it is followed by {N} which
represents how many characters should appear in the sequence where N will be at
least 1. Your goal is to determine if the second string exactly matches the
pattern of the first string in the input.

For example: if str is "++*{5} gheeeee" then the second string in this case does
match the pattern, so your program should return the string true. If the second
string does not match the pattern your program should return the string false.

Sample Test Cases

Input:  "+++++* abcdemmmmmm"
Output: "false"

Input:  "**+*{2} mmmrrrkbb"
Output: "true"





*/






.......................................................................................................



/*
Question#45
Coderbyte coding challenge: Convex Hull Points

Using the C# language, have the function ConvexHullPoints(strArr) take strArr
which will be an array of integer coordinates that exist on a Cartesian plane in
the form: (x,y). Your program should return the minimum number of points that
are needed to form a convex hull around all the points. For example: if the
input is ["(2,2)", "(3,1)", "(2,6)", "(0,-2)"] then your program should return 3
because only 3 points are needed to create a convex hull that encloses all the
points. The input array will always contain at least 3 points.

Sample test cases:

Input:  "(2,2)", "(3,1)", "(2,6)", "(0,1)", "(2,3)", "(5,2)"
Output: 4

Input:  "(0,1)", "(3,6)", "(2,2)", "(0,7)"
Output: 4





*/






.......................................................................................................



/*
Question#46
Coderbyte coding challenge: City Traffic
Using the C# language, have the function CityTraffic(strArr) read strArr which
will be a representation of an undirected graph in a form similar to an
adjacency list. Each element in the input will contain an integer which will
represent the population for that city, and then that will be followed by a
comma separated list of its neighboring cities and their populations (these will
be separated by a colon). For example: strArr may be ["1:[5]", "4:[5]", "3:[5]",
"5:[1,4,3,2]", "2:[5,15,7]", "7:[2,8]", "8:[7,38]", "15:[2]", "38:[8]"]. This
graph then looks like the following picture:
         38
         /
        8
       /
      7
     /
1   2
 \ / \
  5  15
 / \
4   3
Each node represents the population of that city and each edge represents a road
to that city. Your goal is to determine the maximum traffic that would occur via
a single road if everyone decided to go to that city. For example: if every
single person in all the cities decided to go to city 7, then via the upper road
the number of people coming in would be (8 + 38) = 46. If all the cities beneath
city 7 decided to go to it via the lower road, the number of people coming in
would be (2 + 15 + 1 + 3 + 4 + 5) = 30. So the maximum traffic coming into the
city 7 would be 46 because the maximum value of (30, 46) = 46.
Your program should determine the maximum traffic for every single city and
return the answers in a comma separated string in the format:
city:max_traffic,city:max_traffic,... The cities should be outputted in sorted
order by the city number. For the above example, the output would therefore be:
1:82,2:53,3:80,4:79,5:70,7:46,8:38,15:68,38:45. The cities will all be unique
positive integers and there will not be any cycles in the graph. There will
always be at least 2 cities in the graph.
Sample test cases:
Input:  "1:[5]", "2:[5]", "3:[5]", "4:[5]", "5:[1,2,3,4]"
Output: "1:14,2:13,3:12,4:11,5:4"
Input:  "1:[5]", "2:[5,18]", "3:[5,12]", "4:[5]", "5:[1,2,3,4]", "18:[2]",
"12:[3]" Output: "1:44,2:25,3:30,4:41,5:20,12:33,18:27"





*/






.......................................................................................................



/*
Question#48
Coderbyte coding challenge: Pentagonal Number

Using the C# language, have the function PentagonalNumber(num) read num which
will be a positive integer and determine how many dots exist in a pentagonal
shape around a center dot on the Nth iteration. For example, in the image below
you can see that on the first iteration there is only a single dot, on the
second iteration there are 6 dots, on the third there are 16 dots, and on the
fourth there are 31 dots.

Your program should return the number of dots that exist in the whole pentagon
on the Nth iteration.

Sample test cases:

Input:  2
Output: 6

Input:  5
Output: 51






*/






.......................................................................................................



/*
Question#49
Coderbyte coding challenge: Bipartite Matching

Using the C# language, have the function BipartiteMatching(strArr) read strArr
which will be an array of hyphenated letters representing paths from the first
node to the second node. For example: ["a->d", "a->e", "b->f", "c->e"] means
that there is a path from node a to d, a to e, b to f, and so on. The graph will
be bipartite meaning that it is possible to separate the nodes into two disjoint
sets such that every edge only connects a node from the lefthand side to a node
on the righthand side. Your program should determine the maximum cardinality
matching of the bipartite graph, which means finding the largest possible number
of non-adjacent edges that are matching. So for the example above, your program
should return 3 because it is possible to connect every single node on the left
to a node on the right.

The input will only contain lowercase alphabetic characters with a -> between
them signifying an edge between them going from the left node to the right node.
The input will contain at least 1 edge connecting 2 nodes.

Sample test cases:

Input:  "a->w", "a->x", "b->x", "b->y", "c->x", "c->z", "d->w"
Output: 4

Input:  "a->b", "c->b", "c->d", "e->b"
Output: 2






*/






.......................................................................................................



/*
Question#50
Coderbyte coding challenge: Maximal Rectangle

Using the C# language, have the function MaximalRectangle(strArr) take the
strArr parameter being passed which will be a 2D matrix of 0 and 1's, and
determine the area of the largest rectangular submatrix that contains all 1's.
For example: if strArr is ["10100", "10111", "11111", "10010"] then this looks
like the following matrix:

1 0 1 0 0
1 0 1 1 1
1 1 1 1 1
1 0 0 1 0

For the input above, you can see the bolded 1's create the largest rectangular
submatrix of size 2x3, so your program should return the area which is 6. You
can assume the input will not be empty.

Sample test cases:

Input:  "1011", "0011", "0111", "1111"
Output: 8

Input:  "101", "111", "001"
Output: 3






*/






.......................................................................................................



/*
Question#51
Coderbyte coding challenge: Maximal Square

Using the C# language, have the function MaximalSquare(strArr) take the strArr
parameter being passed which will be a 2D matrix of 0 and 1's, and determine the
area of the largest square submatrix that contains all 1's. A square submatrix
is one of equal width and height, and your program should return the area of the
largest submatrix that contains only 1's. For example: if strArr is ["10100",
"10111", "11111", "10010"] then this looks like the following matrix:

1 0 1 0 0
1 0 1 1 1
1 1 1 1 1
1 0 0 1 0

For the input above, you can see the bolded 1's create the largest square
submatrix of size 2x2, so your program should return the area which is 4. You
can assume the input will not be empty.

Sample test cases:

Input:  "0111", "1111", "1111", "1111"
Output: 9

Input:  "0111", "1101", "0111"
Output: 1






*/






.......................................................................................................



/*
Question#52
Coderbyte coding challenge: Array Rotation

Using the C# language, have the function ArrayRotation(arr) take the arr
parameter being passed which will be an array of non-negative integers and
circularly rotate the array starting from the Nth element where N is equal to
the first integer in the array. For example: if arr is [2, 3, 4, 1, 6, 10] then
your program should rotate the array starting from the 2nd position because the
first element in the array is 2. The final array will therefore be [4, 1, 6, 10,
2, 3], and your program should return the new array as a string, so for this
example your program would return 4161023. The first element in the array will
always be an integer greater than or equal to 0 and less than the size of the
array.

Sample test cases:

Input:  2,3,4,1,6,10
Output: "4161023"

Input:  3,2,1,6
Output: "6321"

Input:  4,3,4,3,1,2
Output: "124343"






*/






.......................................................................................................



/*
Question#53
Coderbyte coding challenge: Array Couples

Using the C# language, have the function ArrayCouples(arr) take the arr
parameter being passed which will be an array of an even number of positive
integers, and determine if each pair of integers, [k, k+1], [k+2, k+3], etc. in
the array has a corresponding reversed pair somewhere else in the array. For
example: if arr is [4, 5, 1, 4, 5, 4, 4, 1] then your program should output the
string yes because the first pair 4, 5 has the reversed pair 5, 4 in the array,
and the next pair, 1, 4 has the reversed pair 4, 1 in the array as well. But if
the array doesn't contain all pairs with their reversed pairs, then your program
should output a string of the integer pairs that are incorrect, in the order
that they appear in the array.

For example: if arr is [6, 2, 2, 6, 5, 14, 14, 1] then your program should
output the string 5,14,14,1 with only a comma separating the integers.

Sample test cases:

Input:  4, 5, 1, 4, 5, 4, 4, 1
Output: "yes"

Input:  6, 2, 2, 6, 5, 14, 14, 1
Output: "5,14,14,1"

Input:  2,1,1,2,3,3
Output: "3,3"

Input:  5,4,6,7,7,6,4,5
Output: "yes"






*/






.......................................................................................................



/*
Question#53
Coderbyte coding challenge: Simple SAT

Problem statement:

Using the C# language, have the function SimpleSAT(str) read str which will be
a string consisting of letters, parenthesis, logical operators and tilde's
representing a Boolean formula. For example: str may be "(a&b)|c" which means (a
AND b) OR c. Your program should output the string yes if there is some
arrangement of replacing the letters with TRUE or FALSE in such a way that the
formula equates to TRUE. If there is no possible way of assigning TRUE or FALSE
to the letters, then your program should output the string no. In the example
above, your program would return yes because a=TRUE, b=TRUE and c=FALSE would
make the formula TRUE. Another example: if str is "((a&c)&~a)" which means ((a
AND c) AND NOT a) then your program should output no because it is not possible
to assign TRUE or FALSE values to the letters to produce a TRUE output.

A Boolean formula will always have at most 5 letters, i.e. a, b, c, d and e.
A tilde will never appear outside of a parenthesis, i.e. ~(a&b).

Sample test cases:

Input:  "(a&b&c)|~a"
Output: "yes"

Input:  "a&(b|c)&~b&~c"
Output: "no"






*/






.......................................................................................................


