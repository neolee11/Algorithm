namespace Algorithms
{
	partial class ArrayProblemsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
			this.buttonMaxContSum = new System.Windows.Forms.Button();
			this.textBoxInput1 = new System.Windows.Forms.TextBox();
			this.textBoxInput2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonCalcSums = new System.Windows.Forms.Button();
			this.buttonInterlace = new System.Windows.Forms.Button();
			this.buttonRotate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// richTextBoxOutput
			// 
			this.richTextBoxOutput.Location = new System.Drawing.Point(12, 177);
			this.richTextBoxOutput.Name = "richTextBoxOutput";
			this.richTextBoxOutput.Size = new System.Drawing.Size(564, 152);
			this.richTextBoxOutput.TabIndex = 0;
			this.richTextBoxOutput.Text = "";
			// 
			// buttonMaxContSum
			// 
			this.buttonMaxContSum.Location = new System.Drawing.Point(12, 12);
			this.buttonMaxContSum.Name = "buttonMaxContSum";
			this.buttonMaxContSum.Size = new System.Drawing.Size(124, 23);
			this.buttonMaxContSum.TabIndex = 2;
			this.buttonMaxContSum.Text = "Max Contiguous Sum";
			this.buttonMaxContSum.UseVisualStyleBackColor = true;
			this.buttonMaxContSum.Click += new System.EventHandler(this.buttonMaxContSum_Click);
			// 
			// textBoxInput1
			// 
			this.textBoxInput1.Location = new System.Drawing.Point(64, 58);
			this.textBoxInput1.Name = "textBoxInput1";
			this.textBoxInput1.Size = new System.Drawing.Size(100, 20);
			this.textBoxInput1.TabIndex = 3;
			// 
			// textBoxInput2
			// 
			this.textBoxInput2.Location = new System.Drawing.Point(64, 102);
			this.textBoxInput2.Name = "textBoxInput2";
			this.textBoxInput2.Size = new System.Drawing.Size(100, 20);
			this.textBoxInput2.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Input 1 : ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 105);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Input 2 : ";
			// 
			// buttonCalcSums
			// 
			this.buttonCalcSums.Location = new System.Drawing.Point(170, 100);
			this.buttonCalcSums.Name = "buttonCalcSums";
			this.buttonCalcSums.Size = new System.Drawing.Size(79, 23);
			this.buttonCalcSums.TabIndex = 7;
			this.buttonCalcSums.Text = "Calc Sums";
			this.buttonCalcSums.UseVisualStyleBackColor = true;
			this.buttonCalcSums.Click += new System.EventHandler(this.buttonCalcSums_Click);
			// 
			// buttonInterlace
			// 
			this.buttonInterlace.Location = new System.Drawing.Point(202, 12);
			this.buttonInterlace.Name = "buttonInterlace";
			this.buttonInterlace.Size = new System.Drawing.Size(80, 23);
			this.buttonInterlace.TabIndex = 8;
			this.buttonInterlace.Text = "Interlace";
			this.buttonInterlace.UseVisualStyleBackColor = true;
			this.buttonInterlace.Click += new System.EventHandler(this.buttonInterlace_Click);
			// 
			// buttonRotate
			// 
			this.buttonRotate.Location = new System.Drawing.Point(317, 12);
			this.buttonRotate.Name = "buttonRotate";
			this.buttonRotate.Size = new System.Drawing.Size(80, 23);
			this.buttonRotate.TabIndex = 9;
			this.buttonRotate.Text = "Rotate";
			this.buttonRotate.UseVisualStyleBackColor = true;
			this.buttonRotate.Click += new System.EventHandler(this.buttonRotate_Click);
			// 
			// ArrayProblemsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(590, 341);
			this.Controls.Add(this.buttonRotate);
			this.Controls.Add(this.buttonInterlace);
			this.Controls.Add(this.buttonCalcSums);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxInput2);
			this.Controls.Add(this.textBoxInput1);
			this.Controls.Add(this.buttonMaxContSum);
			this.Controls.Add(this.richTextBoxOutput);
			this.Name = "ArrayProblemsForm";
			this.Text = "ArrayProblemsForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBoxOutput;
		private System.Windows.Forms.Button buttonMaxContSum;
		private System.Windows.Forms.TextBox textBoxInput1;
		private System.Windows.Forms.TextBox textBoxInput2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonCalcSums;
		private System.Windows.Forms.Button buttonInterlace;
		private System.Windows.Forms.Button buttonRotate;
	}
}