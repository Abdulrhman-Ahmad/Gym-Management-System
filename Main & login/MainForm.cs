using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Data.Entity.Core.Metadata.Edm;
using System.Collections.Generic;
using System.Data.Entity;
//using Gym_Management_System;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public string currentPage; // indicate of page
        public int currentPagePanel; // indicate of panel 
        private TextBox searchTextBox;
        GymSystemEntities Context = new GymSystemEntities();
        TableLayoutPanel tableLayoutPanel;

        public MainForm()
        {
            InitializeComponent();
            label_CurrentPage.Location =new Point(0, 0);
            label_UserName.ForeColor = Color.White;
            label_UserName.Visible = true;
        
            BTN_Logout.MouseEnter += CommonButton_MouseEnter;
            BTN_Logout.MouseLeave += CommonButton_MouseLeave;

            BTN_Clients.MouseEnter += CommonButton_MouseEnter;
            BTN_Clients.MouseLeave += CommonButton_MouseLeave;

            BTN_Classes.MouseEnter += CommonButton_MouseEnter;
            BTN_Classes.MouseLeave += CommonButton_MouseLeave;

            BTN_Equipment.MouseEnter += CommonButton_MouseEnter;
            BTN_Equipment.MouseLeave += CommonButton_MouseLeave;

            BTN_Stuff.MouseEnter += CommonButton_MouseEnter;
            BTN_Stuff.MouseLeave += CommonButton_MouseLeave;

            BTN_Dashboard.MouseEnter += CommonButton_MouseEnter;
            BTN_Dashboard.MouseLeave += CommonButton_MouseLeave;
        }

        #region Common Panel & Button
        private void CommonPanel_MouseEnter(object sender, EventArgs e)
        {
            Panel stuffMemberPanel = (Panel)sender;


            stuffMemberPanel.BorderStyle = BorderStyle.None;
            stuffMemberPanel.ForeColor = Color.White;
            stuffMemberPanel.Padding = new Padding(8);
            stuffMemberPanel.Cursor = Cursors.Hand;
            stuffMemberPanel.BorderStyle = BorderStyle.FixedSingle;
            stuffMemberPanel.Region = new Region(new Rectangle(0, 0, stuffMemberPanel.Width, stuffMemberPanel.Height));
            stuffMemberPanel.BackColor = Color.FromArgb(70, 70, 70);
        }
        private void CommonPanel_MouseLeave(object sender, EventArgs e)
        {
            Panel stuffMemberPanel = (Panel)sender;


            stuffMemberPanel.BorderStyle = BorderStyle.None;
            stuffMemberPanel.BackColor = Color.FromArgb(70, 70, 70);
            stuffMemberPanel.ForeColor = Color.White;
            stuffMemberPanel.Padding = new Padding(0);

        }
        private void CommonButton_MouseEnter(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button button = (Guna.UI2.WinForms.Guna2Button)sender;
            button.BorderColor = Color.White;
            button.BorderRadius = 5;
            button.BorderThickness = 5;
            button.ForeColor = Color.White;
        }
        private void CommonButton_MouseLeave(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button button = (Guna.UI2.WinForms.Guna2Button)sender;
            button.BorderRadius = 0;
            button.BorderThickness = 0;
            //button.FillColor = Color.Black;
            button.ForeColor = Color.White;
        }
        #endregion

        #region Entity Methods
        private Panel CreateEntityPanel(object entity)
        {

            Panel entityPanel = new Panel();
            entityPanel.BackColor = Color.FromArgb(70, 70, 70);  // may take it as borders of panels
            entityPanel.Dock = DockStyle.Fill;
            entityPanel.Cursor = Cursors.Hand;
            entityPanel.MouseEnter += CommonPanel_MouseEnter;
            entityPanel.MouseLeave += CommonPanel_MouseLeave;
           


            var nameLabel = new Label();
            nameLabel.Text = GetNameFromEntity(entity);
            nameLabel.ForeColor = Color.White;
            nameLabel.Font = new Font("Segoe UI", 12F);
            nameLabel.Dock = DockStyle.Left;


            var updateButton = new Button();
            updateButton.Text = "Update";
            updateButton.Tag = GetEntityID(entity);
            updateButton.Width = 100;
            updateButton.Height = 30;
            updateButton.Location = new Point(1100, 12);
            updateButton.Click += UpdateButton_Click; // update button to its hand


            var deleteButton = new Button();
            deleteButton.Text = "Delete";
            deleteButton.Tag = GetEntityID(entity);
            deleteButton.Width = 100;
            deleteButton.Height = 30;
            deleteButton.Location = new Point(1200, 12);
            deleteButton.Click += DeleteButton_Click;


            entityPanel.Controls.Add(nameLabel);
            entityPanel.Controls.Add(updateButton);
            entityPanel.Controls.Add(deleteButton);
            entityPanel.Size = new Size(50, 50);

            return entityPanel;
        }
        private string GetNameFromEntity(object entity)
        {
            if (entity is Staff staff)
            {
                return staff.Name;
            }
            else if (entity is Trainee client)
            {
                return client.Name;
            }
            else if (entity is Equipment equipment)
            {
                return equipment.Name;
            }
            else if (entity is Class classEntity)
            {
                return classEntity.Name;
            }

            return string.Empty;
        }
        private int GetEntityID(object entity)
        {
            if (entity is Staff staff)
            {
                return staff.ID;
            }
            else if (entity is Trainee client)
            {
                return client.ID;
            }
            else if (entity is Equipment equipment)
            {
                return equipment.ID;
            }
            else if (entity is Class classEntity)
            {
                return classEntity.ID;
            }

            return 0;
        }

        #endregion

        #region  Buttons Method
        private void BackButton_Click(object sender, EventArgs e)
        {

            switch (currentPage)
            {
                case "staff":
                    BTN_Stuff_Click(sender, e);
                    break;
                case "Equipment":
                    BTN_Equipment_Click(sender, e);
                    break;
                case "Clients":
                    BTN_Clients_Click(sender, e);
                    break;
                case "Classes":
                    BTN_Classes_Click(sender, e);
                    break;

                default:

                    MessageBox.Show("Entity type not found");
                    return;
            }

        }


        #region Delete Methods
        private void DeleteButton_Click(object sender, EventArgs e, int panelTag)
        {
            switch (currentPage)
            {
                case "Classes":
                    {
                        currentPagePanel = panelTag;

                        var classToDelete = Context.Classes.FirstOrDefault(classs => classs.ID == currentPagePanel);

                        if (classToDelete != null)
                        {
                            try
                            {

                                DialogResult result = MessageBox.Show("Are you sure you want to delete this class?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    //I'm Here
                                    Context.DeleteClass(classToDelete.ID);

                                    BTN_Classes_Click(sender, e);
                                }
                                else
                                { BTN_Classes_Click(sender, e); }
                               
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("Cannot delete the class because it is used by clients.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                        else
                        {
                            MessageBox.Show("Class not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;


                case "Equipment":
                    {
                        currentPagePanel = panelTag;


                        var EquipmentToDelete = Context.Equipments.FirstOrDefault(eq => eq.ID == currentPagePanel);

                        if (EquipmentToDelete != null)
                        {
                            try
                            {

                                DialogResult result = MessageBox.Show("Are you sure you want to delete this Equipment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    Context.Equipments.Remove(EquipmentToDelete);
                                    Context.SaveChanges();
                                    BTN_Equipment_Click(sender, e);
                                }
                                else
                                { BTN_Equipment_Click(sender, e); }

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Cannot delete the Equipment because it is used by Classes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                        else
                        {
                            MessageBox.Show("Equipment not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case "Clients":
                    {
                        currentPagePanel = panelTag;


                        var ClientToDelete = Context.Trainees.FirstOrDefault(client => client.ID == currentPagePanel);

                        if (ClientToDelete != null)
                        {
                            try
                            {

                                DialogResult result = MessageBox.Show("Are you sure you want to delete this Client?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    //I'm here
                                    Context.DeleteTrainee(ClientToDelete.ID);
                                    Context.SaveChanges();
                                    BTN_Clients_Click(sender, e);
                                }
                                else
                                { BTN_Clients_Click(sender, e); }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Cannot delete this Client", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Client not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;

                case "staff":
                    {
                        currentPagePanel = panelTag;
                        var stuffToDelete = Context.Staffs.FirstOrDefault(stuff => stuff.ID == currentPagePanel);
                        //var StuffToDelete = Context.ClassTrainers.FirstOrDefault(s => s.StaffID == stuffToDelete.ID);

                        if (stuffToDelete != null)
                        {
                            try
                            {
                                DialogResult result = MessageBox.Show("Are you sure you want to delete this Stuff?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    if (stuffToDelete.JobTitle != "Trainer")
                                    {
                                        Context.Staffs.Remove(stuffToDelete);
                                        Context.SaveChanges();
                                        BTN_Stuff_Click(sender, e);
                                    }
                                    else
                                    {
                                        //Context.DeleteTrainee(currentPagePanel);
                                        //Context.ClassTrainers.Remove(StuffToDelete);
                                        //Context.SaveChanges();
                                        //Context.Staffs.Remove(stuffToDelete);
                                        //Context.SaveChanges();
                                        Context.DeleteTrainer(stuffToDelete.ID);
                                    }
                                    BTN_Stuff_Click(sender, e);
                                }
                                else
                                { BTN_Stuff_Click(sender, e); }


                                BTN_Stuff_Click(sender, e);
                            }
                            catch
                            {
                                MessageBox.Show("Cannot delete the Trainer because it is used by Classes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                        else
                        {
                            MessageBox.Show("stuff not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                default:
                    MessageBox.Show("Entity type not found");
                    return;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (sender is Button deleteButton)
            {
                // Get the panel tag and convert it to an integer
                if (deleteButton.Tag is int panelTag)
                {
                    DeleteButton_Click(sender, e, panelTag); // Pass the panel tag to the updated method
                }
            }
        }
        #endregion

        #region Update Methods
        private void UpdateButton_Click(object sender, EventArgs e, int panelTag)
        {

            Panel_Main.Controls.Clear();

            switch (currentPage)
            {
                case "Classes":
                    {
                        currentPagePanel = panelTag;
                        Panel_Main.Controls.Clear();

                        ClassesUpdate classesUpdate = new ClassesUpdate(currentPagePanel);
                        classesUpdate.TopLevel = false;
                        classesUpdate.FormBorderStyle = FormBorderStyle.None;
                        classesUpdate.Dock = DockStyle.Fill;
                        classesUpdate.ForeColor = Color.Black;
                        classesUpdate.Scale(.8f);
                        Panel_Main.Controls.Add(classesUpdate);
                        classesUpdate.Show();
                    }
                    break;
                case "Equipment":
                    {
                        currentPagePanel = panelTag;
                        Panel_Main.Controls.Clear();

                        EquipmentsUpdate EquipmentUpdate = new EquipmentsUpdate(currentPagePanel);
                        EquipmentUpdate.TopLevel = false;
                        EquipmentUpdate.FormBorderStyle = FormBorderStyle.None;
                        EquipmentUpdate.Dock = DockStyle.Fill;
                        EquipmentUpdate.ForeColor = Color.Black;
                        EquipmentUpdate.Scale(.75f);
                        Panel_Main.Controls.Add(EquipmentUpdate);
                        EquipmentUpdate.Show();
                    }
                    break;
                case "Clients":
                    {
                        currentPagePanel = panelTag;
                        Panel_Main.Controls.Clear();

                        TraineesUpdate traineesUpdate = new TraineesUpdate(currentPagePanel);
                        traineesUpdate.TopLevel = false;
                        traineesUpdate.FormBorderStyle = FormBorderStyle.None;
                        traineesUpdate.Dock = DockStyle.Fill;
                        traineesUpdate.ForeColor = Color.Black;
                        traineesUpdate.Scale(.75f);
                        Panel_Main.Controls.Add(traineesUpdate);
                        traineesUpdate.Show();
                    }
                    break;
                case "staff":
                    {
                        currentPagePanel = panelTag;
                        Panel_Main.Controls.Clear();

                        StaffUpdate staffUpdate = new StaffUpdate(currentPagePanel);
                        staffUpdate.TopLevel = false;
                        staffUpdate.FormBorderStyle = FormBorderStyle.None;
                        staffUpdate.Dock = DockStyle.Fill;
                        staffUpdate.ForeColor = Color.Black;
                        staffUpdate.Scale(.75f);
                        Panel_Main.Controls.Add(staffUpdate);
                        staffUpdate.Show();
                    }
                    break;
                default:
                    MessageBox.Show("Entity type not found");
                    return;
            }
        }

        public void UpdateButton_Click(object sender, EventArgs e)
        {

            if (sender is Button updateButton)
            {

                if (updateButton.Tag is int panelTag)
                {
                    UpdateButton_Click(sender, e, panelTag);
                }
                else
                    UpdateButton_Click(sender, e, currentPagePanel);
            }
        }
        #endregion

        #region Create & Search 
        private void CreateButton_Click(object sender, EventArgs e)
        {
            switch (currentPage)
            {
                case "staff":
                    {
                        Panel_Main.Controls.Clear();

                        Staff_form staff_Form = new Staff_form();
                        staff_Form.TopLevel = false;
                        staff_Form.FormBorderStyle = FormBorderStyle.None;
                        staff_Form.Dock = DockStyle.Fill;
                        staff_Form.ForeColor = Color.Black;
                        staff_Form.Scale(.8f);
                        Panel_Main.Controls.Add(staff_Form);
                        staff_Form.Show();
                    }
                    break;
                case "Equipment":
                    {
                        Panel_Main.Controls.Clear();

                        Equipments equipments = new Equipments();
                        equipments.TopLevel = false;
                        equipments.FormBorderStyle = FormBorderStyle.None;
                        equipments.Dock = DockStyle.Fill;
                        equipments.ForeColor = Color.Black;
                        equipments.Scale(.8f);
                        Panel_Main.Controls.Add(equipments);
                        equipments.Show();
                    }
                    break;
                case "Clients":
                    {
                        Panel_Main.Controls.Clear();

                        Trainees trainees = new Trainees();
                        trainees.TopLevel = false;
                        trainees.FormBorderStyle = FormBorderStyle.None;
                        trainees.Dock = DockStyle.Fill;
                        trainees.ForeColor = Color.Black;
                        trainees.Scale(.8f);
                        Panel_Main.Controls.Add(trainees);
                        trainees.Show();
                    }
                    break;
                case "Classes":
                    {
                        Panel_Main.Controls.Clear();

                        Classes classes = new Classes();
                        classes.TopLevel = false;
                        classes.FormBorderStyle = FormBorderStyle.None;
                        classes.Dock = DockStyle.Fill;
                        classes.ForeColor = Color.Black;
                        classes.Scale(.8f);
                        Panel_Main.Controls.Add(classes);
                        classes.Show();
                    }
                    break;

                default:

                    MessageBox.Show("Entity type not found");
                    return;
            }
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            IEnumerable<object> filteredEntities;
            string searchQuery = searchTextBox.Text.Trim();

            switch (currentPage)
            {
                case "staff":
                    filteredEntities = Context.Staffs.Where(member => member.Name.Contains(searchQuery)).ToList();
                    break;
                case "Equipment":
                    filteredEntities = Context.Equipments.Where(member => member.Name.Contains(searchQuery)).ToList();
                    break;
                case "Clients":
                    filteredEntities = Context.Trainees.Where(member => member.Name.Contains(searchQuery)).ToList();
                    break;
                case "Classes":
                    filteredEntities = Context.Classes.Where(member => member.Name.Contains(searchQuery)).ToList();
                    break;
                default:

                    MessageBox.Show("Entity type not found");
                    return;
            }

            var memberTableLayoutPanel = tableLayoutPanel.GetControlFromPosition(0, 1) as TableLayoutPanel;
            memberTableLayoutPanel.Controls.Clear();

            foreach (object entity in filteredEntities)
            {
                Panel entityPanel = CreateEntityPanel(entity);
                int entityId = -1;
                if (entity is Staff staff)
                {
                    entityId = staff.ID;
                    entityPanel.Tag = entityId;
                    entityPanel.Click += StuffMemberPanel_Click;
                }
                else if (entity is Equipment equipment)
                {
                    entityId = equipment.ID;
                    entityPanel.Tag = entityId;
                    entityPanel.Click += EquipmentMemberPanel_Click;
                }
                else if (entity is Trainee client)
                {
                    entityId = client.ID;
                    entityPanel.Tag = entityId;
                    entityPanel.Click += ClientsMemberPanel_Click;
                }
                else if (entity is Class classEntity)
                {
                    entityId = classEntity.ID;
                    entityPanel.Tag = entityId;
                    entityPanel.Click += ClassesMemberPanel_Click;
                }

                memberTableLayoutPanel.Controls.Add(entityPanel);
            }
        } 
        #endregion

        #endregion

        #region Record Card Design
        private void CreateLabelAndTextBox(Panel parentPanel, string labelText, string value, int x, int y)
        {
            var label = new Label();
            label.Text = labelText;
            label.Location = new Point(x, y);
            label.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label.ForeColor = Color.White;
            parentPanel.Controls.Add(label);

            var textBox = new TextBox();
            textBox.Text = value;
            textBox.Location = new Point(x + 120, y);
            textBox.ReadOnly = true;
            textBox.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            textBox.ForeColor = Color.Black;
            textBox.Size = new Size(200, textBox.Height);
            parentPanel.Controls.Add(textBox);
        }

        #endregion

        #region Search Panel Design
        private TableLayoutPanel CreateSearchPanel()
        {
            var searchPanel = new TableLayoutPanel();
            searchPanel.Dock = DockStyle.Top;
            searchPanel.AutoSize = true;
            searchPanel.BackColor = Color.FromArgb(50, 50, 50);
            searchPanel.Padding = new Padding(10);


            var searchBoxPanel = new Panel();
            searchBoxPanel.Dock = DockStyle.Fill;
            searchBoxPanel.BackColor =  Color.DarkGray;  


            searchTextBox = new TextBox();
            searchTextBox.Dock = DockStyle.Fill;
            searchTextBox.ForeColor = Color.White;
            searchTextBox.BackColor = Color.DimGray;
            searchBoxPanel.Controls.Add(searchTextBox);


            var searchButton = new Button();
            searchButton.Text = "Search";
            searchButton.BackColor = Color.Gray;
            searchButton.ForeColor = Color.White;
            searchButton.Click += SearchButton_Click;
            searchButton.Size = new Size(90, 50);
            searchButton.Location = new Point(800, 40);
            searchBoxPanel.Controls.Add(searchButton);


            var createButton = new Button();
            createButton.Text = "Create";
            createButton.BackColor = Color.Gray;
            createButton.ForeColor = Color.White;
            createButton.Click += CreateButton_Click;
            createButton.Size = new Size(90, 50);
            createButton.Location = new Point(400, 40);
            searchBoxPanel.Controls.Add(createButton);

            searchPanel.Controls.Add(searchBoxPanel);
            return searchPanel;
        } 
        #endregion

        #region Stuff Methods
        private void BTN_Stuff_Click(object sender, EventArgs e)
        {
            currentPage = "staff";
            label_CurrentPage.Text = currentPage;
            Panel_Main.Controls.Clear();

            tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent));
            tableLayoutPanel.Size = new Size(600, 600);
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent));
            tableLayoutPanel.BackColor = Color.FromArgb(210, 210, 210);

            Panel_Main.Controls.Add(tableLayoutPanel);

            var searchPanel = CreateSearchPanel();
            tableLayoutPanel.Controls.Add(searchPanel, 0, 0);

            var memberTableLayoutPanel = new TableLayoutPanel();
            memberTableLayoutPanel.Dock = DockStyle.Fill;
            memberTableLayoutPanel.AutoScroll = true;
            //memberTableLayoutPanel.BackColor= Color.FromArgb(50, 50, 50);
            tableLayoutPanel.Controls.Add(memberTableLayoutPanel, 0, 1);

            var staffMembers = Context.Staffs.ToList();
            foreach (var staffMember in staffMembers)
            {
                Panel memberPanel = CreateEntityPanel(staffMember);

               
                memberPanel.Tag = staffMember.ID;

            
                memberPanel.Click += StuffMemberPanel_Click;

                memberTableLayoutPanel.Controls.Add(memberPanel);

                memberTableLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
                memberTableLayoutPanel.BackColor = Color.DarkGray;  // may take it as borders of panels
            }
        }
        private void StuffMemberPanel_Click(object sender, EventArgs e)
        {
            
            if (sender is Panel stuffMemberPanel)
            {
                int memberId = (int)stuffMemberPanel.Tag;

             
                var member = Context.Staffs.FirstOrDefault(s => s.ID == memberId);

                if (member != null)
                {
                    currentPagePanel= member.ID;
                    Panel_Main.Controls.Clear();
                
                    Panel_Main.BackColor = Color.FromArgb(50, 50, 50);

                 
                    var cardPanel = new Panel();
                    cardPanel.Location = new Point(350, 100);
                    cardPanel.Size = new Size(500, 500);
                    cardPanel.BorderStyle = BorderStyle.FixedSingle; 
                    cardPanel.BackColor = Color.DarkGray; 
                    Panel_Main.Controls.Add(cardPanel);

               
                    CreateLabelAndTextBox(cardPanel, "Name:", member.Name, 120, 60);
                    CreateLabelAndTextBox(cardPanel, "Gender:", member.Gender, 120, 100);
                    CreateLabelAndTextBox(cardPanel, "Age:", member.Age.ToString(), 120, 150);
                    CreateLabelAndTextBox(cardPanel, "Phone:", member.Phone, 120, 200);
                    CreateLabelAndTextBox(cardPanel, "JobTitle:", member.JobTitle, 120, 250);
                    CreateLabelAndTextBox(cardPanel, "Salary:", member.Salary.ToString(), 120, 300);
                    CreateLabelAndTextBox(cardPanel, "HireDate:", member.HireDate.ToString(), 120, 350);

                    var backButton = new Button();
                    backButton.Text = "Back";
                    backButton.Location = new Point(550, 610);
                    backButton.Click += BackButton_Click;
                    backButton.Size = new Size(100, 50);
                    backButton.BackColor = Color.Black;
                    Panel_Main.Controls.Add(backButton);


                }
            }
        }
        #endregion

        #region Clients Methods
        private void BTN_Clients_Click(object sender, EventArgs e)
        {
            currentPage = "Clients";
            label_CurrentPage.Text = currentPage;
            Panel_Main.Controls.Clear();


            tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent));
            tableLayoutPanel.Size = new Size(600, 600);
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent));

            Panel_Main.Controls.Add(tableLayoutPanel);


            var searchPanel = CreateSearchPanel();
            tableLayoutPanel.Controls.Add(searchPanel, 0, 0);


            var memberTableLayoutPanel = new TableLayoutPanel();
            memberTableLayoutPanel.Dock = DockStyle.Fill;
            memberTableLayoutPanel.AutoScroll = true;
            tableLayoutPanel.Controls.Add(memberTableLayoutPanel, 0, 1);


            var Client = Context.Trainees.ToList();
            foreach (var staffMember in Client)
            {

                Panel memberPanel = CreateEntityPanel(staffMember);
                memberPanel.Tag = staffMember.ID;

                memberTableLayoutPanel.Controls.Add(memberPanel);

                memberTableLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
                memberTableLayoutPanel.BackColor = Color.DarkGray;  // may take it as borders of panels
                memberPanel.Click += ClientsMemberPanel_Click;
            }

        }
        private void ClientsMemberPanel_Click(object sender, EventArgs e)
        {
           
            if (sender is Panel stuffMemberPanel)
            {
                Panel_Main.Controls.Clear();
                int memberId = (int)stuffMemberPanel.Tag;
                currentPagePanel = memberId;
                

               
                var member = Context.Trainees.FirstOrDefault(s => s.ID == memberId);

                about About = new about(memberId);
                About.TopLevel = false;
                About.FormBorderStyle = FormBorderStyle.None;
                About.Dock = DockStyle.Fill;
                About.ForeColor = Color.Black;
                About.Size = Panel_Main.Size;
                About.Scale(.8f);
                
                About.button1.Click += UpdateButton_Click;
                Panel_Main.Controls.Add(About);
                About.Show();
            }
        }
        #endregion

        #region Equipment Methods
        private void BTN_Equipment_Click(object sender, EventArgs e)
        {
            currentPage = "Equipment";
            label_CurrentPage.Text = currentPage;
            Panel_Main.Controls.Clear();


            tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent));
            tableLayoutPanel.Size = new Size(600, 600);
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent));

            Panel_Main.Controls.Add(tableLayoutPanel);


            var searchPanel = CreateSearchPanel();
            tableLayoutPanel.Controls.Add(searchPanel, 0, 0);


            var memberTableLayoutPanel = new TableLayoutPanel();
            memberTableLayoutPanel.Dock = DockStyle.Fill;
            memberTableLayoutPanel.AutoScroll = true;
            tableLayoutPanel.Controls.Add(memberTableLayoutPanel, 0, 1);


            var Equeipment = Context.Equipments.ToList();
            foreach (var staffMember in Equeipment)
            {

                Panel memberPanel = CreateEntityPanel(staffMember);

                memberPanel.Tag = staffMember.ID;

       
                memberPanel.Click += EquipmentMemberPanel_Click;
                memberTableLayoutPanel.Controls.Add(memberPanel);

                memberTableLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
                memberTableLayoutPanel.BackColor = Color.DarkGray;  // may take it as borders of panels
            }
        }
        private void EquipmentMemberPanel_Click(object sender, EventArgs e)
        {
           
            if (sender is Panel stuffMemberPanel)
            {
                int memberId = (int)stuffMemberPanel.Tag;
                var className = Context.Equipments
                    .Where(eq => eq.ID == memberId)
                    .Select(eq => eq.Class.Name)
                    .FirstOrDefault();

                
                var member = Context.Equipments.FirstOrDefault(s => s.ID == memberId);

                if (member != null)
                {
                    
                    Panel_Main.Controls.Clear();
                  
                    Panel_Main.BackColor = Color.Black;

                  
                    var cardPanel = new Panel();
                    cardPanel.Location = new Point(350, 100);
                    cardPanel.Size = new Size(500, 500);
                    cardPanel.BorderStyle = BorderStyle.FixedSingle; 
                    cardPanel.BackColor = Color.DarkGray; 
                    Panel_Main.Controls.Add(cardPanel);

                   
                    CreateLabelAndTextBox(cardPanel, "Name:", member.Name, 120, 60);
                    CreateLabelAndTextBox(cardPanel, "Price:", member.Price.ToString(), 120, 100);
                    CreateLabelAndTextBox(cardPanel, "Seriel Number:", member.SerielNum.ToString(), 120, 150);
                    CreateLabelAndTextBox(cardPanel, "Delivery Date:", member.DeliveryDate.ToString(), 120, 200);
                    CreateLabelAndTextBox(cardPanel, "Class Name:", className, 120, 250);

                    var backButton = new Button();
                    backButton.Text = "Back";
                    backButton.Location = new Point(550, 610);
                    backButton.Click += BackButton_Click;
                    backButton.Size = new Size(100, 50);
                    backButton.BackColor = Color.Black;
                    Panel_Main.Controls.Add(backButton);

                }
            }
        }
        #endregion

        #region Classes Methods
        private void BTN_Classes_Click(object sender, EventArgs e)
        {

            currentPage = "Classes";
            label_CurrentPage.Text = currentPage;
            Panel_Main.Controls.Clear();


            tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent));
            tableLayoutPanel.Size = new Size(600, 600);
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent));

            Panel_Main.Controls.Add(tableLayoutPanel);


            var searchPanel = CreateSearchPanel();
            tableLayoutPanel.Controls.Add(searchPanel, 0, 0);


            var memberTableLayoutPanel = new TableLayoutPanel();
            memberTableLayoutPanel.Dock = DockStyle.Fill;
            memberTableLayoutPanel.AutoScroll = true;
            tableLayoutPanel.Controls.Add(memberTableLayoutPanel, 0, 1);

            var Class = Context.Classes.ToList();
            foreach (var staffMember in Class)
            {

                Panel memberPanel = CreateEntityPanel(staffMember);

                memberPanel.Tag = staffMember.ID;

                
                memberPanel.Click += ClassesMemberPanel_Click;
                memberTableLayoutPanel.Controls.Add(memberPanel);

                memberTableLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
                memberTableLayoutPanel.BackColor = Color.DarkGray;  // may take it as borders of panels
            }
        }
        private void ClassesMemberPanel_Click(object sender, EventArgs e)
        {
  
            if (sender is Panel stuffMemberPanel)
            {
                int memberId = (int)stuffMemberPanel.Tag;
              
                var member = Context.Classes.FirstOrDefault(s => s.ID == memberId);

                if (member != null)
                {
                 
                    Panel_Main.Controls.Clear();

                    Panel_Main.BackColor = Color.Black;

            
                    var cardPanel = new Panel();
                    cardPanel.Location = new Point(350, 100);
                    cardPanel.Size = new Size(500, 500);
                    cardPanel.BorderStyle = BorderStyle.FixedSingle; 
                    cardPanel.BackColor = Color.DarkGray; 
                    Panel_Main.Controls.Add(cardPanel);

                    CreateLabelAndTextBox(cardPanel, "Name:", member.Name, 120, 60);
                    CreateLabelAndTextBox(cardPanel, "Code:", member.Code.ToString(), 120, 100);
                    CreateLabelAndTextBox(cardPanel, "Fees:", member.Fees.ToString(), 120, 150);

                    var backButton = new Button();
                    backButton.Text = "Back";
                    backButton.Location = new Point(550, 610);
                    backButton.Click += BackButton_Click;
                    backButton.Size = new Size(100, 50);
                    backButton.BackColor = Color.Black;
                    Panel_Main.Controls.Add(backButton);

                }
            }
        }

        #endregion

        #region Dashboard
        private void BTN_Dashboard_Click(object sender, EventArgs e)
        {
            currentPage = "Dashboard";
            Panel_Main.Controls.Clear();
            Dashboard form1 = new Dashboard();

            // Set the form's properties
            form1.TopLevel = false;
            form1.FormBorderStyle = FormBorderStyle.None;
            form1.Dock = DockStyle.Fill;
            form1.ForeColor = Color.Black;
            form1.Size = Panel_Main.Size;
            form1.Scale(.8f);

            // Set the WindowState to Maximized (full screen)
            form1.WindowState = FormWindowState.Maximized;

            Panel_Main.Controls.Add(form1);
            form1.Show();
        } 
        #endregion

        #region Class Enrollment
        private void btn_ClassEnrollment_Click(object sender, EventArgs e)
        {
            currentPage = "Classes Enrollment";
            Panel_Main.Controls.Clear();
            Form1 form1 = new Form1();
            form1.TopLevel = false;
            form1.FormBorderStyle = FormBorderStyle.None;
            form1.Dock = DockStyle.Fill;
            form1.ForeColor = Color.Black;
            form1.Size = Panel_Main.Size;
            form1.Scale(.5f);
            Panel_Main.Controls.Add(form1);
            form1.Show();
        }
        #endregion

        #region Log Out
        private void BTN_Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        } 
        #endregion

    }
}
