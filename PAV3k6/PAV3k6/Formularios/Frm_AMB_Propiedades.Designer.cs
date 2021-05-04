namespace PAV3k6.Formularios
{
    partial class Frm_AMB_Propiedades
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
            this.button3 = new System.Windows.Forms.Button();
            this.BTN_Baja = new System.Windows.Forms.Button();
            this.BTN_Modificacion = new System.Windows.Forms.Button();
            this.BTN_alta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grid_propiedades = new System.Windows.Forms.DataGridView();
            this.designacion_catastral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPropiedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Lbl_designacion_catastral = new System.Windows.Forms.Label();
            this.Txt_Designacion_Catastral = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_propiedades)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(649, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 28);
            this.button3.TabIndex = 9;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // BTN_Baja
            // 
            this.BTN_Baja.Location = new System.Drawing.Point(117, 347);
            this.BTN_Baja.Name = "BTN_Baja";
            this.BTN_Baja.Size = new System.Drawing.Size(35, 28);
            this.BTN_Baja.TabIndex = 8;
            this.BTN_Baja.Text = "button1";
            this.BTN_Baja.UseVisualStyleBackColor = true;
            // 
            // BTN_Modificacion
            // 
            this.BTN_Modificacion.Location = new System.Drawing.Point(76, 347);
            this.BTN_Modificacion.Name = "BTN_Modificacion";
            this.BTN_Modificacion.Size = new System.Drawing.Size(35, 28);
            this.BTN_Modificacion.TabIndex = 7;
            this.BTN_Modificacion.Text = "button1";
            this.BTN_Modificacion.UseVisualStyleBackColor = true;
            // 
            // BTN_alta
            // 
            this.BTN_alta.Location = new System.Drawing.Point(35, 347);
            this.BTN_alta.Name = "BTN_alta";
            this.BTN_alta.Size = new System.Drawing.Size(35, 28);
            this.BTN_alta.TabIndex = 6;
            this.BTN_alta.Text = "button1";
            this.BTN_alta.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grid_propiedades);
            this.groupBox1.Controls.Add(this.Btn_Buscar);
            this.groupBox1.Controls.Add(this.Lbl_designacion_catastral);
            this.groupBox1.Controls.Add(this.Txt_Designacion_Catastral);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 329);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Propiedades";
            // 
            // grid_propiedades
            // 
            this.grid_propiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_propiedades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.designacion_catastral,
            this.calle,
            this.numero,
            this.piso,
            this.barrio,
            this.tipoPropiedad});
            this.grid_propiedades.Location = new System.Drawing.Point(23, 92);
            this.grid_propiedades.Name = "grid_propiedades";
            this.grid_propiedades.ReadOnly = true;
            this.grid_propiedades.Size = new System.Drawing.Size(649, 198);
            this.grid_propiedades.TabIndex = 3;
            // 
            // designacion_catastral
            // 
            this.designacion_catastral.HeaderText = "Designacion Catastral";
            this.designacion_catastral.Name = "designacion_catastral";
            this.designacion_catastral.ReadOnly = true;
            // 
            // calle
            // 
            this.calle.HeaderText = "Calle";
            this.calle.Name = "calle";
            this.calle.ReadOnly = true;
            // 
            // numero
            // 
            this.numero.HeaderText = "Numero";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // piso
            // 
            this.piso.HeaderText = "Piso";
            this.piso.Name = "piso";
            this.piso.ReadOnly = true;
            // 
            // barrio
            // 
            this.barrio.HeaderText = "Barrio";
            this.barrio.Name = "barrio";
            this.barrio.ReadOnly = true;
            // 
            // tipoPropiedad
            // 
            this.tipoPropiedad.HeaderText = "Tipo de Propiedad";
            this.tipoPropiedad.Name = "tipoPropiedad";
            this.tipoPropiedad.ReadOnly = true;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.Location = new System.Drawing.Point(272, 63);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Buscar.TabIndex = 2;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // Lbl_designacion_catastral
            // 
            this.Lbl_designacion_catastral.AutoSize = true;
            this.Lbl_designacion_catastral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_designacion_catastral.Location = new System.Drawing.Point(20, 43);
            this.Lbl_designacion_catastral.Name = "Lbl_designacion_catastral";
            this.Lbl_designacion_catastral.Size = new System.Drawing.Size(146, 17);
            this.Lbl_designacion_catastral.TabIndex = 0;
            this.Lbl_designacion_catastral.Text = "Designacion Catastral";
            // 
            // Txt_Designacion_Catastral
            // 
            this.Txt_Designacion_Catastral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Designacion_Catastral.Location = new System.Drawing.Point(23, 63);
            this.Txt_Designacion_Catastral.Name = "Txt_Designacion_Catastral";
            this.Txt_Designacion_Catastral.Size = new System.Drawing.Size(243, 23);
            this.Txt_Designacion_Catastral.TabIndex = 1;
            // 
            // Frm_AMB_Propiedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 414);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BTN_Baja);
            this.Controls.Add(this.BTN_Modificacion);
            this.Controls.Add(this.BTN_alta);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_AMB_Propiedades";
            this.Text = "Frm_AMB_Propiedades";
            this.Load += new System.EventHandler(this.Frm_AMB_Propiedades_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_propiedades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BTN_Baja;
        private System.Windows.Forms.Button BTN_Modificacion;
        private System.Windows.Forms.Button BTN_alta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grid_propiedades;
        private System.Windows.Forms.DataGridViewTextBoxColumn designacion_catastral;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn piso;
        private System.Windows.Forms.DataGridViewTextBoxColumn barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPropiedad;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Label Lbl_designacion_catastral;
        private System.Windows.Forms.TextBox Txt_Designacion_Catastral;
    }
}