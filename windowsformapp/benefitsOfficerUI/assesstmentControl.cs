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
    public partial class assesstmentControl : UserControl
    {
        string result;
        public assesstmentControl()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

     

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            formPanel.Width += 50;
            if(formPanel.Width >= metroPanel1.Width)
            {
                timer1.Stop();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=pentagon1.database.windows.net;Initial Catalog=myhealthDb;Persist Security Info=True;User ID=pentagon;Password=@4r99ppea"))
                {
                    conn.Open();
                    string getNameQuery = "SELECT id FROM employees WHERE id =" + metroTextBox1.Text;
                    SqlCommand command = new SqlCommand(getNameQuery, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        result = reader[0].ToString();

                    }
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (result == "1")
            {
                timer1.Start();
            }
            else
            {

            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            formPanel.Width -= 50;
            if (formPanel.Width <= 0)
            {
                timer1.Stop();
            }
        }
    }
}
