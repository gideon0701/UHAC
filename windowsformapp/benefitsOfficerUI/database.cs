using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace benefitsOfficerUI
{
    public partial class database : UserControl
    {
        public database()
        {
            InitializeComponent();
            checkRows();
        }

        private void database_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=pentagon1.database.windows.net;Initial Catalog=myhealthDb;Persist Security Info=True;User ID=pentagon;Password=@4r99ppea";

            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * From employees";

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);
            metroGrid1.DataSource = data;
            checkRows();
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=pentagon1.database.windows.net;Initial Catalog=myhealthDb;Persist Security Info=True;User ID=pentagon;Password=@4r99ppea";

            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * From employees WHERE name LIKE '%" + searchBox.Text + "%' OR id LIKE'%" + searchBox.Text + "%' OR email LIKE '%" + searchBox.Text + "%' OR position LIKE '%" + searchBox.Text + "%' OR HMO_id LIKE '%" + searchBox.Text + "%' OR department LIKE '%" + searchBox.Text + "%' OR healthProvider LIKE '%" + searchBox.Text + "%' OR [Card Expiration Date] LIKE '%" + searchBox.Text + "%'";

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);
            metroGrid1.DataSource = data;
           
        }
        public void checkRows()
        {

            foreach (DataGridViewRow row in metroGrid1.Rows)
            {
                try
                {

                    if (row.Cells[13].Value.ToString() == "1")
                    {
                        row.DefaultCellStyle.BackColor = Color.Azure;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }


                }
                catch (Exception ex)
                {
                    throw;
                }

            }
        }
        private void metroGrid1_Sorted(object sender, EventArgs e)
        {

        }
    }
}
