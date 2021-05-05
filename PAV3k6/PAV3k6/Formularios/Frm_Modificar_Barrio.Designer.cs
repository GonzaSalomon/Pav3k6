namespace PAV3k6.Formularios
{
    partial class Frm_Modificar_Barrio
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
            this.txt_nombre_mod = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_restablecer = new System.Windows.Forms.Button();
            this.btn_aplicar_mod = new System.Windows.Forms.Button();
            this.cmb_provincia_mod = new PAV3k6.Clases.ComboBoxHeredada();
            this.cmb_localidad_mod = new PAV3k6.Clases.ComboBoxHeredada();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombre_mod
            // 
            this.txt_nombre_mod.Location = new System.Drawing.Point(202, 105);
            this.txt_nombre_mod.Name = "txt_nombre_mod";
            this.txt_nombre_mod.Size = new System.Drawing.Size(144, 20);
            this.txt_nombre_mod.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::PAV3k6.Properties.Resources._11vo;
            this.pictureBox1.Location = new System.Drawing.Point(24, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Localidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Provincia";
            // 
            // btn_restablecer
            // 
            this.btn_restablecer.BackgroundImage = global::PAV3k6.Properties.Resources.Erase2;
            this.btn_restablecer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_restablecer.Location = new System.Drawing.Point(352, 102);
            this.btn_restablecer.Name = "btn_restablecer";
            this.btn_restablecer.Size = new System.Drawing.Size(30, 26);
            this.btn_restablecer.TabIndex = 12;
            this.btn_restablecer.UseVisualStyleBackColor = true;
            this.btn_restablecer.Click += new System.EventHandler(this.btn_restablecer_Click);
            // 
            // btn_aplicar_mod
            // 
            this.btn_aplicar_mod.Location = new System.Drawing.Point(202, 143);
            this.btn_aplicar_mod.Name = "btn_aplicar_mod";
            this.btn_aplicar_mod.Size = new System.Drawing.Size(180, 67);
            this.btn_aplicar_mod.TabIndex = 13;
            this.btn_aplicar_mod.Text = "Aplicar Cambios";
            this.btn_aplicar_mod.UseVisualStyleBackColor = true;
            this.btn_aplicar_mod.Click += new System.EventHandler(this.btn_aplicar_mod_Click);
            // 
            // cmb_provincia_mod
            // 
            this.cmb_provincia_mod.FormattingEnabled = true;
            this.cmb_provincia_mod.Location = new System.Drawing.Point(202, 13);
            this.cmb_provincia_mod.Name = "cmb_provincia_mod";
            this.cmb_provincia_mod.Pp_descripcion = "nombre";
            this.cmb_provincia_mod.Pp_Pk = "id_provincia";
            this.cmb_provincia_mod.Pp_tabla_origen = "provincias";
            this.cmb_provincia_mod.Size = new System.Drawing.Size(180, 21);
            this.cmb_provincia_mod.TabIndex = 1;
            this.cmb_provincia_mod.SelectedIndexChanged += new System.EventHandler(this.cmb_provincia_mod_SelectedIndexChanged);
            // 
            // cmb_localidad_mod
            // 
            this.cmb_localidad_mod.FormattingEnabled = true;
            this.cmb_localidad_mod.Location = new System.Drawing.Point(202, 58);
            this.cmb_localidad_mod.Name = "cmb_localidad_mod";
            this.cmb_localidad_mod.Pp_descripcion = "nombre";
            this.cmb_localidad_mod.Pp_Pk = "id_localidad";
            this.cmb_localidad_mod.Pp_tabla_origen = "localidades";
            this.cmb_localidad_mod.Size = new System.Drawing.Size(180, 21);
            this.cmb_localidad_mod.TabIndex = 0;
            // 
            // Frm_Modificar_Barrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 223);
            this.Controls.Add(this.btn_aplicar_mod);
            this.Controls.Add(this.btn_restablecer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nombre_mod);
            this.Controls.Add(this.cmb_provincia_mod);
            this.Controls.Add(this.cmb_localidad_mod);
            this.Name = "Frm_Modificar_Barrio";
            this.Text = "Modificar Barrio";
            this.Load += new System.EventHandler(this.Frm_Modificar_Barrio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.ComboBoxHeredada cmb_localidad_mod;
        private Clases.ComboBoxHeredada cmb_provincia_mod;
        private System.Windows.Forms.TextBox txt_nombre_mod;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_restablecer;
        private System.Windows.Forms.Button btn_aplicar_mod;
    }
}