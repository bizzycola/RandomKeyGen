namespace RandomKeyGen
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.genBtn = new System.Windows.Forms.Button();
            this.symBox = new System.Windows.Forms.CheckBox();
            this.upperBox = new System.Windows.Forms.CheckBox();
            this.lowerBox = new System.Windows.Forms.CheckBox();
            this.numBox = new System.Windows.Forms.CheckBox();
            this.outBox = new System.Windows.Forms.TextBox();
            this.lenBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numKeys = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lenBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKeys)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numKeys);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lenBox);
            this.panel1.Controls.Add(this.genBtn);
            this.panel1.Controls.Add(this.symBox);
            this.panel1.Controls.Add(this.upperBox);
            this.panel1.Controls.Add(this.lowerBox);
            this.panel1.Controls.Add(this.numBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 205);
            this.panel1.TabIndex = 5;
            // 
            // genBtn
            // 
            this.genBtn.Location = new System.Drawing.Point(3, 158);
            this.genBtn.Name = "genBtn";
            this.genBtn.Size = new System.Drawing.Size(75, 25);
            this.genBtn.TabIndex = 9;
            this.genBtn.Text = "Generate";
            this.genBtn.UseVisualStyleBackColor = true;
            this.genBtn.Click += new System.EventHandler(this.genBtn_Click);
            // 
            // symBox
            // 
            this.symBox.AutoSize = true;
            this.symBox.Location = new System.Drawing.Point(3, 76);
            this.symBox.Name = "symBox";
            this.symBox.Size = new System.Drawing.Size(65, 17);
            this.symBox.TabIndex = 8;
            this.symBox.Text = "Symbols";
            this.symBox.UseVisualStyleBackColor = true;
            // 
            // upperBox
            // 
            this.upperBox.AutoSize = true;
            this.upperBox.Location = new System.Drawing.Point(3, 53);
            this.upperBox.Name = "upperBox";
            this.upperBox.Size = new System.Drawing.Size(136, 17);
            this.upperBox.TabIndex = 7;
            this.upperBox.Text = "Uppercase Letters(A-Z)";
            this.upperBox.UseVisualStyleBackColor = true;
            // 
            // lowerBox
            // 
            this.lowerBox.AutoSize = true;
            this.lowerBox.Location = new System.Drawing.Point(3, 30);
            this.lowerBox.Name = "lowerBox";
            this.lowerBox.Size = new System.Drawing.Size(133, 17);
            this.lowerBox.TabIndex = 6;
            this.lowerBox.Text = "Lowercase Letters(a-z)";
            this.lowerBox.UseVisualStyleBackColor = true;
            // 
            // numBox
            // 
            this.numBox.AutoSize = true;
            this.numBox.Location = new System.Drawing.Point(3, 7);
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(89, 17);
            this.numBox.TabIndex = 5;
            this.numBox.Text = "Numbers(1-9)";
            this.numBox.UseVisualStyleBackColor = true;
            // 
            // outBox
            // 
            this.outBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outBox.Location = new System.Drawing.Point(0, 205);
            this.outBox.Multiline = true;
            this.outBox.Name = "outBox";
            this.outBox.Size = new System.Drawing.Size(543, 225);
            this.outBox.TabIndex = 6;
            // 
            // lenBox
            // 
            this.lenBox.Location = new System.Drawing.Point(52, 96);
            this.lenBox.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.lenBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lenBox.Name = "lenBox";
            this.lenBox.Size = new System.Drawing.Size(61, 20);
            this.lenBox.TabIndex = 10;
            this.lenBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Length:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Generate";
            // 
            // numKeys
            // 
            this.numKeys.Location = new System.Drawing.Point(52, 123);
            this.numKeys.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numKeys.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKeys.Name = "numKeys";
            this.numKeys.Size = new System.Drawing.Size(61, 20);
            this.numKeys.TabIndex = 13;
            this.numKeys.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "key(s)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 430);
            this.Controls.Add(this.outBox);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Random Key Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lenBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKeys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button genBtn;
        private System.Windows.Forms.CheckBox symBox;
        private System.Windows.Forms.CheckBox upperBox;
        private System.Windows.Forms.CheckBox lowerBox;
        private System.Windows.Forms.CheckBox numBox;
        private System.Windows.Forms.TextBox outBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown lenBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numKeys;
        private System.Windows.Forms.Label label2;
    }
}

