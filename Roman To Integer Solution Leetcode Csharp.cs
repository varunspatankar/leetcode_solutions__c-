namespace Roman_To_Integer_Solution_Leetcode_Csharp
{
    internal class Program
    {
        
        public class Solution
        {
            public int SimplerConverter(string number)
            {
                number = number.ToUpper(); //Input becomes uppercase
                var result = 0; //define int result

                foreach (var letter in number) //for each letter in string number, convert it to a number using the ConvertLetterToNumber() Function
                {
                    result += ConvertLetterToNumber(letter);
                }

                if (number.Contains("IV") || number.Contains("IX")) //If the number contains IX or IV we minus 2 since these are exceptions
                    result -= 2;

                if (number.Contains("XL") || number.Contains("XC")) //Same for the next two if statements
                    result -= 20;

                if (number.Contains("CD") || number.Contains("CM"))
                    result -= 200;


                return result; //we return the result



            }

            private int ConvertLetterToNumber(char letter) //create function which does the magic
            {
                switch (letter) //switch statement which displays cases and switches letters to numbers
                {
                    case 'M':
                        {
                            return 1000;
                        }

                    case 'D':
                        {
                            return 500;
                        }

                    case 'C':
                        {
                            return 100;
                        }

                    case 'L':
                        {
                            return 50;
                        }

                    case 'X':
                        {
                            return 10;
                        }

                    case 'V':
                        {
                            return 5;
                        }

                    case 'I':
                        {
                            return 1;
                        }

                    default:
                        {
                            throw new ArgumentException("Invalid character");
                        }



                }

            }
        }
        
    }
}