namespace Two_Sum_Solution_Leetcode_Csharp
{
    internal class Program
    {
        public int[] TwoSum(int[] nums, int target)
        {


            int[] result = new int[2]; //we create int array result with length 2

            for (int i = 0; i < nums.Length; i++) //for int i less than nums.length
            {

                for (int j = i + 1; j < nums.Length; j++) //repeat array but set j as i+1
                {

                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i; //if num[i]+nums[j] = we set the values of the array
                        result[1] = j;
                        return result; 

                    }

                }
            }
            return result; //return result

        }
    }
}