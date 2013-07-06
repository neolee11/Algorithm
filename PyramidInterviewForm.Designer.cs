namespace Algorithms
{
    partial class PyramidInterviewForm
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
            this.buttonDistinct = new System.Windows.Forms.Button();
            this.buttonNesting = new System.Windows.Forms.Button();
            this.buttonMagPole = new System.Windows.Forms.Button();
            this.buttonCycleLen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDistinct
            // 
            this.buttonDistinct.Location = new System.Drawing.Point(12, 12);
            this.buttonDistinct.Name = "buttonDistinct";
            this.buttonDistinct.Size = new System.Drawing.Size(90, 23);
            this.buttonDistinct.TabIndex = 0;
            this.buttonDistinct.Text = "Distinct Values";
            this.buttonDistinct.UseVisualStyleBackColor = true;
            this.buttonDistinct.Click += new System.EventHandler(this.buttonDistinct_Click);
            // 
            // buttonNesting
            // 
            this.buttonNesting.Location = new System.Drawing.Point(12, 41);
            this.buttonNesting.Name = "buttonNesting";
            this.buttonNesting.Size = new System.Drawing.Size(90, 23);
            this.buttonNesting.TabIndex = 1;
            this.buttonNesting.Text = "Properly Nested";
            this.buttonNesting.UseVisualStyleBackColor = true;
            this.buttonNesting.Click += new System.EventHandler(this.buttonNesting_Click);
            // 
            // buttonMagPole
            // 
            this.buttonMagPole.Location = new System.Drawing.Point(12, 70);
            this.buttonMagPole.Name = "buttonMagPole";
            this.buttonMagPole.Size = new System.Drawing.Size(90, 23);
            this.buttonMagPole.TabIndex = 2;
            this.buttonMagPole.Text = "Magnitube Pole";
            this.buttonMagPole.UseVisualStyleBackColor = true;
            this.buttonMagPole.Click += new System.EventHandler(this.buttonMagPole_Click);
            // 
            // buttonCycleLen
            // 
            this.buttonCycleLen.Location = new System.Drawing.Point(12, 99);
            this.buttonCycleLen.Name = "buttonCycleLen";
            this.buttonCycleLen.Size = new System.Drawing.Size(90, 23);
            this.buttonCycleLen.TabIndex = 3;
            this.buttonCycleLen.Text = "CycleLength";
            this.buttonCycleLen.UseVisualStyleBackColor = true;
            this.buttonCycleLen.Click += new System.EventHandler(this.buttonCycleLen_Click);
            // 
            // PyramidInterviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.buttonCycleLen);
            this.Controls.Add(this.buttonMagPole);
            this.Controls.Add(this.buttonNesting);
            this.Controls.Add(this.buttonDistinct);
            this.Name = "PyramidInterviewForm";
            this.Text = "PyramidInterviewForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDistinct;
        private System.Windows.Forms.Button buttonNesting;
        private System.Windows.Forms.Button buttonMagPole;
        private System.Windows.Forms.Button buttonCycleLen;
    }
}