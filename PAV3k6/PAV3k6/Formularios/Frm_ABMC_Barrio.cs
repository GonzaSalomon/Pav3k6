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
            //this.provinciasTableAdapter.Fill(this.bD3K6G11_2021Provincias.provincias);
            DataTable tablafull = GenerarGrilla();
            CargarGrilla(tablafull);
            string sqlProv = "SELECT " + cmb_provincias.Pp_Pk + ", " + cmb_provincias.Pp_descripcion + " FROM " + cmb_provincias.Pp_tabla_origen;
            cmb_provincias.CargarCombo(sqlProv);
            cmb_provincias.SelectedIndex = -1;
            cmb_localidades.SelectedIndex = -1;
            cmb_localidades.Text = "Localidad...";
            cmb_provincias.Text = "Provincia...";
            

            ///string sqlLoc = "SELECT " + cmb_localidades.Pp_Pk + ", " + cmb_localidades.Pp_descripcion + " FROM " + cmb_localidades.Pp_tabla_origen + " WHERE id_provincia = " + cmb_provincias.SelectedValue.ToString();
            ///cmb_localidades.CargarCombo(sqlLoc);
        }

        private DataTable GenerarGrilla()
        {
            DataTable tablafull = new DataTable();
            NE_Barrios barrios = new NE_Barrios();
            return barrios.MostrarEnPantalla();
            
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmb_provincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_localidades.CargarCombo("SELECT * FROM " + cmb_localidades.Pp_tabla_origen + " WHERE 1 = 2");
            cmb_localidades.SelectedIndex = -1;
            cmb_localidades.Text = "Localidad...";

            if (cmb_provincias.SelectedIndex != -1)

            {
                string sqlLoc = "SELECT " + cmb_localidades.Pp_Pk + ", " + cmb_localidades.Pp_descripcion + " FROM " + cmb_localidades.Pp_tabla_origen + " WHERE id_provincia = " + cmb_provincias.SelectedValue.ToString();
                cmb_localidades.CargarCombo(sqlLoc);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "" &&
                cmb_localidades.SelectedIndex == -1
                && cmb_provincias.SelectedIndex == -1)
            {
                MessageBox.Show("No ha insertado ningún dato para la búsqueda \n (Se van a mostrar todos los barrios...)");
                DataTable tablafull = GenerarGrilla();
                CargarGrilla(tablafull);

            }

            else
            {
                string sql = @"SELECT barrios.nombre as 'Barrio', localidades.nombre as 'Localidad',
		                       provincias.nombre as 'Provincia' 
                               FROM barrios
                               INNER JOIN localidades ON barrios.id_localidad = localidades.id_localidad 
                               INNER JOIN provincias ON localidades.id_provincia = provincias.id_provincia";

                sql += " WHERE barrios.nombre LIKE '%" + txt_nombre.Text + "%'";

                if (cmb_provincias.SelectedIndex != -1)
                {
                    sql += " AND provincias.id_provincia = " + cmb_provincias.SelectedValue.ToString();
                }
                
                if (cmb_localidades.SelectedIndex != -1)
                {
                    sql += " AND localidades.id_localidad = " + cmb_localidades.SelectedValue.ToString();
                }
                NE_Barrios barrios = new NE_Barrios();
                DataTable tabla_filtrada = barrios.BusquedaAvanzada(sql);
                CargarGrilla(tabla_filtrada);
            }

        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            cmb_localidades.SelectedIndex = -1;
            cmb_localidades.Text = "Localidad...";
            cmb_provincias.SelectedIndex = -1;
            cmb_provincias.Text = "Provincia...";
            txt_nombre.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Alta_Barrio alta = new Frm_Alta_Barrio();
            alta.ShowDialog();
            DataTable tablafull = GenerarGrilla();
            CargarGrilla(tablafull);
        }
    }
    }

