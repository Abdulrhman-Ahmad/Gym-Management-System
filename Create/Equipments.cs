using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Equipments : Form
    {
        private string connectionString = "Server=.;Database=GymSystem;Trusted_Connection=True ;TrustServerCertificate=True;";
        public GymSystemEntities Context = new GymSystemEntities();
        public Equipments()
        {
            var classes = Context.Classes.Select(c => c.Name).ToList();
            var classes1 = Context.Classes.ToList();
            InitializeComponent();
            Dictionary<string, int> classIdMap = new Dictionary<string, int>();
            foreach (var c in classes1)
            {
                 combo_Class.Items.Add(c.Name);
            }
        }

        private void Reg_Equipment_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text) && string.IsNullOrWhiteSpace(txt_name.Text))
            {
                v_name.Text = "Please enter a valid name.";
                v_name.ForeColor = Color.Red;

            }

            if (string.IsNullOrWhiteSpace(txt_sariel.Text))
            {
                v_seriel.Text = "Please enter a valid Sariel Number.";
                v_seriel.ForeColor = Color.Red; // Set the text color to red
                return;
            }


            if (string.IsNullOrWhiteSpace(txt_prise.Text) || !int.TryParse(txt_prise.Text, out int age))
            {
                v_price.Text = "Please enter a valid Price.";
                v_price.ForeColor = Color.Red; // Set the text color to red
                return;
            }

            
            DateTime date = dateTimePicker1.Value; // Get the selected date from the DateTimePicker control
            string dateString = date.ToString("yyyy-MM-dd"); // Convert the date to the desired string format
            string name = txt_name.Text;
            int Price = int.Parse(txt_prise.Text);
            string Seriel = txt_sariel.Text;
            //DateTime date = dateTimePicker1.Text.ToString("yyyy-MM-dd");
            string className = combo_Class.SelectedItem.ToString();
            var classid = Context.Classes.FirstOrDefault(c => c.Name == className).ID;
            // Create SQL Insert Statement
            string insertQuery = "INSERT INTO Equipments (Name, Price, SerielNum, DeliveryDate, ClassID) VALUES (@Name, @Price, @SerielNum, @DeliveryDate, @ClassID)";

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
                        command.Parameters.AddWithValue("@Price", Price);
                        command.Parameters.AddWithValue("@SerielNum", Seriel);
                        command.Parameters.AddWithValue("@DeliveryDate", dateString);
                        command.Parameters.AddWithValue("@ClassID", classid);

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
