namespace ABM_Edificios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_barrio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ascensor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant_Ascensores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ck_todo = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Barrio:";
            // 
            // cmb_barrio
            // 
            this.cmb_barrio.FormattingEnabled = true;
            this.cmb_barrio.Location = new System.Drawing.Point(72, 53);
            this.cmb_barrio.Name = "cmb_barrio";
            this.cmb_barrio.Size = new System.Drawing.Size(210, 21);
            this.cmb_barrio.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Formulario de ABM Edificio";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "ALTA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "BAJA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(161, 391);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "MODIFICAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Domicilio,
            this.Ascensor,
            this.Cant_Ascensores,
            this.Barrio});
            this.dataGridView1.Location = new System.Drawing.Point(17, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(577, 227);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // Domicilio
            // 
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.Width = 150;
            // 
            // Ascensor
            // 
            this.Ascensor.HeaderText = "Ascensor";
            this.Ascensor.Name = "Ascensor";
            this.Ascensor.Width = 70;
            // 
            // Cant_Ascensores
            // 
            this.Cant_Ascensores.HeaderText = "Cant_Ascensores";
            this.Cant_Ascensores.Name = "Cant_Ascensores";
            // 
            // Barrio
            // 
            this.Barrio.HeaderText = "Barrio";
            this.Barrio.Name = "Barrio";
            this.Barrio.Width = 150;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(456, 50);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 72);
            this.button4.TabIndex = 4;
            this.button4.Text = "Mostrar Edificios";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Todos";
            // 
            // ck_todo
            // 
            this.ck_todo.AutoSize = true;
            this.ck_todo.Location = new System.Drawing.Point(72, 80);
            this.ck_todo.Name = "ck_todo";
            this.ck_todo.Size = new System.Drawing.Size(15, 14);
            this.ck_todo.TabIndex = 3;
            this.ck_todo.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(288, 51);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Resetear";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_barrio);
            this.Controls.Add(this.ck_todo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario ABM Edificios";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_barrio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ck_todo;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ascensor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant_Ascensores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio;
    }
}

