using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Algorithms
{
	public partial class ArrayProblemsForm : Form
	{
		private ArrayProblemsClass arrayProblems = new ArrayProblemsClass();

		public ArrayProblemsForm()
		{
			InitializeComponent();
		}

		private void buttonMaxContSum_Click(object sender, EventArgs e)
		{
			int[] array = new int[] { 31, -41, 59, 26, -53, 58, 97, -93, -23, 84 };
			int maxL = -1;
			int maxR = -1;
			int maxSum = 0;
			//maxSum = arrayProblems.MaxSubsetSumSimple(array, ref maxL, ref maxR);
			//maxSum = arrayProblems.MaxSubsetSumDC(array, ref maxL, ref maxR);
			maxSum = arrayProblems.MaxSubsetSumDP(array, ref maxL, ref maxR);

			string msg = "Max Sum Problem:\n";
			msg += arrayProblems.PrintArray(array, maxL, maxR);
			msg += "\n\n";
			msg += "Max Sum: " + maxSum.ToString();

			this.richTextBoxOutput.Text = msg;
		}

		private void buttonCalcSums_Click(object sender, EventArgs e)
		{
			try
			{
				int[] array = new int[] { 31, -41, 59, 26, -53, 58, 97, -93, -23, 84 };
				int index1 = int.Parse(textBoxInput1.Text);
				int index2 = int.Parse(textBoxInput2.Text);

				if (index2 < index1)
				{
					int tmp = index1;
					index1 = index2;
					index2 = tmp;
				}
				MessageBox.Show(arrayProblems.CalcSums(array, index1, index2).ToString());
			}
			catch (Exception ex)
			{
				DisplayException(ex);
			}
			
		}

		private void DisplayException(Exception ex)
		{
			MessageBox.Show(ex.ToString());
		}

		private void buttonInterlace_Click(object sender, EventArgs e)
		{
			int[] array1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
			int[] array2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			string msg = "Original Array: \n" + arrayProblems.PrintArray(array1) + "\n";
			arrayProblems.Interlace(array1);
			msg += "After interlacing: \n" + arrayProblems.PrintArray(array1) + "\n\n";

			msg += "Original Array: \n" + arrayProblems.PrintArray(array2) + "\n";
			arrayProblems.Interlace(array2);
			msg += "After interlacing: \n" + arrayProblems.PrintArray(array2);

			this.richTextBoxOutput.Text = msg;
		}

		private void buttonRotate_Click(object sender, EventArgs e)
		{
			int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

			string msg = "Original Array: \n" + arrayProblems.PrintArray(array) + "\n";
			arrayProblems.Rotate(array, 0, array.Length-1);
			msg += "After Rotation: \n" + arrayProblems.PrintArray(array);

			this.richTextBoxOutput.Text = msg;
		}
	}
}