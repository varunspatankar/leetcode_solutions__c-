public class Solution
{
    public int SubtractProductAndSum(int n)
    {
        char[] a = Convert.ToString(n).ToCharArray(); //we create a character array
        int product = 1; //set int product as 1
        int sum = 0; //set sum as 1

        foreach (char numb in a) //for each char in a
        {
            product *= (int)Char.GetNumericValue(numb); //the product will be set as the character times product
            sum += (int)Char.GetNumericValue(numb); //the sum wil be set as the char plus the sum
        }

        return (product - sum); //return the product minus sum
    }
}
