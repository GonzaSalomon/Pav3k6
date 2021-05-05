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
    public partial class Frm_Borrar_Barrio : Form
    {
        public string id_barrio_baja;
        public Frm_Borrar_Barrio(string id_baja)
        {
            InitializeComponent();
            id_barrio_baja = id_baja;
        }

        private void btn_borrar_barrio_Click(object sender, EventArgs e)
        {
            DialogResult alta = MessageBox.Show("¿Seguro que quiere borrar este barrio? \n Provincia: " +
                    cmb_provincia_baja.Text + "\n Localidad: " + cmb_localidad_baja.Text +
                    "\n Barrio: " + txt_nombre_baja.Text, "Borrar Barrio", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (alta == DialogResult.OK)
            {
                NE_Barrios barrio = new NE_Barrios();
                string nuevo_nombre = txt_nombre_baja.Text;
                barrio.BajaBarrio(id_barrio_baja);
                MessageBox.Show("Barrio borrado con éxito", "Operación exitosa");
                this.Close();
            }
        }

        private void cmb_provincia_baja_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Borrar_Barrio_Load(object sender, EventArgs e)
        {
            NE_Barrios barrio = new NE_Barrios();
            string sql_fila = @"SELECT barrios.id_barrio as 'id_barrio', barrios.nombre as 'Barrio', localidades.nombre as 'Localidad',
		                       provincias.nombre as 'Provincia' 
                               FROM barrios
                               INNER JOIN localidades ON barrios.id_localidad = localidades.id_localidad 
                               INNER JOIN provincias ON localidades.id_provincia = provincias.id_provincia
                                WHERE id_barrio = " + id_barrio_baja;
            DataTable fila = barrio.BusquedaAvanzada(sql_fila);
            string sqlProv = "SELECT " + cmb_provincia_baja.Pp_Pk + ", " + cmb_provincia_baja.Pp_descripcion + " FROM " + cmb_provincia_baja.Pp_tabla_origen;
            cmb_provincia_baja.CargarCombo(sqlProv);
            cmb_provincia_baja.Text = fila.Rows[0]["Provincia"].ToString();
            cmb_localidad_baja.Text = fila.Rows[0]["Localidad"].ToString();
            txt_nombre_baja.Text = fila.Rows[0]["Barrio"].ToString();
        }
    }
}
