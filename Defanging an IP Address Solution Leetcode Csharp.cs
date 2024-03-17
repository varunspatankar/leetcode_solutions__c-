

namespace Defanging_an_IP_Address_Solution_Leetcode_Csharp
{
    public class Solution
    {
        public string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]"); //use replace function which replaces "." with "[.]"
        }
    }

}