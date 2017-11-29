using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
namespace benefitsOfficerUI
{
    public partial class dashboard : UserControl
    {
        public dashboard()
        {
            InitializeComponent();
         
        }

       


        public void cartesianChart()
            
        {

            cartesianChart1.Zoom = ZoomingOptions.Xy;
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Dental",
                    Values = new ChartValues<double> {4,6,5,2,7}
                },
                new LineSeries
                {
                    Title = "Optical",
                    Values = new ChartValues<double> {6,7,3,4,6},
                    PointGeometry = DefaultGeometries.Triangle

                },
                new LineSeries
                {
                    Title = "Medical",
                    Values = new ChartValues<double> {5,2,8,3 },
                    PointGeometry = DefaultGeometries.Square,
                    PointGeometrySize = 10

                }
            };
            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May" }
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Number of Availment",
                LabelFormatter = value => value.ToString()
            });

            cartesianChart1.LegendLocation = LegendLocation.Right;

            cartesianChart1.Series[2].Values.Add(5d);
            cartesianChart1.DataClick += CartesianChart1OnDataClick;

        }
        private void CartesianChart1OnDataClick(object sender, ChartPoint chartPoint)
        {
            MessageBox.Show("You clicked (" + chartPoint.X + "," + chartPoint.Y + ")");
        }
        public void PieChart()
        {

            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "IT",
                    Values = new ChartValues<double> {3},
                    PushOut =15,
                    DataLabels=true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Accounting",
                    Values = new ChartValues<double> {4},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Sales",
                    Values = new ChartValues<double> {10},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Security",
                    Values = new ChartValues<double> {22},
                    DataLabels = true ,
                    LabelPoint = labelPoint
                }
            };
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            cartesianChart();
            PieChart();
        }
    }
}
