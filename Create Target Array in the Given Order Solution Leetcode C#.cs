public class Solution
{
    public int[] CreateTargetArray(int[] nums, int[] index)
    {
        
        var res = new List<int>(); //create new list called res
        for(int i = 0; i < nums.Length; i++) //for loop
        {
            res.Insert(index[i], nums[i]); //insert nums[i] with index[i]
        }

        return res.ToArray(); //convert the list to array and return it
    }
}
