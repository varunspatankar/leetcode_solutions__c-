namespace Concatenation_of_Array_Solution_Leetcode_Csharp
{
    internal class Program
    {
        public int[] GetConcatenation(int[] nums)
        {
            List<int> list = new List<int>(); //create new int list
            list.AddRange(nums); //add nums two times to the new list
            list.AddRange(nums);
            int[] ans = list.ToArray(); //then we convert the list to array
            return ans; //return the array
        }
    }
}