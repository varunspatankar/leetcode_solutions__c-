namespace Palindrome_Solution_Leetcode_Csharp
{
   
    
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            string intxstring = x.ToString(); //Convert int x to string
            char[] chars = intxstring.ToCharArray(); //Then convert x as a string to array
            Array.Reverse(chars); //Then use the built in system to reverse the array
            string reversed = new string(chars); //duplicate original array so you can compare it with the reversed array
            if (reversed == intxstring) //Check if they are equal, and return true if it is
            {
                return true;

            }

            else
            {
                return false;
            }
            //Thats it folks!
        }

    }
    
}