using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Algorithms
{
	public partial class DPForm : Form
	{
		private DPTaskAssignmentsClass taskAssignment = new DPTaskAssignmentsClass();
		private DPAssemblyLineSchedulingClass assemblyLineScheduling = new DPAssemblyLineSchedulingClass();

		public DPForm()
		{
			InitializeComponent();
			this.labelInput.Text = "";
		}

		private void loadInputToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.openFileDialog1.InitialDirectory = ".";
			this.openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			this.openFileDialog1.FilterIndex = 1;
			this.openFileDialog1.FileName = "";

			if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				string filePath = this.openFileDialog1.FileName;
				DisplayInputType(filePath);
				StreamReader sr = new StreamReader(filePath);
				this.richTextBoxInput.Text = sr.ReadToEnd();
			}
		}

		private void DisplayInputType(string filePath)
		{
			FileInfo a = new FileInfo(filePath);
			this.labelInput.Text = a.Name;
		}

		private void buttonTaskAssignments_Click(object sender, EventArgs e)
		{
			string input = this.richTextBoxInput.Text;
			string output = taskAssignment.TaskAssignments(input);
			this.richTextBoxOutput.Text = output;
		}

		private void buttonAssemblyLine_Click(object sender, EventArgs e)
		{
			this.richTextBoxOutput.Text = this.assemblyLineScheduling.DP();
		}

        private void buttonLCS_Click(object sender, EventArgs e)
        {
            string str1 = "BACDB";
            string str2 = "BDCB";
            string lcs = "";

            DPLCSClass lcsClass = new DPLCSClass(str1, str2);
            lcs = lcsClass.Solve();

            string input = "Inputs for LCS Problem:" + "\n"
                                        + "String 1: " + str1 + "\n"
                                        + "String 2: " + str2 + "\n";

            this.richTextBoxInput.Text = input;

            this.richTextBoxOutput.Text = input + "\n\n" + "The Longest Common Subsequence is : " + "\n" + lcs + "\n"
                                            + "Length : " + lcs.Length.ToString() + "\n";
        }

	}
}