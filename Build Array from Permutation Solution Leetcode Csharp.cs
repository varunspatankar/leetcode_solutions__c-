namespace Build_Array_from_Permutation_Solution_Leetcode_Csharp
{
    internal class Program
    {
        public int[] BuildArray(int[] nums)
        {

            int[] ans = new int[nums.Length]; //create new array called ans, with its length being the same length as nums
            for (int x = 0; x < nums.Length; x++)
            {


                ans[x] = nums[nums[x]]; //for each x less than nums.Length we set the elements of ans




            }
            return ans; //return ans
        }
    }
}
