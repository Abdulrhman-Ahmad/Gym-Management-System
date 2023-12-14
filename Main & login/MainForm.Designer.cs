namespace WindowsFormsApp1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.BTN_Logout = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_Dashboard = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_Equipment = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_Classes = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_Clients = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_Stuff = new Guna.UI2.WinForms.Guna2Button();
            this.label_UserType = new System.Windows.Forms.Label();
            this.label_UserName = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label_CurrentPage = new System.Windows.Forms.Label();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Panel_Main = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_ClassEnrollment = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.guna2Panel1.Controls.Add(this.btn_ClassEnrollment);
            this.guna2Panel1.Controls.Add(this.guna2Separator1);
            this.guna2Panel1.Controls.Add(this.BTN_Logout);
            this.guna2Panel1.Controls.Add(this.BTN_Dashboard);
            this.guna2Panel1.Controls.Add(this.BTN_Equipment);
            this.guna2Panel1.Controls.Add(this.BTN_Classes);
            this.guna2Panel1.Controls.Add(this.BTN_Clients);
            this.guna2Panel1.Controls.Add(this.BTN_Stuff);
            this.guna2Panel1.Controls.Add(this.label_UserType);
            this.guna2Panel1.Controls.Add(this.label_UserName);
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(226, 706);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(3, 58);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(217, 10);
            this.guna2Separator1.TabIndex = 4;
            // 
            // BTN_Logout
            // 
            this.BTN_Logout.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Logout.BorderColor = System.Drawing.Color.White;
            this.BTN_Logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Logout.FillColor = System.Drawing.Color.Transparent;
            this.BTN_Logout.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Logout.ForeColor = System.Drawing.Color.White;
            this.BTN_Logout.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Logout.Image")));
            this.BTN_Logout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BTN_Logout.ImageSize = new System.Drawing.Size(40, 40);
            this.BTN_Logout.Location = new System.Drawing.Point(0, 620);
            this.BTN_Logout.Name = "BTN_Logout";
            this.BTN_Logout.PressedColor = System.Drawing.Color.Transparent;
            this.BTN_Logout.Size = new System.Drawing.Size(226, 67);
            this.BTN_Logout.TabIndex = 3;
            this.BTN_Logout.Text = "  Logout";
            this.BTN_Logout.Click += new System.EventHandler(this.BTN_Logout_Click);
            // 
            // BTN_Dashboard
            // 
            this.BTN_Dashboard.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Dashboard.BorderColor = System.Drawing.Color.White;
            this.BTN_Dashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Dashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Dashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Dashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Dashboard.FillColor = System.Drawing.Color.Transparent;
            this.BTN_Dashboard.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Dashboard.ForeColor = System.Drawing.Color.White;
            this.BTN_Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Dashboard.Image")));
            this.BTN_Dashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BTN_Dashboard.ImageSize = new System.Drawing.Size(40, 40);
            this.BTN_Dashboard.Location = new System.Drawing.Point(0, 80);
            this.BTN_Dashboard.Name = "BTN_Dashboard";
            this.BTN_Dashboard.PressedColor = System.Drawing.Color.Transparent;
            this.BTN_Dashboard.Size = new System.Drawing.Size(226, 67);
            this.BTN_Dashboard.TabIndex = 3;
            this.BTN_Dashboard.Text = "     Dashboard";
            this.BTN_Dashboard.Click += new System.EventHandler(this.BTN_Dashboard_Click);
            // 
            // BTN_Equipment
            // 
            this.BTN_Equipment.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Equipment.BorderColor = System.Drawing.Color.White;
            this.BTN_Equipment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Equipment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Equipment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Equipment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Equipment.FillColor = System.Drawing.Color.Transparent;
            this.BTN_Equipment.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Equipment.ForeColor = System.Drawing.Color.White;
            this.BTN_Equipment.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Equipment.Image")));
            this.BTN_Equipment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BTN_Equipment.ImageSize = new System.Drawing.Size(40, 40);
            this.BTN_Equipment.Location = new System.Drawing.Point(0, 440);
            this.BTN_Equipment.Name = "BTN_Equipment";
            this.BTN_Equipment.PressedColor = System.Drawing.Color.Transparent;
            this.BTN_Equipment.Size = new System.Drawing.Size(226, 67);
            this.BTN_Equipment.TabIndex = 3;
            this.BTN_Equipment.Text = "     Equipment";
            this.BTN_Equipment.Click += new System.EventHandler(this.BTN_Equipment_Click);
            // 
            // BTN_Classes
            // 
            this.BTN_Classes.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Classes.BorderColor = System.Drawing.Color.White;
            this.BTN_Classes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Classes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Classes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Classes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Classes.FillColor = System.Drawing.Color.Transparent;
            this.BTN_Classes.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Classes.ForeColor = System.Drawing.Color.White;
            this.BTN_Classes.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Classes.Image")));
            this.BTN_Classes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BTN_Classes.ImageSize = new System.Drawing.Size(40, 40);
            this.BTN_Classes.Location = new System.Drawing.Point(0, 350);
            this.BTN_Classes.Name = "BTN_Classes";
            this.BTN_Classes.PressedColor = System.Drawing.Color.Transparent;
            this.BTN_Classes.Size = new System.Drawing.Size(226, 67);
            this.BTN_Classes.TabIndex = 3;
            this.BTN_Classes.Text = "  Classes";
            this.BTN_Classes.Click += new System.EventHandler(this.BTN_Classes_Click);
            // 
            // BTN_Clients
            // 
            this.BTN_Clients.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Clients.BorderColor = System.Drawing.Color.White;
            this.BTN_Clients.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Clients.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Clients.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Clients.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Clients.FillColor = System.Drawing.Color.Transparent;
            this.BTN_Clients.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Clients.ForeColor = System.Drawing.Color.White;
            this.BTN_Clients.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Clients.Image")));
            this.BTN_Clients.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BTN_Clients.ImageSize = new System.Drawing.Size(40, 40);
            this.BTN_Clients.Location = new System.Drawing.Point(0, 260);
            this.BTN_Clients.Name = "BTN_Clients";
            this.BTN_Clients.PressedColor = System.Drawing.Color.Transparent;
            this.BTN_Clients.Size = new System.Drawing.Size(226, 67);
            this.BTN_Clients.TabIndex = 3;
            this.BTN_Clients.Text = "  Clients";
            this.BTN_Clients.Click += new System.EventHandler(this.BTN_Clients_Click);
            // 
            // BTN_Stuff
            // 
            this.BTN_Stuff.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Stuff.BorderColor = System.Drawing.Color.White;
            this.BTN_Stuff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Stuff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_Stuff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_Stuff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_Stuff.FillColor = System.Drawing.Color.Transparent;
            this.BTN_Stuff.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Stuff.ForeColor = System.Drawing.Color.White;
            this.BTN_Stuff.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Stuff.Image")));
            this.BTN_Stuff.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BTN_Stuff.ImageSize = new System.Drawing.Size(30, 30);
            this.BTN_Stuff.Location = new System.Drawing.Point(0, 170);
            this.BTN_Stuff.Name = "BTN_Stuff";
            this.BTN_Stuff.PressedColor = System.Drawing.Color.Transparent;
            this.BTN_Stuff.Size = new System.Drawing.Size(226, 67);
            this.BTN_Stuff.TabIndex = 3;
            this.BTN_Stuff.Text = " Stuff";
            this.BTN_Stuff.Click += new System.EventHandler(this.BTN_Stuff_Click);
            // 
            // label_UserType
            // 
            this.label_UserType.AutoSize = true;
            this.label_UserType.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserType.ForeColor = System.Drawing.Color.White;
            this.label_UserType.Location = new System.Drawing.Point(88, 32);
            this.label_UserType.Name = "label_UserType";
            this.label_UserType.Size = new System.Drawing.Size(52, 20);
            this.label_UserType.TabIndex = 2;
            this.label_UserType.Text = "Admin";
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserName.ForeColor = System.Drawing.Color.White;
            this.label_UserName.Location = new System.Drawing.Point(88, 9);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(103, 24);
            this.label_UserName.TabIndex = 2;
            this.label_UserName.Text = "User Name";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Black;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(12, 9);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(56, 46);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 1;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel2.Controls.Add(this.label_CurrentPage);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox3);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Panel2.Location = new System.Drawing.Point(226, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(939, 68);
            this.guna2Panel2.TabIndex = 1;
            // 
            // label_CurrentPage
            // 
            this.label_CurrentPage.AutoSize = true;
            this.label_CurrentPage.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CurrentPage.ForeColor = System.Drawing.Color.White;
            this.label_CurrentPage.Location = new System.Drawing.Point(346, 6);
            this.label_CurrentPage.Name = "label_CurrentPage";
            this.label_CurrentPage.Size = new System.Drawing.Size(160, 47);
            this.label_CurrentPage.TabIndex = 1;
            this.label_CurrentPage.Text = "Vein Gym";
            this.label_CurrentPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.BorderColor = System.Drawing.Color.Bisque;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ControlBox3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(845, 3);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(29, 46);
            this.guna2ControlBox3.TabIndex = 0;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(880, 3);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(27, 46);
            this.guna2ControlBox2.TabIndex = 0;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(913, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(23, 46);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // Panel_Main
            // 
            this.Panel_Main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Main.BackgroundImage")));
            this.Panel_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Main.ForeColor = System.Drawing.Color.Transparent;
            this.Panel_Main.Location = new System.Drawing.Point(226, 68);
            this.Panel_Main.Name = "Panel_Main";
            this.Panel_Main.Size = new System.Drawing.Size(939, 638);
            this.Panel_Main.TabIndex = 1;
            // 
            // btn_ClassEnrollment
            // 
            this.btn_ClassEnrollment.BackColor = System.Drawing.Color.Transparent;
            this.btn_ClassEnrollment.BorderColor = System.Drawing.Color.White;
            this.btn_ClassEnrollment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ClassEnrollment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ClassEnrollment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ClassEnrollment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ClassEnrollment.FillColor = System.Drawing.Color.Transparent;
            this.btn_ClassEnrollment.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClassEnrollment.ForeColor = System.Drawing.Color.White;
            this.btn_ClassEnrollment.Image = ((System.Drawing.Image)(resources.GetObject("btn_ClassEnrollment.Image")));
            this.btn_ClassEnrollment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_ClassEnrollment.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_ClassEnrollment.Location = new System.Drawing.Point(-3, 530);
            this.btn_ClassEnrollment.Name = "btn_ClassEnrollment";
            this.btn_ClassEnrollment.PressedColor = System.Drawing.Color.Transparent;
            this.btn_ClassEnrollment.Size = new System.Drawing.Size(226, 67);
            this.btn_ClassEnrollment.TabIndex = 5;
            this.btn_ClassEnrollment.Text = "       Enrollment";
            this.btn_ClassEnrollment.Click += new System.EventHandler(this.btn_ClassEnrollment_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1165, 706);
            this.Controls.Add(this.Panel_Main);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Panel Panel_Main;
        private Guna.UI2.WinForms.Guna2Button BTN_Logout;
        private Guna.UI2.WinForms.Guna2Button BTN_Equipment;
        private Guna.UI2.WinForms.Guna2Button BTN_Classes;
        private Guna.UI2.WinForms.Guna2Button BTN_Clients;
        private Guna.UI2.WinForms.Guna2Button BTN_Stuff;
        private Guna.UI2.WinForms.Guna2Button BTN_Dashboard;
        public System.Windows.Forms.Label label_UserName;
        public System.Windows.Forms.Label label_UserType;
        private System.Windows.Forms.Label label_CurrentPage;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_ClassEnrollment;
    }
}