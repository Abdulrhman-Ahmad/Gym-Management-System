namespace WindowsFormsApp1
{
    partial class ClassesUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassesUpdate));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Vein = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Update_ClassFees = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Update_ClassBtn = new System.Windows.Forms.Button();
            this.Update_ClassCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Update_ClassName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.Vein);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 670);
            this.panel1.TabIndex = 3;
            // 
            // Vein
            // 
            this.Vein.AutoSize = true;
            this.Vein.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vein.ForeColor = System.Drawing.Color.White;
            this.Vein.Location = new System.Drawing.Point(65, 492);
            this.Vein.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Vein.Name = "Vein";
            this.Vein.Size = new System.Drawing.Size(304, 84);
            this.Vein.TabIndex = 1;
            this.Vein.Text = "Vein Gym";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 60);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 372);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Update_ClassFees);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Update_ClassBtn);
            this.panel2.Controls.Add(this.Update_ClassCode);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Update_ClassName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(467, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(605, 670);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Update_ClassFees
            // 
            this.Update_ClassFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_ClassFees.Location = new System.Drawing.Point(53, 412);
            this.Update_ClassFees.Margin = new System.Windows.Forms.Padding(4);
            this.Update_ClassFees.Multiline = true;
            this.Update_ClassFees.Name = "Update_ClassFees";
            this.Update_ClassFees.Size = new System.Drawing.Size(515, 58);
            this.Update_ClassFees.TabIndex = 18;
            this.Update_ClassFees.TextChanged += new System.EventHandler(this.Update_ClassFees_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 377);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Fees :";
            // 
            // Update_ClassBtn
            // 
            this.Update_ClassBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Update_ClassBtn.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_ClassBtn.ForeColor = System.Drawing.Color.White;
            this.Update_ClassBtn.Location = new System.Drawing.Point(47, 507);
            this.Update_ClassBtn.Margin = new System.Windows.Forms.Padding(4);
            this.Update_ClassBtn.Name = "Update_ClassBtn";
            this.Update_ClassBtn.Size = new System.Drawing.Size(517, 81);
            this.Update_ClassBtn.TabIndex = 16;
            this.Update_ClassBtn.Text = "Update";
            this.Update_ClassBtn.UseVisualStyleBackColor = false;
            this.Update_ClassBtn.Click += new System.EventHandler(this.Update_ClassBtn_Click);
            // 
            // Update_ClassCode
            // 
            this.Update_ClassCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_ClassCode.Location = new System.Drawing.Point(53, 300);
            this.Update_ClassCode.Margin = new System.Windows.Forms.Padding(4);
            this.Update_ClassCode.Multiline = true;
            this.Update_ClassCode.Name = "Update_ClassCode";
            this.Update_ClassCode.Size = new System.Drawing.Size(515, 56);
            this.Update_ClassCode.TabIndex = 4;
            this.Update_ClassCode.TextChanged += new System.EventHandler(this.Update_ClassCode_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 265);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Code :";
            // 
            // Update_ClassName
            // 
            this.Update_ClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_ClassName.Location = new System.Drawing.Point(53, 196);
            this.Update_ClassName.Margin = new System.Windows.Forms.Padding(4);
            this.Update_ClassName.Multiline = true;
            this.Update_ClassName.Name = "Update_ClassName";
            this.Update_ClassName.Size = new System.Drawing.Size(515, 51);
            this.Update_ClassName.TabIndex = 2;
            this.Update_ClassName.TextChanged += new System.EventHandler(this.Update_ClassName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Class";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ClassesUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 670);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClassesUpdate";
            this.Text = "Classes";
            this.Load += new System.EventHandler(this.label1_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Vein;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Update_ClassBtn;
        private System.Windows.Forms.TextBox Update_ClassCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Update_ClassName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Update_ClassFees;
        private System.Windows.Forms.Label label4;
    }
}