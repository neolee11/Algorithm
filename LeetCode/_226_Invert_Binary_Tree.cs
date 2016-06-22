using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _226_Invert_Binary_Tree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return null;

            TreeNode right = InvertTree(root.right);
            TreeNode left = InvertTree(root.left);
            root.left = right;
            root.right = left;
            return root;
        }
    }
}
