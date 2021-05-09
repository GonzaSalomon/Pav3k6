namespace ABM_Edificios
{
    partial class AltaEdificios
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_barrio = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cant = new ABM_Edificios.TextBox01();
            this.txt_ascensor = new ABM_Edificios.TextBox01();
            this.txt_domi = new ABM_Edificios.TextBox01();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Domicilio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ascensor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cantidad Ascensores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Barrio";
            // 
            // cmb_barrio
            // 
            this.cmb_barrio.FormattingEnabled = true;
            this.cmb_barrio.Location = new System.Drawing.Point(230, 159);
            this.cmb_barrio.Name = "cmb_barrio";
            this.cmb_barrio.Size = new System.Drawing.Size(121, 21);
            this.cmb_barrio.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Alta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(74, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(368, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "FORMULARIO DE ALTA DE EDIFICIOS";
            // 
            // txt_cant
            // 
            this.txt_cant.Location = new System.Drawing.Point(250, 123);
            this.txt_cant.Name = "txt_cant";
            this.txt_cant.Pp_campo = null;
            this.txt_cant.Pp_MensajeError = "Debe ingresar un valor de cantidad de ascensores";
            this.txt_cant.Pp_tabla = null;
            this.txt_cant.Pp_validable = true;
            this.txt_cant.Size = new System.Drawing.Size(100, 20);
            this.txt_cant.TabIndex = 3;
            // 
            // txt_ascensor
            // 
            this.txt_ascensor.Location = new System.Drawing.Point(250, 91);
            this.txt_ascensor.Name = "txt_ascensor";
            this.txt_ascensor.Pp_campo = null;
            this.txt_ascensor.Pp_MensajeError = "Debe ingresar un valor para ascensor";
            this.txt_ascensor.Pp_tabla = null;
            this.txt_ascensor.Pp_validable = true;
            this.txt_ascensor.Size = new System.Drawing.Size(100, 20);
            this.txt_ascensor.TabIndex = 2;
            // 
            // txt_domi
            // 
            this.txt_domi.Location = new System.Drawing.Point(250, 56);
            this.txt_domi.Name = "txt_domi";
            this.txt_domi.Pp_campo = null;
            this.txt_domi.Pp_MensajeError = "Debe ingresar un domicilio";
            this.txt_domi.Pp_tabla = null;
            this.txt_domi.Pp_validable = false;
            this.txt_domi.Size = new System.Drawing.Size(100, 20);
            this.txt_domi.TabIndex = 1;
            // 
            // AltaEdificios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 276);
            this.Controls.Add(this.txt_domi);
            this.Controls.Add(this.txt_ascensor);
            this.Controls.Add(this.txt_cant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_barrio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaEdificios";
            this.Text = "AltaEdificios";
            this.Load += new System.EventHandler(this.AltaEdificios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_barrio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private TextBox01 txt_cant;
        private TextBox01 txt_ascensor;
        private TextBox01 txt_domi;
    }
}