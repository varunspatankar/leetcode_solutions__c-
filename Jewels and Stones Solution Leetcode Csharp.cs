 public class Solution
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            int total = 0; //create integer total and set it as 0
            for (int x = 0; x < jewels.Length; x++) //create two for loops for each array
            {
                for (int y = 0; y < stones.Length; y++)
                {
                    if (jewels[x] == stones[y]) //if a element in stones is equal to one of the jewels, add one to total
                    {
                        total++;
                    } 
                }

            }
            return total; //return total
        }
    } public class Solution
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            int total = 0; //create integer total and set it as 0
            for (int x = 0; x < jewels.Length; x++) //create two for loops for each array
            {
                for (int y = 0; y < stones.Length; y++)
                {
                    if (jewels[x] == stones[y]) //if a element in stones is equal to one of the jewels, add one to total
                    {
                        total++;
                    } 
                }

            }
            return total; //return total
        }
    }
