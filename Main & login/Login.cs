using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public int CheckForm = 0;

        GymSystemEntities Context = new GymSystemEntities();
        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Name = "Login";
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Hide();
            signUp.ShowDialog(); 
            this.Close();
            //this.Hide();        
        }


        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Password_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string enteredUsername = Text_UserName.Text;
            string enteredPassword = Text_Password.Text;

            // Check if there is a staff with the entered username
            bool isUserValid = Context.Staffs.Any(staff => staff.username == enteredUsername);
            var userType = Context.Staffs.FirstOrDefault(staff => staff.username == enteredUsername);

            if (isUserValid)
            {
                // A staff with the entered username exists, now check the password
                bool isPasswordValid = Context.Staffs.Any(staff => staff.username == enteredUsername && staff.password == enteredPassword);

                if (isPasswordValid)
                {
                    // Both username and password are correct, proceed to the main form
                    MainForm mainForm = new MainForm();

                    // Pass the logged-in username to the MainForm
                    mainForm.label_UserName.Text = enteredUsername;
                    mainForm.label_UserType.Text = userType.JobTitle;
                    this.Hide();
                    mainForm.ShowDialog(); // Show the MainForm
                    this.Close();
                    //this.Close();
                }
                else
                {
                    // Password is incorrect
                    label_PasswordError.Text = "Wrong Password";
                    label_PasswordError.Visible = true;
                    label_UserError.Visible = false;
                }
            }
            else
            {
                // No staff with the entered username
                label_UserError.Text = "Wrong User Name";
                label_UserError.Visible = true;
                label_PasswordError.Visible = false; // Hide any previous password error
            }
        }



        private void label_UserName_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
