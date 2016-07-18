namespace winFormConvert
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
            this.txtEur = new System.Windows.Forms.TextBox();
            this.txtChf = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.rbtChf = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtEur = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEur
            // 
            this.txtEur.Location = new System.Drawing.Point(96, 41);
            this.txtEur.Name = "txtEur";
            this.txtEur.Size = new System.Drawing.Size(100, 22);
            this.txtEur.TabIndex = 0;
            // 
            // txtChf
            // 
            this.txtChf.Location = new System.Drawing.Point(96, 7);
            this.txtChf.Name = "txtChf";
            this.txtChf.Size = new System.Drawing.Size(100, 22);
            this.txtChf.TabIndex = 1;
            this.txtChf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChf_KeyDown);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(175, 96);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(268, 96);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rbtChf
            // 
            this.rbtChf.AutoSize = true;
            this.rbtChf.Location = new System.Drawing.Point(6, 21);
            this.rbtChf.Name = "rbtChf";
            this.rbtChf.Size = new System.Drawing.Size(77, 21);
            this.rbtChf.TabIndex = 5;
            this.rbtChf.TabStop = true;
            this.rbtChf.Text = "To CHF";
            this.rbtChf.UseVisualStyleBackColor = true;
            this.rbtChf.CheckedChanged += new System.EventHandler(this.rbtChf_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtEur);
            this.groupBox1.Controls.Add(this.rbtChf);
            this.groupBox1.Location = new System.Drawing.Point(374, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 83);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversion";
            // 
            // rbtEur
            // 
            this.rbtEur.AutoSize = true;
            this.rbtEur.Location = new System.Drawing.Point(6, 48);
            this.rbtEur.Name = "rbtEur";
            this.rbtEur.Size = new System.Drawing.Size(79, 21);
            this.rbtEur.TabIndex = 6;
            this.rbtEur.TabStop = true;
            this.rbtEur.Text = "To EUR";
            this.rbtEur.UseVisualStyleBackColor = true;
            this.rbtEur.CheckedChanged += new System.EventHandler(this.rbtEur_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "CHF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "EUR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 140);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtChf);
            this.Controls.Add(this.txtEur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEur;
        private System.Windows.Forms.TextBox txtChf;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton rbtChf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtEur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

