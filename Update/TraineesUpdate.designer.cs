namespace WindowsFormsApp1
{
    partial class TraineesUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraineesUpdate));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Vein = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Update_ClientClassEdit = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Update_ClientGender = new System.Windows.Forms.ComboBox();
            this.Update_ClientClass = new System.Windows.Forms.ComboBox();
            this.Update_ClientBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Update_ClientAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Update_ClientPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Update_ClientFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TraineeIdLabel = new System.Windows.Forms.Label();
            this.DurationComboBox = new System.Windows.Forms.ComboBox();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 542);
            this.panel1.TabIndex = 1;
            // 
            // Vein
            // 
            this.Vein.AutoSize = true;
            this.Vein.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vein.ForeColor = System.Drawing.Color.White;
            this.Vein.Location = new System.Drawing.Point(49, 400);
            this.Vein.Name = "Vein";
            this.Vein.Size = new System.Drawing.Size(244, 67);
            this.Vein.TabIndex = 1;
            this.Vein.Text = "Vein Gym";
            this.Vein.Click += new System.EventHandler(this.Vein_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.DurationLabel);
            this.panel2.Controls.Add(this.DurationComboBox);
            this.panel2.Controls.Add(this.TraineeIdLabel);
            this.panel2.Controls.Add(this.Update_ClientClassEdit);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Update_ClientGender);
            this.panel2.Controls.Add(this.Update_ClientClass);
            this.panel2.Controls.Add(this.Update_ClientBtn);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.Update_ClientAge);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Update_ClientPhone);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Update_ClientFullName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(350, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 542);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Update_ClientClassEdit
            // 
            this.Update_ClientClassEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Update_ClientClassEdit.FormattingEnabled = true;
            this.Update_ClientClassEdit.Location = new System.Drawing.Point(236, 237);
            this.Update_ClientClassEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Update_ClientClassEdit.Name = "Update_ClientClassEdit";
            this.Update_ClientClassEdit.Size = new System.Drawing.Size(188, 37);
            this.Update_ClientClassEdit.TabIndex = 22;
            this.Update_ClientClassEdit.SelectedIndexChanged += new System.EventHandler(this.Update_ClientClassEdit_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(231, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "Edit Class ";
            // 
            // Update_ClientGender
            // 
            this.Update_ClientGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Update_ClientGender.FormattingEnabled = true;
            this.Update_ClientGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Update_ClientGender.Location = new System.Drawing.Point(37, 400);
            this.Update_ClientGender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Update_ClientGender.Name = "Update_ClientGender";
            this.Update_ClientGender.Size = new System.Drawing.Size(187, 37);
            this.Update_ClientGender.TabIndex = 20;
            this.Update_ClientGender.SelectedIndexChanged += new System.EventHandler(this.Update_ClientGender_SelectedIndexChanged);
            // 
            // Update_ClientClass
            // 
            this.Update_ClientClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Update_ClientClass.FormattingEnabled = true;
            this.Update_ClientClass.Location = new System.Drawing.Point(36, 237);
            this.Update_ClientClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Update_ClientClass.Name = "Update_ClientClass";
            this.Update_ClientClass.Size = new System.Drawing.Size(187, 37);
            this.Update_ClientClass.TabIndex = 19;
            this.Update_ClientClass.SelectedIndexChanged += new System.EventHandler(this.Update_ClientClass_SelectedIndexChanged);
            // 
            // Update_ClientBtn
            // 
            this.Update_ClientBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Update_ClientBtn.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_ClientBtn.ForeColor = System.Drawing.Color.White;
            this.Update_ClientBtn.Location = new System.Drawing.Point(35, 464);
            this.Update_ClientBtn.Name = "Update_ClientBtn";
            this.Update_ClientBtn.Size = new System.Drawing.Size(388, 66);
            this.Update_ClientBtn.TabIndex = 16;
            this.Update_ClientBtn.Text = "Update";
            this.Update_ClientBtn.UseVisualStyleBackColor = false;
            this.Update_ClientBtn.Click += new System.EventHandler(this.Update_ClientBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Gender ";
            // 
            // Update_ClientAge
            // 
            this.Update_ClientAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_ClientAge.Location = new System.Drawing.Point(236, 314);
            this.Update_ClientAge.Multiline = true;
            this.Update_ClientAge.Name = "Update_ClientAge";
            this.Update_ClientAge.Size = new System.Drawing.Size(189, 36);
            this.Update_ClientAge.TabIndex = 8;
            this.Update_ClientAge.TextChanged += new System.EventHandler(this.Update_ClientAge_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(232, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Age ";
            // 
            // Update_ClientPhone
            // 
            this.Update_ClientPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_ClientPhone.Location = new System.Drawing.Point(38, 314);
            this.Update_ClientPhone.Multiline = true;
            this.Update_ClientPhone.Name = "Update_ClientPhone";
            this.Update_ClientPhone.Size = new System.Drawing.Size(187, 36);
            this.Update_ClientPhone.TabIndex = 6;
            this.Update_ClientPhone.TextChanged += new System.EventHandler(this.Update_ClientPhone_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Class";
            // 
            // Update_ClientFullName
            // 
            this.Update_ClientFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_ClientFullName.Location = new System.Drawing.Point(37, 148);
            this.Update_ClientFullName.Multiline = true;
            this.Update_ClientFullName.Name = "Update_ClientFullName";
            this.Update_ClientFullName.Size = new System.Drawing.Size(389, 36);
            this.Update_ClientFullName.TabIndex = 2;
            this.Update_ClientFullName.TextChanged += new System.EventHandler(this.Update_ClientFullName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Client";
            // 
            // TraineeIdLabel
            // 
            this.TraineeIdLabel.AutoSize = true;
            this.TraineeIdLabel.Location = new System.Drawing.Point(450, 9);
            this.TraineeIdLabel.Name = "TraineeIdLabel";
            this.TraineeIdLabel.Size = new System.Drawing.Size(0, 13);
            this.TraineeIdLabel.TabIndex = 23;
            this.TraineeIdLabel.Visible = false;
            // 
            // DurationComboBox
            // 
            this.DurationComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.DurationComboBox.FormattingEnabled = true;
            this.DurationComboBox.Location = new System.Drawing.Point(235, 400);
            this.DurationComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.DurationComboBox.Name = "DurationComboBox";
            this.DurationComboBox.Size = new System.Drawing.Size(188, 37);
            this.DurationComboBox.TabIndex = 24;
            this.DurationComboBox.Visible = false;
            // 
            // DurationLabel
            // 
            this.DurationLabel.AllowDrop = true;
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DurationLabel.Location = new System.Drawing.Point(231, 372);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(75, 23);
            this.DurationLabel.TabIndex = 25;
            this.DurationLabel.Text = "Duration";
            this.DurationLabel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(414, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 29);
            this.label6.TabIndex = 26;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // TraineesUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 542);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TraineesUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aa";
            this.Load += new System.EventHandler(this.Update_Client_Load);
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
        private System.Windows.Forms.Button Update_ClientBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Update_ClientAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Update_ClientPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Update_ClientFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Update_ClientClass;
        private System.Windows.Forms.ComboBox Update_ClientClassEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Update_ClientGender;
        private System.Windows.Forms.Label TraineeIdLabel;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.ComboBox DurationComboBox;
        private System.Windows.Forms.Label label6;
    }
}