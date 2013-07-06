using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Algorithms
{
	public partial class StackAndQueueForm : Form
	{
		private StackClass stack;
		private QueueClass queue;

		public StackAndQueueForm()
		{
			InitializeComponent();

			stack = new StackClass();
			queue = new QueueClass();
		}

		private void buttonPush_Click(object sender, EventArgs e)
		{
			try
			{
				int val = int.Parse(this.textBoxPush.Text);
				if (stack.Push(val) == false)
					MessageBox.Show("Stack is full");
				this.textBoxPush.Text = "";
				this.richTextBoxStackContent.Text = stack.Print();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void buttonPop_Click(object sender, EventArgs e)
		{
			try
			{
				int val = -1;
				if (stack.Pop(ref val) == false)
					MessageBox.Show("Stack is empty");
				else
				{
					this.textBoxPop.Text = val.ToString();
					this.richTextBoxStackContent.Text = stack.Print();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void buttonEnQ_Click(object sender, EventArgs e)
		{
			try
			{
				int val = int.Parse(this.textBoxEnQ.Text);
				if (queue.Enqueue(val) == false)
					MessageBox.Show("Queue is full");
				this.textBoxEnQ.Text = "";
				//this.richTextBoxQueueContent.Text = queue.Print();
				PrintQueue();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void buttonDeQ_Click(object sender, EventArgs e)
		{
			try
			{
				int val = -1;
				if (queue.Dequeue(ref val) == false)
					MessageBox.Show("Queue is empty");
				else
				{
					this.textBoxDeQ.Text = val.ToString();
					PrintQueue();
					//this.richTextBoxQueueContent.Text = queue.Print();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void PrintQueue()
		{
			this.richTextBoxQueueContent.Text = queue.Print() + "\n\n\n";
			this.richTextBoxQueueContent.Text += queue.PrintArray();
		}

		private void buttonHeadIndex_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Head Index : " + queue.HeadIndex().ToString());
		}

		private void buttonHeadVal_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Head Value : " + queue.HeadValue().ToString());
		}

		private void buttonTailIndex_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Tail Index : " + queue.TailIndex().ToString());
		}

		private void buttonTailVal_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Tail Value: " + queue.TailValue().ToString());
		}
	}
}