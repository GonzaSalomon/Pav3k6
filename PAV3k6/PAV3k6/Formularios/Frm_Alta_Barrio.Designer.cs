namespace PAV3k6.Formularios
{
    partial class Frm_Alta_Barrio
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
            this.cmb_provincias_alta = new PAV3k6.Clases.ComboBoxHeredada();
            this.cmb_localidades_alta = new PAV3k6.Clases.ComboBoxHeredada();
            this.txt_nombre_barrio = new System.Windows.Forms.TextBox();
            this.btn_Alta_Barrio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_borrar_todo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_provincias_alta
            // 
            this.cmb_provincias_alta.FormattingEnabled = true;
            this.cmb_provincias_alta.Location = new System.Drawing.Point(202, 13);
            this.cmb_provincias_alta.Name = "cmb_provincias_alta";
            this.cmb_provincias_alta.Pp_descripcion = "nombre";
            this.cmb_provincias_alta.Pp_Pk = "id_provincia";
            this.cmb_provincias_alta.Pp_tabla_origen = "provincias";
            this.cmb_provincias_alta.Size = new System.Drawing.Size(180, 21);
            this.cmb_provincias_alta.TabIndex = 0;
            this.cmb_provincias_alta.SelectedIndexChanged += new System.EventHandler(this.comboBoxHeredada1_SelectedIndexChanged);
            // 
            // cmb_localidades_alta
            // 
            this.cmb_localidades_alta.FormattingEnabled = true;
            this.cmb_localidades_alta.Location = new System.Drawing.Point(202, 58);
            this.cmb_localidades_alta.Name = "cmb_localidades_alta";
            this.cmb_localidades_alta.Pp_descripcion = "nombre";
            this.cmb_localidades_alta.Pp_Pk = "id_localidad";
            this.cmb_localidades_alta.Pp_tabla_origen = "localidades";
            this.cmb_localidades_alta.Size = new System.Drawing.Size(180, 21);
            this.cmb_localidades_alta.TabIndex = 1;
            this.cmb_localidades_alta.SelectedIndexChanged += new System.EventHandler(this.comboBoxHeredada2_SelectedIndexChanged);
            // 
            // txt_nombre_barrio
            // 
            this.txt_nombre_barrio.Location = new System.Drawing.Point(202, 105);
            this.txt_nombre_barrio.Name = "txt_nombre_barrio";
            this.txt_nombre_barrio.Size = new System.Drawing.Size(144, 20);
            this.txt_nombre_barrio.TabIndex = 2;
            this.txt_nombre_barrio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_Alta_Barrio
            // 
            this.btn_Alta_Barrio.Location = new System.Drawing.Point(202, 143);
            this.btn_Alta_Barrio.Name = "btn_Alta_Barrio";
            this.btn_Alta_Barrio.Size = new System.Drawing.Size(180, 67);
            this.btn_Alta_Barrio.TabIndex = 3;
            this.btn_Alta_Barrio.Text = "Agregar Nuevo Barrio";
            this.btn_Alta_Barrio.UseVisualStyleBackColor = true;
            this.btn_Alta_Barrio.Click += new System.EventHandler(this.btn_Alta_Barrio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Provincia";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Localidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::PAV3k6.Properties.Resources._11vo;
            this.pictureBox1.Location = new System.Drawing.Point(24, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btn_borrar_todo
            // 
            this.btn_borrar_todo.BackgroundImage = global::PAV3k6.Properties.Resources.Erase2;
            this.btn_borrar_todo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_borrar_todo.Location = new System.Drawing.Point(352, 101);
            this.btn_borrar_todo.Name = "btn_borrar_todo";
            this.btn_borrar_todo.Size = new System.Drawing.Size(30, 26);
            this.btn_borrar_todo.TabIndex = 8;
            this.btn_borrar_todo.UseVisualStyleBackColor = true;
            this.btn_borrar_todo.Click += new System.EventHandler(this.btn_borrar_todo_Click);
            // 
            // Frm_Alta_Barrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 223);
            this.Controls.Add(this.btn_borrar_todo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Alta_Barrio);
            this.Controls.Add(this.txt_nombre_barrio);
            this.Controls.Add(this.cmb_localidades_alta);
            this.Controls.Add(this.cmb_provincias_alta);
            this.Name = "Frm_Alta_Barrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dar de alta un nuevo Barrio";
            this.Load += new System.EventHandler(this.Frm_Alta_Barrio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.ComboBoxHeredada cmb_provincias_alta;
        private Clases.ComboBoxHeredada cmb_localidades_alta;
        private System.Windows.Forms.TextBox txt_nombre_barrio;
        private System.Windows.Forms.Button btn_Alta_Barrio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_borrar_todo;
    }
}