using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TraineesUpdate : Form
    {
        private int currentPagePanel;

        GymSystemEntities Context = new GymSystemEntities();


        public TraineesUpdate(int currentPagePanel)
        {
            InitializeComponent();
            this.currentPagePanel = currentPagePanel; 
        }

        #region Unused Events
        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void Vein_Click(object sender, EventArgs e) { }

        private void panel2_Paint(object sender, PaintEventArgs e) { }



        private void Update_ClientClassEdit_SelectedIndexChanged(object sender, EventArgs e)
        { }

        private void Update_ClientPhone_TextChanged(object sender, EventArgs e)
        { }

        private void Update_ClientAge_TextChanged(object sender, EventArgs e)
        { }

        private void Update_ClientGender_SelectedIndexChanged(object sender, EventArgs e)
        { }

        private void Update_ClientDuration_TextChanged(object sender, EventArgs e)
        { }

        private void Update_ClientFullName_TextChanged(object sender, EventArgs e)
        { }
        #endregion


        private void Update_ClientClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Update_ClientClass.Text == "New")
            {
                DurationLabel.Visible = true;
                DurationComboBox.Visible = true;
            }
            else
            {
                DurationLabel.Visible = false;
                DurationComboBox.Visible = false;
            }
        }

        private void Update_Client_Load(object sender, EventArgs e)
        {
            TraineeIdLabel.Text = "2";                       // -- [ SELECTOR ] --
            int SelectedTraineeId = int.Parse(TraineeIdLabel.Text);
            try
            {
                // get the selected Trainee Data through the Trainee Id
                Trainee traineeFromDatabase = Context.Trainees.FirstOrDefault(c => c.ID == currentPagePanel);

                if (traineeFromDatabase != null)
                {
                    #region Setting the inputs value with the Trainee Values
                    Update_ClientFullName.Text = traineeFromDatabase.Name;
                    Update_ClientPhone.Text = traineeFromDatabase.Phone.ToString();
                    Update_ClientAge.Text = traineeFromDatabase.Age.ToString();
                    Update_ClientGender.Text = traineeFromDatabase.Gender;
                    #endregion

                    #region Fill classes from database
                    Class classFromDatabase = Context.Classes.FirstOrDefault(c => c.ID == currentPagePanel);
                    List<Class> classes = Context.Classes.ToList();
                    Update_ClientClassEdit.DataSource = classes;
                    Update_ClientClassEdit.DisplayMember = "Name";
                    Update_ClientClassEdit.ValueMember = "ID";

                    Update_ClientClassEdit.SelectedValue = classFromDatabase.ID;
                    #endregion

                    #region Fill the enrolled classes for the selected Trainee
                    var traineeClasses = Context.TraineesClassesEnrollments
                     .Where(enrollment => enrollment.TraineesID == currentPagePanel)
                     .Select(enrollment => enrollment.Class)
                     .ToList();
                    traineeClasses.Add(new Class() { Name = "New" });
                    Update_ClientClass.DataSource = traineeClasses;
                    Update_ClientClass.DisplayMember = "Name";
                    Update_ClientClass.ValueMember = "ID";
                    #endregion
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            //filling the duration combobox
            DurationComboBox.DataSource = new List<int>() { 1, 3, 6, 12 };
        }
        private void Update_ClientBtn_Click(object sender, EventArgs e)
        {
            if (ValidateClientInput())
            {
                int SelectedTraineeId = int.Parse(TraineeIdLabel.Text);

                Trainee traineeFromDatabase = Context.Trainees.FirstOrDefault(c => c.ID == currentPagePanel);
                if (traineeFromDatabase != null)
                {
                    traineeFromDatabase.Name = Update_ClientFullName.Text;
                    traineeFromDatabase.Phone = Update_ClientPhone.Text;
                    traineeFromDatabase.Age = Convert.ToInt32(Update_ClientAge.Text);
                    traineeFromDatabase.Gender = Update_ClientGender.Text;
                    Context.SaveChanges();

                    traineeFromDatabase = Context.Trainees.FirstOrDefault(c => c.ID == currentPagePanel);


                    #region Getting Data 
                    string ClassEditValue = Update_ClientClassEdit.Text;
                    string ClassValue = Update_ClientClass.Text;

                    var TraineeEnrollment = Context.TraineesClassesEnrollments.FirstOrDefault(c => c.TraineesID == traineeFromDatabase.ID && c.Class.Name == ClassValue);

                    var SelectedClassId = Context.Classes.FirstOrDefault(c => c.Name == ClassEditValue);
                    #endregion

                    MessageBox.Show("Update successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (ClassValue != "New")
                    {

                        #region New Record Creating
                        TraineesClassesEnrollment newRecord = new TraineesClassesEnrollment()
                        {
                            TraineesID = TraineeEnrollment.TraineesID,
                            ClassID = SelectedClassId.ID,
                            StartDate = TraineeEnrollment.StartDate,
                            EndDate = TraineeEnrollment.EndDate,
                            SubFee = TraineeEnrollment.SubFee,
                        };
                        #endregion

                        Context.TraineesClassesEnrollments.Remove(TraineeEnrollment);
                        Context.TraineesClassesEnrollments.Add(newRecord);
                        Context.SaveChanges();

                    }
                    else
                    {

                        Context.AddTrainee(traineeFromDatabase.Name,
                                            traineeFromDatabase.Gender,
                                            traineeFromDatabase.Age,
                                            traineeFromDatabase.Phone,
                                            Update_ClientClassEdit.Text,
                                            int.Parse(DurationComboBox.Text)
                                            );

                    }

                    this.Close();

                }
            }
        }
        private bool ValidateClientInput()
        {
            if (string.IsNullOrWhiteSpace(Update_ClientFullName.Text))
            {
                MessageBox.Show("Client full name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(Update_ClientPhone.Text) || Update_ClientPhone.Text.Length != 11 || !Update_ClientPhone.Text.All(char.IsDigit))
            {
                MessageBox.Show("Phone should contain exactly 11 digits and only numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(Update_ClientAge.Text, out int age) || age < 0 || age > 100)
            {
                MessageBox.Show("Invalid age. Please enter a valid number between 0 and 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
