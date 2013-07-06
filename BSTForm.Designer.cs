namespace Algorithms
{
	partial class BSTForm
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
			this.circleTree1 = new UI.CustomControl.CircleTree();
			this.btnClearCircle = new System.Windows.Forms.Button();
			this.gbCircleLink = new System.Windows.Forms.GroupBox();
			this.btnEditLikn = new System.Windows.Forms.Button();
			this.btnDelLink = new System.Windows.Forms.Button();
			this.numLinkToY = new System.Windows.Forms.NumericUpDown();
			this.numLinkToX = new System.Windows.Forms.NumericUpDown();
			this.lblLinkToY = new System.Windows.Forms.Label();
			this.lblLinkToX = new System.Windows.Forms.Label();
			this.btnAddLink = new System.Windows.Forms.Button();
			this.numLinkFromY = new System.Windows.Forms.NumericUpDown();
			this.numLinkFromX = new System.Windows.Forms.NumericUpDown();
			this.lblLinkFromY = new System.Windows.Forms.Label();
			this.lblLinkFromX = new System.Windows.Forms.Label();
			this.tbLinkText = new System.Windows.Forms.TextBox();
			this.lblLinkText = new System.Windows.Forms.Label();
			this.gbAddCircle = new System.Windows.Forms.GroupBox();
			this.btnDeleteCircle = new System.Windows.Forms.Button();
			this.btnEditCircle = new System.Windows.Forms.Button();
			this.btnAddCircle = new System.Windows.Forms.Button();
			this.numCircleY = new System.Windows.Forms.NumericUpDown();
			this.numCircleX = new System.Windows.Forms.NumericUpDown();
			this.lblCircleY = new System.Windows.Forms.Label();
			this.lblCircleX = new System.Windows.Forms.Label();
			this.tbCircleText = new System.Windows.Forms.TextBox();
			this.lblCircleText = new System.Windows.Forms.Label();
			this.buttonInsert = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxValue = new System.Windows.Forms.TextBox();
			this.checkBoxRandomGen = new System.Windows.Forms.CheckBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonMax = new System.Windows.Forms.Button();
			this.buttonRandomInsert = new System.Windows.Forms.Button();
			this.buttonMin = new System.Windows.Forms.Button();
			this.buttonPredecessor = new System.Windows.Forms.Button();
			this.buttonParent = new System.Windows.Forms.Button();
			this.buttonChildBranch = new System.Windows.Forms.Button();
			this.buttonSuccessor = new System.Windows.Forms.Button();
			this.buttonLCA = new System.Windows.Forms.Button();
			this.richTextBoxOrder = new System.Windows.Forms.RichTextBox();
			this.buttonPreOrder = new System.Windows.Forms.Button();
			this.buttonInOrder = new System.Windows.Forms.Button();
			this.buttonPostOrder = new System.Windows.Forms.Button();
			this.buttonHeight = new System.Windows.Forms.Button();
			this.gbCircleLink.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numLinkToY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numLinkToX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numLinkFromY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numLinkFromX)).BeginInit();
			this.gbAddCircle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numCircleY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numCircleX)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// circleTree1
			// 
			this.circleTree1.AutoScroll = true;
			this.circleTree1.AutoScrollMinSize = new System.Drawing.Size(300, 300);
			this.circleTree1.BackColor = System.Drawing.SystemColors.Window;
			this.circleTree1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.circleTree1.CircleOutlineWidth = 2;
			this.circleTree1.CircleSize = 20;
			this.circleTree1.GridSize = 20;
			this.circleTree1.Location = new System.Drawing.Point(12, 40);
			this.circleTree1.Name = "circleTree1";
			this.circleTree1.Size = new System.Drawing.Size(1231, 342);
			this.circleTree1.TabIndex = 0;
			// 
			// btnClearCircle
			// 
			this.btnClearCircle.Location = new System.Drawing.Point(328, 541);
			this.btnClearCircle.Name = "btnClearCircle";
			this.btnClearCircle.Size = new System.Drawing.Size(92, 23);
			this.btnClearCircle.TabIndex = 6;
			this.btnClearCircle.Text = "Clear";
			this.btnClearCircle.UseVisualStyleBackColor = true;
			this.btnClearCircle.Click += new System.EventHandler(this.btnClearCircle_Click);
			// 
			// gbCircleLink
			// 
			this.gbCircleLink.Controls.Add(this.btnEditLikn);
			this.gbCircleLink.Controls.Add(this.btnDelLink);
			this.gbCircleLink.Controls.Add(this.numLinkToY);
			this.gbCircleLink.Controls.Add(this.numLinkToX);
			this.gbCircleLink.Controls.Add(this.lblLinkToY);
			this.gbCircleLink.Controls.Add(this.lblLinkToX);
			this.gbCircleLink.Controls.Add(this.btnAddLink);
			this.gbCircleLink.Controls.Add(this.numLinkFromY);
			this.gbCircleLink.Controls.Add(this.numLinkFromX);
			this.gbCircleLink.Controls.Add(this.lblLinkFromY);
			this.gbCircleLink.Controls.Add(this.lblLinkFromX);
			this.gbCircleLink.Controls.Add(this.tbLinkText);
			this.gbCircleLink.Controls.Add(this.lblLinkText);
			this.gbCircleLink.Location = new System.Drawing.Point(311, 422);
			this.gbCircleLink.Name = "gbCircleLink";
			this.gbCircleLink.Size = new System.Drawing.Size(333, 110);
			this.gbCircleLink.TabIndex = 5;
			this.gbCircleLink.TabStop = false;
			this.gbCircleLink.Text = "Add link:";
			// 
			// btnEditLikn
			// 
			this.btnEditLikn.Location = new System.Drawing.Point(246, 48);
			this.btnEditLikn.Name = "btnEditLikn";
			this.btnEditLikn.Size = new System.Drawing.Size(75, 23);
			this.btnEditLikn.TabIndex = 12;
			this.btnEditLikn.Text = "Edit";
			this.btnEditLikn.UseVisualStyleBackColor = true;
			// 
			// btnDelLink
			// 
			this.btnDelLink.Location = new System.Drawing.Point(246, 78);
			this.btnDelLink.Name = "btnDelLink";
			this.btnDelLink.Size = new System.Drawing.Size(75, 23);
			this.btnDelLink.TabIndex = 11;
			this.btnDelLink.Text = "Delete";
			this.btnDelLink.UseVisualStyleBackColor = true;
			// 
			// numLinkToY
			// 
			this.numLinkToY.Location = new System.Drawing.Point(172, 82);
			this.numLinkToY.Name = "numLinkToY";
			this.numLinkToY.Size = new System.Drawing.Size(67, 20);
			this.numLinkToY.TabIndex = 9;
			// 
			// numLinkToX
			// 
			this.numLinkToX.Location = new System.Drawing.Point(53, 82);
			this.numLinkToX.Name = "numLinkToX";
			this.numLinkToX.Size = new System.Drawing.Size(64, 20);
			this.numLinkToX.TabIndex = 7;
			this.numLinkToX.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// lblLinkToY
			// 
			this.lblLinkToY.AutoSize = true;
			this.lblLinkToY.Location = new System.Drawing.Point(133, 84);
			this.lblLinkToY.Name = "lblLinkToY";
			this.lblLinkToY.Size = new System.Drawing.Size(33, 13);
			this.lblLinkToY.TabIndex = 8;
			this.lblLinkToY.Text = "To Y:";
			// 
			// lblLinkToX
			// 
			this.lblLinkToX.AutoSize = true;
			this.lblLinkToX.Location = new System.Drawing.Point(14, 84);
			this.lblLinkToX.Name = "lblLinkToX";
			this.lblLinkToX.Size = new System.Drawing.Size(33, 13);
			this.lblLinkToX.TabIndex = 6;
			this.lblLinkToX.Text = "To X:";
			// 
			// btnAddLink
			// 
			this.btnAddLink.Location = new System.Drawing.Point(245, 18);
			this.btnAddLink.Name = "btnAddLink";
			this.btnAddLink.Size = new System.Drawing.Size(75, 23);
			this.btnAddLink.TabIndex = 10;
			this.btnAddLink.Text = "Add";
			this.btnAddLink.UseVisualStyleBackColor = true;
			// 
			// numLinkFromY
			// 
			this.numLinkFromY.Location = new System.Drawing.Point(172, 51);
			this.numLinkFromY.Name = "numLinkFromY";
			this.numLinkFromY.Size = new System.Drawing.Size(67, 20);
			this.numLinkFromY.TabIndex = 5;
			// 
			// numLinkFromX
			// 
			this.numLinkFromX.Location = new System.Drawing.Point(53, 51);
			this.numLinkFromX.Name = "numLinkFromX";
			this.numLinkFromX.Size = new System.Drawing.Size(64, 20);
			this.numLinkFromX.TabIndex = 3;
			// 
			// lblLinkFromY
			// 
			this.lblLinkFromY.AutoSize = true;
			this.lblLinkFromY.Location = new System.Drawing.Point(123, 53);
			this.lblLinkFromY.Name = "lblLinkFromY";
			this.lblLinkFromY.Size = new System.Drawing.Size(43, 13);
			this.lblLinkFromY.TabIndex = 4;
			this.lblLinkFromY.Text = "From Y:";
			// 
			// lblLinkFromX
			// 
			this.lblLinkFromX.AutoSize = true;
			this.lblLinkFromX.Location = new System.Drawing.Point(4, 53);
			this.lblLinkFromX.Name = "lblLinkFromX";
			this.lblLinkFromX.Size = new System.Drawing.Size(43, 13);
			this.lblLinkFromX.TabIndex = 2;
			this.lblLinkFromX.Text = "From X:";
			// 
			// tbLinkText
			// 
			this.tbLinkText.Location = new System.Drawing.Point(42, 20);
			this.tbLinkText.Name = "tbLinkText";
			this.tbLinkText.Size = new System.Drawing.Size(197, 20);
			this.tbLinkText.TabIndex = 1;
			// 
			// lblLinkText
			// 
			this.lblLinkText.AutoSize = true;
			this.lblLinkText.Location = new System.Drawing.Point(4, 23);
			this.lblLinkText.Name = "lblLinkText";
			this.lblLinkText.Size = new System.Drawing.Size(31, 13);
			this.lblLinkText.TabIndex = 0;
			this.lblLinkText.Text = "Text:";
			// 
			// gbAddCircle
			// 
			this.gbAddCircle.Controls.Add(this.btnDeleteCircle);
			this.gbAddCircle.Controls.Add(this.btnEditCircle);
			this.gbAddCircle.Controls.Add(this.btnAddCircle);
			this.gbAddCircle.Controls.Add(this.numCircleY);
			this.gbAddCircle.Controls.Add(this.numCircleX);
			this.gbAddCircle.Controls.Add(this.lblCircleY);
			this.gbAddCircle.Controls.Add(this.lblCircleX);
			this.gbAddCircle.Controls.Add(this.tbCircleText);
			this.gbAddCircle.Controls.Add(this.lblCircleText);
			this.gbAddCircle.Location = new System.Drawing.Point(12, 422);
			this.gbAddCircle.Name = "gbAddCircle";
			this.gbAddCircle.Size = new System.Drawing.Size(284, 108);
			this.gbAddCircle.TabIndex = 4;
			this.gbAddCircle.TabStop = false;
			this.gbAddCircle.Text = "Add circle:";
			// 
			// btnDeleteCircle
			// 
			this.btnDeleteCircle.Location = new System.Drawing.Point(201, 77);
			this.btnDeleteCircle.Name = "btnDeleteCircle";
			this.btnDeleteCircle.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteCircle.TabIndex = 8;
			this.btnDeleteCircle.Text = "Delete";
			this.btnDeleteCircle.UseVisualStyleBackColor = true;
			// 
			// btnEditCircle
			// 
			this.btnEditCircle.Location = new System.Drawing.Point(201, 47);
			this.btnEditCircle.Name = "btnEditCircle";
			this.btnEditCircle.Size = new System.Drawing.Size(75, 23);
			this.btnEditCircle.TabIndex = 7;
			this.btnEditCircle.Text = "Edit";
			this.btnEditCircle.UseVisualStyleBackColor = true;
			// 
			// btnAddCircle
			// 
			this.btnAddCircle.Location = new System.Drawing.Point(200, 17);
			this.btnAddCircle.Name = "btnAddCircle";
			this.btnAddCircle.Size = new System.Drawing.Size(75, 23);
			this.btnAddCircle.TabIndex = 6;
			this.btnAddCircle.Text = "Add";
			this.btnAddCircle.UseVisualStyleBackColor = true;
			this.btnAddCircle.Click += new System.EventHandler(this.btnAddCircle_Click);
			// 
			// numCircleY
			// 
			this.numCircleY.Location = new System.Drawing.Point(127, 51);
			this.numCircleY.Name = "numCircleY";
			this.numCircleY.Size = new System.Drawing.Size(67, 20);
			this.numCircleY.TabIndex = 5;
			this.numCircleY.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// numCircleX
			// 
			this.numCircleX.Location = new System.Drawing.Point(33, 51);
			this.numCircleX.Name = "numCircleX";
			this.numCircleX.Size = new System.Drawing.Size(64, 20);
			this.numCircleX.TabIndex = 3;
			this.numCircleX.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// lblCircleY
			// 
			this.lblCircleY.AutoSize = true;
			this.lblCircleY.Location = new System.Drawing.Point(103, 53);
			this.lblCircleY.Name = "lblCircleY";
			this.lblCircleY.Size = new System.Drawing.Size(17, 13);
			this.lblCircleY.TabIndex = 4;
			this.lblCircleY.Text = "Y:";
			// 
			// lblCircleX
			// 
			this.lblCircleX.AutoSize = true;
			this.lblCircleX.Location = new System.Drawing.Point(6, 53);
			this.lblCircleX.Name = "lblCircleX";
			this.lblCircleX.Size = new System.Drawing.Size(17, 13);
			this.lblCircleX.TabIndex = 2;
			this.lblCircleX.Text = "X:";
			// 
			// tbCircleText
			// 
			this.tbCircleText.Location = new System.Drawing.Point(44, 20);
			this.tbCircleText.Name = "tbCircleText";
			this.tbCircleText.Size = new System.Drawing.Size(150, 20);
			this.tbCircleText.TabIndex = 1;
			// 
			// lblCircleText
			// 
			this.lblCircleText.AutoSize = true;
			this.lblCircleText.Location = new System.Drawing.Point(6, 23);
			this.lblCircleText.Name = "lblCircleText";
			this.lblCircleText.Size = new System.Drawing.Size(31, 13);
			this.lblCircleText.TabIndex = 0;
			this.lblCircleText.Text = "Text:";
			// 
			// buttonInsert
			// 
			this.buttonInsert.Location = new System.Drawing.Point(221, 570);
			this.buttonInsert.Name = "buttonInsert";
			this.buttonInsert.Size = new System.Drawing.Size(92, 23);
			this.buttonInsert.TabIndex = 7;
			this.buttonInsert.Text = "Insert";
			this.buttonInsert.UseVisualStyleBackColor = true;
			this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 574);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Value :";
			// 
			// textBoxValue
			// 
			this.textBoxValue.Location = new System.Drawing.Point(65, 572);
			this.textBoxValue.Name = "textBoxValue";
			this.textBoxValue.Size = new System.Drawing.Size(150, 20);
			this.textBoxValue.TabIndex = 9;
			// 
			// checkBoxRandomGen
			// 
			this.checkBoxRandomGen.AutoSize = true;
			this.checkBoxRandomGen.Location = new System.Drawing.Point(21, 536);
			this.checkBoxRandomGen.Name = "checkBoxRandomGen";
			this.checkBoxRandomGen.Size = new System.Drawing.Size(158, 17);
			this.checkBoxRandomGen.TabIndex = 10;
			this.checkBoxRandomGen.Text = "Random Generate Numbers";
			this.checkBoxRandomGen.UseVisualStyleBackColor = true;
			this.checkBoxRandomGen.CheckedChanged += new System.EventHandler(this.checkBoxRandomGen_CheckedChanged);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1251, 24);
			this.menuStrip1.TabIndex = 11;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.closeToolStripMenuItem.Text = "Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(328, 570);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(92, 23);
			this.buttonDelete.TabIndex = 12;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonMax
			// 
			this.buttonMax.Location = new System.Drawing.Point(437, 541);
			this.buttonMax.Name = "buttonMax";
			this.buttonMax.Size = new System.Drawing.Size(75, 23);
			this.buttonMax.TabIndex = 13;
			this.buttonMax.Text = "Max Value";
			this.buttonMax.UseVisualStyleBackColor = true;
			this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
			// 
			// buttonRandomInsert
			// 
			this.buttonRandomInsert.Location = new System.Drawing.Point(221, 541);
			this.buttonRandomInsert.Name = "buttonRandomInsert";
			this.buttonRandomInsert.Size = new System.Drawing.Size(92, 23);
			this.buttonRandomInsert.TabIndex = 14;
			this.buttonRandomInsert.Text = "Random Insert";
			this.buttonRandomInsert.UseVisualStyleBackColor = true;
			this.buttonRandomInsert.Click += new System.EventHandler(this.buttonRandomInsert_Click);
			// 
			// buttonMin
			// 
			this.buttonMin.Location = new System.Drawing.Point(518, 541);
			this.buttonMin.Name = "buttonMin";
			this.buttonMin.Size = new System.Drawing.Size(75, 23);
			this.buttonMin.TabIndex = 15;
			this.buttonMin.Text = "Min Value";
			this.buttonMin.UseVisualStyleBackColor = true;
			this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
			// 
			// buttonPredecessor
			// 
			this.buttonPredecessor.Location = new System.Drawing.Point(21, 606);
			this.buttonPredecessor.Name = "buttonPredecessor";
			this.buttonPredecessor.Size = new System.Drawing.Size(92, 23);
			this.buttonPredecessor.TabIndex = 16;
			this.buttonPredecessor.Text = "Predecessor";
			this.buttonPredecessor.UseVisualStyleBackColor = true;
			this.buttonPredecessor.Click += new System.EventHandler(this.buttonPredecessor_Click);
			// 
			// buttonParent
			// 
			this.buttonParent.Location = new System.Drawing.Point(328, 606);
			this.buttonParent.Name = "buttonParent";
			this.buttonParent.Size = new System.Drawing.Size(92, 23);
			this.buttonParent.TabIndex = 17;
			this.buttonParent.Text = "Parent";
			this.buttonParent.UseVisualStyleBackColor = true;
			this.buttonParent.Click += new System.EventHandler(this.buttonParent_Click);
			// 
			// buttonChildBranch
			// 
			this.buttonChildBranch.Location = new System.Drawing.Point(437, 606);
			this.buttonChildBranch.Name = "buttonChildBranch";
			this.buttonChildBranch.Size = new System.Drawing.Size(92, 23);
			this.buttonChildBranch.TabIndex = 18;
			this.buttonChildBranch.Text = "Child Branch";
			this.buttonChildBranch.UseVisualStyleBackColor = true;
			this.buttonChildBranch.Click += new System.EventHandler(this.buttonChildBranch_Click);
			// 
			// buttonSuccessor
			// 
			this.buttonSuccessor.Location = new System.Drawing.Point(123, 606);
			this.buttonSuccessor.Name = "buttonSuccessor";
			this.buttonSuccessor.Size = new System.Drawing.Size(92, 23);
			this.buttonSuccessor.TabIndex = 19;
			this.buttonSuccessor.Text = "Successor";
			this.buttonSuccessor.UseVisualStyleBackColor = true;
			this.buttonSuccessor.Click += new System.EventHandler(this.buttonSuccessor_Click);
			// 
			// buttonLCA
			// 
			this.buttonLCA.Location = new System.Drawing.Point(437, 570);
			this.buttonLCA.Name = "buttonLCA";
			this.buttonLCA.Size = new System.Drawing.Size(138, 23);
			this.buttonLCA.TabIndex = 20;
			this.buttonLCA.Text = "Least Common Ancestor";
			this.buttonLCA.UseVisualStyleBackColor = true;
			this.buttonLCA.Click += new System.EventHandler(this.buttonLCA_Click);
			// 
			// richTextBoxOrder
			// 
			this.richTextBoxOrder.Location = new System.Drawing.Point(682, 533);
			this.richTextBoxOrder.Name = "richTextBoxOrder";
			this.richTextBoxOrder.Size = new System.Drawing.Size(423, 96);
			this.richTextBoxOrder.TabIndex = 21;
			this.richTextBoxOrder.Text = "";
			// 
			// buttonPreOrder
			// 
			this.buttonPreOrder.Location = new System.Drawing.Point(1124, 536);
			this.buttonPreOrder.Name = "buttonPreOrder";
			this.buttonPreOrder.Size = new System.Drawing.Size(75, 23);
			this.buttonPreOrder.TabIndex = 22;
			this.buttonPreOrder.Text = "Pre Order";
			this.buttonPreOrder.UseVisualStyleBackColor = true;
			this.buttonPreOrder.Click += new System.EventHandler(this.buttonPreOrder_Click);
			// 
			// buttonInOrder
			// 
			this.buttonInOrder.Location = new System.Drawing.Point(1125, 572);
			this.buttonInOrder.Name = "buttonInOrder";
			this.buttonInOrder.Size = new System.Drawing.Size(75, 23);
			this.buttonInOrder.TabIndex = 23;
			this.buttonInOrder.Text = "In Order";
			this.buttonInOrder.UseVisualStyleBackColor = true;
			this.buttonInOrder.Click += new System.EventHandler(this.buttonInOrder_Click);
			// 
			// buttonPostOrder
			// 
			this.buttonPostOrder.Location = new System.Drawing.Point(1125, 606);
			this.buttonPostOrder.Name = "buttonPostOrder";
			this.buttonPostOrder.Size = new System.Drawing.Size(75, 23);
			this.buttonPostOrder.TabIndex = 24;
			this.buttonPostOrder.Text = "Post Order";
			this.buttonPostOrder.UseVisualStyleBackColor = true;
			this.buttonPostOrder.Click += new System.EventHandler(this.buttonPostOrder_Click);
			// 
			// buttonHeight
			// 
			this.buttonHeight.Location = new System.Drawing.Point(221, 606);
			this.buttonHeight.Name = "buttonHeight";
			this.buttonHeight.Size = new System.Drawing.Size(92, 23);
			this.buttonHeight.TabIndex = 25;
			this.buttonHeight.Text = "Height";
			this.buttonHeight.UseVisualStyleBackColor = true;
			this.buttonHeight.Click += new System.EventHandler(this.buttonHeight_Click);
			// 
			// BinaryTreeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1251, 641);
			this.Controls.Add(this.buttonHeight);
			this.Controls.Add(this.buttonPostOrder);
			this.Controls.Add(this.buttonInOrder);
			this.Controls.Add(this.buttonPreOrder);
			this.Controls.Add(this.richTextBoxOrder);
			this.Controls.Add(this.buttonLCA);
			this.Controls.Add(this.buttonSuccessor);
			this.Controls.Add(this.buttonChildBranch);
			this.Controls.Add(this.buttonParent);
			this.Controls.Add(this.buttonPredecessor);
			this.Controls.Add(this.buttonMin);
			this.Controls.Add(this.buttonRandomInsert);
			this.Controls.Add(this.buttonMax);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.checkBoxRandomGen);
			this.Controls.Add(this.textBoxValue);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonInsert);
			this.Controls.Add(this.btnClearCircle);
			this.Controls.Add(this.gbCircleLink);
			this.Controls.Add(this.gbAddCircle);
			this.Controls.Add(this.circleTree1);
			this.Controls.Add(this.menuStrip1);
			this.Name = "BinaryTreeForm";
			this.Text = "BinaryTreeForm";
			this.gbCircleLink.ResumeLayout(false);
			this.gbCircleLink.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numLinkToY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numLinkToX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numLinkFromY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numLinkFromX)).EndInit();
			this.gbAddCircle.ResumeLayout(false);
			this.gbAddCircle.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numCircleY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numCircleX)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private UI.CustomControl.CircleTree circleTree1;
		private System.Windows.Forms.Button btnClearCircle;
		private System.Windows.Forms.GroupBox gbCircleLink;
		private System.Windows.Forms.Button btnEditLikn;
		private System.Windows.Forms.Button btnDelLink;
		private System.Windows.Forms.NumericUpDown numLinkToY;
		private System.Windows.Forms.NumericUpDown numLinkToX;
		private System.Windows.Forms.Label lblLinkToY;
		private System.Windows.Forms.Label lblLinkToX;
		private System.Windows.Forms.Button btnAddLink;
		private System.Windows.Forms.NumericUpDown numLinkFromY;
		private System.Windows.Forms.NumericUpDown numLinkFromX;
		private System.Windows.Forms.Label lblLinkFromY;
		private System.Windows.Forms.Label lblLinkFromX;
		private System.Windows.Forms.TextBox tbLinkText;
		private System.Windows.Forms.Label lblLinkText;
		private System.Windows.Forms.GroupBox gbAddCircle;
		private System.Windows.Forms.Button btnDeleteCircle;
		private System.Windows.Forms.Button btnEditCircle;
		private System.Windows.Forms.Button btnAddCircle;
		private System.Windows.Forms.NumericUpDown numCircleY;
		private System.Windows.Forms.NumericUpDown numCircleX;
		private System.Windows.Forms.Label lblCircleY;
		private System.Windows.Forms.Label lblCircleX;
		private System.Windows.Forms.TextBox tbCircleText;
		private System.Windows.Forms.Label lblCircleText;
		private System.Windows.Forms.Button buttonInsert;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxValue;
		private System.Windows.Forms.CheckBox checkBoxRandomGen;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonMax;
		private System.Windows.Forms.Button buttonRandomInsert;
		private System.Windows.Forms.Button buttonMin;
		private System.Windows.Forms.Button buttonPredecessor;
		private System.Windows.Forms.Button buttonParent;
		private System.Windows.Forms.Button buttonChildBranch;
		private System.Windows.Forms.Button buttonSuccessor;
		private System.Windows.Forms.Button buttonLCA;
		private System.Windows.Forms.RichTextBox richTextBoxOrder;
		private System.Windows.Forms.Button buttonPreOrder;
		private System.Windows.Forms.Button buttonInOrder;
		private System.Windows.Forms.Button buttonPostOrder;
		private System.Windows.Forms.Button buttonHeight;
	}
}