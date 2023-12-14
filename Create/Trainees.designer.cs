namespace WindowsFormsApp1
{
    partial class Trainees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trainees));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Vein = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.combo_gender = new System.Windows.Forms.ComboBox();
            this.combo_Class = new System.Windows.Forms.ComboBox();
            this.Reg_Trainess = new System.Windows.Forms.Button();
            this.txt_duration = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Labol = new System.Windows.Forms.Label();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.v_name = new System.Windows.Forms.Label();
            this.v_phonr = new System.Windows.Forms.Label();
            this.v_age = new System.Windows.Forms.Label();
            this.v_duration = new System.Windows.Forms.Label();
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
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.v_duration);
            this.panel2.Controls.Add(this.v_age);
            this.panel2.Controls.Add(this.v_phonr);
            this.panel2.Controls.Add(this.v_name);
            this.panel2.Controls.Add(this.combo_gender);
            this.panel2.Controls.Add(this.combo_Class);
            this.panel2.Controls.Add(this.Reg_Trainess);
            this.panel2.Controls.Add(this.txt_duration);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Labol);
            this.panel2.Controls.Add(this.txt_age);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_phone);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_name);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(350, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 542);
            this.panel2.TabIndex = 2;
            // 
            // combo_gender
            // 
            this.combo_gender.AutoCompleteCustomSource.AddRange(new string[] {
            ""});
            this.combo_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.combo_gender.FormattingEnabled = true;
            this.combo_gender.Location = new System.Drawing.Point(37, 388);
            this.combo_gender.Name = "combo_gender";
            this.combo_gender.Size = new System.Drawing.Size(187, 37);
            this.combo_gender.TabIndex = 20;
            this.combo_gender.SelectedIndexChanged += new System.EventHandler(this.combo_gender_SelectedIndexChanged);
            // 
            // combo_Class
            // 
            this.combo_Class.AutoCompleteCustomSource.AddRange(new string[] {
            ""});
            this.combo_Class.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.combo_Class.FormattingEnabled = true;
            this.combo_Class.Location = new System.Drawing.Point(35, 221);
            this.combo_Class.Name = "combo_Class";
            this.combo_Class.Size = new System.Drawing.Size(387, 37);
            this.combo_Class.TabIndex = 19;
            this.combo_Class.SelectedIndexChanged += new System.EventHandler(this.combo_Class_SelectedIndexChanged);
            // 
            // Reg_Trainess
            // 
            this.Reg_Trainess.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Reg_Trainess.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reg_Trainess.ForeColor = System.Drawing.Color.White;
            this.Reg_Trainess.Location = new System.Drawing.Point(35, 445);
            this.Reg_Trainess.Name = "Reg_Trainess";
            this.Reg_Trainess.Size = new System.Drawing.Size(388, 66);
            this.Reg_Trainess.TabIndex = 16;
            this.Reg_Trainess.Text = "Register";
            this.Reg_Trainess.UseVisualStyleBackColor = false;
            this.Reg_Trainess.Click += new System.EventHandler(this.Reg_Trainess_Click);
            // 
            // txt_duration
            // 
            this.txt_duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_duration.Location = new System.Drawing.Point(235, 387);
            this.txt_duration.Multiline = true;
            this.txt_duration.Name = "txt_duration";
            this.txt_duration.Size = new System.Drawing.Size(189, 38);
            this.txt_duration.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(230, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Duration :";
            // 
            // Labol
            // 
            this.Labol.AutoSize = true;
            this.Labol.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labol.Location = new System.Drawing.Point(31, 359);
            this.Labol.Name = "Labol";
            this.Labol.Size = new System.Drawing.Size(78, 23);
            this.Labol.TabIndex = 9;
            this.Labol.Text = "Gender :";
            // 
            // txt_age
            // 
            this.txt_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_age.Location = new System.Drawing.Point(235, 302);
            this.txt_age.Multiline = true;
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(189, 38);
            this.txt_age.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(230, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Age :";
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.Location = new System.Drawing.Point(36, 302);
            this.txt_phone.Multiline = true;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(188, 38);
            this.txt_phone.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Class :";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(37, 141);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(387, 38);
            this.txt_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Client";
            // 
            // v_name
            // 
            this.v_name.AutoSize = true;
            this.v_name.Location = new System.Drawing.Point(34, 182);
            this.v_name.Name = "v_name";
            this.v_name.Size = new System.Drawing.Size(0, 13);
            this.v_name.TabIndex = 21;
            // 
            // v_phonr
            // 
            this.v_phonr.AutoSize = true;
            this.v_phonr.Location = new System.Drawing.Point(34, 343);
            this.v_phonr.Name = "v_phonr";
            this.v_phonr.Size = new System.Drawing.Size(0, 13);
            this.v_phonr.TabIndex = 22;
            // 
            // v_age
            // 
            this.v_age.AutoSize = true;
            this.v_age.Location = new System.Drawing.Point(232, 343);
            this.v_age.Name = "v_age";
            this.v_age.Size = new System.Drawing.Size(0, 13);
            this.v_age.TabIndex = 23;
            // 
            // v_duration
            // 
            this.v_duration.AutoSize = true;
            this.v_duration.Location = new System.Drawing.Point(232, 429);
            this.v_duration.Name = "v_duration";
            this.v_duration.Size = new System.Drawing.Size(0, 13);
            this.v_duration.TabIndex = 24;
            // 
            // Trainees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 542);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Trainees";
            this.Text = "Aa";
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
        private System.Windows.Forms.Button Reg_Trainess;
        private System.Windows.Forms.TextBox txt_duration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Labol;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_Class;
        private System.Windows.Forms.ComboBox combo_gender;
        private System.Windows.Forms.Label v_duration;
        private System.Windows.Forms.Label v_age;
        private System.Windows.Forms.Label v_phonr;
        private System.Windows.Forms.Label v_name;
    }
}