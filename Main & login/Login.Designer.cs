namespace WindowsFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_UserName = new System.Windows.Forms.Label();
            this.Text_UserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.label_Password = new System.Windows.Forms.Label();
            this.Text_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_UserError = new System.Windows.Forms.Label();
            this.label_PasswordError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Black;
            this.guna2PictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(363, 251);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 0;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.Click += new System.EventHandler(this.guna2PictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(94, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name";
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserName.ForeColor = System.Drawing.Color.Black;
            this.label_UserName.Location = new System.Drawing.Point(57, 272);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(95, 23);
            this.label_UserName.TabIndex = 2;
            this.label_UserName.Text = "User Name";
            this.label_UserName.Click += new System.EventHandler(this.label_UserName_Click);
            // 
            // Text_UserName
            // 
            this.Text_UserName.AutoSize = true;
            this.Text_UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_UserName.DefaultText = "";
            this.Text_UserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Text_UserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Text_UserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Text_UserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Text_UserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Text_UserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Text_UserName.ForeColor = System.Drawing.Color.Black;
            this.Text_UserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Text_UserName.Location = new System.Drawing.Point(61, 313);
            this.Text_UserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Text_UserName.Name = "Text_UserName";
            this.Text_UserName.PasswordChar = '\0';
            this.Text_UserName.PlaceholderText = "";
            this.Text_UserName.SelectedText = "";
            this.Text_UserName.Size = new System.Drawing.Size(229, 48);
            this.Text_UserName.TabIndex = 3;
            this.Text_UserName.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Black;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(61, 533);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(108, 45);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "Login";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 20;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Black;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(182, 533);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(108, 45);
            this.guna2Button2.TabIndex = 4;
            this.guna2Button2.Text = "Register";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.ForeColor = System.Drawing.Color.Black;
            this.label_Password.Location = new System.Drawing.Point(57, 399);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(80, 23);
            this.label_Password.TabIndex = 2;
            this.label_Password.Text = "Password";
            this.label_Password.Click += new System.EventHandler(this.label_Password_Click);
            // 
            // Text_Password
            // 
            this.Text_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_Password.DefaultText = "";
            this.Text_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Text_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Text_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Text_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Text_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Text_Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Text_Password.ForeColor = System.Drawing.Color.Black;
            this.Text_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Text_Password.Location = new System.Drawing.Point(61, 440);
            this.Text_Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Text_Password.Name = "Text_Password";
            this.Text_Password.PasswordChar = '●';
            this.Text_Password.PlaceholderText = "";
            this.Text_Password.SelectedText = "";
            this.Text_Password.Size = new System.Drawing.Size(229, 48);
            this.Text_Password.TabIndex = 3;
            this.Text_Password.UseSystemPasswordChar = true;
            this.Text_Password.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(227, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vein Gym";
            // 
            // label_UserError
            // 
            this.label_UserError.AutoSize = true;
            this.label_UserError.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserError.ForeColor = System.Drawing.Color.Red;
            this.label_UserError.Location = new System.Drawing.Point(57, 365);
            this.label_UserError.Name = "label_UserError";
            this.label_UserError.Size = new System.Drawing.Size(159, 23);
            this.label_UserError.TabIndex = 2;
            this.label_UserError.Text = "User Error Indicator";
            this.label_UserError.Visible = false;
            this.label_UserError.Click += new System.EventHandler(this.label_UserName_Click);
            // 
            // label_PasswordError
            // 
            this.label_PasswordError.AutoSize = true;
            this.label_PasswordError.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PasswordError.ForeColor = System.Drawing.Color.Red;
            this.label_PasswordError.Location = new System.Drawing.Point(57, 492);
            this.label_PasswordError.Name = "label_PasswordError";
            this.label_PasswordError.Size = new System.Drawing.Size(159, 23);
            this.label_PasswordError.TabIndex = 2;
            this.label_PasswordError.Text = "User Error Indicator";
            this.label_PasswordError.Visible = false;
            this.label_PasswordError.Click += new System.EventHandler(this.label_UserName_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(363, 603);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.Text_Password);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.Text_UserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_PasswordError);
            this.Controls.Add(this.label_UserError);
            this.Controls.Add(this.label_UserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2PictureBox2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_UserName;
        private Guna.UI2.WinForms.Guna2TextBox Text_UserName;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Label label_Password;
        private Guna.UI2.WinForms.Guna2TextBox Text_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_UserError;
        private System.Windows.Forms.Label label_PasswordError;
        public Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

