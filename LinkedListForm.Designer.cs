namespace Algorithms
{
	partial class LinkedListForm
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
			this.buttonRandomInsert = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.textBoxInput = new System.Windows.Forms.TextBox();
			this.buttonInsert = new System.Windows.Forms.Button();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonSort = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonReverse = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonRandomInsert
			// 
			this.buttonRandomInsert.Location = new System.Drawing.Point(29, 27);
			this.buttonRandomInsert.Name = "buttonRandomInsert";
			this.buttonRandomInsert.Size = new System.Drawing.Size(104, 23);
			this.buttonRandomInsert.TabIndex = 13;
			this.buttonRandomInsert.Text = "Random Insert";
			this.buttonRandomInsert.UseVisualStyleBackColor = true;
			this.buttonRandomInsert.Click += new System.EventHandler(this.buttonRandomInsert_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(29, 182);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(375, 96);
			this.richTextBox1.TabIndex = 14;
			this.richTextBox1.Text = "";
			// 
			// textBoxInput
			// 
			this.textBoxInput.Location = new System.Drawing.Point(81, 145);
			this.textBoxInput.Name = "textBoxInput";
			this.textBoxInput.Size = new System.Drawing.Size(165, 20);
			this.textBoxInput.TabIndex = 15;
			// 
			// buttonInsert
			// 
			this.buttonInsert.Location = new System.Drawing.Point(166, 27);
			this.buttonInsert.Name = "buttonInsert";
			this.buttonInsert.Size = new System.Drawing.Size(104, 23);
			this.buttonInsert.TabIndex = 16;
			this.buttonInsert.Text = "Insert";
			this.buttonInsert.UseVisualStyleBackColor = true;
			this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(29, 65);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(104, 23);
			this.buttonSearch.TabIndex = 17;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 145);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 18;
			this.label1.Text = "Input : ";
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(166, 65);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(104, 23);
			this.buttonDelete.TabIndex = 19;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(281, 143);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(123, 23);
			this.buttonUpdate.TabIndex = 20;
			this.buttonUpdate.Text = "Update List Content";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// buttonSort
			// 
			this.buttonSort.Location = new System.Drawing.Point(29, 102);
			this.buttonSort.Name = "buttonSort";
			this.buttonSort.Size = new System.Drawing.Size(104, 23);
			this.buttonSort.TabIndex = 21;
			this.buttonSort.Text = "Sort";
			this.buttonSort.UseVisualStyleBackColor = true;
			this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
			// 
			// buttonClear
			// 
			this.buttonClear.Location = new System.Drawing.Point(166, 102);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(104, 23);
			this.buttonClear.TabIndex = 22;
			this.buttonClear.Text = "Clear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonReverse
			// 
			this.buttonReverse.Location = new System.Drawing.Point(300, 27);
			this.buttonReverse.Name = "buttonReverse";
			this.buttonReverse.Size = new System.Drawing.Size(104, 23);
			this.buttonReverse.TabIndex = 23;
			this.buttonReverse.Text = "Reverse";
			this.buttonReverse.UseVisualStyleBackColor = true;
			this.buttonReverse.Click += new System.EventHandler(this.buttonReverse_Click);
			// 
			// LinkedListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(429, 299);
			this.Controls.Add(this.buttonReverse);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonSort);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.buttonInsert);
			this.Controls.Add(this.textBoxInput);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.buttonRandomInsert);
			this.Name = "LinkedListForm";
			this.Text = "LinkedListForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonRandomInsert;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.TextBox textBoxInput;
		private System.Windows.Forms.Button buttonInsert;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonSort;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Button buttonReverse;
	}
}