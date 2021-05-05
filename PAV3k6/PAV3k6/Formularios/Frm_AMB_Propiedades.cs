using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using PAV3k6.Negocio;

namespace PAV3k6.Formularios
{
    public partial class Frm_AMB_Propiedades : Form
    {
        DataTable tabla = new DataTable();
        NE_Propiedades propiedad = new NE_Propiedades();

        public Frm_AMB_Propiedades()
        {
            InitializeComponent();
        }

        private void CargarGrilla(DataTable tabla)
        {
            grid_propiedades.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_propiedades.Rows.Add();
                grid_propiedades.Rows[i].Cells[0].Value = tabla.Rows[i]["designacion_catastral"].ToString();
                grid_propiedades.Rows[i].Cells[1].Value = tabla.Rows[i]["calle"].ToString();
                grid_propiedades.Rows[i].Cells[2].Value = tabla.Rows[i]["numero"].ToString();
                grid_propiedades.Rows[i].Cells[3].Value = tabla.Rows[i]["piso"].ToString();
                grid_propiedades.Rows[i].Cells[4].Value = tabla.Rows[i]["departamento"].ToString();
                grid_propiedades.Rows[i].Cells[5].Value = tabla.Rows[i]["barrio"].ToString();
                grid_propiedades.Rows[i].Cells[6].Value = tabla.Rows[i]["tipo"].ToString();

            }
        }

        private void Frm_AMB_Propiedades_Load(object sender, EventArgs e)
        {
            tabla = propiedad.RecuperarTodos();
            CargarGrilla(tabla);
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            tabla = propiedad.RecuperarDesignacion(Txt_Designacion_Catastral.Text.ToString());
            CargarGrilla(tabla);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FRM_Alta_Propiedades alta = new FRM_Alta_Propiedades();
            alta.ShowDialog();
        }
    }
}
