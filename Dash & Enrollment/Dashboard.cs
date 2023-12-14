using LiveCharts;
using LiveCharts.Helpers;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using SeriesCollection = LiveCharts.SeriesCollection;

namespace WindowsFormsApp1
{
    public partial class Dashboard : Form
    {
        private string connectionString = "Server=.;Database=GymSystem;Trusted_Connection=True ;TrustServerCertificate=True;";
        GymSystemEntities context = new GymSystemEntities();


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidthEllipse,
                int nHeightEllipse
            );

        public Dashboard()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

        Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);

        private void Form1_Load(object sender, EventArgs e)
        {
            var firstChar = context.MoneyGraphList().ToList();

            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 60, 60));
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 60, 60));
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 60, 60));
            panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 60, 60));


            //pieChart_trainees.BackColor = Color.Red;
            pieChart_trainees.ForeColor = Color.Green;

            #region First Chart
            // Clear any existing data
            //chart_money.Series.Clear();

            // Create a new series
            System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series("Sample Data");

            // Add data points to the series
            //series.Points.AddXY("1", 2000);

            for (int i = 0; i < firstChar.Count; i++)
            {
                series.Points.AddXY((i + 1).ToString(), firstChar[i]);

            }

            // Add the series to the chart
            chart_money.Series.Add(series);

            // Set the chart type to column chart
            series.ChartType = SeriesChartType.Column;

            #endregion

            #region pieChart

            var secondChar = context.TraineePerEachClass().ToList();

            SeriesCollection seriesCollection = new SeriesCollection();

            foreach (var item in secondChar)
            {
                seriesCollection.Add(new PieSeries() { Title = item.Name.ToString(), Values = new ChartValues<int> { int.Parse(item.trainees.ToString()) }, DataLabels = true, LabelPoint = labelPoint });
            }

            //seriesCollection.Add(new PieSeries() { Title = "A", Values = new ChartValues<int> { 5 }, DataLabels = true, LabelPoint = labelPoint });


            pieChart_trainees.Series = seriesCollection;

            pieChart_trainees.LegendLocation = LegendLocation.Bottom;

            #endregion

            #region Third Chart

            var thirdChar = context.TraineesPerClassMonths().ToList();


            //var groupedData = thirdChar.GroupBy(row => row.className);
            var groupedMonth = thirdChar.GroupBy(row => row.last);
            var groupedClass = thirdChar.GroupBy(row => row.className);

            //// x axis
            cartesianChart_trainees.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
            });

            //// y axis
            cartesianChart_trainees.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Trainees",
                //LabelFormatter= value=>value.ToString("")
            });

            cartesianChart_trainees.LegendLocation = LiveCharts.LegendLocation.Right;

            //// init data
            cartesianChart_trainees.Series.Clear();
            SeriesCollection chart3Series = new SeriesCollection();


            foreach (var item in groupedClass)
            {
                var newOne = new ChartValues<int>();

                for (int i = 0; i < groupedMonth.Count(); i++)
                {
                    if (thirdChar.Where(s => s.className == item.Key && s.last == i).Select(s=>s.Traffic).FirstOrDefault()==null)
                    {
                        newOne.Add(0);
                    }
                    else
                    {
                        newOne.Add(int.Parse(thirdChar.Where(s => s.className == item.Key && s.last == i).Select(s => s.Traffic).FirstOrDefault().ToString()));
                    }

                }

                chart3Series.Add(new LineSeries() { Title = item.Key, Values = newOne });

            }


            cartesianChart_trainees.Series = chart3Series;

            #endregion



            #region panels

    
            var totalMoney = context.TraineesClassesEnrollments.Select(s=>s.SubFee).Sum();
            label_totalMoney.Text = totalMoney.ToString()+"$";

            var totalTrainers = context.Staffs.Select(t => t.JobTitle == "Trainer").Count();
            label_totalCoachs.Text = totalTrainers.ToString();

            var totalTrainees = context.Trainees.Count();
            label_totalTrainees.Text = totalTrainees.ToString();

            var totalEquip = context.Equipments.Count();
            label_totalEquip.Text = totalEquip.ToString();

            #endregion

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }


    }

