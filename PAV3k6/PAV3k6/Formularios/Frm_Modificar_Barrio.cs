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
    public partial class Frm_Modificar_Barrio : Form
    {
        public string id_barrio_mod;

        public Frm_Modificar_Barrio(string id_mod)
        {
            InitializeComponent();
            id_barrio_mod = id_mod;
        }

        private void Frm_Modificar_Barrio_Load(object sender, EventArgs e)
        {
            NE_Barrios barrio = new NE_Barrios();
            string sql_fila = @"SELECT barrios.id_barrio as 'id_barrio', barrios.nombre as 'Barrio', localidades.nombre as 'Localidad',
		                       provincias.nombre as 'Provincia' 
                               FROM barrios
                               INNER JOIN localidades ON barrios.id_localidad = localidades.id_localidad 
                               INNER JOIN provincias ON localidades.id_provincia = provincias.id_provincia
                                WHERE id_barrio = " + id_barrio_mod;
            DataTable fila = barrio.BusquedaAvanzada(sql_fila);
            string sqlProv = "SELECT " + cmb_provincia_mod.Pp_Pk + ", " + cmb_provincia_mod.Pp_descripcion + " FROM " + cmb_provincia_mod.Pp_tabla_origen;
            cmb_provincia_mod.CargarCombo(sqlProv);
            cmb_provincia_mod.Text = fila.Rows[0]["Provincia"].ToString();
            cmb_localidad_mod.Text = fila.Rows[0]["Localidad"].ToString();
            txt_nombre_mod.Text = fila.Rows[0]["Barrio"].ToString();

        }

        private void cmb_provincia_mod_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_localidad_mod.CargarCombo("SELECT * FROM " + cmb_localidad_mod.Pp_tabla_origen + " WHERE 1 = 2");
            cmb_localidad_mod.SelectedIndex = -1;
            cmb_localidad_mod.Text = "Localidad...";

            if (cmb_provincia_mod.SelectedIndex != -1)

            {
                string sqlLoc = "SELECT " + cmb_localidad_mod.Pp_Pk + ", " + cmb_localidad_mod.Pp_descripcion + " FROM " + cmb_localidad_mod.Pp_tabla_origen + " WHERE id_provincia = " + cmb_provincia_mod.SelectedValue.ToString();
                cmb_localidad_mod.CargarCombo(sqlLoc);
            }
        }

        private void btn_restablecer_Click(object sender, EventArgs e)
        {
            NE_Barrios barrio = new NE_Barrios();
            string sql_fila = @"SELECT barrios.id_barrio as 'id_barrio', barrios.nombre as 'Barrio', localidades.nombre as 'Localidad',
		                       provincias.nombre as 'Provincia' 
                               FROM barrios
                               INNER JOIN localidades ON barrios.id_localidad = localidades.id_localidad 
                               INNER JOIN provincias ON localidades.id_provincia = provincias.id_provincia
                                WHERE id_barrio = " + id_barrio_mod;
            DataTable fila = barrio.BusquedaAvanzada(sql_fila);
            cmb_provincia_mod.Text = fila.Rows[0]["Provincia"].ToString();
            cmb_localidad_mod.Text = fila.Rows[0]["Localidad"].ToString();
            txt_nombre_mod.Text = fila.Rows[0]["Barrio"].ToString();
        }

        private void btn_aplicar_mod_Click(object sender, EventArgs e)
        {
            if (cmb_provincia_mod.SelectedIndex == -1)
            {
                MessageBox.Show("No seleccionó provincia");
            }
            else if (cmb_localidad_mod.SelectedIndex == -1)
            {
                MessageBox.Show("No seleccionó localidad");
            }
            else if (txt_nombre_mod.Text == "")
            {
                MessageBox.Show("No indicó ningún nombre para el barrio");
            }
            else
            {
                DialogResult alta = MessageBox.Show("¿Son correctos los nuevos datos? \n Provincia: " +
                    cmb_provincia_mod.Text + "\n Localidad: " + cmb_localidad_mod.Text +
                    "\n Barrio: " + txt_nombre_mod.Text, "Confirmar Cambios", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (alta == DialogResult.OK)
                {
                    NE_Barrios barrio = new NE_Barrios();
                    string nuevo_nombre = txt_nombre_mod.Text;
                    string nueva_loc = cmb_localidad_mod.SelectedValue.ToString();
                    barrio.ModBarrio(id_barrio_mod, nuevo_nombre, nueva_loc);
                    MessageBox.Show("Barrio modificado con éxito", "Operación exitosa");
                    this.Close();
                }
            }
        }
    }
}