using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Algorithms
{
	public class BSTClass
	{
		public TreeNode root;
		
		public BSTClass()
		{
		}

		public BSTClass(int rootValue)
		{
			root = new TreeNode(rootValue);
		}

		public int Height
		{
			get { return HeightHelper(root); }
		}

		private int HeightHelper(TreeNode currNode) //Nodes counting
		{
			if (currNode == null)
				return 0;
			else
				return 1 + compareMax(HeightHelper(currNode.Left), HeightHelper(currNode.Right));
		}

        private int HeightHelper2(TreeNode currNode) //Path counting
        {
            if (currNode == null) return 0;
            int leftHeight = 0;
            if (currNode.Left != null)
                leftHeight = 1 + HeightHelper2(currNode.Left);
            int rightHeight = 0;
            if (currNode.Right != null)
                rightHeight = 1 + HeightHelper2(currNode.Right);

            return leftHeight > rightHeight ? leftHeight : rightHeight;

        }

		private int compareMax(int a, int b)
		{
			if (a >= b) 
				return a;
			else 
				return b;
		}

		public void Insert(int value)
		{
			if (root == null)
			{
				root = new TreeNode(value);
				return;
			}

			TreeNode newNode = new TreeNode(value);

			TreeNode currNode = root;
			TreeNode nodeInsertAt = null;
			while (currNode != null)
			{
				nodeInsertAt = currNode;
				if (newNode.Value <= currNode.Value) currNode = currNode.Left;
				else currNode = currNode.Right;
			}
			if (newNode.Value <= nodeInsertAt.Value)
				nodeInsertAt.Left = newNode;
			else
				nodeInsertAt.Right = newNode;
		}

		public void Delete(int value)
		{
			TreeNode node = Search(value);
			if (node == null)
				return;

			DeleteHelper(node);
		}

		private void DeleteHelper(TreeNode ToDelete)
		{
			TreeNode toSplice;
			if (ToDelete.Left == null || ToDelete.Right == null)
				toSplice = ToDelete;
			else
				toSplice = SuccessorNode(ToDelete);

			TreeNode childNode;
			if (toSplice.Left != null)
				childNode = toSplice.Left;
			else
				childNode = toSplice.Right;

			TreeNode toSpliceParent = Parent(toSplice);
			if (toSpliceParent == null)
				root = childNode;
			else
			{
				ChildType ToSpliceBranch = GetMyBranchType(toSplice);
				if (ToSpliceBranch == ChildType.LEFT_CHILD)
					toSpliceParent.Left = childNode;
				else
					toSpliceParent.Right = childNode;
			}

			if (toSplice != ToDelete)
				ToDelete.Value = toSplice.Value;

		}

		public TreeNode Search(int value)
		{
			if (root == null)
				return null;

			TreeNode curr = root;
			while (curr != null)
			{
				if (value == curr.Value)
					return curr;
				else if (value <= curr.Value)
					curr = curr.Left;
				else
					curr = curr.Right;
			}
			return null;
		}

		public int MaxVal()
		{
			TreeNode maxNode = MaxValNode(root);
			if (maxNode == null)
				return 0;
			else
				return maxNode.Value;
		}

		private TreeNode MaxValNode(TreeNode root)
		{
			if (root == null)
				return null;

			if (root.Right == null)
				return root;

			TreeNode curr = root;
			while (curr.Right != null)
				curr = curr.Right;
			return curr;
		}

		public int MinVal()
		{
			TreeNode minNode = MinValNode(root);
			if (minNode == null)
				return 0;
			else
				return minNode.Value;
		}

		private TreeNode MinValNode(TreeNode root)
		{
			if (root == null)
				return null;

			if (root.Left == null)
				return root;

			TreeNode curr = root;
			while (curr.Left != null)
				curr = curr.Left;
			return curr;
		}

		public TreeNode Predecessor(int value)
		{
			TreeNode node = Search(value);
			if(node == null)
				return null;

			if (node.Left != null)
				return MaxValNode(node.Left);
			else
			{
				ChildType childBranch = GetMyBranchType(node);
				if (childBranch == ChildType.RIGHT_CHILD)
					return Parent(node);
				else if (childBranch == ChildType.LEFT_CHILD)
				{
					TreeNode parent = Parent(node);
					while (parent != null)
					{
						if (GetMyBranchType(node) == ChildType.RIGHT_CHILD)
							return parent;
						node = parent;
						parent = Parent(node);
					}
					return null;
				}
				else
					return null; //Root doesn't have a left branch
			}
		}

		public TreeNode Successor(int value)
		{
			TreeNode node = Search(value);
			return SuccessorNode(node);
		}

		public TreeNode SuccessorNode(TreeNode node)
		{
			if (node == null)
				return null;

			if (node.Right != null)
				return MinValNode(node.Right);
			else
			{
				TreeNode parent = Parent(node);
				while (parent != null && GetMyBranchType(node) == ChildType.RIGHT_CHILD)
				{
					node = parent;
					parent = Parent(parent);
				}
				return parent;
			}
		}

		public TreeNode Successor1(int value)
		{
			TreeNode node = Search(value);
			if (node == null)
				return null;

			if (node.Right != null)
				return MinValNode(node.Right);
			else
			{
				ChildType childBranch = GetMyBranchType(node);
				if (childBranch == ChildType.LEFT_CHILD)
					return Parent(node);
				else if (childBranch == ChildType.RIGHT_CHILD)
				{
					TreeNode parent = Parent(node);
					while (parent != null)
					{
						if (GetMyBranchType(node) == ChildType.LEFT_CHILD)
							return parent;
						node = parent;
						parent = Parent(parent);
					}
					return null;
				}
				else
					return null; 
			}
		}

		public TreeNode Parent(TreeNode node)
		{
			if (node == null || node == root)
				return null;

			TreeNode parent = root;
			TreeNode curr;
			if (node.Value <= parent.Value)
				curr = parent.Left;
			else
				curr = parent.Right;

			while (curr != null)
			{
				if (node.Value == curr.Value)
					return parent;
				else if (node.Value <= curr.Value)
				{
					parent = curr;
					curr = curr.Left;
				}
				else
				{
					parent = curr;
					curr = curr.Right;
				}
			}
			return null;
		}
		
		public ChildType GetMyBranchType(TreeNode node)
		{
			TreeNode parent = Parent(node);
			if (parent == null)
				return ChildType.NONE;

			if (parent.Left == node)
				return ChildType.LEFT_CHILD;
			else
				return ChildType.RIGHT_CHILD;
		}

		public TreeNode LeastCommonAncestor(int val1, int val2) 
		{
			TreeNode node1 = Search(val1);
			TreeNode node2 = Search(val2);
			
			if (node1 == null || node2 == null)
				return null;

			TreeNode ancestor = root;
			while (ancestor != null)
			{
				if (node1.Value == ancestor.Value || node2.Value == ancestor.Value)
					return ancestor;
				else if (node1.Value <= ancestor.Value && node2.Value > ancestor.Value)
					return ancestor;
				else if (node1.Value > ancestor.Value && node2.Value <= ancestor.Value)
					return ancestor;
				else if (node1.Value <= ancestor.Value && node2.Value <= ancestor.Value)
					ancestor = ancestor.Left;
				else
					ancestor = ancestor.Right;
			}
			return ancestor;
		}

		public string InOrderPrint() 
		{
			return InOrderPrintHelper(root);
		}

		private string InOrderPrintHelper(TreeNode root)
		{
			if (root == null)
				return "";

			string msg = "";
			msg = msg + InOrderPrintHelper(root.Left);
			msg = msg + " " + root.Value;
			msg = msg + InOrderPrintHelper(root.Right);
			return msg;
		}

		public string PreOrderPrint()
		{
			return PreOrderPrintHelper(root);
		}

		private string PreOrderPrintHelper(TreeNode root)
		{
			if (root == null)
				return "";

			string msg = "";
			msg = msg + " " + root.Value;
			msg = msg + PreOrderPrintHelper(root.Left);
			msg = msg + PreOrderPrintHelper(root.Right);
			return msg;
		}

		public string PostOrderPrint() 
		{
			return PostOrderPrintHelper(root);
		}

		private string PostOrderPrintHelper(TreeNode root)
		{
			if (root == null)
				return "";

			string msg = "";
			msg = msg + PostOrderPrintHelper(root.Left);
			msg = msg + PostOrderPrintHelper(root.Right);
			msg = msg + " " + root.Value;
			return msg;
		}

		public void Clear()
		{
			this.root = null;
		}
	}

	public class TreeNode
	{
		private TreeNode mLeft;
		public TreeNode Left
		{
			get { return this.mLeft; }
			set { mLeft = value; }
		}

		private TreeNode mRight;
		public TreeNode Right
		{
			get { return this.mRight; }
			set { mRight = value; }
		}

		private int mValue;
		public int Value
		{
			get { return this.mValue; }
			set { this.mValue = value; }
		}

		public TreeNode()
		{
			Left = null;
			Right = null;
			mValue = -100;
		}

		public TreeNode(int aValue){
			Left = null;
			Right = null;
			mValue = aValue;
		}
	}

	public enum ChildType
	{
		NONE = 0,
		LEFT_CHILD = 1,
		RIGHT_CHILD = 2
	}
}
