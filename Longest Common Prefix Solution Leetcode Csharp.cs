namespace Longest_Common_Prefix_Solution_Leetcode_Csharp
{
    internal class Program
    {

        public class Solution
        {
            public string LongestCommonPrefix(string[] strs)
            {
                if (strs.Length == 0) { return ""; } //if strs is empty return nothing
                string prefix = strs[0];

                for (int i = 1; i < strs.Length; i++) //create for loop
                {
                    while (strs[i].IndexOf(prefix) != 0) //while loop which runs if strs[i].IndexOf(prefix) is not equal to zero
                    {
                        prefix = prefix.Substring(0, prefix.Length - 1); //prefix is equal to substring of 0 and prefix length minus 1
                    }
                }
                return prefix;
            }
        }


    }
}