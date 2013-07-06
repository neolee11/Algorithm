namespace Algorithms
{
	partial class StackAndQueueForm
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
			this.richTextBoxStackContent = new System.Windows.Forms.RichTextBox();
			this.textBoxPush = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonPush = new System.Windows.Forms.Button();
			this.buttonPop = new System.Windows.Forms.Button();
			this.textBoxPop = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.richTextBoxQueueContent = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxDeQ = new System.Windows.Forms.TextBox();
			this.buttonDeQ = new System.Windows.Forms.Button();
			this.buttonEnQ = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxEnQ = new System.Windows.Forms.TextBox();
			this.buttonHeadIndex = new System.Windows.Forms.Button();
			this.buttonHeadVal = new System.Windows.Forms.Button();
			this.buttonTailIndex = new System.Windows.Forms.Button();
			this.buttonTailVal = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// richTextBoxStackContent
			// 
			this.richTextBoxStackContent.Location = new System.Drawing.Point(22, 101);
			this.richTextBoxStackContent.Name = "richTextBoxStackContent";
			this.richTextBoxStackContent.Size = new System.Drawing.Size(277, 157);
			this.richTextBoxStackContent.TabIndex = 0;
			this.richTextBoxStackContent.Text = "";
			// 
			// textBoxPush
			// 
			this.textBoxPush.Location = new System.Drawing.Point(86, 17);
			this.textBoxPush.Name = "textBoxPush";
			this.textBoxPush.Size = new System.Drawing.Size(100, 20);
			this.textBoxPush.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Push Box : ";
			// 
			// buttonPush
			// 
			this.buttonPush.Location = new System.Drawing.Point(205, 17);
			this.buttonPush.Name = "buttonPush";
			this.buttonPush.Size = new System.Drawing.Size(75, 23);
			this.buttonPush.TabIndex = 3;
			this.buttonPush.Text = "Push";
			this.buttonPush.UseVisualStyleBackColor = true;
			this.buttonPush.Click += new System.EventHandler(this.buttonPush_Click);
			// 
			// buttonPop
			// 
			this.buttonPop.Location = new System.Drawing.Point(205, 59);
			this.buttonPop.Name = "buttonPop";
			this.buttonPop.Size = new System.Drawing.Size(75, 23);
			this.buttonPop.TabIndex = 4;
			this.buttonPop.Text = "Pop";
			this.buttonPop.UseVisualStyleBackColor = true;
			this.buttonPop.Click += new System.EventHandler(this.buttonPop_Click);
			// 
			// textBoxPop
			// 
			this.textBoxPop.Location = new System.Drawing.Point(86, 62);
			this.textBoxPop.Name = "textBoxPop";
			this.textBoxPop.Size = new System.Drawing.Size(100, 20);
			this.textBoxPop.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Pop Box : ";
			// 
			// richTextBoxQueueContent
			// 
			this.richTextBoxQueueContent.Location = new System.Drawing.Point(334, 101);
			this.richTextBoxQueueContent.Name = "richTextBoxQueueContent";
			this.richTextBoxQueueContent.Size = new System.Drawing.Size(277, 157);
			this.richTextBoxQueueContent.TabIndex = 7;
			this.richTextBoxQueueContent.Text = "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(337, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Deqeue Box : ";
			// 
			// textBoxDeQ
			// 
			this.textBoxDeQ.Location = new System.Drawing.Point(418, 62);
			this.textBoxDeQ.Name = "textBoxDeQ";
			this.textBoxDeQ.Size = new System.Drawing.Size(100, 20);
			this.textBoxDeQ.TabIndex = 12;
			// 
			// buttonDeQ
			// 
			this.buttonDeQ.Location = new System.Drawing.Point(529, 62);
			this.buttonDeQ.Name = "buttonDeQ";
			this.buttonDeQ.Size = new System.Drawing.Size(75, 23);
			this.buttonDeQ.TabIndex = 11;
			this.buttonDeQ.Text = "DeQueue";
			this.buttonDeQ.UseVisualStyleBackColor = true;
			this.buttonDeQ.Click += new System.EventHandler(this.buttonDeQ_Click);
			// 
			// buttonEnQ
			// 
			this.buttonEnQ.Location = new System.Drawing.Point(529, 15);
			this.buttonEnQ.Name = "buttonEnQ";
			this.buttonEnQ.Size = new System.Drawing.Size(75, 23);
			this.buttonEnQ.TabIndex = 10;
			this.buttonEnQ.Text = "EnQueue";
			this.buttonEnQ.UseVisualStyleBackColor = true;
			this.buttonEnQ.Click += new System.EventHandler(this.buttonEnQ_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(337, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Enqueue Box : ";
			// 
			// textBoxEnQ
			// 
			this.textBoxEnQ.Location = new System.Drawing.Point(418, 17);
			this.textBoxEnQ.Name = "textBoxEnQ";
			this.textBoxEnQ.Size = new System.Drawing.Size(100, 20);
			this.textBoxEnQ.TabIndex = 8;
			// 
			// buttonHeadIndex
			// 
			this.buttonHeadIndex.Location = new System.Drawing.Point(630, 101);
			this.buttonHeadIndex.Name = "buttonHeadIndex";
			this.buttonHeadIndex.Size = new System.Drawing.Size(75, 23);
			this.buttonHeadIndex.TabIndex = 14;
			this.buttonHeadIndex.Text = "Head Index";
			this.buttonHeadIndex.UseVisualStyleBackColor = true;
			this.buttonHeadIndex.Click += new System.EventHandler(this.buttonHeadIndex_Click);
			// 
			// buttonHeadVal
			// 
			this.buttonHeadVal.Location = new System.Drawing.Point(630, 129);
			this.buttonHeadVal.Name = "buttonHeadVal";
			this.buttonHeadVal.Size = new System.Drawing.Size(75, 23);
			this.buttonHeadVal.TabIndex = 15;
			this.buttonHeadVal.Text = "Head Value";
			this.buttonHeadVal.UseVisualStyleBackColor = true;
			this.buttonHeadVal.Click += new System.EventHandler(this.buttonHeadVal_Click);
			// 
			// buttonTailIndex
			// 
			this.buttonTailIndex.Location = new System.Drawing.Point(630, 209);
			this.buttonTailIndex.Name = "buttonTailIndex";
			this.buttonTailIndex.Size = new System.Drawing.Size(75, 23);
			this.buttonTailIndex.TabIndex = 16;
			this.buttonTailIndex.Text = "Tail Index";
			this.buttonTailIndex.UseVisualStyleBackColor = true;
			this.buttonTailIndex.Click += new System.EventHandler(this.buttonTailIndex_Click);
			// 
			// buttonTailVal
			// 
			this.buttonTailVal.Location = new System.Drawing.Point(630, 238);
			this.buttonTailVal.Name = "buttonTailVal";
			this.buttonTailVal.Size = new System.Drawing.Size(75, 23);
			this.buttonTailVal.TabIndex = 17;
			this.buttonTailVal.Text = "Tail Value";
			this.buttonTailVal.UseVisualStyleBackColor = true;
			this.buttonTailVal.Click += new System.EventHandler(this.buttonTailVal_Click);
			// 
			// StackAndQueueForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(731, 285);
			this.Controls.Add(this.buttonTailVal);
			this.Controls.Add(this.buttonTailIndex);
			this.Controls.Add(this.buttonHeadVal);
			this.Controls.Add(this.buttonHeadIndex);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxDeQ);
			this.Controls.Add(this.buttonDeQ);
			this.Controls.Add(this.buttonEnQ);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxEnQ);
			this.Controls.Add(this.richTextBoxQueueContent);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxPop);
			this.Controls.Add(this.buttonPop);
			this.Controls.Add(this.buttonPush);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxPush);
			this.Controls.Add(this.richTextBoxStackContent);
			this.Name = "StackAndQueueForm";
			this.Text = "StackAndQueueForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBoxStackContent;
		private System.Windows.Forms.TextBox textBoxPush;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonPush;
		private System.Windows.Forms.Button buttonPop;
		private System.Windows.Forms.TextBox textBoxPop;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox richTextBoxQueueContent;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxDeQ;
		private System.Windows.Forms.Button buttonDeQ;
		private System.Windows.Forms.Button buttonEnQ;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxEnQ;
		private System.Windows.Forms.Button buttonHeadIndex;
		private System.Windows.Forms.Button buttonHeadVal;
		private System.Windows.Forms.Button buttonTailIndex;
		private System.Windows.Forms.Button buttonTailVal;
	}
}