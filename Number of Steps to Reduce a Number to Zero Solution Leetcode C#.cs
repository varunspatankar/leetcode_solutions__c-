public class Solution
{
    public int NumberOfSteps(int num)
    {
        int steps = 0; //create int steps and set it as 0
        while(num != 0) //create while loop
        {
            if(num% 2 == 0) //if the number is even
            {
                num = num / 2; //the number will be divided by 2
                
            }
            else
            {
                num = num - 1; //if it is odd, we will minus 1 off it
                
            }
            steps++; //add one step
        }
        return steps; //return steps
    }
}
