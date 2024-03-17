public class Solution
    {
        public int[] Decode(int[] encoded, int first)
        {
            int[] decoded = new int[encoded.Length + 1]; //create new array decoded with 1+ length
            decoded[0] = first; //set decoded 0 as int first
            for(int i = 0; i < encoded.Length; i++) //for loop
            {
                decoded[i + 1] = encoded[i] ^ decoded[i];   //decoded[i+1} will be equal to encoded[i] ^ decoded[i]
            }
            return decoded; //return decoded
        }
    }
