public class Solution {
     public bool ContainsDuplicate(int[] nums) {
        Hashtable table = new Hashtable(); //create hashtable
        
        foreach (var item in nums) //for each loop
            if (table.Contains(item)) //if the table contains an element, we return true as there are dupes
                return true;
            else
                table.Add(item, null); //else we add the element and monitor it using the loop
        
        return false; //return false if the above statements are false
    }
}
