namespace WindowsFormsApp1
{
    partial class StaffUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffUpdate));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Vein = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Update_FactorBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Update_FactorGender = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Update_FactorSalary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Update_FactorHireDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Update_FactorAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Update_FactorPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Update_FactorJobTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Update_FactorFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 667);
            this.panel1.TabIndex = 0;
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
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 372);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Update_FactorBtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Update_FactorGender);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.Update_FactorSalary);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Update_FactorHireDate);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Update_FactorAge);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Update_FactorPhone);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Update_FactorJobTitle);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Update_FactorFullName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(467, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 667);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Update_FactorBtn
            // 
            this.Update_FactorBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Update_FactorBtn.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_FactorBtn.ForeColor = System.Drawing.Color.White;
            this.Update_FactorBtn.Location = new System.Drawing.Point(47, 571);
            this.Update_FactorBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Update_FactorBtn.Name = "Update_FactorBtn";
            this.Update_FactorBtn.Size = new System.Drawing.Size(517, 81);
            this.Update_FactorBtn.TabIndex = 16;
            this.Update_FactorBtn.Text = "Update";
            this.Update_FactorBtn.UseVisualStyleBackColor = false;
            this.Update_FactorBtn.Click += new System.EventHandler(this.Update_FactorBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Factor";
            // 
            // Update_FactorGender
            // 
            this.Update_FactorGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Update_FactorGender.FormattingEnabled = true;
            this.Update_FactorGender.Items.AddRange(new object[] {
            "Male ",
            "Female"});
            this.Update_FactorGender.Location = new System.Drawing.Point(315, 283);
            this.Update_FactorGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update_FactorGender.Name = "Update_FactorGender";
            this.Update_FactorGender.Size = new System.Drawing.Size(249, 44);
            this.Update_FactorGender.TabIndex = 17;
            this.Update_FactorGender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(309, 249);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "Gender :";
            // 
            // Update_FactorSalary
            // 
            this.Update_FactorSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_FactorSalary.Location = new System.Drawing.Point(312, 492);
            this.Update_FactorSalary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Update_FactorSalary.Multiline = true;
            this.Update_FactorSalary.Name = "Update_FactorSalary";
            this.Update_FactorSalary.Size = new System.Drawing.Size(251, 57);
            this.Update_FactorSalary.TabIndex = 12;
            this.Update_FactorSalary.TextChanged += new System.EventHandler(this.Update_FactorSalary_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(307, 458);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Salary :";
            // 
            // Update_FactorHireDate
            // 
            this.Update_FactorHireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_FactorHireDate.Location = new System.Drawing.Point(47, 492);
            this.Update_FactorHireDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Update_FactorHireDate.Multiline = true;
            this.Update_FactorHireDate.Name = "Update_FactorHireDate";
            this.Update_FactorHireDate.ReadOnly = true;
            this.Update_FactorHireDate.Size = new System.Drawing.Size(249, 57);
            this.Update_FactorHireDate.TabIndex = 10;
            this.Update_FactorHireDate.TextChanged += new System.EventHandler(this.Update_FactorHireDate_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 458);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "Hire Date :";
            // 
            // Update_FactorAge
            // 
            this.Update_FactorAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_FactorAge.Location = new System.Drawing.Point(315, 388);
            this.Update_FactorAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Update_FactorAge.Multiline = true;
            this.Update_FactorAge.Name = "Update_FactorAge";
            this.Update_FactorAge.Size = new System.Drawing.Size(249, 43);
            this.Update_FactorAge.TabIndex = 8;
            this.Update_FactorAge.TextChanged += new System.EventHandler(this.Update_FactorAge_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(308, 354);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Age :";
            // 
            // Update_FactorPhone
            // 
            this.Update_FactorPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_FactorPhone.Location = new System.Drawing.Point(49, 388);
            this.Update_FactorPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Update_FactorPhone.Multiline = true;
            this.Update_FactorPhone.Name = "Update_FactorPhone";
            this.Update_FactorPhone.Size = new System.Drawing.Size(249, 43);
            this.Update_FactorPhone.TabIndex = 6;
            this.Update_FactorPhone.TextChanged += new System.EventHandler(this.Update_FactorPhone_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 354);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone :";
            // 
            // Update_FactorJobTitle
            // 
            this.Update_FactorJobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_FactorJobTitle.Location = new System.Drawing.Point(49, 283);
            this.Update_FactorJobTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Update_FactorJobTitle.Multiline = true;
            this.Update_FactorJobTitle.Name = "Update_FactorJobTitle";
            this.Update_FactorJobTitle.Size = new System.Drawing.Size(249, 43);
            this.Update_FactorJobTitle.TabIndex = 4;
            this.Update_FactorJobTitle.TextChanged += new System.EventHandler(this.Update_FactorJobTitle_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Job Title :";
            // 
            // Update_FactorFullName
            // 
            this.Update_FactorFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_FactorFullName.Location = new System.Drawing.Point(49, 182);
            this.Update_FactorFullName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Update_FactorFullName.Multiline = true;
            this.Update_FactorFullName.Name = "Update_FactorFullName";
            this.Update_FactorFullName.Size = new System.Drawing.Size(515, 43);
            this.Update_FactorFullName.TabIndex = 2;
            this.Update_FactorFullName.TextChanged += new System.EventHandler(this.Update_FactorFullName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name :";
            // 
            // StaffUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 667);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StaffUpdate";
            this.Text = "StaffUpdate";
            this.Load += new System.EventHandler(this.StaffUpdate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Vein;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Update_FactorFullName;
        private System.Windows.Forms.Button Update_FactorBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Update_FactorSalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Update_FactorHireDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Update_FactorAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Update_FactorPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Update_FactorJobTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Update_FactorGender;
    }
}

