public class Solution
    {
        public string Interpret(string command)
        {

            return command.Replace("()", "o").Replace("(al)", "al"); //return command with () replaced as o and (al) as al  
        }
        
    }
