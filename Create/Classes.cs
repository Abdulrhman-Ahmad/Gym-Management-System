using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Classes : Form
    {
        private string connectionString = "Server=.;Database=GymSystem;Trusted_Connection=True ;TrustServerCertificate=True;";
        public Classes()
        {
            InitializeComponent();
           
        }

        private void reg_class_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text) && string.IsNullOrWhiteSpace(txt_name.Text))
            {
                v_name.Text = "Please enter a valid name.";
                v_name.ForeColor = Color.Red;

            }

            if (string.IsNullOrWhiteSpace(txt_code.Text))
            {
                v_code.Text = "Please enter a valid Code.";
                v_code.ForeColor = Color.Red; // Set the text color to red
                return;
            }


            if (string.IsNullOrWhiteSpace(txt_fees.Text) || !int.TryParse(txt_fees.Text, out int age))
            {
                v_fees.Text = "Please enter a valid Fees.";
                v_fees.ForeColor = Color.Red; // Set the text color to red
                return;
            }

            
            string name = txt_name.Text;
            string Code = txt_code.Text;
            int Fees =int.Parse(txt_fees.Text);

            // Create SQL Insert Statement
            string insertQuery = "INSERT INTO Classes (Name, Code, Fees) VALUES (@Name, @Code, @Fees)";

            // Establish a Database Connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create a SqlCommand
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Set Parameters
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Code", Code);
                        command.Parameters.AddWithValue("@Fees", Fees);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data inserted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Data insertion failed.");
                        }
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
