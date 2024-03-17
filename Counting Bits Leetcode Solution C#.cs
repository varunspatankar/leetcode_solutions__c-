public class Solution {
    public int[] CountBits(int n) {
        int[] ans = new int[n+1]; //new array
        for(int x = 0; x<=n;x++){ //for loop
            
            string res = Convert.ToString(x, 2); //converts int to base two(binary)
            int freq = res.Count(f => (f == '1')); //(counts how many times 1 appears in the binary)
            ans[x] = freq; //set ans[x] as that freq
            res = ""; //reset res
        }
        return ans; //return array ans
    }
}
