using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=GymSystem;Integrated Security=True;TrustServerCertificate=True;";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                string query = "SELECT TCE.TraineesID, T.Name AS TraineeName, TCE.ClassID, C.Name AS ClassName " +
                               "FROM [dbo].[Trainees] AS T " +
                               "JOIN [dbo].[TraineesClassesEnrollment] AS TCE ON T.ID = TCE.TraineesID " +
                               "JOIN [dbo].[Classes] AS C ON C.ID = TCE.ClassID";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                dataGridView1.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }
        private void GenerateExcelFile(DataTable dataTable, string filePath)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Data");

                worksheet.Cell(1, 1).InsertTable(dataTable);

                workbook.SaveAs(filePath);
            }
        }

        private void button_Generate_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = (DataTable)dataGridView1.DataSource;

                if (dataTable != null)
                {
                    string filePath = "D:\\iti\\شهر 9\\C#\\Project\\New folder\\Elsayed\\YourExcelFile.xlsx";


                    GenerateExcelFile(dataTable, filePath);

                    MessageBox.Show("Excel file generated successfully.");
                }
                else
                {
                    MessageBox.Show("No data to export to Excel.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
