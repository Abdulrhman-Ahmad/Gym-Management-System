namespace WindowsFormsApp1
{
    partial class EquipmentsUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipmentsUpdate));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Vein = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Update_EquipmentBtn = new System.Windows.Forms.Button();
            this.Update_EquipmentPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Update_EquipmentSerialNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Update_EquipmentFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Update_EquipmentClassName = new System.Windows.Forms.ComboBox();
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
            this.panel1.Size = new System.Drawing.Size(467, 668);
            this.panel1.TabIndex = 2;
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
            this.panel2.Controls.Add(this.Update_EquipmentClassName);
            this.panel2.Controls.Add(this.Update_EquipmentBtn);
            this.panel2.Controls.Add(this.Update_EquipmentPrice);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Update_EquipmentSerialNumber);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Update_EquipmentFullName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(467, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 668);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Update_EquipmentBtn
            // 
            this.Update_EquipmentBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Update_EquipmentBtn.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_EquipmentBtn.ForeColor = System.Drawing.Color.White;
            this.Update_EquipmentBtn.Location = new System.Drawing.Point(47, 571);
            this.Update_EquipmentBtn.Margin = new System.Windows.Forms.Padding(4);
            this.Update_EquipmentBtn.Name = "Update_EquipmentBtn";
            this.Update_EquipmentBtn.Size = new System.Drawing.Size(517, 81);
            this.Update_EquipmentBtn.TabIndex = 16;
            this.Update_EquipmentBtn.Text = "Update";
            this.Update_EquipmentBtn.UseVisualStyleBackColor = false;
            this.Update_EquipmentBtn.Click += new System.EventHandler(this.Update_EquipmentBtn_Click);
            // 
            // Update_EquipmentPrice
            // 
            this.Update_EquipmentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_EquipmentPrice.Location = new System.Drawing.Point(49, 386);
            this.Update_EquipmentPrice.Margin = new System.Windows.Forms.Padding(4);
            this.Update_EquipmentPrice.Multiline = true;
            this.Update_EquipmentPrice.Name = "Update_EquipmentPrice";
            this.Update_EquipmentPrice.Size = new System.Drawing.Size(513, 46);
            this.Update_EquipmentPrice.TabIndex = 8;
            this.Update_EquipmentPrice.TextChanged += new System.EventHandler(this.Update_EquipmentPrice_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 351);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Price ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 458);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Class Name";
            // 
            // Update_EquipmentSerialNumber
            // 
            this.Update_EquipmentSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_EquipmentSerialNumber.Location = new System.Drawing.Point(48, 283);
            this.Update_EquipmentSerialNumber.Margin = new System.Windows.Forms.Padding(4);
            this.Update_EquipmentSerialNumber.Multiline = true;
            this.Update_EquipmentSerialNumber.Name = "Update_EquipmentSerialNumber";
            this.Update_EquipmentSerialNumber.Size = new System.Drawing.Size(515, 46);
            this.Update_EquipmentSerialNumber.TabIndex = 4;
            this.Update_EquipmentSerialNumber.TextChanged += new System.EventHandler(this.Update_EquipmentSerialNumber_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sariel Namder ";
            // 
            // Update_EquipmentFullName
            // 
            this.Update_EquipmentFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_EquipmentFullName.Location = new System.Drawing.Point(49, 182);
            this.Update_EquipmentFullName.Margin = new System.Windows.Forms.Padding(4);
            this.Update_EquipmentFullName.Multiline = true;
            this.Update_EquipmentFullName.Name = "Update_EquipmentFullName";
            this.Update_EquipmentFullName.Size = new System.Drawing.Size(515, 46);
            this.Update_EquipmentFullName.TabIndex = 2;
            this.Update_EquipmentFullName.TextChanged += new System.EventHandler(this.Update_EquipmentFullName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Equipment";
            // 
            // Update_EquipmentClassName
            // 
            this.Update_EquipmentClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Update_EquipmentClassName.FormattingEnabled = true;
            this.Update_EquipmentClassName.Location = new System.Drawing.Point(49, 492);
            this.Update_EquipmentClassName.Name = "Update_EquipmentClassName";
            this.Update_EquipmentClassName.Size = new System.Drawing.Size(513, 44);
            this.Update_EquipmentClassName.TabIndex = 17;
            this.Update_EquipmentClassName.SelectedIndexChanged += new System.EventHandler(this.Update_EquipmentClassName_SelectedIndexChanged);
            // 
            // EquipmentsUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 668);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EquipmentsUpdate";
            this.Text = "Equipments";
            this.Load += new System.EventHandler(this.EquipmentsUpdate_Load);
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
        private System.Windows.Forms.Button Update_EquipmentBtn;
        private System.Windows.Forms.TextBox Update_EquipmentPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Update_EquipmentSerialNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Update_EquipmentFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Update_EquipmentClassName;
    }
}