using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class StaffUpdate : Form
    {
        private int currentPagePanel;
        GymSystemEntities Context = new GymSystemEntities();

        public StaffUpdate(int currentPagePanel)
        {
            InitializeComponent();
            this.currentPagePanel = currentPagePanel;
        }

        private void Form1_Load(object sender, EventArgs e) {}

        private void panel2_Paint(object sender, PaintEventArgs e) {}

        private void Update_FactorFullName_TextChanged(object sender, EventArgs e) { }

        private void Update_FactorJobTitle_TextChanged(object sender, EventArgs e) {}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void Update_FactorPhone_TextChanged(object sender, EventArgs e){}

        private void Update_FactorAge_TextChanged(object sender, EventArgs e) { }

        private void Update_FactorHireDate_TextChanged(object sender, EventArgs e){ }

        private void Update_FactorSalary_TextChanged(object sender, EventArgs e) {}




        private void StaffUpdate_Load(object sender, EventArgs e)
        {
            try
            {
                Staff staffFromDatabase = Context.Staffs.FirstOrDefault(c => c.ID == currentPagePanel);

                if (staffFromDatabase != null)
                {
                    Update_FactorFullName.Text = staffFromDatabase.Name;
                    Update_FactorJobTitle.Text = staffFromDatabase.JobTitle;
                    Update_FactorSalary.Text = staffFromDatabase.Salary.ToString();
                    Update_FactorHireDate.Text = staffFromDatabase.HireDate.ToString();
                    Update_FactorAge.Text = staffFromDatabase.Age.ToString();
                    Update_FactorPhone.Text = staffFromDatabase.Phone.ToString();

                    Update_FactorGender.SelectedValue = staffFromDatabase.Gender;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void Update_FactorBtn_Click(object sender, EventArgs e)
        {
            if (ValidateFactorInput())
            {
                Staff staffFromDatabase = Context.Staffs.FirstOrDefault(c => c.ID == currentPagePanel);
                if (staffFromDatabase != null)
                {
                    staffFromDatabase.Name = Update_FactorFullName.Text;
                    staffFromDatabase.JobTitle = Update_FactorJobTitle.Text;
                    staffFromDatabase.Salary = Convert.ToInt32(Update_FactorSalary.Text);
                    staffFromDatabase.Phone = Update_FactorPhone.Text.PadRight(12).Substring(0, 12);
                    staffFromDatabase.Age = Convert.ToInt32(Update_FactorAge.Text);
                    staffFromDatabase.Gender = Update_FactorGender.Text;

                    try
                    {
                        Context.SaveChanges();
                        MessageBox.Show("Update successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private bool ValidateFactorInput()
        {
            if (string.IsNullOrWhiteSpace(Update_FactorJobTitle.Text))
            {
                MessageBox.Show("Job title is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Update_FactorJobTitle.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Job title should not contain numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(Update_FactorPhone.Text) || Update_FactorPhone.Text.Length != 11 || !Update_FactorPhone.Text.All(char.IsDigit))
            {
                MessageBox.Show("Phone should contain exactly 11 digits and only numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(Update_FactorSalary.Text, out int salary) || salary < 0 || salary > 10000)
            {
                MessageBox.Show("Invalid salary. Please enter a valid number between 0 and 10000.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(Update_FactorGender.Text))
            {
                MessageBox.Show("Gender is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true; 
        }


    }
}
