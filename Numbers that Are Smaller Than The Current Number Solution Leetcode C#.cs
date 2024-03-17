public class Solution
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {

        int[] sortedNums = (int[])nums.Clone(); //create a clone of array nums since the result is the same length
        Array.Sort(sortedNums); //we sort the cloned array from least to greatest

        for (int j = 0; j < nums.Length; j++) //for loop
        {
            nums[j] = Array.IndexOf(sortedNums, nums[j]); //nums[j] will be set as the index of the sorted array of the element nums[j], since it is from least to greatest
        }

        return nums; //return nums
    }
}
