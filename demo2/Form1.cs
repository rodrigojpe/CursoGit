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
using System.Collections;
using System.Security.Principal;

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
        static List<Vehiculo> vehicuulos = new List<Vehiculo>();
        static List<Object> groupedCustomer = new List<Object>();

        public static string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0'";
        public string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0'";
        OpenFileDialog openfiledialog1 = new OpenFileDialog();

        private void roundButton1_Click(object sender, EventArgs e)
        {
            try
            {
                btnMostrar.Enabled = true;
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

                            cliente.Rows.Add("935150000", 3, 1);

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
                catch (Exception ex)
                {

                    MessageBox.Show("Error, deber elegir un archivo", " Error " + ex);
                }
            }
            catch (OleDbException ex)
            {

                MessageBox.Show("Debe seleccionar una archivo", "Error : " + ex);
            }
           
        }
        public void clearComboboxz()
        {
            try
            {
                ((DataGridViewComboBoxCell)dataGridView1.Rows[0].Cells["cbo1"]).Value = null;
                ((DataGridViewComboBoxCell)dataGridView1.Rows[0].Cells["cbo2"]).Value = null;
                ((DataGridViewComboBoxCell)dataGridView1.Rows[0].Cells["cbo3"]).Value = null;
                ((DataGridViewComboBoxCell)dataGridView1.Rows[0].Cells["cbo4"]).Value = null;
                ((DataGridViewComboBoxCell)dataGridView1.Rows[0].Cells["cbo5"]).Value = null;
                ((DataGridViewComboBoxCell)dataGridView1.Rows[0].Cells["cbo6"]).Value = null;
                ((DataGridViewComboBoxCell)dataGridView1.Rows[0].Cells["cbo7"]).Value = null;
                ((DataGridViewComboBoxCell)dataGridView1.Rows[0].Cells["cbo8"]).Value = null;
                ((DataGridViewComboBoxCell)dataGridView1.Rows[0].Cells["cbo9"]).Value = null;
                ((DataGridViewComboBoxCell)dataGridView1.Rows[0].Cells["cbo10"]).Value = null;
                ((DataGridViewComboBoxCell)dataGridView1.Rows[0].Cells["cbo11"]).Value = null;
                ((DataGridViewComboBoxCell)dataGridView1.Rows[0].Cells["cbo12"]).Value = null;
                ((DataGridViewComboBoxCell)dataGridView1.Rows[0].Cells["cbo13"]).Value = null;
                ((DataGridViewComboBoxCell)dataGridView1.Rows[0].Cells["cbo14"]).Value = null;
                ((DataGridViewComboBoxCell)dataGridView1.Rows[0].Cells["cbo15"]).Value = null;
                ((DataGridViewComboBoxCell)dataGridView1.Rows[0].Cells["cbo16"]).Value = null;
                ((DataGridViewComboBoxCell)dataGridView1.Rows[0].Cells["cbo17"]).Value = null;
                
                
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
            // agrego una fila y seteo los botones 
            dataGridView1.Rows.Add(1);
            btnInsert.Enabled = false;
            btnMostrar.Enabled = false;
        }

      


        private void btnMostrar_Click(object sender, EventArgs e)
        {

            //if (dataGridView2.RowCount > 0)
            //{
                btnInsert.Enabled = true;
                //  get values of the header tex
                //String column1 = dataGridView3.Columns[0].HeaderText; 

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

                                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                                {
                                    if (dataGridView1.Rows[0].Cells[i].Value == null)
                                    {
                                        MessageBox.Show("Seleccione todas las opciones", "Error");
                                        estado = false;
                                        break;
                                    }
                                    else
                                    {
                                        if (dataGridView1.Rows[0].Cells[i].Value.ToString() == string.Empty)
                                        {
                                            MessageBox.Show("Seleccione todas las opciones una opción", "Error");
                                            estado = false;
                                            break;
                                        }
                                    }
                                }
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

                                    cmd.CommandText = "SELECT INVOICE, 935150000, 3, 1, " + newS + "  From [" + hoja_nombre + "]";
                                    cmd.Connection = con;
                                    con.Open();
                                    oda.SelectCommand = cmd;
                                    oda.Fill(dt);
                                    oda.Dispose();
                                    con.Close();
                                    dataGridView2.DataSource = dt;
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

            //}

            //MessageBox.Show("Debes seleccionar un archivo", "Error");
           // btnMostrar.Enabled = false;
        }

        public void listaVehiculos(DataGridView dvg)
        {

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
                

                //var groups1 = groupedCustomerList.GroupBy(n => n.codigo_sap, n => n.invoice_number).Select(n => new
                //{
                //    MetricName = n.Key,
                //    MetricCount = n.Count()
                //}).OrderBy(n => n.MetricCount).ToList();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex);
            }
        }

        private void btnClearGv_Click(object sender, EventArgs e)
        {
            clearDataGridView();
            clearComboboxz();
            
        }

        public void btnInsert_Click(object sender, EventArgs e)
       
        {
            btnInsert.Enabled = false;
            btnMostrar.Enabled = false;
                if (vehicuulos.Count > 0)
                {
                    var groupedCustomerList = vehicuulos.GroupBy(x => x.invoice_number)
                           .Select(g => g.First()).ToList();
                    // var groupedCustomerList = new List<Vehiculo>().ToList();

                    foreach (var despacho in groupedCustomerList)
                    {

                        string ConnString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString.ToString();
                        try
                        {
                            // Armado de insert Cabecera devolviendo ys eteando la cusdec_id en la lista de vehiculos 
                            using (SqlConnection conn = new SqlConnection(ConnString))
                            {
                                conn.Open();
                                SqlCommand cmd = new SqlCommand("INSERT INTO Edi_File.dbo.CUSDEC_Header (RutCliente, Numsucursal, Invoice_Date, Invoice_Number, Invoice_currency_name_code)" +
                                                "values(@rut, @num_sucursal, @invoice_date, @invoice_number, @invoice_cnc) select CAST(scope_identity() AS int)", conn);

                                cmd.Parameters.AddWithValue("@rut", despacho.rut_cliente);
                                cmd.Parameters.AddWithValue("@num_sucursal", despacho.num_sucursal);
                                cmd.Parameters.AddWithValue("@invoice_date", despacho.invoice_date);
                                cmd.Parameters.AddWithValue("@invoice_number", despacho.invoice_number);
                                cmd.Parameters.AddWithValue("@invoice_cnc", despacho.invoice_currency_n_c);
                               

                                //foreingK = cmd.ExecuteNonQuery();
                                int z = 1;
                                var fkk = (int)cmd.ExecuteScalar();
                                
                             
                               
                                //metroGrid1.DataSource = cusdec;
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

                                if (conn.State == System.Data.ConnectionState.Open) conn.Close();

                                MessageBox.Show("Good", "Insert succesfull !!!");

                            }
                        }

                        catch (SqlException ex)
                        {
                            MessageBox.Show("Error tipo : " + ex);
                        }
                    }
                    //Armar Insert de detalle 
                    try
                    {
                        string ConnString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString.ToString();
                        // int foreingK = 0;
                        using (SqlConnection conn = new SqlConnection(ConnString))
                        {
                            conn.Open();
                        foreach (var i in vehicuulos)
                            {
                                
                               
                                SqlCommand cmd = new SqlCommand("INSERT INTO Edi_File.dbo.CUSDEC_Detail (Cusdec_ID, Net_Value, Z_description,Line_id, Package_qty, Numero_VIN, Modelo,Numero_Motor, Key_Number, Model_Year, Color_Nombre, Codigo_SAP, Seudonimo_SAP, Tramite)" +
                                                "values(@cusdec_id, @net_value, @z_description, @line_id, @package_qty, @numero_vin, @modelo, @numero_motor, @key_number, @model_year, @color_nombre, @codigo_sap, @seudonimo_sap, @tramite)", conn);
                               // cmd.Parameters.AddWithValue("@detail_id", i.Detail_ID);
                                cmd.Parameters.AddWithValue("@cusdec_id", i.cusdec_id);
                                cmd.Parameters.AddWithValue("@net_value", i.net_value);
                                cmd.Parameters.AddWithValue("@z_description", i.z_description);
                                cmd.Parameters.AddWithValue("@line_id", i.line_id);
                                cmd.Parameters.AddWithValue("@package_qty", i.package_qty);
                                cmd.Parameters.AddWithValue("@numero_vin", i.numero_vin);
                                cmd.Parameters.AddWithValue("@modelo", i.modelo);
                                cmd.Parameters.AddWithValue("@numero_motor", i.numero_motor);
                                cmd.Parameters.AddWithValue("@key_number", i.key_number);
                                cmd.Parameters.AddWithValue("@model_year", i.model_year);
                                cmd.Parameters.AddWithValue("@color_nombre", i.color_nombre);
                                cmd.Parameters.AddWithValue("@codigo_sap", i.codigo_sap);
                                cmd.Parameters.AddWithValue("@seudonimo_sap", i.seudonimo_sap);
                                cmd.Parameters.AddWithValue("@tramite", i.tramite);

                                
                                cmd.ExecuteNonQuery();

                            }
                            if (conn.State == System.Data.ConnectionState.Open) conn.Close();
                                      MessageBox.Show("Good, you insert all register !!", "Insert succesfull !!!, bye !");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error", "Error :" + ex);
                    }
                }
          //  clearComboboxz();
            btnInsert.Enabled = true;
            btnMostrar.Enabled = false;
            }
        }
     }
