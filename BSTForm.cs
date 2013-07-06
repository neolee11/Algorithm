using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Collections;

namespace Algorithms
{
	public partial class BSTForm : Form
	{
		private bool mRandomGenNum = false;
		private BSTClass mBST;

		public BSTForm()
		{
			InitializeComponent();
			mBST = new BSTClass();
		}

		private void btnAddCircle_Click(object sender, EventArgs e)
		{

		}

		private void buttonInsert_Click(object sender, EventArgs e)
		{
			if (this.textBoxValue.Text == "") return;

			int value = Int32.Parse(this.textBoxValue.Text);
			mBST.Insert(value);
			PrintBSTOnScreen();
			this.DoRandomGen();
		}

		private void buttonRandomInsert_Click(object sender, EventArgs e)
		{
			int maxNums = 10;
			Random ran = new Random();
			int val;
			for (int i = 0; i < maxNums; i++)
			{
				do
				{
					val = ran.Next(50);
				} while (mBST.Search(val) != null);
				mBST.Insert(val);
			}
			PrintBSTOnScreen();
		}

		private void PrintBSTOnScreen()
		{
			this.circleTree1.Clear();
			int height = mBST.Height;
			if (height == 0) return;
			int rootX = ((int)Math.Pow(2.0, height)) / 2;
			PrintBSTNodes(mBST.root, rootX, 1, height);
			PrintBSTLinks(mBST.root, rootX, 1, height);
		}

		private void PrintBSTNodes(TreeNode node, int x, int level, int treeHeight)
		{
			if (node == null) return;

			this.circleTree1.Add(x, level - 1, node.Value.ToString());

			int	space = (int)(Math.Pow(2.0, (treeHeight - level - 1)));
			PrintBSTNodes(node.Left, x - space, level + 1, treeHeight);
			PrintBSTNodes(node.Right, x + space, level + 1, treeHeight);
		}

		private void PrintBSTLinks(TreeNode node, int x, int level, int treeHeight)
		{
			if (node == null)
				return;

			int space = (int)(Math.Pow(2.0, (treeHeight - level - 1)));

			if (node.Left != null)
				this.circleTree1.AddLink(x, level - 1, x - space, level, "");
			if (node.Right != null)
				this.circleTree1.AddLink(x, level - 1, x + space, level, "");

			PrintBSTLinks(node.Left, x - space, level+1, treeHeight);
			PrintBSTLinks(node.Right, x + space, level + 1, treeHeight);

		}

		private void checkBoxRandomGen_CheckedChanged(object sender, EventArgs e)
		{
			this.mRandomGenNum = this.checkBoxRandomGen.Checked;
			DoRandomGen();
		}

		private void DoRandomGen()
		{
			if (this.mRandomGenNum)
				this.textBoxValue.Text = GetNextRanNumber().ToString();
		}

		private int GetNextRanNumber()
		{
			Random ran = new Random();
			return ran.Next(50);
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string filePath = "TreeNodes.xml";

			this.saveFileDialog1.InitialDirectory = ".";
			this.saveFileDialog1.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
			this.saveFileDialog1.FilterIndex = 1;
			this.saveFileDialog1.FileName = filePath;

			if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				filePath = this.saveFileDialog1.FileName;
				this.SaveTreeNodes(filePath);
				MessageBox.Show("BST successfully saved.");
			}
		}

		private void SaveTreeNodes(string filePath)
		{
			if (filePath == "") return;

			ArrayList list = new ArrayList();
			InsertNodes(list, this.mBST.root);

			Type[] extraTypes = new Type[1];
			extraTypes[0] = typeof(TreeNode);

			XmlSerializer serializer = new XmlSerializer(typeof(ArrayList), extraTypes);

			Stream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None);
			serializer.Serialize(stream, list);
			stream.Close();
		}

		private void InsertNodes(ArrayList list, TreeNode node)
		{
			if (node == null)
				return;

			list.Add(node);
			InsertNodes(list, node.Left);
			InsertNodes(list, node.Right);
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.openFileDialog1.InitialDirectory = ".";
			this.openFileDialog1.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
			this.openFileDialog1.FilterIndex = 1;
			this.openFileDialog1.FileName = "";

			if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				string filePath = this.openFileDialog1.FileName;
				ReadTreeNodes(filePath);
				PrintBSTOnScreen();
			}
		}

		private void ReadTreeNodes(string filePath)
		{
			this.mBST = new BSTClass();
			ArrayList list = new ArrayList();

			Type[] extraTypes = new Type[1];
			extraTypes[0] = typeof(TreeNode);

			XmlSerializer serializer = new XmlSerializer(typeof(ArrayList), extraTypes);
			FileStream fs = new FileStream(filePath, FileMode.Open);

			list = (ArrayList)serializer.Deserialize(fs);
			for (int i = 0; i < list.Count; i++)
			{
				TreeNode node = (TreeNode)list[i];
				mBST.Insert(node.Value);
			}

		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (this.textBoxValue.Text == "") return;
			int value = Int32.Parse(this.textBoxValue.Text);
			mBST.Delete(value);
			PrintBSTOnScreen();
		}

		private void buttonMax_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Max Value : " + mBST.MaxVal().ToString());
		}

		private void btnClearCircle_Click(object sender, EventArgs e)
		{
			mBST.Clear();
			PrintBSTOnScreen();
		}

		private void buttonMin_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Min Value : " + mBST.MinVal().ToString());
		}

		private void buttonPredecessor_Click(object sender, EventArgs e)
		{
			if (this.textBoxValue.Text == "") return;
			int value = Int32.Parse(this.textBoxValue.Text);

			TreeNode node = mBST.Predecessor(value);
			if (node != null)
				MessageBox.Show("Predecessor of " + value.ToString() + " is : " + node.Value.ToString());
			else
				MessageBox.Show("Predecessor of " + value.ToString() + " does not exist");
		}

		private void buttonSuccessor_Click(object sender, EventArgs e)
		{
			if (this.textBoxValue.Text == "") return;
			int value = Int32.Parse(this.textBoxValue.Text);

			TreeNode node = mBST.Successor(value);
			if (node != null)
				MessageBox.Show("Successor of " + value.ToString() + " is : " + node.Value.ToString());
			else
				MessageBox.Show("Successor of " + value.ToString() + " does not exist");
		}

		private void buttonParent_Click(object sender, EventArgs e)
		{
			if (this.textBoxValue.Text == "") return;
			int value = Int32.Parse(this.textBoxValue.Text);

			TreeNode node = mBST.Search(value);
			TreeNode parent = mBST.Parent(node);
			if (parent != null)
				MessageBox.Show("Parent of " + value.ToString() + " is : " + parent.Value.ToString());
			else
				MessageBox.Show("Parent of " + value.ToString() + " does not exist");

		}

		private void buttonChildBranch_Click(object sender, EventArgs e)
		{
			if (this.textBoxValue.Text == "") return;
			int value = Int32.Parse(this.textBoxValue.Text);

			TreeNode node = mBST.Search(value);
			TreeNode parent = mBST.Parent(node);
			ChildType childType = mBST.GetMyBranchType(node);
			if (childType == ChildType.LEFT_CHILD)
				MessageBox.Show(node.Value + " is the left child of " + parent.Value);
			else if (childType == ChildType.RIGHT_CHILD)
				MessageBox.Show(node.Value + " is the right child of " + parent.Value);
			else
				MessageBox.Show(node.Value + " is either root or does not exist.");

		}

		private void buttonLCA_Click(object sender, EventArgs e)
		{
			if (this.textBoxValue.Text == "") return;
			string[] text = this.textBoxValue.Text.Split(new char[]{' '});
			int val1 = Convert.ToInt32(text[0]);
			int val2 = Convert.ToInt32(text[1]);

			TreeNode ancestor = mBST.LeastCommonAncestor(val1, val2);

			if(ancestor != null)
				MessageBox.Show("The least common ancestor of " + val1.ToString() + " and " + val2.ToString() + " is : " + ancestor.Value.ToString());
			else
				MessageBox.Show("The least common ancestor of " + val1.ToString() + " and " + val2.ToString() + " does not exist");
		}

		private void buttonPreOrder_Click(object sender, EventArgs e)
		{
			string msg = mBST.PreOrderPrint();
			this.richTextBoxOrder.Text = msg;
		}

		private void buttonInOrder_Click(object sender, EventArgs e)
		{
			string msg = mBST.InOrderPrint();
			this.richTextBoxOrder.Text = msg;
		}

		private void buttonPostOrder_Click(object sender, EventArgs e)
		{
			string msg = mBST.PostOrderPrint();
			this.richTextBoxOrder.Text = msg;
		}

		private void buttonHeight_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Height : " + mBST.Height.ToString());
		}

		

		
	}
}