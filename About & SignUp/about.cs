
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class about : Form
    {
        int MemberID;
        GymSystemEntities context = new GymSystemEntities();
        

        public about(int memberID)
        {
            MemberID=memberID;
            InitializeComponent();
            
        }

        private void about_Load(object sender, EventArgs e)
        {

            //////////////////////// Here is the ID of The Trainer (Static ID Temporary) ///////////////
            var TraineeID = MemberID;

            

            var trainee = context.Trainees.Where(t => t.ID == TraineeID).FirstOrDefault();
            var StartDate = context.TraineesClassesEnrollments.Where(t => t.TraineesID == TraineeID).FirstOrDefault();
            var classesIDList = context.TraineesClassesEnrollments.Where(t=>t.TraineesID== TraineeID).Select(t=>t.ClassID).ToList();

            var classesNames = "";

            foreach (var classID in classesIDList)
            {
                classesNames += context.Classes.Where(c => c.ID == classID).Select(c => c.Name).FirstOrDefault().ToString()+", ";
            }

            label_ID.Text = TraineeID.ToString();
            label_Name.Text = trainee.Name;
            label_Date.Text = StartDate.StartDate.ToString();
            label_phone.Text = trainee.Phone.ToString();
            label_age.Text = trainee.Age.ToString();
            label_gender.Text = trainee.Gender.ToString();
            label_classes.Text = classesNames;

            #region QR Generator

            // Create a QRCodeGenerator instance
            QRCodeGenerator qrGenerator = new QRCodeGenerator();

            // Create a QRCodeData instance and encode the text
            QRCodeData qrCodeData = qrGenerator.CreateQrCode("Client ID "+ label_ID.Text +", Name " + label_Name.Text +", Phone " + label_phone.Text
                + ", Age " + label_age.Text + ", Gender " + label_gender.Text + ", Classes " + label_classes.Text
                , QRCodeGenerator.ECCLevel.Q);

            // Create a QRCode instance using the QRCodeData
            QRCode qrCode = new QRCode(qrCodeData);

            // Convert the QR code to a bitmap image
            Bitmap qrCodeImage = qrCode.GetGraphic(10);

            // Save the QR code image to a file or display it as needed
            //qrCodeImage.Save($"D:/.Net/windows form project/Gym Management System/img test/Client{TraineeID}Image.png");


            #endregion

            picture_Qr.Image = qrCodeImage;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
