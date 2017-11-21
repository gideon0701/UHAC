using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace benefitsOfficer_v1
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        
        int PW;
        bool sliderHidden;
        public Form1()
        {
            InitializeComponent();
            PW = slidePanel.Width;
            sliderHidden = true;
            //metroProgressSpinner1.Visible = false;
            //metroProgressSpinner1.Spinning = false;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myhealthDbDataSet.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.myhealthDbDataSet.employees);
         
            // TODO: This line of code loads data into the 'myhealthDbDataSet.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.myhealthDbDataSet.employees);
            checkRows();
        }
        public void checkRows()
        {
            
            foreach (DataGridViewRow row in dataGridPanel.Rows)
            {
                try
                {
                   
                    if(row.Cells[11].Value.ToString() =="1")
                    {
                        row.DefaultCellStyle.BackColor = Color.Orange;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                  
                   
                }
                catch (Exception ex)
                {

                }

            }
        }
   
        private void metroTile1_Click(object sender, EventArgs e)
        {
            sliderTimer.Start();
        }

        private void sliderTimer_Tick(object sender, EventArgs e)
        {
            if (sliderHidden)
            {
                slidePanel.Width = slidePanel.Width + 50;
                if (slidePanel.Width >= controlsPanel.Width)
                {
                    sliderTimer.Stop();
                    sliderHidden = false;
                    this.Refresh();
                }
            }
            else
            {
                slidePanel.Width = slidePanel.Width - 50;
                if(slidePanel.Width<= 55)
                {
                    sliderTimer.Stop();
                    sliderHidden = true;
                    this.Refresh();
                }
            }
        }

  
        private void dataGridPanel_Sorted(object sender, EventArgs e)
        {
            checkRows();
        }

     

    

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            //metroProgressSpinner1.Visible = true;
            //metroProgressSpinner1.Spinning = true;
            
            
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=pentagon1.database.windows.net;Initial Catalog=myhealthDb;Persist Security Info=True;User ID=pentagon;Password=@4r99ppea";

            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * From employees WHERE name LIKE '%" + searchBox.Text + "%' OR id LIKE'%" + searchBox.Text + "%' OR email LIKE '%"+ searchBox.Text +"%' OR position LIKE '%"+ searchBox.Text +"%' OR HMO_id LIKE '%"+searchBox.Text+"%' OR department LIKE '%"+ searchBox.Text +"%' OR healthProvider LIKE '%" + searchBox.Text + "%' OR [Card Expiration Date] LIKE '%" + searchBox.Text +"%'";

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
         
            adapter.Fill(data);
            dataGridPanel.DataSource = data;

           
            //metroProgressSpinner1.Spinning = false;
            //metroProgressSpinner1.Visible = false;

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int getId = Convert.ToInt32(dataGridPanel.CurrentRow.Cells[0].Value);
                detailViewForm dVForm = new detailViewForm(getId);
                dVForm.Show();
            }
            catch (ConstraintException)
            {
                throw;
            }
        }

        
    }
}
