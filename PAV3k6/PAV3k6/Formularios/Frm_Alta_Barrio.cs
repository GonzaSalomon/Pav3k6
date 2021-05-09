using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV3k6.Negocio;

namespace PAV3k6.Formularios
{
    public partial class Frm_Alta_Barrio : Form
    {
        public Frm_Alta_Barrio()
        {
            InitializeComponent();
        }

        private void comboBoxHeredada1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_localidades_alta.CargarCombo("SELECT * FROM " + cmb_localidades_alta.Pp_tabla_origen + " WHERE 1 = 2");
            cmb_localidades_alta.SelectedIndex = -1;
            cmb_localidades_alta.Text = "Localidad...";

            if (cmb_provincias_alta.SelectedIndex != -1)

            {
                string sqlLoc = "SELECT " + cmb_localidades_alta.Pp_Pk + ", " + cmb_localidades_alta.Pp_descripcion + " FROM " + cmb_localidades_alta.Pp_tabla_origen + " WHERE id_provincia = " + cmb_provincias_alta.SelectedValue.ToString();
                cmb_localidades_alta.CargarCombo(sqlLoc);
            }
        }

        private void comboBoxHeredada2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Alta_Barrio_Load(object sender, EventArgs e)
        {
            string sqlProv = "SELECT " + cmb_provincias_alta.Pp_Pk + ", " + cmb_provincias_alta.Pp_descripcion + " FROM " + cmb_provincias_alta.Pp_tabla_origen;
            cmb_provincias_alta.CargarCombo(sqlProv);
            cmb_provincias_alta.SelectedIndex = -1;
            cmb_localidades_alta.SelectedIndex = -1;
            cmb_localidades_alta.Text = "Localidad...";
            cmb_provincias_alta.Text = "Provincia...";
        }

        private void btn_borrar_todo_Click(object sender, EventArgs e)
        {
            cmb_localidades_alta.SelectedIndex = -1;
            cmb_provincias_alta.SelectedIndex = -1;
            cmb_localidades_alta.Text = "Localidad...";
            cmb_provincias_alta.Text = "Provincia...";
            txt_nombre_barrio.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Alta_Barrio_Click(object sender, EventArgs e)
        {
            if (cmb_provincias_alta.SelectedIndex == -1)
            {
                MessageBox.Show("No seleccionó provincia");
            }
            else if (cmb_localidades_alta.SelectedIndex == -1)
            {
                MessageBox.Show("No seleccionó localidad");
            }
            else if (txt_nombre_barrio.Text == "")
            {
                MessageBox.Show("No indicó ningún nombre para el barrio");
            }
            else
            {
                DialogResult alta = MessageBox.Show("¿Son correctos los datos? \n Provincia: " + 
                    cmb_provincias_alta.Text + "\n Localidad: " + cmb_localidades_alta.Text +
                    "\n Barrio: " + txt_nombre_barrio.Text, "Confirmar Alta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (alta == DialogResult.OK)
                {
                    NE_Barrios barrio = new NE_Barrios();
                    barrio.AltaBarrio(txt_nombre_barrio.Text, cmb_localidades_alta.SelectedValue.ToString());
                    MessageBox.Show("Barrio añadido con éxito", "Operación exitosa");
                    this.Close();
                }
                
            }
        }
    }
}
