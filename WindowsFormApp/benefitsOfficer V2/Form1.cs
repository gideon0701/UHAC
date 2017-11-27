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
using DGVPrinterHelper;
using System.Data.SqlClient;
using MetroFramework;
namespace benefitsOfficer_V2
{
    public partial class home : Form
    {
        int btnSelected ; 

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        List<Panel> listPanel = new List<Panel>();
        public home()
        {
            InitializeComponent();
            RePaint();

            dataBasePanel.BringToFront();
        }
       
        private void home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myhealthDbDataSet.reqAssessment' table. You can move, or remove it, as needed.
        
            // TODO: This line of code loads data into the 'myhealthDbDataSet.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.myhealthDbDataSet.employees);
            checkRows();
          
            listPanel.Add(dataBasePanel);
            listPanel.Add(assessmentPanel);
            
        }


    
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

        public void checkRows()
        {

            foreach (DataGridViewRow row in employeeDataGrid.Rows)
            {
                try
                {

                    if (row.Cells[11].Value.ToString() == "1")
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 146, 72);
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }


                }
                catch (Exception ex)
                {
                    throw;
                }

            }
        }

        public void selectBarLocation()
        {
            if (btnSelected == 1)
            {
                selectBar.Location = new Point(192, dashBoardBtn.Location.Y);
            }
            else if ( btnSelected == 2)
            {
                selectBar.Location = new Point(192, 117);
            }
            else if (btnSelected == 3)
            {
                selectBar.Location = new Point(192, 161);
            }
            else if (btnSelected == 4)
            {
                selectBar.Location = new Point(192, button3.Location.Y);
            }
            else if (btnSelected == 5)
            {
                selectBar.Location = new Point(192, button4.Location.Y);
            }


            if(btnSelected != 2)
            {
                searchBox.Enabled = false;
                viewRecordBtn.Visible = false; 
                
            }
        }
        private void dashBoardBtn_MouseEnter(object sender, EventArgs e)
        { 
            dashBoardBtn.ForeColor = System.Drawing.Color.FromArgb(246, 140, 30);
        }
        private void dashBoardBtn_MouseLeave(object sender, EventArgs e)
        {
            if (btnSelected != 1)
            {
                dashBoardBtn.ForeColor = System.Drawing.Color.FromArgb(158, 158, 158);
            }
        }
        private void databaseBtn_MouseEnter(object sender, EventArgs e)
        {
            dataBaseBtn.ForeColor = System.Drawing.Color.FromArgb(246, 140, 30);
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            if (btnSelected != 2)
            {
                dataBaseBtn.ForeColor = System.Drawing.Color.FromArgb(158, 158, 158);
            }
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
          
                assessmentBtn.ForeColor = System.Drawing.Color.FromArgb(246, 140, 30);
            
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            if (btnSelected != 3)
            {
                assessmentBtn.ForeColor = System.Drawing.Color.FromArgb(158, 158, 158);
            }
        }
        private void button3_MouseEnter(object sender, EventArgs e)
        {
           
                button3.ForeColor = System.Drawing.Color.FromArgb(246, 140, 30);
             
        }
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            if (btnSelected != 4)
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
            if (btnSelected != 5)
            {
                button4.ForeColor = System.Drawing.Color.FromArgb(158, 158, 158);
            }
        }

        private void employeeDataGrid_Sorted(object sender, EventArgs e)
        {
            checkRows();
        }

        private void displayRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int getId = Convert.ToInt32(employeeDataGrid.CurrentRow.Cells[0].Value);
                employeeRecordView recordForm = new employeeRecordView(getId);
                recordForm.Show();
            }
            catch (ConstraintException)
            {
                throw;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int getId = Convert.ToInt32(employeeDataGrid.CurrentRow.Cells[0].Value);
                employeeRecordView recordForm = new employeeRecordView(getId);
                recordForm.Show();
            }
            catch (ConstraintException)
            {
                throw;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {


            searchBox.Text = "Search";
            searchBox.Font = new Font(searchBox.Font, FontStyle.Italic);
            searchBox.ForeColor = SystemColors.GrayText;

            string txt = "";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=pentagon1.database.windows.net;Initial Catalog=myhealthDb;Persist Security Info=True;User ID=pentagon;Password=@4r99ppea";

            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * From employees WHERE name LIKE '%" + txt + "%' OR id LIKE'%" + txt + "%' OR email LIKE '%" + txt + "%' OR position LIKE '%" + txt + "%' OR HMO_id LIKE '%" + txt + "%' OR department LIKE '%" + txt + "%' OR healthProvider LIKE '%" + txt + "%' OR [Card Expiration Date] LIKE '%" + txt + "%'";

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);
            employeeDataGrid.DataSource = data;
            checkRows();

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

            searchBox.Text = "";
            searchBox.Font = new Font(searchBox.Font, FontStyle.Regular);
            searchBox.ForeColor = SystemColors.WindowText;

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=pentagon1.database.windows.net;Initial Catalog=myhealthDb;Persist Security Info=True;User ID=pentagon;Password=@4r99ppea";

                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "SELECT * From employees WHERE name LIKE '%" + searchBox.Text + "%' OR id LIKE'%" + searchBox.Text + "%' OR email LIKE '%" + searchBox.Text + "%' OR position LIKE '%" + searchBox.Text + "%' OR HMO_id LIKE '%" + searchBox.Text + "%' OR department LIKE '%" + searchBox.Text + "%' OR healthProvider LIKE '%" + searchBox.Text + "%' OR [Card Expiration Date] LIKE '%" + searchBox.Text + "%'";

                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);
                employeeDataGrid.DataSource = data;
                checkRows();
            
        }

        private void analyticsBtn_click(object sender, EventArgs e)
        {
            

            dashBoardBtn.ForeColor = System.Drawing.Color.FromArgb(246, 140, 30);

            assessmentBtn.ForeColor = System.Drawing.Color.FromArgb(158, 158, 158);
            dataBasePanel.ForeColor = System.Drawing.Color.FromArgb(158, 158, 158);
            button3.ForeColor = System.Drawing.Color.FromArgb(158, 158, 158);
            button4.ForeColor = System.Drawing.Color.FromArgb(158, 158, 158);

            dashBoardBtn.BackColor = System.Drawing.Color.FromArgb(17, 25, 52);

            assessmentBtn.BackColor = System.Drawing.Color.FromArgb(43, 51, 62);
            dataBaseBtn.BackColor = System.Drawing.Color.FromArgb(43, 51, 62);
            button3.BackColor = System.Drawing.Color.FromArgb(43, 51, 62);
            button4.BackColor = System.Drawing.Color.FromArgb(43, 51, 62);

            btnSelected = 1;
            selectBarLocation();
            //analyticsPanel.Visible = true;
            assessmentPanel.Visible = false;
            dataBasePanel.Visible = false;

        }
        private void dataBaseBtn_Click(object sender, EventArgs e)
        {

            dataBasePanel.BringToFront();
            dataBaseBtn.ForeColor = System.Drawing.Color.FromArgb(246, 140, 30);

            assessmentBtn.ForeColor = System.Drawing.Color.FromArgb(158, 158, 158);
            dashBoardBtn.ForeColor = System.Drawing.Color.FromArgb(158, 158, 158);
            button3.ForeColor = System.Drawing.Color.FromArgb(158, 158, 158);
            button4.ForeColor = System.Drawing.Color.FromArgb(158, 158, 158);


            dataBaseBtn.BackColor = System.Drawing.Color.FromArgb(17, 25, 52);

            assessmentBtn.BackColor = System.Drawing.Color.FromArgb(43, 51, 62);
            dashBoardBtn.BackColor = System.Drawing.Color.FromArgb(43, 51, 62);
            button3.BackColor = System.Drawing.Color.FromArgb(43, 51, 62);
            button4.BackColor = System.Drawing.Color.FromArgb(43, 51, 62);

            btnSelected = 2;

            selectBarLocation();
        //    assessmentPanel.Visible = false;
           // dataBasePanel.Visible = true;
          //  analyticsPanel.Visible = false;


        }

        private void assessmentBtn_Click(object sender, EventArgs e)
        {
            assessmentPanel.BringToFront();
            selectBarLocation();

            assessmentBtn.ForeColor = System.Drawing.Color.FromArgb(246, 140, 30);

            dashBoardBtn.ForeColor = System.Drawing.Color.FromArgb(158, 158, 158);
            dataBaseBtn.ForeColor = System.Drawing.Color.FromArgb(158, 158, 158);
            button3.ForeColor = System.Drawing.Color.FromArgb(158, 158, 158);
            button4.ForeColor = System.Drawing.Color.FromArgb(158, 158, 158);

            assessmentBtn.BackColor = System.Drawing.Color.FromArgb(17, 25, 52);

            dataBaseBtn.BackColor = System.Drawing.Color.FromArgb(43, 51, 62);
            dashBoardBtn.BackColor = System.Drawing.Color.FromArgb(43, 51, 62);
            button3.BackColor = System.Drawing.Color.FromArgb(43, 51, 62);
            button4.BackColor = System.Drawing.Color.FromArgb(43, 51, 62);

            btnSelected = 3;

           

            //analyticsPanel.Visible = false;
        }

        private void dataBasePanel_Paint(object sender, PaintEventArgs e)
        {

        }

    



        private void depCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(depCombo.Text == "Spouse and Kids")
            {
                bchild1.Visible = true;
                depNumLabel.Visible = true;
                depNumCombo.Visible = true;
               
            }
            else
            {
                bchild1.Visible = false;
             
                depNumLabel.Visible = false;
                depNumCombo.Visible = false;
            }
        }

        private void depNumCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (depNumCombo.Text == "2")
            {
                bchild2.Visible = true;
                bchild3.Visible = false;
            }
            else if (depNumCombo.Text == "3")
            {

                bchild2.Visible = true;
                bchild3.Visible = true;
            }
            else
            {
                bchild2.Visible = false;
                bchild3.Visible = false;
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            getMaritalStatus(idNum.Text);
        }

        private void idNum_TextChanged(object sender, EventArgs e)
        {
            if (idNum.Text == "")
            {
                maritalValue.Text = "";
            }
            else
            {
                timer1.Stop();
                timer1.Start();
            }
        }
        string maritalStat;
        private void getMaritalStatus(string id)
        {
            if (id != "")
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=pentagon1.database.windows.net;Initial Catalog=myhealthDb;Persist Security Info=True;User ID=pentagon;Password=@4r99ppea"))
                {
                    conn.Open();
                    string query = "SELECT isMarried FROM employees WHERE id =" + id;
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        maritalStat = reader[0].ToString();

                    }
                    conn.Close();
                }
            }
            if (maritalStat == "1") {

                maritalValue.Text = "Married";

                mContract.Visible = true;
                bFather.Visible = false;
                bMother.Visible = false;

                depNumCombo.Visible = true;
                depNumLabel.Visible = true;
                depLabel.Visible = true;
                depCombo.Visible = true;
                depNumCombo.Text = "1";

            }
            else if(maritalStat =="0")
            {
                maritalValue.Text = "Single";
                mContract.Visible = false;
                bFather.Visible = true;
                bMother.Visible = true;
                bchild1.Visible = false;
                bchild2.Visible = false;
                bchild3.Visible = false;
                depNumCombo.Visible = false;
                depLabel.Visible = false;
                depNumCombo.Visible = false;
                depNumLabel.Visible = false;
            }
            else
            {
                maritalValue.Text = "";
                mContract.Visible = false;
                bFather.Visible = true;
                bMother.Visible = true;
                bchild1.Visible = false;
                bchild2.Visible = false;
                bchild3.Visible = false;
                depNumCombo.Visible = false;
                depLabel.Visible = false;
                depNumCombo.Visible = false;
                depNumLabel.Visible = false;
            }
        }


        string dependents;
        int numDep;
        int j;
        private void submit_Click(object sender, EventArgs e)
        {

         
         
            List<String> docu = new List<String>();
            var checkBox = groupBox.Controls.OfType<CheckBox>();
            if (maritalValue.Text == "Single")
            {
                dependents = "Parents";
                numDep = 2;
                foreach (CheckBox cb in checkBox)
                {
                    if (cb.Checked)
                    {
                        docu.Add(cb.Name.ToString());
                    }

                }
                 //update query
            }
            else if(maritalValue.Text == "Married")
            {
                dependents = depCombo.Text;
                if(depCombo.Text == "Spouse and Kids")
                {
                    int x = Int32.Parse(depNumCombo.Text);
                    numDep = 1 + x ; 

                }
                else if (depCombo.Text == "Spouse Only")
                {
                    numDep = 1;

                }

                foreach (CheckBox cb in checkBox)
                {
                    if (cb.Checked)
                    {
                        docu.Add(cb.Name.ToString());
                    }
                }


            }


           // richTextBox1.Text = String.Join("\n",docu);
        //    richTextBox1.Text = richTextBox1.Text + "\n"+ dependents+ "\n" + numDep.ToString();

            
            foreach(var itemNum in docu)
            {
                assessmentToDb(docu[j],idNum.Text);
                j++;
            }
            docu.Clear();
        }
        
        string query;
        private void assessmentToDb(string dLabel,string id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=pentagon1.database.windows.net;Initial Catalog=myhealthDb;Persist Security Info=True;User ID=pentagon;Password=@4r99ppea"))
                {
                    conn.Open();
                    query = "UPDATE requirements SET  isReceived = 1 WHERE employee_id =" + id + "AND documentLabel='" + dLabel + "';";

                    SqlCommand command = new SqlCommand(query, conn);
                    command.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }

}
