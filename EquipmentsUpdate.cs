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
            this.currentPagePanel = currentPagePanel; // Assign the parameter value to the field
            try
            {
                // استرجاع بيانات المعدات من قاعدة البيانات بناءً على الرقم التسلسلي
                Equipment equipmentFromDatabase = Context.Equipments.FirstOrDefault(c => c.ID == currentPagePanel);

                if (equipmentFromDatabase != null)
                {
                    Update_EquipmentFullName.Text = equipmentFromDatabase.Name;
                    Update_EquipmentSerialNumber.Text = equipmentFromDatabase.SerielNum;
                    Update_EquipmentPrice.Text = equipmentFromDatabase.Price.ToString();

                    // ملأ ComboBox بكائنات الصف
                    List<Class> classes = Context.Classes.ToList();
                    Update_EquipmentClassName.DataSource = classes;
                    Update_EquipmentClassName.DisplayMember = "Name";
                    Update_EquipmentClassName.ValueMember = "ID";

                    // تعيين الصف المحدد للمعدات
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
            Equipment EquipmentToUpdate = Context.Equipments.FirstOrDefault(c => c.ID == currentPagePanel);
            if (EquipmentToUpdate != null)
            {
                // تحديث القيم في الصف باستخدام القيم المدخلة في النموذج
                EquipmentToUpdate.Name = Update_EquipmentFullName.Text;
                EquipmentToUpdate.SerielNum =  Update_EquipmentSerialNumber.Text;
                EquipmentToUpdate.Price = Convert.ToInt32(Update_EquipmentPrice.Text);
                EquipmentToUpdate.ClassID = (int)Update_EquipmentClassName.SelectedValue;

                // حفظ التغييرات في قاعدة البيانات
                Context.SaveChanges();

                // إغلاق النموذج بعد التحديث
                this.Close();

            }
        }
    }
}
