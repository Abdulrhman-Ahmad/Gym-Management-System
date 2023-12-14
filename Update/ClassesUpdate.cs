using System;
using System.Linq;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;
using System.Runtime.Remoting.Contexts;

namespace WindowsFormsApp1
{
    public partial class ClassesUpdate : Form
    {
        private int currentPagePanel; // Add a field to store the currentPagePanel value

        public ClassesUpdate(int currentPagePanel)
        {
            InitializeComponent();
            this.currentPagePanel = currentPagePanel; // Assign the parameter value to the field
            try
            {
                Class classFromDatabase = Context.Classes.FirstOrDefault(c => c.ID == currentPagePanel);
                if (classFromDatabase != null)
                {
                    Update_ClassName.Text = classFromDatabase.Name;
                    Update_ClassCode.Text = classFromDatabase.Code;
                    Update_ClassFees.Text = classFromDatabase.Fees.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    public void SetClassData(Class classData)
    {
        // Set data on your form controls
        Update_ClassName.Text = classData.Name;
        Update_ClassCode.Text = classData.Code;
        Update_ClassFees.Text = classData.Fees.ToString();
    }
        GymSystemEntities Context = new GymSystemEntities();
        Class Clas = new Class();

        public ClassesUpdate()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        //private void Update_ClassID_TextChanged(object sender, EventArgs e) { }
        private void Update_ClassName_TextChanged(object sender, EventArgs e) { }
        private void Update_ClassCode_TextChanged(object sender, EventArgs e) { }
        private void Update_ClassFees_TextChanged(object sender, EventArgs e) { }




        private void Update_ClassBtn_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Class classToUpdate = Context.Classes.FirstOrDefault(c => c.ID == currentPagePanel);
                if (classToUpdate != null)
                {
                    classToUpdate.Name = Update_ClassName.Text;
                    classToUpdate.Code = Update_ClassCode.Text;
                    classToUpdate.Fees = Convert.ToInt32(Update_ClassFees.Text);

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
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(Update_ClassName.Text))
            {
                MessageBox.Show("Class name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(Update_ClassCode.Text))
            {
                MessageBox.Show("Class code is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(Update_ClassFees.Text, out int fees) || fees < 0 || fees > 5000)
            {
                MessageBox.Show("Invalid class fees. Please enter a valid number between 0 and 5000.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true; 
        }




    }
}
