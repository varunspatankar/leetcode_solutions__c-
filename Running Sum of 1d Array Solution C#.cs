public class Solution {
    public int[] RunningSum(int[] nums) {
      if (nums == null) //if the array is null, we return null
                return null;
            
            for (int i = 1; i < nums.Length; i++) //for loop
            {
                nums[i] = nums[i-1] + nums[i]; //the element is equal to the sum of the element before it and the element itself
            }
            
            return nums; //return array
    }
}
