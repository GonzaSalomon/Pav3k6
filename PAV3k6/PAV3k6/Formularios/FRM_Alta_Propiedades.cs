using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV3k6.Negocio;
using PAV3k6.Clases;
using System.Data;


namespace PAV3k6.Formularios
{
    public partial class FRM_Alta_Propiedades : Form
    {
        public FRM_Alta_Propiedades()
        {
            InitializeComponent();
        }

        private void FRM_Alta_Propiedades_Load(object sender, EventArgs e)
        {
            //cmb_provincia.CargarCombo("SELECT " + cmb_provincia.Pp_Pk + ", " + cmb_provincia.Pp_descripcion + " FROM " + cmb_provincia.Pp_tabla_origen);
            //cmb_localidad.CargarCombo("SELECT " + cmb_localidad.Pp_Pk + ", " + cmb_localidad.Pp_descripcion + " FROM " + cmb_localidad.Pp_tabla_origen);
            cmb_barrio.CargarCombo("SELECT " + cmb_barrio.Pp_Pk + ", " + cmb_barrio.Pp_descripcion + " FROM " + cmb_barrio.Pp_tabla_origen);
            cmb_tipo_propiedad.CargarCombo("SELECT " + cmb_tipo_propiedad.Pp_Pk + ", " + cmb_tipo_propiedad.Pp_descripcion + " FROM " + cmb_tipo_propiedad.Pp_tabla_origen);

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            NE_Propiedades propiedad = new NE_Propiedades();

            if (txt_designacion.Text == "")
            {
                MessageBox.Show("Se nececita cargar una designacion catastral.");
                return;
            }
            else
            {
                tabla = propiedad.RecuperarDesignacion(txt_designacion.Text.ToString());
                if (tabla.Rows.Count != 0)
                {
                    MessageBox.Show("Ya existe propiedad con la designacion catastral indicada");
                    return;

                }
            }

            if (txt_calle.Text == "" )
            {
                MessageBox.Show("Se nececita cargar la calle.");
                return;

            }

            if (txt_numero.Text == "")
            {
                MessageBox.Show("Se nececita cargar el numero de domicilio.");
                return;

            }

            propiedad.Pp_designacion = txt_designacion.Text;
            propiedad.Pp_calle = txt_calle.Text;
            propiedad.Pp_numero = txt_numero.Text;
            propiedad.Pp_piso = txt_piso.Text;
            propiedad.Pp_departamento = txt_departamento.Text;
            propiedad.Pp_id_barrio = cmb_barrio.SelectedValue.ToString();
            propiedad.Pp_id_tipo = cmb_tipo_propiedad.SelectedValue.ToString();


            if (txt_departamento.Text == "")
            {
                propiedad.insertarsindepto();
                this.Close();

            }
            else
            {
                propiedad.insertarCompleto();
                this.Close();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
