public class Solution
{
    public int MostWordsFound(string[] sentences)
    {

        int maxlength = 0; //create integer maxlength
        for(int i = 0; i < sentences.Length; i++) //for loop
        {
            string sentence = sentences[i]; //this will iterate through each sentence in the array

            int count = sentence.Count(Char.IsWhiteSpace)+1; //for each sentence we check the amount of spaces and add 1 to find the amount of words

            if (count > maxlength) //if the word count for once sentence is greater than another, set it as maxlength
            {
                maxlength = count;
            }   
        }   
        return maxlength; //return maxlength
    }
}
