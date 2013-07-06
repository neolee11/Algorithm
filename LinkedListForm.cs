using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Algorithms
{
	public partial class LinkedListForm : Form
	{
		private LinkedList mLinkedList; 

		public LinkedListForm()
		{
			InitializeComponent();

			mLinkedList = new LinkedList();
		}

		private void buttonRandomInsert_Click(object sender, EventArgs e)
		{
			int len = 10;
			Random ran = new Random();
			int num;
			for (int i = 0; i < len; i++)
			{
				num = ran.Next(100);
				mLinkedList.Insert(num);
			}
			this.UpdateScreen();
		}

		private void UpdateScreen()
		{
			this.richTextBox1.Text = mLinkedList.PrintList();
		}

		private void buttonInsert_Click(object sender, EventArgs e)
		{
			if (this.textBoxInput.Text.Trim() == "")
				return;

			int value = int.Parse(this.textBoxInput.Text);
			mLinkedList.Insert(value);
			this.UpdateScreen();
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			if (this.textBoxInput.Text.Trim() == "")
				return;

			int value = int.Parse(this.textBoxInput.Text);
			if (mLinkedList.Search(value) != null)
				MessageBox.Show("Value exists");
			else
				MessageBox.Show("Value not exists");

		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (this.textBoxInput.Text.Trim() == "")
				return;

			int value = int.Parse(this.textBoxInput.Text);
			mLinkedList.Delete(value);
			this.UpdateScreen();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.UpdateScreen();
		}

		private void buttonSort_Click(object sender, EventArgs e)
		{
			mLinkedList.Sort();
			this.UpdateScreen();
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			mLinkedList.Clear();
			this.UpdateScreen();

		}

		private void buttonReverse_Click(object sender, EventArgs e)
		{
			mLinkedList.Reverse();
			this.UpdateScreen();
		}

	}
}