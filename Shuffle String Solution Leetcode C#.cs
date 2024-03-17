 public class Solution
    {
        public string RestoreString(string s, int[] indices)
        {
            char[] result = new char[s.Length]; //create a new character array called result
            for (int i = 0; i < indices.Length; i++) //for loop
            {
                result[indices[i]] = s[i]; //make result[indices[i]] equal to s[i]
            }

            return new string(result); //convert the array to a string and return it
        }
    }
