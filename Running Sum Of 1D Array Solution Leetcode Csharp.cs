namespace Running_Sum_Of_1D_Array_Solution_Leetcode_Csharp
{
    public class Solution
    {
        public int[] RunningSum(int[] nums)
        {
            int sum = 0; //create int sum and set it to zero

            int[] result = new int[nums.Length]; //create new int array

            for (int i = 0; i < nums.Length; i++) //for loop
            {
                sum += nums[i]; //set sum equal the sum of it and nums[i]
                result[i] = sum; //create result array


            }
            return result; //return result
        }
    }
}