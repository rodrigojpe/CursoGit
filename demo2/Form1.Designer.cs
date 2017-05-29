namespace demo2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.CmdAddbutton_click = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btncargar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnClearGv = new System.Windows.Forms.Button();
            this.cbo1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbo2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbo3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbo4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbo5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbo6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbo7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbo8 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbo9 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbo10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbo11 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbo12 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbo13 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbo14 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbo15 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbo16 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbo17 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.roundButton1 = new demo2.RoundButton();
            this.lblprimaryKey = new System.Windows.Forms.Label();
            this.lblshow = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio1.Location = new System.Drawing.Point(196, 113);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(54, 22);
            this.radio1.TabIndex = 2;
            this.radio1.Text = "Yes";
            this.radio1.UseVisualStyleBackColor = true;
            // 
            // radio
            // 
            this.radio.AutoSize = true;
            this.radio.Checked = true;
            this.radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio.Location = new System.Drawing.Point(261, 113);
            this.radio.Name = "radio";
            this.radio.Size = new System.Drawing.Size(48, 22);
            this.radio.TabIndex = 3;
            this.radio.TabStop = true;
            this.radio.Text = "No";
            this.radio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "You need the Header ?";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.roundButton1);
            this.groupBox1.Controls.Add(this.radio1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 212);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carga de Archivo";
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(457, 398);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(781, 23);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert register to Database";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(457, 436);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(781, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save register";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // CmdAddbutton_click
            // 
            this.CmdAddbutton_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAddbutton_click.Location = new System.Drawing.Point(457, 474);
            this.CmdAddbutton_click.Name = "CmdAddbutton_click";
            this.CmdAddbutton_click.Size = new System.Drawing.Size(781, 23);
            this.CmdAddbutton_click.TabIndex = 9;
            this.CmdAddbutton_click.Text = "AddCombobox";
            this.CmdAddbutton_click.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(457, 548);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(781, 23);
            this.btnMostrar.TabIndex = 10;
            this.btnMostrar.Text = "Mostrar datos seleccionados";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btncargar
            // 
            this.btncargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncargar.Location = new System.Drawing.Point(457, 509);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(781, 23);
            this.btncargar.TabIndex = 11;
            this.btncargar.Text = "Cargar";
            this.btncargar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbo1,
            this.cbo2,
            this.cbo3,
            this.cbo4,
            this.cbo5,
            this.cbo6,
            this.cbo7,
            this.cbo8,
            this.cbo9,
            this.cbo10,
            this.cbo11,
            this.cbo12,
            this.cbo13,
            this.cbo14,
            this.cbo15,
            this.cbo16,
            this.cbo17});
            this.dataGridView1.Location = new System.Drawing.Point(1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1788, 99);
            this.dataGridView1.TabIndex = 13;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1, 107);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1788, 234);
            this.dataGridView2.TabIndex = 14;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(1, 107);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1788, 21);
            this.dataGridView3.TabIndex = 15;
            this.dataGridView3.Visible = false;
            // 
            // btnClearGv
            // 
            this.btnClearGv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearGv.Location = new System.Drawing.Point(457, 360);
            this.btnClearGv.Name = "btnClearGv";
            this.btnClearGv.Size = new System.Drawing.Size(1277, 23);
            this.btnClearGv.TabIndex = 16;
            this.btnClearGv.Text = "Limpiar registros de la Tabla";
            this.btnClearGv.UseVisualStyleBackColor = true;
            this.btnClearGv.Click += new System.EventHandler(this.btnClearGv_Click);
            // 
            // cbo1
            // 
            this.cbo1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.cbo1.FillWeight = 105F;
            this.cbo1.HeaderText = "Rut Cliente";
            this.cbo1.Items.AddRange(new object[] {
            "GM"});
            this.cbo1.Name = "cbo1";
            this.cbo1.Width = 105;
            // 
            // cbo2
            // 
            this.cbo2.DataPropertyName = "cbo2";
            this.cbo2.FillWeight = 105F;
            this.cbo2.HeaderText = "N° Sucursal";
            this.cbo2.Items.AddRange(new object[] {
            "3"});
            this.cbo2.Name = "cbo2";
            this.cbo2.Width = 105;
            // 
            // cbo3
            // 
            this.cbo3.DataPropertyName = "cbo3";
            this.cbo3.FillWeight = 105F;
            this.cbo3.HeaderText = "Invoice Date";
            this.cbo3.Name = "cbo3";
            this.cbo3.Width = 105;
            // 
            // cbo4
            // 
            this.cbo4.FillWeight = 105F;
            this.cbo4.HeaderText = "Invoice Number";
            this.cbo4.Name = "cbo4";
            this.cbo4.Width = 105;
            // 
            // cbo5
            // 
            this.cbo5.FillWeight = 105F;
            this.cbo5.HeaderText = "Invoice Currency Name Code";
            this.cbo5.Items.AddRange(new object[] {
            "USD",
            "CLP"});
            this.cbo5.Name = "cbo5";
            this.cbo5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbo5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cbo5.Width = 105;
            // 
            // cbo6
            // 
            this.cbo6.FillWeight = 105F;
            this.cbo6.HeaderText = "Net Value";
            this.cbo6.Name = "cbo6";
            this.cbo6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbo6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cbo6.Width = 105;
            // 
            // cbo7
            // 
            this.cbo7.FillWeight = 105F;
            this.cbo7.HeaderText = "Z Description";
            this.cbo7.Name = "cbo7";
            this.cbo7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbo7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cbo7.Width = 105;
            // 
            // cbo8
            // 
            this.cbo8.FillWeight = 105F;
            this.cbo8.HeaderText = "Package Qty";
            this.cbo8.Items.AddRange(new object[] {
            "1"});
            this.cbo8.Name = "cbo8";
            this.cbo8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbo8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cbo8.Width = 105;
            // 
            // cbo9
            // 
            this.cbo9.FillWeight = 105F;
            this.cbo9.HeaderText = "N° Vin ";
            this.cbo9.Name = "cbo9";
            this.cbo9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbo9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cbo9.Width = 105;
            // 
            // cbo10
            // 
            this.cbo10.FillWeight = 105F;
            this.cbo10.HeaderText = "Modelo";
            this.cbo10.Name = "cbo10";
            this.cbo10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbo10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cbo10.Width = 105;
            // 
            // cbo11
            // 
            this.cbo11.FillWeight = 105F;
            this.cbo11.HeaderText = "N° Motor";
            this.cbo11.Name = "cbo11";
            this.cbo11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbo11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cbo11.Width = 105;
            // 
            // cbo12
            // 
            this.cbo12.FillWeight = 105F;
            this.cbo12.HeaderText = "Key Number";
            this.cbo12.Name = "cbo12";
            this.cbo12.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbo12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cbo12.Width = 105;
            // 
            // cbo13
            // 
            this.cbo13.FillWeight = 105F;
            this.cbo13.HeaderText = "Model Year";
            this.cbo13.Name = "cbo13";
            this.cbo13.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbo13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cbo13.Width = 105;
            // 
            // cbo14
            // 
            this.cbo14.FillWeight = 105F;
            this.cbo14.HeaderText = "Color Nombre";
            this.cbo14.Name = "cbo14";
            this.cbo14.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbo14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cbo14.Width = 105;
            // 
            // cbo15
            // 
            this.cbo15.FillWeight = 105F;
            this.cbo15.HeaderText = "Codigo Sap";
            this.cbo15.Name = "cbo15";
            this.cbo15.Width = 105;
            // 
            // cbo16
            // 
            this.cbo16.FillWeight = 105F;
            this.cbo16.HeaderText = "Seudonimo Sap";
            this.cbo16.Name = "cbo16";
            this.cbo16.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbo16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cbo17
            // 
            this.cbo17.FillWeight = 105F;
            this.cbo17.HeaderText = "Tramite";
            this.cbo17.Name = "cbo17";
            this.cbo17.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbo17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cbo17.Width = 105;
            // 
            // roundButton1
            // 
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roundButton1.Image = ((System.Drawing.Image)(resources.GetObject("roundButton1.Image")));
            this.roundButton1.Location = new System.Drawing.Point(22, 61);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(98, 96);
            this.roundButton1.TabIndex = 5;
            this.roundButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.roundButton1.UseVisualStyleBackColor = true;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // lblprimaryKey
            // 
            this.lblprimaryKey.AutoSize = true;
            this.lblprimaryKey.Location = new System.Drawing.Point(1266, 403);
            this.lblprimaryKey.Name = "lblprimaryKey";
            this.lblprimaryKey.Size = new System.Drawing.Size(119, 13);
            this.lblprimaryKey.TabIndex = 17;
            this.lblprimaryKey.Text = "Primary key First Table :";
            // 
            // lblshow
            // 
            this.lblshow.AutoSize = true;
            this.lblshow.Location = new System.Drawing.Point(1400, 403);
            this.lblshow.Name = "lblshow";
            this.lblshow.Size = new System.Drawing.Size(61, 13);
            this.lblshow.TabIndex = 18;
            this.lblshow.Text = "?????????";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1801, 584);
            this.Controls.Add(this.lblshow);
            this.Controls.Add(this.lblprimaryKey);
            this.Controls.Add(this.btnClearGv);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btncargar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.CmdAddbutton_click);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "importacion de archivos XLS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.RadioButton radio;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RoundButton roundButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button CmdAddbutton_click;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btncargar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnClearGv;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbo1;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbo2;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbo3;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbo4;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbo5;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbo6;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbo7;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbo8;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbo9;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbo10;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbo11;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbo12;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbo13;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbo14;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbo15;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbo16;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbo17;
        private System.Windows.Forms.Label lblprimaryKey;
        private System.Windows.Forms.Label lblshow;
    }
}

