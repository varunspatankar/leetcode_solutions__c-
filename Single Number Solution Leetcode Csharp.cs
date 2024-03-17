namespace Single_Number_Solution_Leetcode_Csharp
{
    internal class Program
    {
       
            public int SingleNumber(int[] nums)
            {
                var singleNumber = 0; //define var single number and set it to zero
                foreach (var num in nums) //for each nums in the array
                {
                    singleNumber ^= num; //single number will be equa to singlenumber xor num, this will find the number that is the odd one out
                }
                return singleNumber; //return single number
            }
       
    }
}