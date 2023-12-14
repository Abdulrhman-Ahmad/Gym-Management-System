using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Staff_form : Form
    {
        private string connectionString = "Server=.;Database=GymSystem;Trusted_Connection=True ;TrustServerCertificate=True;";

        public Staff_form()
        {
            GymSystemEntities Context = new GymSystemEntities();
            InitializeComponent();
            combo_genderr.Items.Add("Male");
            combo_genderr.Items.Add("Female");
        }

        private void Reg_Factor_Click(object sender, EventArgs e)
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

            if (string.IsNullOrWhiteSpace(txt_salary.Text) || !int.TryParse(txt_salary.Text, out int salary1))
            {
                v_salary.Text = "Please enter a valid salary.";
                v_salary.ForeColor = Color.Red; // Set the text color to red
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_job.Text))
            {
                v_job.Text = "Please enter a valid Job Title.";
                v_job.ForeColor = Color.Red; // Set the text color to red
                return;
            }

            string name = txt_name.Text;
            string job = txt_job.Text;
            string selectedValue = combo_genderr.SelectedItem.ToString();
            string Phone = txt_phone.Text;
            int Age = int.Parse(txt_age.Text);
            int salary = int.Parse(txt_salary.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create a SqlCommand for the stored procedure
                using (SqlCommand command = new SqlCommand("AddStaff", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters if needed
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@gender", selectedValue);
                    command.Parameters.AddWithValue("@age", Age);
                    command.Parameters.AddWithValue("@phone", Phone);
                    command.Parameters.AddWithValue("@jobTitle", job);
                    command.Parameters.AddWithValue("@salary", salary);

                    // Execute the stored procedure
                    command.ExecuteNonQuery();
                    try
                    {
                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected < 0)
                        {
                            MessageBox.Show("Data inserted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Data insertion failed.");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        
    }
}
