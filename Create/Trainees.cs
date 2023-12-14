using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Trainees : Form
    {
        private string connectionString = "Server=.;Database=GymSystem;Trusted_Connection=True ;TrustServerCertificate=True;";
        public Trainees()
        {

            GymSystemEntities Context = new GymSystemEntities();
            var classes = Context.Classes.Select(c => c.Name).ToList();
            InitializeComponent();
            combo_gender.Items.Add("Male");
            combo_gender.Items.Add("Female");
            foreach (var c in classes)
            {
                combo_Class.Items.Add(c);
            }
        }

        private void Reg_Trainess_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text) && string.IsNullOrWhiteSpace(txt_name.Text))
            {
                v_name.Text = "Please enter a valid name.";
                v_name.ForeColor = Color.Red;

            }

            if (string.IsNullOrWhiteSpace(txt_phone.Text))
            {
                v_phonr.Text = "Please enter a valid phone number.";
                v_phonr.ForeColor = Color.Red; // Set the text color to red
                return;
            }


            if (string.IsNullOrWhiteSpace(txt_age.Text) || !int.TryParse(txt_age.Text, out int age))
            {
                v_age.Text = "Please enter a valid age.";
                v_age.ForeColor = Color.Red; // Set the text color to red
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_duration.Text))
            {
                v_duration.Text = "Please enter a valid Duration.";
                v_duration.ForeColor = Color.Red; // Set the text color to red
                return;
            }

            
            string name = txt_name.Text;
            string selectedValue = combo_gender.SelectedItem.ToString();
            string Phone = txt_phone.Text;
            int Age = int.Parse(txt_age.Text);
            string class1 = combo_Class.SelectedItem.ToString();
            string duration = txt_duration.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create a SqlCommand for the stored procedure
                using (SqlCommand command = new SqlCommand("AddTrainee", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters if needed
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@gender", selectedValue);
                    command.Parameters.AddWithValue("@age", Age);
                    command.Parameters.AddWithValue("@phone", Phone);
                    command.Parameters.AddWithValue("@class", class1);
                    command.Parameters.AddWithValue("@duration", duration);

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

        private void combo_Class_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo_gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
