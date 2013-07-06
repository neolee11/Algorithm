namespace Algorithms
{
	partial class DPForm
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
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTaskAssignments = new System.Windows.Forms.Button();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelInput = new System.Windows.Forms.Label();
            this.buttonAssemblyLine = new System.Windows.Forms.Button();
            this.buttonLCS = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Location = new System.Drawing.Point(67, 68);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(454, 181);
            this.richTextBoxInput.TabIndex = 0;
            this.richTextBoxInput.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input : ";
            // 
            // buttonTaskAssignments
            // 
            this.buttonTaskAssignments.Location = new System.Drawing.Point(15, 265);
            this.buttonTaskAssignments.Name = "buttonTaskAssignments";
            this.buttonTaskAssignments.Size = new System.Drawing.Size(104, 23);
            this.buttonTaskAssignments.TabIndex = 2;
            this.buttonTaskAssignments.Text = "Task Assignments";
            this.buttonTaskAssignments.UseVisualStyleBackColor = true;
            this.buttonTaskAssignments.Click += new System.EventHandler(this.buttonTaskAssignments_Click);
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(67, 304);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.Size = new System.Drawing.Size(454, 181);
            this.richTextBoxOutput.TabIndex = 3;
            this.richTextBoxOutput.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output : ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(613, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadInputToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadInputToolStripMenuItem
            // 
            this.loadInputToolStripMenuItem.Name = "loadInputToolStripMenuItem";
            this.loadInputToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.loadInputToolStripMenuItem.Text = "Load Input";
            this.loadInputToolStripMenuItem.Click += new System.EventHandler(this.loadInputToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(64, 43);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(40, 13);
            this.labelInput.TabIndex = 6;
            this.labelInput.Text = "Input : ";
            // 
            // buttonAssemblyLine
            // 
            this.buttonAssemblyLine.Location = new System.Drawing.Point(125, 265);
            this.buttonAssemblyLine.Name = "buttonAssemblyLine";
            this.buttonAssemblyLine.Size = new System.Drawing.Size(152, 23);
            this.buttonAssemblyLine.TabIndex = 7;
            this.buttonAssemblyLine.Text = "Assembly Line Scheudling";
            this.buttonAssemblyLine.UseVisualStyleBackColor = true;
            this.buttonAssemblyLine.Click += new System.EventHandler(this.buttonAssemblyLine_Click);
            // 
            // buttonLCS
            // 
            this.buttonLCS.Location = new System.Drawing.Point(283, 265);
            this.buttonLCS.Name = "buttonLCS";
            this.buttonLCS.Size = new System.Drawing.Size(169, 23);
            this.buttonLCS.TabIndex = 8;
            this.buttonLCS.Text = "Longest Common Subsequence";
            this.buttonLCS.UseVisualStyleBackColor = true;
            this.buttonLCS.Click += new System.EventHandler(this.buttonLCS_Click);
            // 
            // DPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 497);
            this.Controls.Add(this.buttonLCS);
            this.Controls.Add(this.buttonAssemblyLine);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.buttonTaskAssignments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxInput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DPForm";
            this.Text = "DPForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBoxInput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonTaskAssignments;
		private System.Windows.Forms.RichTextBox richTextBoxOutput;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadInputToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label labelInput;
		private System.Windows.Forms.Button buttonAssemblyLine;
        private System.Windows.Forms.Button buttonLCS;
	}
}