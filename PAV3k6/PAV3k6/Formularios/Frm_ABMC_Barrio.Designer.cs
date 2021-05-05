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
            this.btn_iniciar_alta = new System.Windows.Forms.Button();
            this.btn_iniciar_update = new System.Windows.Forms.Button();
            this.btn_iniciar_baja = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_localidades = new PAV3k6.Clases.ComboBoxHeredada();
            this.cmb_provincias = new PAV3k6.Clases.ComboBoxHeredada();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.bD3K6G112021DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD3K6G11_2021Provincias = new PAV3k6.BD3K6G11_2021Provincias();
            this.provinciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provinciasTableAdapter = new PAV3k6.BD3K6G11_2021ProvinciasTableAdapters.provinciasTableAdapter();
            this.bD3K6G11_2021Provincias1 = new PAV3k6.BD3K6G11_2021Provincias();
            this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.grid_barrios.AllowUserToAddRows = false;
            this.grid_barrios.AllowUserToDeleteRows = false;
            this.grid_barrios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_barrios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barrio,
            this.Localidad,
            this.Provincia,
            this.id_barrio});
            this.grid_barrios.Location = new System.Drawing.Point(12, 12);
            this.grid_barrios.Name = "grid_barrios";
            this.grid_barrios.ReadOnly = true;
            this.grid_barrios.RowTemplate.ReadOnly = true;
            this.grid_barrios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_barrios.Size = new System.Drawing.Size(361, 335);
            this.grid_barrios.TabIndex = 0;
            this.grid_barrios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_barrios_CellClick);
            // 
            // btn_iniciar_alta
            // 
            this.btn_iniciar_alta.Location = new System.Drawing.Point(379, 12);
            this.btn_iniciar_alta.Name = "btn_iniciar_alta";
            this.btn_iniciar_alta.Size = new System.Drawing.Size(239, 59);
            this.btn_iniciar_alta.TabIndex = 1;
            this.btn_iniciar_alta.Text = "Agregar Nuevo Barrio";
            this.btn_iniciar_alta.UseVisualStyleBackColor = true;
            this.btn_iniciar_alta.Click += new System.EventHandler(this.btn_iniciar_alta_Click);
            // 
            // btn_iniciar_update
            // 
            this.btn_iniciar_update.Enabled = false;
            this.btn_iniciar_update.Location = new System.Drawing.Point(379, 77);
            this.btn_iniciar_update.Name = "btn_iniciar_update";
            this.btn_iniciar_update.Size = new System.Drawing.Size(239, 59);
            this.btn_iniciar_update.TabIndex = 2;
            this.btn_iniciar_update.Text = "Modificar Seleccionado";
            this.btn_iniciar_update.UseVisualStyleBackColor = true;
            this.btn_iniciar_update.Click += new System.EventHandler(this.btn_iniciar_update_Click);
            // 
            // btn_iniciar_baja
            // 
            this.btn_iniciar_baja.Enabled = false;
            this.btn_iniciar_baja.Location = new System.Drawing.Point(379, 142);
            this.btn_iniciar_baja.Name = "btn_iniciar_baja";
            this.btn_iniciar_baja.Size = new System.Drawing.Size(239, 59);
            this.btn_iniciar_baja.TabIndex = 3;
            this.btn_iniciar_baja.Text = "Borrar Seleccionado";
            this.btn_iniciar_baja.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_borrar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_localidades);
            this.groupBox1.Controls.Add(this.cmb_provincias);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Location = new System.Drawing.Point(379, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 139);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackgroundImage = global::PAV3k6.Properties.Resources.Erase2;
            this.btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_borrar.Location = new System.Drawing.Point(198, 72);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(29, 25);
            this.btn_borrar.TabIndex = 9;
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Localidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Provincia";
            // 
            // cmb_localidades
            // 
            this.cmb_localidades.FormattingEnabled = true;
            this.cmb_localidades.Location = new System.Drawing.Point(124, 40);
            this.cmb_localidades.Name = "cmb_localidades";
            this.cmb_localidades.Pp_descripcion = "nombre";
            this.cmb_localidades.Pp_Pk = "id_localidad";
            this.cmb_localidades.Pp_tabla_origen = "localidades";
            this.cmb_localidades.Size = new System.Drawing.Size(103, 21);
            this.cmb_localidades.TabIndex = 6;
            // 
            // cmb_provincias
            // 
            this.cmb_provincias.FormattingEnabled = true;
            this.cmb_provincias.Location = new System.Drawing.Point(12, 40);
            this.cmb_provincias.Name = "cmb_provincias";
            this.cmb_provincias.Pp_descripcion = "nombre";
            this.cmb_provincias.Pp_Pk = "id_provincia";
            this.cmb_provincias.Pp_tabla_origen = "provincias";
            this.cmb_provincias.Size = new System.Drawing.Size(103, 21);
            this.cmb_provincias.TabIndex = 5;
            this.cmb_provincias.SelectedIndexChanged += new System.EventHandler(this.cmb_provincias_SelectedIndexChanged);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(12, 101);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(215, 23);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.Text = "Buscar Barrio";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(59, 75);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(133, 20);
            this.txt_nombre.TabIndex = 2;
            this.txt_nombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // Barrio
            // 
            this.Barrio.HeaderText = "Barrio";
            this.Barrio.Name = "Barrio";
            this.Barrio.ReadOnly = true;
            // 
            // Localidad
            // 
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.Name = "Localidad";
            this.Localidad.ReadOnly = true;
            // 
            // Provincia
            // 
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.Name = "Provincia";
            this.Provincia.ReadOnly = true;
            // 
            // id_barrio
            // 
            this.id_barrio.HeaderText = "id_barrio";
            this.id_barrio.Name = "id_barrio";
            this.id_barrio.ReadOnly = true;
            this.id_barrio.Visible = false;
            // 
            // ABMC_Barrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(630, 359);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_iniciar_baja);
            this.Controls.Add(this.btn_iniciar_update);
            this.Controls.Add(this.btn_iniciar_alta);
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
        private System.Windows.Forms.Button btn_iniciar_alta;
        private System.Windows.Forms.Button btn_iniciar_update;
        private System.Windows.Forms.Button btn_iniciar_baja;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bD3K6G112021DataSetBindingSource;
        private BD3K6G11_2021Provincias bD3K6G11_2021Provincias;
        private System.Windows.Forms.BindingSource provinciasBindingSource;
        private BD3K6G11_2021ProvinciasTableAdapters.provinciasTableAdapter provinciasTableAdapter;
        private BD3K6G11_2021Provincias bD3K6G11_2021Provincias1;
        private Clases.ComboBoxHeredada cmb_localidades;
        private Clases.ComboBoxHeredada cmb_provincias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_barrio;
    }
}