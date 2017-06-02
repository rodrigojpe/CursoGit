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
using System.Data.SqlClient;
using demo2.Entidades;
using System.Configuration;

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
            clearComboboxz();
            openfiledialog1.ShowDialog();
             string filePath = openfiledialog1.FileName;
            ruta_file = filePath;
            
           
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
                        DataTable cliente = new DataTable();
                        cliente.Columns.Add("Rut");
                        cliente.Columns.Add("Sucursal");
                        cliente.Columns.Add("package");

                        cliente.Rows.Add("935150000",3,1);

                        cbo8.ValueMember = "package";
                        cbo8.DisplayMember = "package";
                        cbo8.DataSource = cliente;

                        cbo1.ValueMember = "Rut";
                        cbo1.DisplayMember = "Rut";
                        cbo1.DataSource = cliente; // rut cliente

                        cbo2.ValueMember = "Sucursal";
                        cbo2.DisplayMember = "Sucursal";
                        cbo2.DataSource = cliente; // N° sucursal

                        dataGridView3.DataSource = dt;

                        DataTable cabecera = new DataTable();
                        cabecera.Columns.Add("Columna");

                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            String field1 = dt.Columns[i].ColumnName;
                            cabecera.Rows.Add(field1);
                        }

                        cbo3.ValueMember = "Columna"; cbo3.DisplayMember = "Columna"; cbo3.DataSource = cabecera; // invoice date
                        cbo4.ValueMember = "Columna"; cbo4.DisplayMember = "Columna"; cbo4.DataSource = cabecera;  // invoice number
                        cbo5.ValueMember = "Columna"; cbo5.DisplayMember = "Columna"; cbo5.DataSource = cabecera;  // invoice_currency_name_code
                        cbo6.ValueMember = "Columna"; cbo6.DisplayMember = "Columna"; cbo6.DataSource = cabecera; // net value 
                        cbo7.ValueMember = "Columna"; cbo7.DisplayMember = "Columna"; cbo7.DataSource = cabecera;  // Z description
                        //cbo8.ValueMember = "Columna"; cbo8.DisplayMember = "Columna"; cbo8.DataSource = cabecera; // package qty
                        cbo9.ValueMember = "Columna"; cbo9.DisplayMember = "Columna"; cbo9.DataSource = cabecera;  // numero vin
                        cbo10.ValueMember = "Columna"; cbo10.DisplayMember = "Columna"; cbo10.DataSource = cabecera; // modelo
                        cbo11.ValueMember = "Columna"; cbo11.DisplayMember = "Columna"; cbo11.DataSource = cabecera; // numero motor
                        cbo12.ValueMember = "Columna"; cbo12.DisplayMember = "Columna"; cbo12.DataSource = cabecera; // key number
                        cbo13.ValueMember = "Columna"; cbo13.DisplayMember = "Columna"; cbo13.DataSource = cabecera; // model year 
                        cbo14.ValueMember = "Columna"; cbo14.DisplayMember = "Columna"; cbo14.DataSource = cabecera; // color nombre
                        cbo15.ValueMember = "Columna"; cbo15.DisplayMember = "Columna"; cbo15.DataSource = cabecera; // codigo sap
                        cbo16.ValueMember = "Columna"; cbo16.DisplayMember = "Columna"; cbo16.DataSource = cabecera; // seudonimo sap
                        cbo17.ValueMember = "Columna"; cbo17.DisplayMember = "Columna"; cbo17.DataSource = cabecera; // tramite
                        

                    }
              
                }
            }
        }
       

        public void clearComboboxz()
        {
            try
            {
                // if (dataGridView1.Columns[0] != null && dataGridView1.Columns[1] != null && dataGridView1.Columns[2] != null && dataGridView1.Columns[3] != null && dataGridView1.Columns[4] != null &&
                //dataGridView1.Columns[5] != null && dataGridView1.Columns[6] != null && dataGridView1.Columns[7] != null && dataGridView1.Columns[8] != null && dataGridView1.Columns[9] != null &&
                //dataGridView1.Columns[10] != null && dataGridView1.Columns[11] != null && dataGridView1.Columns[12] != null && dataGridView1.Columns[13] != null && dataGridView1.Columns[14] != null &&
                //dataGridView1.Columns[15] != null && dataGridView1.Columns[16] != null)
                //{

                  
                    dataGridView1.FirstDisplayedCell = null;
                    cbo1.DataSource = null;
                    cbo2.DataSource = null;
                    cbo3.DataSource =null;
                    cbo4.DataSource =null;
                    cbo5.DataSource =null;
                    cbo2.DataSource =null;
                    cbo3.DataSource =null;
                    cbo4.DataSource =null;
                    cbo5.DataSource =null;
                    cbo6.DataSource =null;
                    cbo7.DataSource =null;
                    cbo8.DataSource =null;
                    cbo9.DataSource =null;
                    cbo10.DataSource = null;
                    cbo11.DataSource = null;
                    cbo12.DataSource = null;
                    cbo13.DataSource = null;
                    cbo14.DataSource = null;
                    cbo15.DataSource = null;
                    cbo16.DataSource = null;
                    cbo17.DataSource = null;

                //}
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error :" + ex);
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
            //String column1 = dataGridView3.Columns[0].HeaderText; 
            //String column2 = dataGridView3.Columns[1].HeaderText;
            //String column3 = dataGridView3.Columns[2].HeaderText;

            // get values selected in the combobox inside data grid view 
            //string nameCombo1 = string.Empty;
            //string nameCombo2 = string.Empty;
            //if (dataGridView1.Rows[0].Cells["cbo1"].Value != null) nameCombo1 = dataGridView1.Rows[0].Cells["cbo1"].Value.ToString();
            //string nameCombo2 = dataGridView1.Rows[0].Cells["cbo2"].Value.ToString();
            //string nameCombo3 = dataGridView1.Rows[0].Cells["cbo3"].Value.ToString();
            //string nameCombo4 = dataGridView1.Rows[0].Cells["cbo4"].Value.ToString();
            //string nameCombo5 = dataGridView1.Rows[0].Cells["cbo5"].Value.ToString();
            //string nameCombo6 = dataGridView1.Rows[0].Cells["cbo6"].Value.ToString();
            //string nameCombo7 = dataGridView1.Rows[0].Cells["cbo7"].Value.ToString();
            //string nameCombo8 = dataGridView1.Rows[0].Cells["cbo8"].Value.ToString();
            //string nameCombo9 = dataGridView1.Rows[0].Cells["cbo9"].Value.ToString();
            //string nameCombo10 = dataGridView1.Rows[0].Cells["cbo10"].Value.ToString();
            //string nameCombo11 = dataGridView1.Rows[0].Cells["cbo11"].Value.ToString();
            //string nameCombo12 = dataGridView1.Rows[0].Cells["cbo12"].Value.ToString();
            //string nameCombo13 = dataGridView1.Rows[0].Cells["cbo13"].Value.ToString();
            //string nameCombo14 = dataGridView1.Rows[0].Cells["cbo14"].Value.ToString();
            //string nameCombo15 = dataGridView1.Rows[0].Cells["cbo15"].Value.ToString();
            //string nameCombo16 = dataGridView1.Rows[0].Cells["cbo16"].Value.ToString();
            //string nameCombo17 = dataGridView1.Rows[0].Cells["cbo17"].Value.ToString();

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

                        DataTable dt2 = new DataTable();
                        bool estado = true;

                        try
                        {
                            StringBuilder sb = new StringBuilder();

                        //    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        //    {
                        //        if (dataGridView1.Rows[0].Cells[i].Value == null)
                        //        {
                        //            MessageBox.Show("Seleccione todas las opciones una opción", "Error");
                        //            estado = false;
                        //            break;
                        //        }
                        //        else
                        //        {
                        //            if (dataGridView1.Rows[0].Cells[i].Value.ToString() == string.Empty)
                        //            {
                        //                MessageBox.Show("Seleccione todas las opciones una opción", "Error");
                        //                estado = false;
                        //                break;
                        //            }
                        //        }
                        //    }

                        //if (nameCombo1 == null && nameCombo2 == null && nameCombo3 == null && nameCombo4 == null && nameCombo5 == null && nameCombo6 == null &&
                        //    nameCombo7 == null && nameCombo8 == null && nameCombo9 == null && nameCombo10 == null && nameCombo11 == null && nameCombo12 == null &&
                        //    nameCombo13 == null && nameCombo14 == null && nameCombo15 == null && nameCombo16 == null && nameCombo17 == null)
                        //{
                        //    MessageBox.Show("Error", "Seleccione almenos una opción");
                        //}
                        if (estado)
                            {
                                for (int i = 3; i < dataGridView1.Columns.Count; i++)
                                {
                                    if (dataGridView1.Rows[0].Cells[i].Value != null)
                                    {
                                        if (dataGridView1.Rows[0].Cells[i].Value.ToString() != string.Empty) //value is not null
                                        {
                                            sb.Append("[" + dataGridView1.Rows[0].Cells[i].Value.ToString() + "]  ,");
                                        }
                                    }
                                }
                                string newS = string.Concat(sb.ToString().Reverse().Skip(2).Reverse());

                                //if (nameCombo1 != null && nameCombo2 != null && nameCombo3 != null)
                                //{
                                cmd.CommandText = "SELECT INVOICE, 935150000, 3, 1, " + newS + "  From [" + hoja_nombre + "]";
                                cmd.Connection = con;
                                con.Open();
                                oda.SelectCommand = cmd;
                                oda.Fill(dt);
                                oda.Dispose();
                                con.Close();
                                dataGridView2.DataSource = dt;
                                //}
                            }
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.Write(ex);
                            
                        }
                        
                }
                }

                listaVehiculos(dataGridView2);
            }
        }


        private void listaVehiculos(DataGridView dvg)
        {
           // var vehiculos = new List<Vehiculo>(dvg.RowCount);
            List<Vehiculo> vehicuulos = new List<Vehiculo>();
            try
            {
                
                foreach (DataGridViewRow item in dataGridView2.Rows)
                    {
                    dvg.AllowUserToAddRows = false;

                    Vehiculo vehiculo = new Vehiculo
                    {
                        rut_cliente = "935150000",
                        num_sucursal = 3,
                        package_qty = 1,
                        invoice_date = item.Cells[4].Value.ToString().Trim(),
                        invoice_number = item.Cells[5].Value.ToString().Trim(),
                        invoice_currency_n_c = item.Cells[6].Value.ToString().Trim(),
                        net_value = item.Cells[7].Value.ToString().Trim(),
                        z_description = item.Cells[8].Value.ToString().Trim(),
                        numero_vin = item.Cells[9].Value.ToString().Trim(),
                        modelo = item.Cells[10].Value.ToString().Trim(),
                        numero_motor = item.Cells[11].Value.ToString().Trim(),
                        key_number = item.Cells[12].Value.ToString().Trim(),
                        model_year = item.Cells[13].Value.ToString().Trim(),
                        color_nombre = item.Cells[14].Value.ToString().Trim(),
                        codigo_sap = item.Cells[15].Value.ToString().Trim(),
                        seudonimo_sap = item.Cells[16].Value.ToString().Trim(),
                        tramite = item.Cells[17].Value.ToString().Trim()
                    };
                    vehicuulos.Add(vehiculo);
                   
                }


                  //var groupedCustomerList = vehicuulos.GroupBy(u => u.invoice_number ).Select(grp => grp.ToList()).ToList();

                var groupedCustomerList = vehicuulos.GroupBy(x => x.invoice_number)
                    .Select(g => g.First()).ToList();







                var groups1 = groupedCustomerList.GroupBy(n => n.codigo_sap, n => n.invoice_number).Select(n => new
                {
                    MetricName = n.Key,
                    MetricCount = n.Count()
                }).OrderBy(n => n.MetricCount).ToList();

                //var groups2 = groupedCustomerList[0].GroupBy(n => n.codigo_sap, n => n.invoice_number).Select(n => new
                //{
                //    MetricName = n.Key,
                //    MetricCount = n.Count()
                //}).OrderBy(n => n.MetricName).ToList();

                //var groups3 = groupedCustomerList[1].GroupBy(n => n.codigo_sap, n => n.invoice_number).Select(n => new
                //{
                //    MetricName = n.Key,
                //    MetricCount = n.Count()
                //}).OrderBy(n => n.MetricName).ToList();

                //var groups4 = groupedCustomerList[1].GroupBy(n => n.codigo_sap, n => n.invoice_number).Select(n => new
                //{
                //    MetricName = n.Key,
                //    MetricCount = n.Count()
                //}).OrderBy(n => n.MetricCount).ToList();

                var pausa = 0;

                foreach (var despacho in groupedCustomerList)
                    {
                        string ConnString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString.ToString();
                        try
                        {
                           // int foreingK = 0;
                            using (SqlConnection conn = new SqlConnection(ConnString))
                            {
                                conn.Open();
                                SqlCommand cmd = new SqlCommand("INSERT INTO Edi_File.dbo.CUSDEC_HEADER (RutCliente, Numsucursal, Invoice_Date, Invoice_Number, Invoice_currency_name_code)" +
                                                "values(@rut, @num_sucursal, @invoice_date, @invoice_number, @invoice_cnc) select CAST(scope_identity() AS int)", conn);

                                cmd.Parameters.AddWithValue("@rut", despacho.rut_cliente);
                                cmd.Parameters.AddWithValue("@num_sucursal", despacho.num_sucursal);
                                cmd.Parameters.AddWithValue("@invoice_date", despacho.invoice_date);
                                cmd.Parameters.AddWithValue("@invoice_number", despacho.invoice_number);
                                cmd.Parameters.AddWithValue("@invoice_cnc", despacho.invoice_currency_n_c);

                            //foreingK = cmd.ExecuteNonQuery();
                            int z = 1;
                                var fkk = (int)cmd.ExecuteScalar();
                            /// setea el objeto veiculo 
                           vehicuulos.Where(x => x.invoice_number == despacho.invoice_number).ToList().ForEach(i => i.cusdec_id = fkk);

                            foreach (var groups in vehicuulos.Where(x => x.invoice_number == despacho.invoice_number).GroupBy(i => i.codigo_sap))
                            {
                                foreach (var group in groups)
                                {
                                    group.line_id = z;
                                }
                                z++;
                            }    
                            

                            Vehiculo v = new Vehiculo();
                            v.cusdec_id.GetTypeCode();

                            if (conn.State == System.Data.ConnectionState.Open) conn.Close();

                                MessageBox.Show("Good", "Insert succesfull !!!");
                                
                            }
                        }

                        catch (SqlException ex)
                        {
                            MessageBox.Show("Error tipo : " + ex);

                        }
                   
                    }
                           
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex);
            }
           

               


        }

        private void btnClearGv_Click(object sender, EventArgs e)
        {
            clearDataGridView();
        }

        public void  InsertDAtabaseRegisterDatagridView()
        {
            //flag = 1;
           
          

        }

    }
}

