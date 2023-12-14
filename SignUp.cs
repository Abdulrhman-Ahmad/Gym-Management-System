using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SignUp : Form
    {
        public GymSystemEntities Context = new GymSystemEntities();
        public SignUp()
        {
            var classes = Context.Classes.Select(c => c.Name).ToList();
            InitializeComponent();
            combo_gender.Items.Add("Male");
            combo_gender.Items.Add("Female");
            combo_job.Items.Add("Manger");
            combo_job.Items.Add("Trainer");
            combo_job.Items.Add("Receptionist");
        }

        private void Reg_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_name.Text) && string.IsNullOrWhiteSpace(txt_name.Text))
            {
                v_name.Text = "Please enter a valid name.";
                v_name.ForeColor = Color.Red;
                
            }
            
            if (string.IsNullOrWhiteSpace(txt_phone.Text))
            {
                v_phone.Text = "Please enter a valid phone number.";
                v_phone.ForeColor = Color.Red; // Set the text color to red
                return;
            }


            if (string.IsNullOrWhiteSpace(txt_age.Text) || !int.TryParse(txt_age.Text, out int age))
            {
                v_age.Text = "Please enter a valid age.";
                v_age.ForeColor = Color.Red; // Set the text color to red
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_salary.Text) || !int.TryParse(txt_salary.Text, out int salary))
            {
                v_salary.Text = "Please enter a valid salary.";
                v_salary.ForeColor = Color.Red; // Set the text color to red
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_user.Text))
            {
                v_user.Text = "Please enter a valid username.";
                v_user.ForeColor = Color.Red; // Set the text color to red
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_pass.Text))
            {
                v_pass.Text = "Please enter a valid password.";
                v_pass.ForeColor = Color.Red; // Set the text color to red
                return;
            }
            var staff = new Staff
            {
                HireDate = dateTimePicker1.Value,
                Name = txt_name.Text,
                Gender = combo_gender.SelectedItem.ToString(),
                Phone = txt_phone.Text,
                JobTitle = combo_job.SelectedItem.ToString(),
                Age = int.Parse(txt_age.Text),
                Salary = int.Parse(txt_salary.Text),
                username = txt_user.Text,
                password = txt_pass.Text,
            };
            Context.Staffs.Add(staff);
            var rowsAffected = Context.SaveChanges();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Data inserted successfully!");
            }
            else
            {
                MessageBox.Show("Data insertion failed.");
            }
        }

        private bool Ischaracter(string input)
        {
            Regex regex = new Regex(@"^[0-9]+$");
            return regex.IsMatch(input);
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
