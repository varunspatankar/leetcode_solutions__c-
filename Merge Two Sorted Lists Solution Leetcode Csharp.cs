using System.Net.NetworkInformation;

namespace Merge_Two_Sorted_Lists_Solution_Leetcode_Csharp
{
    internal class Program
    {
        

        public class Solution
        {
            public ListNode MergeTwoLists(ListNode l1, ListNode l2)
            {
                if (l1 == null) return l2; //if any of the lists are empty, return the other one
                if (l2 == null) return l1;
                if (l1.val < l2.val) //if the value of l1 is less than l2
                {
                    l1.next = MergeTwoLists(l2, l1.next); //l1 next will be equal to the equivalent of l2
                    return l1; //return l2
                }
                else
                {
                    l2.next = MergeTwoLists(l1, l2.next); //else do the opposite
                    return l2;
                }


            }
        }
    }
}