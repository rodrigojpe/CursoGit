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
        public static string name_hoja;
        public static string ruta_file;
        public static string cnString;


        public static string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0'";
        public string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0'";
        OpenFileDialog openfiledialog1 = new OpenFileDialog();

        private void roundButton1_Click(object sender, EventArgs e)
        {
            
            openfiledialog1.ShowDialog();
             string filePath = openfiledialog1.FileName;
            ruta_file = filePath;
            clearComboboxz();
           
            string extension = Path.GetExtension(filePath);
            //  string header = radio1.Checked ? "YES" : "NO";
            string conStr, sheetName;

            conStr = string.Empty;
            switch (extension)
            {

                case ".xls": //Excel 97-03
                    conStr = string.Format(Excel03ConString, filePath /*header*/);
                    break;

                case ".xlsx": //Excel 07
                    conStr = string.Format(Excel07ConString, filePath /*header*/);
                    cnString = conStr;
                    break;
            }

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
                        string sTop = "1";

                        DataTable dt = new DataTable();
                        //DataTable dt2 = new DataTable();

                        //cmd.CommandText = ("Select * from [" + sheetName + "$" + range + "]");
                        cmd.CommandText = "SELECT top " + sTop + " *  From [" + sheetName + "]";
                        name_hoja = sheetName;
                        cmd.Connection = con;
                        con.Open();
                        oda.SelectCommand = cmd;
                        oda.Fill(dt);
                        oda.Dispose();
                        con.Close();
                        dataGridView3.DataSource = dt;
                        cbo1.Items.Add("");
                        
                        cbo2.Items.Add(3);
                        cbo5.Items.Add("");
                        cbo5.Items.Add("USD");
                        cbo5.Items.Add("CLP");
                        cbo8.Items.Add("");
                        cbo8.Items.Add(1);
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            String field1 = dt.Columns[i].ColumnName;
                            // Console.WriteLine(dt.Rows[0][dc].ToString());
                            cbo1.Items.Add("GM");
                            // cbo1.Items.Add(field1);
                            // cbo2.Items.Add(field1);
                            cbo3.Items.Add(field1);
                            cbo4.Items.Add(field1);
                           // cbo5.Items.Add(field1);
                            cbo6.Items.Add(field1);
                            cbo7.Items.Add(field1);
                            //cbo8.Items.Add(field1);
                            cbo9.Items.Add(field1);
                            cbo10.Items.Add(field1);
                            cbo11.Items.Add(field1);
                            cbo12.Items.Add(field1);
                            cbo13.Items.Add(field1);
                            cbo14.Items.Add(field1);
                            cbo15.Items.Add(field1);
                            cbo16.Items.Add(field1);
                            cbo17.Items.Add(field1);
                           
                        }
                    }
                }
            }
        }
       

        public void clearComboboxz()
        {
            if (dataGridView1.Columns[0] != null && dataGridView1.Columns[1] != null && dataGridView1.Columns[2] != null && dataGridView1.Columns[3] != null && dataGridView1.Columns[4] != null &&
                dataGridView1.Columns[5] != null && dataGridView1.Columns[6] != null && dataGridView1.Columns[7] != null && dataGridView1.Columns[8] != null && dataGridView1.Columns[9] != null &&
                dataGridView1.Columns[10] != null && dataGridView1.Columns[11] != null && dataGridView1.Columns[12] != null && dataGridView1.Columns[13] != null && dataGridView1.Columns[14] != null &&
                dataGridView1.Columns[15] != null && dataGridView1.Columns[16] != null )
            {

                dataGridView1.Rows[0].Cells[0].Value = "";
                cbo1.Items.Clear();
                dataGridView1.DataSource = null;
                cbo2.Items.Clear();
                dataGridView1.Rows[0].Cells[1].Value = "";
                cbo3.Items.Clear();
                dataGridView1.Rows[0].Cells[2].Value = "";
                cbo4.Items.Clear();
                dataGridView1.Rows[0].Cells[3].Value = "";
                cbo5.Items.Clear();
                dataGridView1.Rows[0].Cells[4].Value = "";
                cbo6.Items.Clear();
                dataGridView1.Rows[0].Cells[5].Value = "";
                cbo7.Items.Clear();
                dataGridView1.Rows[0].Cells[6].Value = "";
                cbo8.Items.Clear();
                dataGridView1.Rows[0].Cells[7].Value = "";
                cbo9.Items.Clear();
                dataGridView1.Rows[0].Cells[8].Value = "";
                cbo10.Items.Clear();
                dataGridView1.Rows[0].Cells[9].Value = "";
                cbo11.Items.Clear();
                dataGridView1.Rows[0].Cells[10].Value = "";
                cbo12.Items.Clear();
                dataGridView1.Rows[0].Cells[11].Value = "";
                cbo13.Items.Clear();
                dataGridView1.Rows[0].Cells[12].Value = "";
                cbo14.Items.Clear();
                dataGridView1.Rows[0].Cells[13].Value = "";
                cbo15.Items.Clear();
                dataGridView1.Rows[0].Cells[14].Value = "";
                cbo16.Items.Clear();
                dataGridView1.Rows[0].Cells[15].Value = "";
                cbo17.Items.Clear();
                dataGridView1.Rows[0].Cells[16].Value = "";
               
            }
        }



        public void clearDataGridView()
        {
            dataGridView2.DataSource = "";
           // dataGridView2.Dispose();
            dataGridView2.Columns.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Take 20 items from whatever source you are currently using in the DGV.
            dataGridView1.Rows.Add(1);
        }
       
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            
            //  get values of the header tex
            String column1 = dataGridView3.Columns[0].HeaderText; 
            String column2 = dataGridView3.Columns[1].HeaderText;
            String column3 = dataGridView3.Columns[2].HeaderText;

            // get values selected in the combobox inside data grid view 
            string nameCombo1 = dataGridView1.Rows[0].Cells["cbo1"].Value.ToString();
            string nameCombo2 = dataGridView1.Rows[0].Cells["cbo2"].Value.ToString();
            string nameCombo3 = dataGridView1.Rows[0].Cells["cbo3"].Value.ToString();
            string nameCombo4 = dataGridView1.Rows[0].Cells["cbo4"].Value.ToString();
            string nameCombo5 = dataGridView1.Rows[0].Cells["cbo5"].Value.ToString();
            string nameCombo6 = dataGridView1.Rows[0].Cells["cbo6"].Value.ToString();
            string nameCombo7 = dataGridView1.Rows[0].Cells["cbo7"].Value.ToString();
            string nameCombo8 = dataGridView1.Rows[0].Cells["cbo8"].Value.ToString();
            string nameCombo9 = dataGridView1.Rows[0].Cells["cbo9"].Value.ToString();
            string nameCombo10 = dataGridView1.Rows[0].Cells["cbo10"].Value.ToString();
            string nameCombo11 = dataGridView1.Rows[0].Cells["cbo11"].Value.ToString();
            string nameCombo12 = dataGridView1.Rows[0].Cells["cbo12"].Value.ToString();
            string nameCombo13 = dataGridView1.Rows[0].Cells["cbo13"].Value.ToString();
            string nameCombo14 = dataGridView1.Rows[0].Cells["cbo14"].Value.ToString();
            string nameCombo15 = dataGridView1.Rows[0].Cells["cbo15"].Value.ToString();
            string nameCombo16 = dataGridView1.Rows[0].Cells["cbo16"].Value.ToString();
            string nameCombo17 = dataGridView1.Rows[0].Cells["cbo17"].Value.ToString();

            string hoja_nombre = name_hoja;
            string ruta = ruta_file;
            string conexion = cnString;

            using (OleDbConnection con = new OleDbConnection(conexion))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = con;
                    con.Open();
                    DataTable dtExcelSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    hoja_nombre = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                    con.Close();
                }
            }
            using (OleDbConnection con = new OleDbConnection(conexion))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    using (OleDbDataAdapter oda = new OleDbDataAdapter())
                    {
                        DataTable dt = new DataTable();
                        dt.Rows.Clear();

                        //DataTable dt2 = new DataTable();
                        //  bool estado = dataGridView1.Rows[0].Cells[1].Selected;

                        try
                        {
                            StringBuilder sb = new StringBuilder();

                            //for (int i = 0; i < dataGridView1.Columns.Count; i++)
                            //{
                            //    if (dataGridView1.Rows[0].Cells[i].Value.ToString() == string.Empty)
                            //    {
                            //        MessageBox.Show("Error", "Seleccione almenos una opción");
                            //    }
                            //}

                            if (nameCombo1 == null && nameCombo2 == null && nameCombo3 == null && nameCombo4 == null && nameCombo5 == null && nameCombo6 == null &&
                                nameCombo7 == null && nameCombo8 == null && nameCombo9 == null && nameCombo10 == null && nameCombo11 == null && nameCombo12 == null &&
                                nameCombo13 == null && nameCombo14 == null && nameCombo15 == null && nameCombo16 == null && nameCombo17 == null)
                            {
                                MessageBox.Show("Error", "Seleccione almenos una opción");
                            }

                            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                            {
                                if (dataGridView1.Rows[0].Cells[i].Value.ToString() != string.Empty) //value is not null
                                {
                                    sb.Append(dataGridView1.Rows[0].Cells[i].Value.ToString() + "  ,");
                                }
                            }
                            string newS = string.Concat(sb.ToString().Reverse().Skip(2).Reverse());

                            //if (nameCombo1 != null && nameCombo2 != null && nameCombo3 != null)
                            //{
                                cmd.CommandText = "SELECT " + newS + "  From [" + hoja_nombre + "]";
                                cmd.Connection = con;
                                con.Open();
                                oda.SelectCommand = cmd;
                                oda.Fill(dt);
                                oda.Dispose();
                                con.Close();
                                dataGridView2.DataSource = dt;
                            //}
                        }
                        catch (Exception ex)
                        {
                            Console.Write(ex);
                            
                        }
                }
                }
            }
        }

        private void btnClearGv_Click(object sender, EventArgs e)
        {
            clearDataGridView();
        }
    }
}

