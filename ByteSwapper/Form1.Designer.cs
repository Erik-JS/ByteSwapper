namespace ByteSwapper
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
            this.btnInput = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.optSwap8 = new System.Windows.Forms.RadioButton();
            this.optSwap4 = new System.Windows.Forms.RadioButton();
            this.optSwap2 = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnSwap = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(221, 33);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(255, 45);
            this.btnInput.TabIndex = 0;
            this.btnInput.Text = "SELECT INPUT FILE";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.optSwap8);
            this.groupBox1.Controls.Add(this.optSwap4);
            this.groupBox1.Controls.Add(this.optSwap2);
            this.groupBox1.Location = new System.Drawing.Point(43, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Swap type";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(156, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 47);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // optSwap8
            // 
            this.optSwap8.AutoSize = true;
            this.optSwap8.Enabled = false;
            this.optSwap8.Location = new System.Drawing.Point(44, 65);
            this.optSwap8.Name = "optSwap8";
            this.optSwap8.Size = new System.Drawing.Size(59, 17);
            this.optSwap8.TabIndex = 2;
            this.optSwap8.TabStop = true;
            this.optSwap8.Text = "8 bytes";
            this.optSwap8.UseVisualStyleBackColor = true;
            // 
            // optSwap4
            // 
            this.optSwap4.AutoSize = true;
            this.optSwap4.Enabled = false;
            this.optSwap4.Location = new System.Drawing.Point(44, 42);
            this.optSwap4.Name = "optSwap4";
            this.optSwap4.Size = new System.Drawing.Size(59, 17);
            this.optSwap4.TabIndex = 1;
            this.optSwap4.TabStop = true;
            this.optSwap4.Text = "4 bytes";
            this.optSwap4.UseVisualStyleBackColor = true;
            // 
            // optSwap2
            // 
            this.optSwap2.AutoSize = true;
            this.optSwap2.Enabled = false;
            this.optSwap2.Location = new System.Drawing.Point(44, 19);
            this.optSwap2.Name = "optSwap2";
            this.optSwap2.Size = new System.Drawing.Size(59, 17);
            this.optSwap2.TabIndex = 0;
            this.optSwap2.TabStop = true;
            this.optSwap2.Text = "2 bytes";
            this.optSwap2.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 331);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(673, 26);
            this.progressBar1.TabIndex = 3;
            // 
            // btnSwap
            // 
            this.btnSwap.Enabled = false;
            this.btnSwap.Location = new System.Drawing.Point(216, 253);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(255, 45);
            this.btnSwap.TabIndex = 4;
            this.btnSwap.Text = "SWAP BYTES NOW!";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.Location = new System.Drawing.Point(12, 98);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(28, 16);
            this.lblInput.TabIndex = 5;
            this.lblInput.Text = ". . .";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(196, 301);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(301, 13);
            this.lblOutput.TabIndex = 6;
            this.lblOutput.Text = "You will be asked whether or not you wish to create a new file.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Example:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Drag and drop is supported.";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 370);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Byte Swapper by Erik JS";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optSwap8;
        private System.Windows.Forms.RadioButton optSwap4;
        private System.Windows.Forms.RadioButton optSwap2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

