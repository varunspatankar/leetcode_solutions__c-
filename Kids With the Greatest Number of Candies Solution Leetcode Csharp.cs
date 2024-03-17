public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        bool[] arr = new bool[candies.Length]; //create bool array
        i
        int max = candies.Max(); //find the max candies in the array
        for(int x = 0; x < candies.Length; x++) //for loop
        {
            if (candies[x] + extraCandies >= max) //if a element plus extra candies is the max value
            {
                arr[x] = true; //the bool array value will be true
            }
            else
            {
                arr[x] = false; //else it will be set as fals
            }

        }
        return arr; //return array
    }
