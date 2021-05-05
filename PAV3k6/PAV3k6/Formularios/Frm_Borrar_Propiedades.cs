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
    public partial class Frm_Borrar_Propiedades : Form
    {
        public string designacionCatastralBorrar { get; set; }

        NE_Propiedades propiedad = new NE_Propiedades();

        public Frm_Borrar_Propiedades()
        {
            InitializeComponent();
        }

        private void MostrarDatos(DataTable tabla)
        {
            txt_designacion.Text = tabla.Rows[0]["designacion_catastral"].ToString();
            txt_calle.Text = tabla.Rows[0]["calle"].ToString();
            txt_numero.Text = tabla.Rows[0]["numero"].ToString();
            txt_piso.Text = tabla.Rows[0]["piso"].ToString();
            txt_departamento.Text = tabla.Rows[0]["departamento"].ToString();
            txt_barrio.Text = tabla.Rows[0]["barrio"].ToString();
            txt_tipo.Text = tabla.Rows[0]["tipo"].ToString();
        }

        private void Frm_Borrar_Propiedades_Load(object sender, EventArgs e)
        {
            MostrarDatos(propiedad.RecuperarDesignacion(designacionCatastralBorrar));
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de Borrar?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                propiedad.borrar(designacionCatastralBorrar);
                MessageBox.Show("Se borró correctamente el usuario");
                this.Close();
             
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
