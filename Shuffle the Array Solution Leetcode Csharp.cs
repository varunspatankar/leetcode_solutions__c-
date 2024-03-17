public class Solution
    {
        public int[] Shuffle(int[] nums, int n)
        {
            List<int> listx = new List<int>(); //create empty list
            List<int> listy = new List<int>(); //create empty list
            for (int i = 0; i < n; i++)
            {
                listx.Add(nums[i]); //insert all the elements of array nums into list x
            }
            for (int i = n; i < 2 * n; i++)
            {
                listy.Add(nums[i]); //insert all the elements of array nums into list y
            }

            List<int> list = new List<int>(); //create another empty list
            for (int i = 0; i < n; i++)
            {
                list.Add(listx[i]); //add each element at a time, now it is organized
                list.Add(listy[i]);
            }
            return list.ToArray(); //convert list back to array and return that
        }
    }
