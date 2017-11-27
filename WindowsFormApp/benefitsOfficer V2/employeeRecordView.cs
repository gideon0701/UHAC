using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DGVPrinterHelper;
namespace benefitsOfficer_V2
{
    public partial class employeeRecordView : Form
    {
        int i;
        string name;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public employeeRecordView(int getId)
        {
            InitializeComponent();
            RePaint();
            i = getId;
            queryName(i);
        }
        private void Form_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        protected void RePaint()
        {
            GraphicsPath graphicpath = new GraphicsPath();
            graphicpath.StartFigure();
            graphicpath.AddArc(0, 0, 20, 20, 180, 90);
            graphicpath.AddLine(25, 0, this.Width - 25, 0);
            graphicpath.AddArc(this.Width - 25, 0, 25, 25, 270, 90);
            graphicpath.AddLine(this.Width, 25, this.Width, this.Height - 25);
            graphicpath.AddArc(this.Width - 25, this.Height - 25, 25, 25, 0, 90);
            graphicpath.AddLine(this.Width - 25, this.Height, 25, this.Height);
            graphicpath.AddArc(0, this.Height - 25, 25, 25, 90, 90);
            graphicpath.CloseFigure();
            this.Region = new Region(graphicpath);
        }

        private void employeeRecordView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myhealthDbDataSet.Records' table. You can move, or remove it, as needed.
            this.recordsTableAdapter.Fill(this.myhealthDbDataSet.Records);
            fillDt(i);
        }
        public void queryName(int id)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=pentagon1.database.windows.net;Initial Catalog=myhealthDb;Persist Security Info=True;User ID=pentagon;Password=@4r99ppea"))
            {
                conn.Open();
                string query = "SELECT name FROM employees WHERE id =" + id.ToString();
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    name = reader[0].ToString();

                }
            }
        }
        public void fillDt(int id)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=pentagon1.database.windows.net;Initial Catalog=myhealthDb;Persist Security Info=True;User ID=pentagon;Password=@4r99ppea";

                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "SELECT * From records WHERE id =" + id;

                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);
                recordDataGrid.DataSource = data;
            }
            catch (NullReferenceException)
            {
                throw;
            }
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = name + "'s Benefits Report - ";
            printer.SubTitle = "UnionBank of The Philippines \n" + string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "";
            printer.FooterSpacing = 15;
            //  printer.PrintDataGridView(recordGrid);
            printer.PrintPreviewNoDisplay(recordDataGrid);
        }
    }
}
