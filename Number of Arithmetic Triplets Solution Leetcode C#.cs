internal class Program
    {
        static int Main(int[] nums, int diff)
        {
            int count = 0; //create int count and set it to 0
            for(int x = 0; x < nums.Length; x++) //create 3 for loops
            {
                for(int i = 0; i < nums.Length; i++)
                {
                    for(int y = 0; y < nums.Length; y++)
                    {
                        if (nums[y] - nums[i] == diff && nums[i] - nums[x] == diff) //if these rules stand
                        {
                            count++; //increment count
                        }
                    }    
                } 
            }  
            return count;   //return count
        }
    }
