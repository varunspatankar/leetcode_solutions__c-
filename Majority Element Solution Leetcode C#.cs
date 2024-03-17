public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            int target = nums.Length / 2; //we can set the Length of the array/2 as target
            Dictionary<int, int> dic = new Dictionary<int, int>(); //create new integer dictionary <integer, how many times it appears>
            for (int i = 0; i < nums.Length; i++) //for loop
            {
                if (!dic.ContainsKey(nums[i])) //if the dictionary does not contain the element
                {
                    dic.Add(nums[i], 1); //we add it with 1 as the amount of times it appears

                }

                else
                {
                    dic[nums[i]]++; //if the element appears again, we increase its number times appeared

                }

                if (dic[nums[i]] > target) //if it is greater than target
                {
                    return nums[i]; //we return nums[i]
                }

            }
            return 7989; //this doesnt matter since it just makes sure the function returns something
        }
    }
