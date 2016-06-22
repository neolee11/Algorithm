using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _104_Max_Depth_Of_Binary_Tree
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;

            var leftDepth = 1 + MaxDepth(root.left);
            var rightDepth = 1 + MaxDepth(root.right);

            return Math.Max(leftDepth, rightDepth);
        }
    }
   
}
