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
using ABM_Edificios;

namespace ABM_Edificios
{
    public partial class Form1 : Form
    {
        public string id { get; set; }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BE_Edificios _BD = new BE_Edificios();
            DataTable tabla = new DataTable();
            string sql;
            sql = "SELECT id_barrio, nombre FROM barrios";
            tabla = _BD.Ejecutar_Select(sql);
            cmb_barrio.DisplayMember = "nombre";
            cmb_barrio.ValueMember = "id_barrio";
            cmb_barrio.DataSource = tabla;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NE_edificios edificio = new NE_edificios();
            if (ck_todo.Checked == true)
            {
                dataGridView1.Rows.Clear();
                DataTable tabla = new DataTable();
                tabla = edificio.RecuperarEdificios();
                CargarGrilla(tabla);
            }
            if (cmb_barrio.SelectedIndex!=-1)
            {
                dataGridView1.Rows.Clear();
                CargarGrilla(edificio.RecuperarBarrio(cmb_barrio.SelectedValue.ToString()));
                return;
            }
        }
        private void CargarGrilla(DataTable tabla)
            {
                if (tabla.Rows.Count == 0)
                {
                    dataGridView1.Rows.Clear();

                }
                else
                {
                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells[0].Value = tabla.Rows[i]["ID"].ToString();
                        dataGridView1.Rows[i].Cells[1].Value = tabla.Rows[i]["DOMICILIO"].ToString();
                        dataGridView1.Rows[i].Cells[2].Value = tabla.Rows[i]["ASCENSOR"].ToString();
                        dataGridView1.Rows[i].Cells[3].Value = tabla.Rows[i]["CANT_ASCENSORES"].ToString();
                        dataGridView1.Rows[i].Cells[4].Value = tabla.Rows[i]["BARRIO"].ToString();


                }
            }
            }

        private void button5_Click(object sender, EventArgs e)
        {
            cmb_barrio.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaEdificios alta = new AltaEdificios();
            alta.ShowDialog();
            alta.Dispose();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridView1.CurrentRow.Cells)
            id = dataGridView1.CurrentRow.Cells["id"].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cmb_barrio.SelectedValue.ToString());
            ModificarEdificios modificar = new ModificarEdificios();
            modificar.id = id;
            modificar.ShowDialog();
            modificar.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BajaEdificios baja = new BajaEdificios();
            baja.id = id;
            baja.ShowDialog();
            baja.Dispose();
        }

    }
}
