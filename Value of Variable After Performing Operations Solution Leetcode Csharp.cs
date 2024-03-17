namespace Value_of_Variable_After_Performing_Operations_Solution_Leetcode_Csharp;
public class Solution
{
    public int FinalValueAfterOperations(string[] operations)
    {
        int x = 0; //define int x and set it to 0

        for(int i = 0; i < operations.Length; i++) //for loop
        {
            if (operations[i] == "++X" || operations[i] == "X++") //if operations[i] = ++x or x++ increment x by 1
            {
                x = x + 1;
            }
            else if (operations[i] == "--X" || operations[i] == "X--") //if operations[i] = --x or x-- increment x by -1
            {
                
                x = x - 1;
            }
        }   
        return x; //return x
    }
}