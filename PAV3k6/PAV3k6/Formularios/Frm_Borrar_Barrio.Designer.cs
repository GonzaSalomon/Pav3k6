namespace PAV3k6.Formularios
{
    partial class Frm_Borrar_Barrio
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
            this.btn_borrar_barrio = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre_baja = new System.Windows.Forms.TextBox();
            this.cmb_provincia_baja = new PAV3k6.Clases.ComboBoxHeredada();
            this.cmb_localidad_baja = new PAV3k6.Clases.ComboBoxHeredada();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_borrar_barrio
            // 
            this.btn_borrar_barrio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_borrar_barrio.Location = new System.Drawing.Point(201, 143);
            this.btn_borrar_barrio.Name = "btn_borrar_barrio";
            this.btn_borrar_barrio.Size = new System.Drawing.Size(180, 67);
            this.btn_borrar_barrio.TabIndex = 22;
            this.btn_borrar_barrio.Text = "Borrar Barrio";
            this.btn_borrar_barrio.UseVisualStyleBackColor = true;
            this.btn_borrar_barrio.Click += new System.EventHandler(this.btn_borrar_barrio_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Localidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Provincia";
            // 
            // txt_nombre_baja
            // 
            this.txt_nombre_baja.Enabled = false;
            this.txt_nombre_baja.Location = new System.Drawing.Point(201, 105);
            this.txt_nombre_baja.Name = "txt_nombre_baja";
            this.txt_nombre_baja.Size = new System.Drawing.Size(180, 20);
            this.txt_nombre_baja.TabIndex = 16;
            // 
            // cmb_provincia_baja
            // 
            this.cmb_provincia_baja.Enabled = false;
            this.cmb_provincia_baja.FormattingEnabled = true;
            this.cmb_provincia_baja.Location = new System.Drawing.Point(201, 13);
            this.cmb_provincia_baja.Name = "cmb_provincia_baja";
            this.cmb_provincia_baja.Pp_descripcion = "nombre";
            this.cmb_provincia_baja.Pp_Pk = "id_provincia";
            this.cmb_provincia_baja.Pp_tabla_origen = "provincias";
            this.cmb_provincia_baja.Size = new System.Drawing.Size(180, 21);
            this.cmb_provincia_baja.TabIndex = 15;
            this.cmb_provincia_baja.SelectedIndexChanged += new System.EventHandler(this.cmb_provincia_baja_SelectedIndexChanged);
            // 
            // cmb_localidad_baja
            // 
            this.cmb_localidad_baja.Enabled = false;
            this.cmb_localidad_baja.FormattingEnabled = true;
            this.cmb_localidad_baja.Location = new System.Drawing.Point(201, 58);
            this.cmb_localidad_baja.Name = "cmb_localidad_baja";
            this.cmb_localidad_baja.Pp_descripcion = "nombre";
            this.cmb_localidad_baja.Pp_Pk = "id_localidad";
            this.cmb_localidad_baja.Pp_tabla_origen = "localidades";
            this.cmb_localidad_baja.Size = new System.Drawing.Size(180, 21);
            this.cmb_localidad_baja.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PAV3k6.Properties.Resources.cruz;
            this.pictureBox2.Location = new System.Drawing.Point(76, 128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::PAV3k6.Properties.Resources._11vo;
            this.pictureBox1.Location = new System.Drawing.Point(23, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Borrar_Barrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 223);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_borrar_barrio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nombre_baja);
            this.Controls.Add(this.cmb_provincia_baja);
            this.Controls.Add(this.cmb_localidad_baja);
            this.Name = "Frm_Borrar_Barrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_Borrar_Barrio";
            this.Load += new System.EventHandler(this.Frm_Borrar_Barrio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_borrar_barrio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre_baja;
        private Clases.ComboBoxHeredada cmb_provincia_baja;
        private Clases.ComboBoxHeredada cmb_localidad_baja;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}