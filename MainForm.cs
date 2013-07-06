using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Algorithms
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void buttonReverseStr_Click(object sender, EventArgs e)
		{
			//MessageBox.Show("Max Int: " + uint.MaxValue.ToString());
			
			char[] input1 = new char[] { 'a', 'b', 'c', 'd', 'e' };
			char[] input2 = new char[] { 'a', 'b', 'c', 'd', 'e', 'f'};

			char[] input = input2;
			char[] output = StringManipulationClass.ReverseString(input);
			string msg = "Input: \n" + StringManipulationClass.PrintCharArray(input) + "\n\n";
			msg += "Output: \n" + StringManipulationClass.PrintCharArray(output) + "\n";

			MessageBox.Show(msg);
		}

		private void buttonRotateVector_Click(object sender, EventArgs e)
		{
			string msg = "";
			int length = 8;
			//int[] arr = MiscelClass.RandomGenerateIntArray(length);
			int[] arr = new int[length];
			for (int i = 0; i < length; i++)
				arr[i] = i + 1;

			string before = MiscelHelperClass.PrintArray(arr);
			msg = "Before: \n" + before;
			int rotateIndex = 5;
			int[] newArr = MiscelAlgorithms.RotateVector(arr, rotateIndex);
			string after = MiscelHelperClass.PrintArray(newArr);
			msg = msg + "\n\n"+ "After rotating " + rotateIndex.ToString() + " positions to the left: \n" + after;
			MessageBox.Show(msg);
		}

		private void buttonPerm_Click(object sender, EventArgs e)
		{
            int length = 4;
            int[] arr = MiscelHelperClass.GenOrderedIntArray(length, 1, 1);
            string result = CombinatoricsClass.Perm(arr, 0, arr.Length - 1);
            MessageBox.Show(result);
		}

        private void buttonCombination_Click(object sender, EventArgs e)
        {
            //string[] arr = new string[2] { "x", "y"};
            //string[] arr = new string[3] { "x", "y", "z" };
            string[] arr = new string[4] { "w", "x", "y", "z" };
            string[] result = CombinatoricsClass.Comb(arr);
            string msg = "";
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == "")
                    msg += "Empty";
                else
                    msg += result[i] + "\n";
            }
            MessageBox.Show(msg);
        }

		private void buttonBST_Click(object sender, EventArgs e)
		{
			BSTForm bstForm = new BSTForm();
			bstForm.Show();
		}

		private void buttonSumOnes_Click(object sender, EventArgs e)
		{
			try
			{
				ulong input =  ulong.Parse(this.textBoxInput.Text);

				ulong result = MiscelAlgorithms.Sum1s(input);
				string msg  = "Number of 1s from 1 to " + input.ToString() + " is : " + result.ToString();
				this.richTextBoxOutput.Text = msg;
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}

		private void buttonCount2s_Click(object sender, EventArgs e)
		{
			try
			{
				int input = int.Parse(this.textBoxInput.Text);

				int result = MiscelAlgorithms.Count2sFrom1ToN(input);
				MessageBox.Show("Number of 2s from 1 to " + input.ToString() + " is : " + result.ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void buttonRunCPT_Click(object sender, EventArgs e)
		{
			MiscelAlgorithms.RunCPU();
		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void buttonSorting_Click(object sender, EventArgs e)
		{
			SortingForm sortingForm = new SortingForm();
			sortingForm.Show();
		}

		private void buttonLinkedList_Click(object sender, EventArgs e)
		{
			LinkedListForm listForm = new LinkedListForm();
			listForm.Show();
		}

		private void buttonDP_Click(object sender, EventArgs e)
		{
			DPForm form = new DPForm();
			form.Show();
		}

		private void buttonStackQueue_Click(object sender, EventArgs e)
		{
			StackAndQueueForm form = new StackAndQueueForm();
			form.Show();
		}

		private void buttonBS_Click(object sender, EventArgs e)
		{
			int[] array = new int[] { 1, 3, 3, 4, 4, 4, 4, 6, 300 };
			int T = 4;
			if(this.textBoxInput.Text.Trim() != "")
				T = int.Parse(this.textBoxInput.Text);

			int index = MiscelAlgorithms.BinarySearchFirstOccurrence(array, T);
			string msg = "Binary Search: Find first occurence of " + T.ToString() + "\n\n";
			msg += "Array Content:\n";
			msg += ArrayProblemsClass.PrintArrayWithIndexAbove(array);

			msg += "\nFound Index: " + index.ToString();

			this.richTextBoxOutput.Text = msg;
		}

		private void buttonFib_Click(object sender, EventArgs e)
		{
			int n = 0;
			try
			{
				n = int.Parse(this.textBoxInput.Text);
			}
			catch (Exception ex)
			{
				n = 5;
			}
			
			int iterRes = MiscelAlgorithms.FibIterVer(n);
			int recurRes = MiscelAlgorithms.FibRecurVer(n);

			string msg = "The " + n.ToString() + "th Fib number is:\n\n";
			msg += "Iterative algorithm: " + iterRes.ToString() + "\n";
			msg += "Recursive algorithm: " + recurRes.ToString() + "\n";
			this.richTextBoxOutput.Text = msg;
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			int a = int.Parse(this.textBoxInput.Text);
			int b = int.Parse(this.textBoxInput2.Text);

			int c = MiscelAlgorithms.Addition(a, b);
			MessageBox.Show(a.ToString() + " + " + b.ToString() + " = " + c.ToString());
		}

		private void buttonAtoI_Click(object sender, EventArgs e)
		{
			string input = textBoxInput.Text;
			int output = StringManipulationClass.StrToInt(input);
			MessageBox.Show(output.ToString());
		}

		private void buttonItoA_Click(object sender, EventArgs e)
		{
			int input = int.Parse(textBoxInput.Text);
			string output = StringManipulationClass.IntToStr(input);
			MessageBox.Show(output);
		}

        private void buttonPyramidInterivew_Click(object sender, EventArgs e)
        {
            PyramidInterviewForm form = new PyramidInterviewForm();
            form.Show();
        }

		
		
	}
}