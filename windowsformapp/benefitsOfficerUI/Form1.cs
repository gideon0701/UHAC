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
using MetroFramework;
using DGVPrinterHelper;
using System.Data.SqlClient;
namespace benefitsOfficerUI
{
    public partial class Form1 : Form
    {
        int btnSelected;
        string name;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
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
        public Form1()
        {
            InitializeComponent();
            RePaint();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myhealthDbDataSet.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.myhealthDbDataSet.employees);
            checkRows();

            button1.PerformClick();
        }






        /////////////////////////////////////////////////button effects

        //selected buttion tile position handler
        public void selectBarLocation(int select)
        {
            if (select == 1)
            {
                selectTile.Location = new Point(0, button1.Location.Y);

            }
            else if (select == 2)
            {
                selectTile.Location = new Point(0, button2.Location.Y);
            }
            else if (select == 3)
            {
                selectTile.Location = new Point(0, button3.Location.Y);
            }
            else if (select == 4)
            {
                selectTile.Location = new Point(0, button4.Location.Y);
            }

            btnSelected = select;

            //if (btnSelected != 2)
            //{
            //    searchBox.Enabled = false;
            //    viewRecordBtn.Visible = false;

            //}
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = System.Drawing.Color.FromArgb(246, 140, 30);
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            if (btnSelected != 1)
            {
                button1.ForeColor = System.Drawing.Color.FromArgb(158, 158, 158);
            }
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = System.Drawing.Color.FromArgb(246, 140, 30);
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            if (btnSelected != 2)
            {
                button2.ForeColor = System.Drawing.Color.FromArgb(158, 158, 158);
            }
        }
        private void button3_MouseEnter(object sender, EventArgs e)
        {

            button3.ForeColor = System.Drawing.Color.FromArgb(246, 140, 30);

        }
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            if (btnSelected != 3)
            {
                button3.ForeColor = System.Drawing.Color.FromArgb(158, 158, 158);
            }
        }
        private void button4_MouseEnter(object sender, EventArgs e)
        {

            button4.ForeColor = System.Drawing.Color.FromArgb(246, 140, 30);

        }
        private void button4_MouseLeave(object sender, EventArgs e)
        {
            if (btnSelected != 4)
            {
                button4.ForeColor = System.Drawing.Color.FromArgb(158, 158, 158);
            }
        }

        private void button1_click(object sender, EventArgs e)
        {

            dashboard1.BringToFront();

            //change forecolor of button 1
            button1.ForeColor = System.Drawing.Color.FromArgb(246, 140, 30);
            button2.ForeColor = System.Drawing.Color.FromArgb(158, 158, 158);
            button3.ForeColor = System.Drawing.Color.FromArgb(158, 158, 158);
            button4.ForeColor = System.Drawing.Color.FromArgb(158, 158, 158);


            //change backcolor of button 1
            button1.BackColor = System.Drawing.Color.FromArgb(17, 25, 52);
            button2.BackColor = System.Drawing.Color.FromArgb(43, 51, 62);
            button3.BackColor = System.Drawing.Color.FromArgb(43, 51, 62);
            button4.BackColor = System.Drawing.Color.FromArgb(43, 51, 62);


            selectBarLocation(1);


        }
        private void button2_Click(object sender, EventArgs e)
        {
            dbPanel.BringToFront();
            checkRows();
            //change forecolor of button 2
            button2.ForeColor = System.Drawing.Color.FromArgb(246, 140, 30);
            button1.ForeColor = System.Drawing.Color.FromArgb(158, 158, 158);
            button3.ForeColor = System.Drawing.Color.FromArgb(158, 158, 158);
            button4.ForeColor = System.Drawing.Color.FromArgb(158, 158, 158);


            //change backcolor of button 1
            button2.BackColor = System.Drawing.Color.FromArgb(17, 25, 52);
            button1.BackColor = System.Drawing.Color.FromArgb(43, 51, 62);
            button3.BackColor = System.Drawing.Color.FromArgb(43, 51, 62);
            button4.BackColor = System.Drawing.Color.FromArgb(43, 51, 62);



            selectBarLocation(2);

            //    assessmentPanel.Visible = false;
            // dataBasePanel.Visible = true;
            //  analyticsPanel.Visible = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            assesstmentControl1.BringToFront();
            //change forecolor of button 3
            button3.ForeColor = System.Drawing.Color.FromArgb(246, 140, 30);
            button2.ForeColor = System.Drawing.Color.FromArgb(158, 158, 158);
            button1.ForeColor = System.Drawing.Color.FromArgb(158, 158, 158);
            button4.ForeColor = System.Drawing.Color.FromArgb(158, 158, 158);


            //change backcolor of button 3
            button3.BackColor = System.Drawing.Color.FromArgb(17, 25, 52);
            button2.BackColor = System.Drawing.Color.FromArgb(43, 51, 62);
            button1.BackColor = System.Drawing.Color.FromArgb(43, 51, 62);
            button4.BackColor = System.Drawing.Color.FromArgb(43, 51, 62);

            selectBarLocation(3);





        }
        private void button4_Click(object sender, EventArgs e)
        {
            //change forecolor of button 3
            button4.ForeColor = System.Drawing.Color.FromArgb(246, 140, 30);
            button3.ForeColor = System.Drawing.Color.FromArgb(158, 158, 158);
            button2.ForeColor = System.Drawing.Color.FromArgb(158, 158, 158);
            button1.ForeColor = System.Drawing.Color.FromArgb(158, 158, 158);



            //change backcolor of button 3
            button4.BackColor = System.Drawing.Color.FromArgb(17, 25, 52);
            button3.BackColor = System.Drawing.Color.FromArgb(43, 51, 62);
            button2.BackColor = System.Drawing.Color.FromArgb(43, 51, 62);
            button1.BackColor = System.Drawing.Color.FromArgb(43, 51, 62);





            selectBarLocation(4);


            //analyticsPanel.Visible = false;
        }


        ///////////////////////////////////////////////////////////////



        //////////////////////////////////////////////// DataGridView

        public void checkRows()
        {

            foreach (DataGridViewRow row in metroGrid1.Rows)
            {
                try
                {

                    if (row.Cells[10].Value.ToString() == "1")
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(200, 200, 200); ;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void metroGrid1_Sorted(object sender, EventArgs e)
        {
            checkRows();
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=pentagon1.database.windows.net;Initial Catalog=myhealthDb;Persist Security Info=True;User ID=pentagon;Password=@4r99ppea";

            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * From employees WHERE name LIKE '%" + metroTextBox1.Text + "%' OR id LIKE'%" + metroTextBox1.Text + "%' OR email LIKE '%" + metroTextBox1.Text + "%' OR position LIKE '%" + metroTextBox1.Text + "%' OR HMO_id LIKE '%" + metroTextBox1.Text + "%' OR department LIKE '%" + metroTextBox1.Text + "%' OR healthProvider LIKE '%" + metroTextBox1.Text + "%' OR [Card Expiration Date] LIKE '%" + metroTextBox1.Text + "%'";

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);
            metroGrid1.DataSource = data;
            checkRows();
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {

            try
            {
                int getId = Convert.ToInt32(metroGrid1.CurrentRow.Cells[0].Value);
                Form2 recordForm = new Form2(getId);
                recordForm.Show();
            }
            catch (ConstraintException)
            {
                throw;
            }
        }


        ///////////////////////////////////////////////////////////////

    }
}
