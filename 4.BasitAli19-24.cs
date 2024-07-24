 public static int StringCalculate(string str)
        {
            // Replace exponentiation operator '**' with '^' for DataTable.Compute
            string modifiedStr = str.Replace("**", "^");

            // Use DataTable.Compute to evaluate the expression
            // Note: Compute returns a double, so cast to int
            try
            {
                DataTable table = new DataTable();
                var result = table.Compute(modifiedStr, string.Empty);
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error evaluating expression: {ex.Message}");
                return 0;
            }
        }



 static string StringExpression(string str)
        {
            // Dictionary to map written numbers to digits
            Dictionary<string, int> numberMap = new Dictionary<string, int>()
        {
            { "zero", 0 },
            { "one", 1 },
            { "two", 2 },
            { "three", 3 },
            { "four", 4 },
            { "five", 5 },
            { "six", 6 },
            { "seven", 7 },
            { "eight", 8 },
            { "nine", 9 }
        };

            // List to store the final expression parts
            List<string> expressionParts = new List<string>();
            string temp = "";
            for (int i = 0; i < str.Length; i++)
            {
                temp += str[i];
                if (numberMap.ContainsKey(temp))
                {
                    expressionParts.Add(numberMap[temp].ToString());
                    temp = "";
                }
                else if (temp == "minus")
                {
                    expressionParts.Add("-");
                    temp = "";
                }
                else if (temp == "plus")
                {
                    expressionParts.Add("+");
                    temp = "";
                }
            }

            // Join the parts to form the expression string
            string expression = string.Join("", expressionParts);

            // Evaluate the expression
            int result = EvaluateExpression(expression);

            // Convert the result back to written format
            return NumberToWords(result);
        }

        static int EvaluateExpression(string expression)
        {
            // Evaluate the expression using DataTable Compute method
            var table = new System.Data.DataTable();
            return Convert.ToInt32(table.Compute(expression, string.Empty));
        }

        static string NumberToWords(int num)
        {
            if (num == 0)
                return "zero";

            if (num < 0)
                return "negative" + NumberToWords(-num);

            string[] words = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            string result = "";
            foreach (char c in num.ToString())
            {
                result += words[int.Parse(c.ToString())];
            }

            return result;
        }



 public static int CountBinaryChanges(string[] strArr)
        {
            int decimalNumber = int.Parse(strArr[0]);
            string givenBinary = strArr[1];

            // Convert the decimal number to binary
            string correctBinary = Convert.ToString(decimalNumber, 2);

            // Pad the given binary string with leading zeros if necessary
            int lengthDifference = correctBinary.Length - givenBinary.Length;
            if (lengthDifference > 0)
            {
                givenBinary = new string('0', lengthDifference) + givenBinary;
            }
            else if (lengthDifference < 0)
            {
                correctBinary = new string('0', -lengthDifference) + correctBinary;
            }

            // Count the number of different digits
            int changes = 0;
            for (int i = 0; i < correctBinary.Length; i++)
            {
                if (correctBinary[i] != givenBinary[i])
                {
                    changes++;
                }
            }

            return changes;
        }


