using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV3k6;
using PAV3k6.Negocio;
using PAV3k6.Clases;

namespace PAV3k6.Formularios
{
    public partial class ABMC_Barrio : Form
    {
        public ABMC_Barrio()
        {
            InitializeComponent();
        }

        private void ABMC_Barrio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD3K6G11_2021Provincias.provincias' table. You can move, or remove it, as needed.
            this.provinciasTableAdapter.Fill(this.bD3K6G11_2021Provincias.provincias);
            DataTable tablafull = new DataTable();
            NE_Barrios barrios = new NE_Barrios();
            tablafull = barrios.MostrarEnPantalla();
            CargarGrilla(tablafull);
            string sqlProv = "SELECT " + cmb_provincias.Pp_Pk + ", " + cmb_provincias.Pp_descripcion + " FROM " + cmb_provincias.Pp_tabla_origen;
            cmb_provincias.CargarCombo(sqlProv);
            string sqlLoc = "SELECT " + cmb_localidades.Pp_Pk + ", " + cmb_localidades.Pp_descripcion + " FROM " + cmb_localidades.Pp_tabla_origen + " WHERE id_provincia = " + cmb_provincias.SelectedValue.ToString();
            cmb_localidades.CargarCombo(sqlLoc);
        }


        private void CargarGrilla(DataTable tabla)
        {
            grid_barrios.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_barrios.Rows.Add();
                grid_barrios.Rows[i].Cells[0].Value = tabla.Rows[i]["Barrio"].ToString();
                grid_barrios.Rows[i].Cells[1].Value = tabla.Rows[i]["Localidad"].ToString();
                grid_barrios.Rows[i].Cells[2].Value = tabla.Rows[i]["Provincia"].ToString();
            }
        }

        private void grid_barrios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void cmb_provincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlLoc = "SELECT " + cmb_localidades.Pp_Pk + ", " + cmb_localidades.Pp_descripcion + " FROM " + cmb_localidades.Pp_tabla_origen + " WHERE id_provincia = " + cmb_provincias.SelectedValue.ToString();
            cmb_localidades.CargarCombo(sqlLoc);
        }
    }
}
