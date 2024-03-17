namespace Square_Root_of_x_Solution_Leetcode_Csharp
{
    internal class Program
    {
        public class Solution
        {
            public int MySqrt(int x)
            {


                long p = 1; //create a variable long p and set it to the value 1
                while (p * p <= x) //create a while loop which keep incrementing by 1 until p*p=x
                {
                    p++;
                }

                return (int)p - 1; //return p-1 as an integer
            }
        }
    }
}