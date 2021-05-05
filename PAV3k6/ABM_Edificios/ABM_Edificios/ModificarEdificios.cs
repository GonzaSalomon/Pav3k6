using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABM_Edificios.BE_abmEdificios;
using ABM_Edificios.NE_abmEdificios;

namespace ABM_Edificios
{
    public partial class ModificarEdificios : Form
    {

        public string id { get; set; }

        public ModificarEdificios()
        {
            InitializeComponent();
        }

        private void ModificarEdificios_Load(object sender, EventArgs e)
        {
            BE_Edificios _BD = new BE_Edificios();
            DataTable tabla = new DataTable();
            NE_edificios edificios = new NE_edificios();
            string sql;
            sql = "SELECT id_barrio, nombre FROM barrios";
            tabla = _BD.Ejecutar_Select(sql);
            cmb_barrio.DisplayMember = "nombre";
            cmb_barrio.ValueMember = "id_barrio";
            cmb_barrio.DataSource = tabla;

            MostrarDatos(edificios.RecuperarID(id));
        }

        private void MostrarDatos(DataTable tabla)
        {
            
            txt_domi.Text = tabla.Rows[0]["Domicilio"].ToString();
            txt_cant.Text = tabla.Rows[0]["Cant_Ascensores"].ToString();
            txt_ascensor.Text = tabla.Rows[0]["Ascensor"].ToString();
            cmb_barrio.SelectedValue = tabla.Rows[0]["Barrio"].ToString(); 
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(this.Controls) == TratamientosEspeciales.Resultado.ok)
            {
                NE_edificios edificios = new NE_edificios();

                edificios.Pp_id = id;
                edificios.Pp_domicilio = txt_domi.Text;
                edificios.Pp_cant_ascensor = txt_cant.Text;
                edificios.Pp_ascensor = txt_ascensor.Text;
                edificios.Pp_id_barrio = cmb_barrio.SelectedValue.ToString();


                edificios.Modificar();
                MessageBox.Show("Se realizaron las modificaciones correspondientes.");
                this.Close();
            }
            else
            {
                return;
            }
        }

    }
}
