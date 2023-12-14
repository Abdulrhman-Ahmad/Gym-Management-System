namespace WindowsFormsApp1
{
    partial class Classes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Classes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Vein = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.v_fees = new System.Windows.Forms.Label();
            this.v_code = new System.Windows.Forms.Label();
            this.v_name = new System.Windows.Forms.Label();
            this.txt_fees = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.reg_class = new System.Windows.Forms.Button();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 544);
            this.panel1.TabIndex = 3;
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
            this.panel2.Controls.Add(this.v_fees);
            this.panel2.Controls.Add(this.v_code);
            this.panel2.Controls.Add(this.v_name);
            this.panel2.Controls.Add(this.txt_fees);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.reg_class);
            this.panel2.Controls.Add(this.txt_code);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_name);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(350, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 544);
            this.panel2.TabIndex = 4;
            // 
            // v_fees
            // 
            this.v_fees.AutoSize = true;
            this.v_fees.Location = new System.Drawing.Point(35, 420);
            this.v_fees.Name = "v_fees";
            this.v_fees.Size = new System.Drawing.Size(0, 13);
            this.v_fees.TabIndex = 21;
            // 
            // v_code
            // 
            this.v_code.AutoSize = true;
            this.v_code.Location = new System.Drawing.Point(35, 326);
            this.v_code.Name = "v_code";
            this.v_code.Size = new System.Drawing.Size(0, 13);
            this.v_code.TabIndex = 20;
            // 
            // v_name
            // 
            this.v_name.AutoSize = true;
            this.v_name.Location = new System.Drawing.Point(35, 225);
            this.v_name.Name = "v_name";
            this.v_name.Size = new System.Drawing.Size(0, 13);
            this.v_name.TabIndex = 19;
            // 
            // txt_fees
            // 
            this.txt_fees.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fees.Location = new System.Drawing.Point(38, 379);
            this.txt_fees.Multiline = true;
            this.txt_fees.Name = "txt_fees";
            this.txt_fees.Size = new System.Drawing.Size(387, 38);
            this.txt_fees.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Fees :";
            // 
            // reg_class
            // 
            this.reg_class.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reg_class.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_class.ForeColor = System.Drawing.Color.White;
            this.reg_class.Location = new System.Drawing.Point(35, 446);
            this.reg_class.Name = "reg_class";
            this.reg_class.Size = new System.Drawing.Size(388, 66);
            this.reg_class.TabIndex = 16;
            this.reg_class.Text = "Register";
            this.reg_class.UseVisualStyleBackColor = false;
            this.reg_class.Click += new System.EventHandler(this.reg_class_Click);
            // 
            // txt_code
            // 
            this.txt_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_code.Location = new System.Drawing.Point(38, 285);
            this.txt_code.Multiline = true;
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(387, 38);
            this.txt_code.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Code :";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(38, 184);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(387, 38);
            this.txt_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Class";
            // 
            // Classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 544);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Classes";
            this.Text = "Classes";
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
        private System.Windows.Forms.Button reg_class;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_fees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label v_fees;
        private System.Windows.Forms.Label v_code;
        private System.Windows.Forms.Label v_name;
    }
}