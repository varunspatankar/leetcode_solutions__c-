public class Solution
    {
        public int[] DecompressRLElist(int[] nums)
        {
            ArrayList result = new ArrayList(); //create array list so it wil be easier to add elements
            for (int i = 1; i < nums.Length;i+=2) //for loop which increments by 2
            {
                int frequency = nums[i - 1]; //set frequency as element before value
                int val = nums[i]; //set value as nums[i]

                for (int j = 0; j < frequency;j++) //for loop which adds element
                {
                    result.Add(val); //we add the value frequency many times to the arraylist
                }
            }
            int[] res = result.ToArray(typeof(int)) as int[]; //we convert the list bnacl to an int array
            return res; //we return the array

        }
    }
