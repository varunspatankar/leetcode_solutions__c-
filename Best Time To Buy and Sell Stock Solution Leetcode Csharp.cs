namespace Best_Time_To_Buy_and_Sell_Stock_Solution_Leetcode_Csharp
{
    internal class Program
    {
        public int MaxProfit(int[] prices)
        {
            int minprice = int.MaxValue; //we can set integer min price to the maximum value for an integer
            int maxprofit = 0; //we can also set maxprofit to zero
            for (int i = 0; i < prices.Length; i++) //for each integer i less than prices.length
            {
                if (prices[i] < minprice)
                    minprice = prices[i]; //if prices[i] is less than min price, we set prices[i] as min price, this wil find the lowest price in the array
                else if (prices[i] - minprice > maxprofit)
                    maxprofit = prices[i] - minprice; //here we find the max profit
            }
            return maxprofit; //we return max profit
        }
    }
}