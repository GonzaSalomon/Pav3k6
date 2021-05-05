namespace PAV3k6.Formularios
{
    partial class FRM_Alta_Propiedades
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_designacion = new System.Windows.Forms.TextBox();
            this.txt_calle = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_piso = new System.Windows.Forms.TextBox();
            this.txt_departamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.cmb_tipo_propiedad = new PAV3k6.Clases.ComboBoxHeredada();
            this.cmb_barrio = new PAV3k6.Clases.ComboBoxHeredada();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta Propiedades";
            // 
            // txt_designacion
            // 
            this.txt_designacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_designacion.Location = new System.Drawing.Point(199, 85);
            this.txt_designacion.MaxLength = 12;
            this.txt_designacion.Name = "txt_designacion";
            this.txt_designacion.Size = new System.Drawing.Size(150, 26);
            this.txt_designacion.TabIndex = 1;
            // 
            // txt_calle
            // 
            this.txt_calle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_calle.Location = new System.Drawing.Point(199, 117);
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.Size = new System.Drawing.Size(188, 26);
            this.txt_calle.TabIndex = 2;
            // 
            // txt_numero
            // 
            this.txt_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero.Location = new System.Drawing.Point(199, 149);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(92, 26);
            this.txt_numero.TabIndex = 3;
            // 
            // txt_piso
            // 
            this.txt_piso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_piso.Location = new System.Drawing.Point(199, 181);
            this.txt_piso.Name = "txt_piso";
            this.txt_piso.Size = new System.Drawing.Size(68, 26);
            this.txt_piso.TabIndex = 4;
            // 
            // txt_departamento
            // 
            this.txt_departamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_departamento.Location = new System.Drawing.Point(199, 213);
            this.txt_departamento.Name = "txt_departamento";
            this.txt_departamento.Size = new System.Drawing.Size(68, 26);
            this.txt_departamento.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Designacion Catastral";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Calle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Numero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(154, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Piso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(81, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Departamento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(142, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Barrio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(78, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tipo Propiedad";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(82, 347);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 15;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(312, 347);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 16;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // cmb_tipo_propiedad
            // 
            this.cmb_tipo_propiedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo_propiedad.FormattingEnabled = true;
            this.cmb_tipo_propiedad.Location = new System.Drawing.Point(199, 283);
            this.cmb_tipo_propiedad.Name = "cmb_tipo_propiedad";
            this.cmb_tipo_propiedad.Pp_descripcion = "nombre";
            this.cmb_tipo_propiedad.Pp_Pk = "id_tipo_propiedad";
            this.cmb_tipo_propiedad.Pp_tabla_origen = "tipos_propiedad";
            this.cmb_tipo_propiedad.Size = new System.Drawing.Size(137, 28);
            this.cmb_tipo_propiedad.TabIndex = 7;
            // 
            // cmb_barrio
            // 
            this.cmb_barrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_barrio.FormattingEnabled = true;
            this.cmb_barrio.Location = new System.Drawing.Point(199, 249);
            this.cmb_barrio.Name = "cmb_barrio";
            this.cmb_barrio.Pp_descripcion = "nombre";
            this.cmb_barrio.Pp_Pk = "id_barrio";
            this.cmb_barrio.Pp_tabla_origen = "barrios";
            this.cmb_barrio.Size = new System.Drawing.Size(188, 28);
            this.cmb_barrio.TabIndex = 6;
            // 
            // FRM_Alta_Propiedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 404);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_tipo_propiedad);
            this.Controls.Add(this.cmb_barrio);
            this.Controls.Add(this.txt_departamento);
            this.Controls.Add(this.txt_piso);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.txt_calle);
            this.Controls.Add(this.txt_designacion);
            this.Controls.Add(this.label1);
            this.Name = "FRM_Alta_Propiedades";
            this.Text = "FRM_Alta_Propiedades";
            this.Load += new System.EventHandler(this.FRM_Alta_Propiedades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_designacion;
        private System.Windows.Forms.TextBox txt_calle;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_piso;
        private System.Windows.Forms.TextBox txt_departamento;
        private Clases.ComboBoxHeredada cmb_barrio;
        private Clases.ComboBoxHeredada cmb_tipo_propiedad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}