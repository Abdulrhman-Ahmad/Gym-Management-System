namespace WindowsFormsApp1
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label_totalTrainees = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label_totalCoachs = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_totalMoney = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label_totalEquip = new System.Windows.Forms.Label();
            this.cartesianChart_trainees = new LiveCharts.WinForms.CartesianChart();
            this.pieChart_trainees = new LiveCharts.WinForms.PieChart();
            this.chart_money = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_money)).BeginInit();
            this.SuspendLayout();
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.cartesianChart_trainees);
            this.panel1.Controls.Add(this.pieChart_trainees);
            this.panel1.Controls.Add(this.chart_money);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1348, 720);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(922, 634);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(394, 29);
            this.label11.TabIndex = 18;
            this.label11.Text = "Trainees per Months for each class ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(561, 634);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 29);
            this.label10.TabIndex = 17;
            this.label10.Text = "Trainees per Class";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(170, 634);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 29);
            this.label9.TabIndex = 16;
            this.label9.Text = "Money per Month";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGreen;
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.label_totalTrainees);
            this.panel4.Location = new System.Drawing.Point(716, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(281, 193);
            this.panel4.TabIndex = 13;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(50, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(170, 29);
            this.label20.TabIndex = 4;
            this.label20.Text = "Total Trainees";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(7, 54);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 93);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // label_totalTrainees
            // 
            this.label_totalTrainees.AutoSize = true;
            this.label_totalTrainees.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalTrainees.ForeColor = System.Drawing.Color.White;
            this.label_totalTrainees.Location = new System.Drawing.Point(131, 73);
            this.label_totalTrainees.Name = "label_totalTrainees";
            this.label_totalTrainees.Size = new System.Drawing.Size(104, 54);
            this.label_totalTrainees.TabIndex = 5;
            this.label_totalTrainees.Text = "980";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label_totalCoachs);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(397, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 193);
            this.panel2.TabIndex = 14;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(61, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(164, 29);
            this.label21.TabIndex = 3;
            this.label21.Text = "Total Trainers";
            // 
            // label_totalCoachs
            // 
            this.label_totalCoachs.AutoSize = true;
            this.label_totalCoachs.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalCoachs.ForeColor = System.Drawing.Color.White;
            this.label_totalCoachs.Location = new System.Drawing.Point(132, 73);
            this.label_totalCoachs.Name = "label_totalCoachs";
            this.label_totalCoachs.Size = new System.Drawing.Size(77, 54);
            this.label_totalCoachs.TabIndex = 3;
            this.label_totalCoachs.Text = "50";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 93);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.IndianRed;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label_totalMoney);
            this.panel3.Location = new System.Drawing.Point(78, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(281, 193);
            this.panel3.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 93);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Money";
            // 
            // label_totalMoney
            // 
            this.label_totalMoney.AutoSize = true;
            this.label_totalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalMoney.ForeColor = System.Drawing.Color.White;
            this.label_totalMoney.Location = new System.Drawing.Point(99, 73);
            this.label_totalMoney.Name = "label_totalMoney";
            this.label_totalMoney.Size = new System.Drawing.Size(122, 51);
            this.label_totalMoney.TabIndex = 0;
            this.label_totalMoney.Text = "856$";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.label_totalEquip);
            this.panel5.Location = new System.Drawing.Point(1035, 57);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(281, 193);
            this.panel5.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(59, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "Total Equipments";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 54);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 93);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // label_totalEquip
            // 
            this.label_totalEquip.AutoSize = true;
            this.label_totalEquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalEquip.ForeColor = System.Drawing.Color.White;
            this.label_totalEquip.Location = new System.Drawing.Point(134, 73);
            this.label_totalEquip.Name = "label_totalEquip";
            this.label_totalEquip.Size = new System.Drawing.Size(104, 54);
            this.label_totalEquip.TabIndex = 8;
            this.label_totalEquip.Text = "985";
            // 
            // cartesianChart_trainees
            // 
            this.cartesianChart_trainees.BackColor = System.Drawing.Color.Transparent;
            this.cartesianChart_trainees.Location = new System.Drawing.Point(892, 312);
            this.cartesianChart_trainees.Name = "cartesianChart_trainees";
            this.cartesianChart_trainees.Size = new System.Drawing.Size(424, 284);
            this.cartesianChart_trainees.TabIndex = 11;
            this.cartesianChart_trainees.Text = "cartesianChart1";
            // 
            // pieChart_trainees
            // 
            this.pieChart_trainees.BackColor = System.Drawing.Color.Transparent;
            this.pieChart_trainees.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pieChart_trainees.Location = new System.Drawing.Point(451, 312);
            this.pieChart_trainees.Name = "pieChart_trainees";
            this.pieChart_trainees.Size = new System.Drawing.Size(424, 284);
            this.pieChart_trainees.TabIndex = 10;
            this.pieChart_trainees.Text = "pieChart1";
            // 
            // chart_money
            // 
            this.chart_money.BackColor = System.Drawing.Color.Transparent;
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            chartArea3.Name = "ChartArea1";
            this.chart_money.ChartAreas.Add(chartArea3);
            this.chart_money.Location = new System.Drawing.Point(33, 312);
            this.chart_money.Name = "chart_money";
            this.chart_money.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series3.ChartArea = "ChartArea1";
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.Name = "Series1";
            this.chart_money.Series.Add(series3);
            this.chart_money.Size = new System.Drawing.Size(424, 284);
            this.chart_money.TabIndex = 9;
            this.chart_money.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1348, 720);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_money)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label_totalTrainees;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label_totalCoachs;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_totalMoney;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label_totalEquip;
        private LiveCharts.WinForms.CartesianChart cartesianChart_trainees;
        private LiveCharts.WinForms.PieChart pieChart_trainees;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_money;
    }
}

