using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DGVPrinterHelper;
namespace benefitsOfficer_v1
{
    public partial class detailViewForm : MetroFramework.Forms.MetroForm
    {
        int i;
        string name;
        public detailViewForm(int getId)
        {
            InitializeComponent();
            i = getId;
            queryName(i);
        }

        private void detailViewForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myhealthDbDataSet.records' table. You can move, or remove it, as needed.
            fillDt(i);

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
                recordGrid.DataSource = data;
            }
            catch (NullReferenceException)
            {
                throw;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Records Report";

            for (int i = 1; i < recordGrid.Columns.Count + 1; i++)
            {
                worksheet.Cells[1,i] = recordGrid.Columns[i-1].HeaderText;

                    
            }

            for (int i = 0; i < recordGrid.Rows.Count; i++)
            {
                for(int j = 0; j < recordGrid.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = recordGrid.Rows[i].Cells[j].Value.ToString();
                }
            }

            


            SaveFileDialog save = new SaveFileDialog();
            save.FileName =   name +"'s Benefits Record";
            save.DefaultExt = ".xlsx";
            
            if(save.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(save.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
               
            }
            
            app.Quit();
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

        private void metroButton2_Click(object sender, EventArgs e)
        {
          
            DGVPrinter printer = new DGVPrinter();
            printer.Title = name + "'s Benefits Report - ";
            printer.SubTitle = "UnionBank of The Philippines \n"+ string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "";
            printer.FooterSpacing = 15;
            //  printer.PrintDataGridView(recordGrid);
            printer.PrintPreviewNoDisplay(recordGrid);
        }
    }
}
