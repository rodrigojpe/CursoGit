using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Data.OleDb;

namespace demo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
       
        // Conecction Excel 2003, 2007
        public string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        public string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        OpenFileDialog openfiledialog1 = new OpenFileDialog();
       

        private void btnbuscar_Click(object sender, EventArgs e)
        {
                   
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            // selecciona archivo excel
            openfiledialog1.ShowDialog();
            string filePath = openfiledialog1.FileName;
            string extension = Path.GetExtension(filePath);
            string header = radio1.Checked ? "YES" : "NO";
            string conStr, sheetName;

            conStr = string.Empty;
            switch (extension)
            {

                case ".xls": //Excel 97-03
                    conStr = string.Format(Excel03ConString, filePath, header);
                    break;

                case ".xlsx": //Excel 07
                    conStr = string.Format(Excel07ConString, filePath, header);
                    break;
            }
            try
            {
                using (OleDbConnection con = new OleDbConnection(conStr))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.Connection = con;
                        con.Open();
                        DataTable dtExcelSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                        sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                        con.Close();
                    }
                }
                using (OleDbConnection con = new OleDbConnection(conStr))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        using (OleDbDataAdapter oda = new OleDbDataAdapter())
                        {
                            string sTop = "5";
                            DataTable dt = new DataTable();
                            cmd.CommandText = "SELECT top " + sTop + " * From [" + sheetName + "]";
                            cmd.Connection = con;
                            con.Open();
                            oda.SelectCommand = cmd;
                            oda.Fill(dt);
                            con.Close();

                            //Populate DataGridView.
                            dataGridView1.DataSource = dt;
                            con.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Console.Write(ex);
            }

            int rowCount = dataGridView1.RowCount;
            Console.WriteLine(rowCount);


            /*
             for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ID_Proof;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("INSERT INTO Restaurant (Customer_Name,Quantity,Price,Category,Subcategory,Item,Room_No,Tax,Service_Charge,Service_Tax,Order_Time) values (@customer,@quantity,@price,@category,@subcategory,@item,@roomno,@tax,@servicecharge,@sertax,@ordertime)", con);
                        cmd.Parameters.AddWithValue("@customer",dataGridView2.Rows[i].Cells[0].Value);
                        cmd.Parameters.AddWithValue("@quantity",dataGridView2.Rows[i].Cells[1].Value);
                        cmd.Parameters.AddWithValue("@price",dataGridView2.Rows[i].Cells[2].Value);
                        cmd.Parameters.AddWithValue("@category",dataGridView2.Rows[i].Cells[3].Value);
                        cmd.Parameters.AddWithValue("@subcategory",dataGridView2.Rows[i].Cells[4].Value);
                        cmd.Parameters.AddWithValue("@item",dataGridView2.Rows[i].Cells[5].Value);
                        cmd.Parameters.AddWithValue("@roomno",dataGridView2.Rows[i].Cells[6].Value);
                        cmd.Parameters.AddWithValue("@tax",dataGridView2.Rows[i].Cells[7].Value);
                        cmd.Parameters.AddWithValue("@servicecharge",dataGridView2.Rows[i].Cells[8].Value);
                        cmd.Parameters.AddWithValue("@sertax",dataGridView2.Rows[i].Cells[9].Value);
                        cmd.Parameters.AddWithValue("@ordertime",dataGridView2.Rows[i].Cells[10].Value);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Added successfully!");
            }
             */
            //Get the name of the First Sheet.


            //Read Data from the First Sheet.

        }
    }
    }

