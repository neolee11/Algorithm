using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _237_Delete_Node_In_A_Linked_List
    {
        public void DeleteNode(ListNode node)
        {
            if (node == null) return;

            //if(node.next == null) return;

            while (node.next != null)
            {
                node.val = node.next.val;
                if (node.next.next != null)
                {
                    node = node.next;
                }
                else
                {
                    node.next = null;
                }
            }

        }
    }
}
