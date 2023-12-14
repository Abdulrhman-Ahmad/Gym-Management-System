using System;
using System.Linq;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;
using System.Runtime.Remoting.Contexts;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
   
    public partial class EquipmentsUpdate : Form
    {
        private int currentPagePanel;

        GymSystemEntities Context = new GymSystemEntities();
        public EquipmentsUpdate(int currentPagePanel)
        {
            InitializeComponent();
            this.currentPagePanel = currentPagePanel; 
            try
            {
             
                Equipment equipmentFromDatabase = Context.Equipments.FirstOrDefault(c => c.ID == currentPagePanel);

                if (equipmentFromDatabase != null)
                {
                    Update_EquipmentFullName.Text = equipmentFromDatabase.Name;
                    Update_EquipmentSerialNumber.Text = equipmentFromDatabase.SerielNum;
                    Update_EquipmentPrice.Text = equipmentFromDatabase.Price.ToString();


                    List<Class> classes = Context.Classes.ToList();
                    Update_EquipmentClassName.DataSource = classes;
                    Update_EquipmentClassName.DisplayMember = "Name";
                    Update_EquipmentClassName.ValueMember = "ID";

                    Update_EquipmentClassName.SelectedValue = equipmentFromDatabase.ClassID;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ: {ex.Message}");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Update_EquipmentFullName_TextChanged(object sender, EventArgs e) { }

        private void Update_EquipmentSerialNumber_TextChanged(object sender, EventArgs e) { }

        private void Update_EquipmentPrice_TextChanged(object sender, EventArgs e) { }

        private void Update_EquipmentClassName_SelectedIndexChanged(object sender, EventArgs e) { }

        private void EquipmentsUpdate_Load(object sender, EventArgs e)
        {

        }

        private void Update_EquipmentBtn_Click(object sender, EventArgs e)
        {
            if (ValidateEquipmentInput())
            {
                Equipment equipmentToUpdate = Context.Equipments.FirstOrDefault(c => c.ID == currentPagePanel);
                if (equipmentToUpdate != null)
                {
                    equipmentToUpdate.Name = Update_EquipmentFullName.Text;
                    equipmentToUpdate.SerielNum = Update_EquipmentSerialNumber.Text;
                    equipmentToUpdate.Price = Convert.ToInt32(Update_EquipmentPrice.Text);
                    equipmentToUpdate.ClassID = (int)Update_EquipmentClassName.SelectedValue;

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
        private bool ValidateEquipmentInput()
        {
            if (string.IsNullOrWhiteSpace(Update_EquipmentFullName.Text))
            {
                MessageBox.Show("Equipment full name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(Update_EquipmentSerialNumber.Text))
            {
                MessageBox.Show("Equipment serial number is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidSerialNumber(Update_EquipmentSerialNumber.Text))
            {
                MessageBox.Show("Invalid serial number. Please enter a valid serial number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(Update_EquipmentPrice.Text, out int price) || price < 0 || price > 30000)
            {
                MessageBox.Show("Invalid equipment price. Please enter a valid number between 0 and 30000.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true; 
        }

        private bool IsValidSerialNumber(string serialNumber)
        {
            return !string.IsNullOrWhiteSpace(serialNumber) && System.Text.RegularExpressions.Regex.IsMatch(serialNumber, "^[A-Za-z0-9]+$");
        }

    }
}
