namespace PAV3k6.Formularios
{
    partial class ABMC_Barrio
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
            this.components = new System.ComponentModel.Container();
            this.bD3K6G11_2021DataSet = new PAV3k6.BD3K6G11_2021DataSet();
            this.barriosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barriosTableAdapter = new PAV3k6.BD3K6G11_2021DataSetTableAdapters.barriosTableAdapter();
            this.grid_barrios = new System.Windows.Forms.DataGridView();
            this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bD3K6G112021DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD3K6G11_2021Provincias = new PAV3k6.BD3K6G11_2021Provincias();
            this.provinciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provinciasTableAdapter = new PAV3k6.BD3K6G11_2021ProvinciasTableAdapters.provinciasTableAdapter();
            this.bD3K6G11_2021Provincias1 = new PAV3k6.BD3K6G11_2021Provincias();
            this.cmb_provincias = new PAV3k6.Clases.ComboBoxHeredada();
            this.cmb_localidades = new PAV3k6.Clases.ComboBoxHeredada();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K6G11_2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barriosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_barrios)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K6G112021DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K6G11_2021Provincias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K6G11_2021Provincias1)).BeginInit();
            this.SuspendLayout();
            // 
            // bD3K6G11_2021DataSet
            // 
            this.bD3K6G11_2021DataSet.DataSetName = "BD3K6G11_2021DataSet";
            this.bD3K6G11_2021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barriosBindingSource
            // 
            this.barriosBindingSource.DataMember = "barrios";
            this.barriosBindingSource.DataSource = this.bD3K6G11_2021DataSet;
            // 
            // barriosTableAdapter
            // 
            this.barriosTableAdapter.ClearBeforeFill = true;
            // 
            // grid_barrios
            // 
            this.grid_barrios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_barrios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barrio,
            this.Localidad,
            this.Provincia});
            this.grid_barrios.Location = new System.Drawing.Point(12, 12);
            this.grid_barrios.Name = "grid_barrios";
            this.grid_barrios.Size = new System.Drawing.Size(361, 309);
            this.grid_barrios.TabIndex = 0;
            this.grid_barrios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_barrios_CellContentClick);
            // 
            // Barrio
            // 
            this.Barrio.HeaderText = "Barrio";
            this.Barrio.Name = "Barrio";
            // 
            // Localidad
            // 
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.Name = "Localidad";
            // 
            // Provincia
            // 
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.Name = "Provincia";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar Nuevo Barrio";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(379, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 59);
            this.button2.TabIndex = 2;
            this.button2.Text = "Modificar Seleccionado";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(379, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(239, 59);
            this.button3.TabIndex = 3;
            this.button3.Text = "Borrar Seleccionado";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_localidades);
            this.groupBox1.Controls.Add(this.cmb_provincias);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(379, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 113);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 81);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(215, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Buscar Barrio";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 2;
            // 
            // bD3K6G112021DataSetBindingSource
            // 
            this.bD3K6G112021DataSetBindingSource.DataSource = this.bD3K6G11_2021DataSet;
            this.bD3K6G112021DataSetBindingSource.Position = 0;
            // 
            // bD3K6G11_2021Provincias
            // 
            this.bD3K6G11_2021Provincias.DataSetName = "BD3K6G11_2021Provincias";
            this.bD3K6G11_2021Provincias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // provinciasBindingSource
            // 
            this.provinciasBindingSource.DataMember = "provincias";
            this.provinciasBindingSource.DataSource = this.bD3K6G11_2021Provincias;
            // 
            // provinciasTableAdapter
            // 
            this.provinciasTableAdapter.ClearBeforeFill = true;
            // 
            // bD3K6G11_2021Provincias1
            // 
            this.bD3K6G11_2021Provincias1.DataSetName = "BD3K6G11_2021Provincias";
            this.bD3K6G11_2021Provincias1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmb_provincias
            // 
            this.cmb_provincias.FormattingEnabled = true;
            this.cmb_provincias.Location = new System.Drawing.Point(13, 20);
            this.cmb_provincias.Name = "cmb_provincias";
            this.cmb_provincias.Pp_descripcion = "nombre";
            this.cmb_provincias.Pp_Pk = "id_provincia";
            this.cmb_provincias.Pp_tabla_origen = "provincias";
            this.cmb_provincias.Size = new System.Drawing.Size(103, 21);
            this.cmb_provincias.TabIndex = 5;
            this.cmb_provincias.Text = "Provincia...";
            this.cmb_provincias.SelectedIndexChanged += new System.EventHandler(this.cmb_provincias_SelectedIndexChanged);
            // 
            // cmb_localidades
            // 
            this.cmb_localidades.FormattingEnabled = true;
            this.cmb_localidades.Location = new System.Drawing.Point(125, 20);
            this.cmb_localidades.Name = "cmb_localidades";
            this.cmb_localidades.Pp_descripcion = "nombre";
            this.cmb_localidades.Pp_Pk = "id_localidad";
            this.cmb_localidades.Pp_tabla_origen = "localidades";
            this.cmb_localidades.Size = new System.Drawing.Size(103, 21);
            this.cmb_localidades.TabIndex = 6;
            // 
            // ABMC_Barrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(630, 333);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grid_barrios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ABMC_Barrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administrar Barrios";
            this.Load += new System.EventHandler(this.ABMC_Barrio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD3K6G11_2021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barriosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_barrios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K6G112021DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K6G11_2021Provincias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K6G11_2021Provincias1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BD3K6G11_2021DataSet bD3K6G11_2021DataSet;
        private System.Windows.Forms.BindingSource barriosBindingSource;
        private BD3K6G11_2021DataSetTableAdapters.barriosTableAdapter barriosTableAdapter;
        private System.Windows.Forms.DataGridView grid_barrios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bD3K6G112021DataSetBindingSource;
        private BD3K6G11_2021Provincias bD3K6G11_2021Provincias;
        private System.Windows.Forms.BindingSource provinciasBindingSource;
        private BD3K6G11_2021ProvinciasTableAdapters.provinciasTableAdapter provinciasTableAdapter;
        private BD3K6G11_2021Provincias bD3K6G11_2021Provincias1;
        private Clases.ComboBoxHeredada cmb_localidades;
        private Clases.ComboBoxHeredada cmb_provincias;
    }
}