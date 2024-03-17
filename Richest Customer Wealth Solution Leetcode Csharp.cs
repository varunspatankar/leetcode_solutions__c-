namespace Richest_Customer_Wealth_Solution_Leetcode_Csharp
{
    public class Solution
    {
        public int MaximumWealth(int[][] accounts)
        {
            int maxsum = 0; //create integer for max sum and set it as equal to 0
            for (int x = 0; x < accounts.Length; x++) //create for loop which calculates how many outer brackets there are
            {
                int currentrowsum = 0; //create currentrowsum integer which will be the sum of each row in a square bracket
                for (int y = 0; y < accounts[x].Length; y++) //another for loop which iterates through inner brackets
                {
                    currentrowsum = currentrowsum + accounts[x][y]; //we find the sum of a current row and set it as currentrowsum

                }
                if (currentrowsum > maxsum) //if the current row sum is greater than max sum set it as maxsum
                {
                    maxsum = currentrowsum;
                }

            }

            return maxsum; //return maxsum
        }
        
    }
    
}
