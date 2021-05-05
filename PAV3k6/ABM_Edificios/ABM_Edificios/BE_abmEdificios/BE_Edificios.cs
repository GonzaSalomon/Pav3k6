using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ABM_Edificios.BE_abmEdificios
{
    class BE_Edificios
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        private void conectar()
        {
            conexion.ConnectionString = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K6G11_2021;Persist Security Info=True;User ID=BD3K6G11_2021;Password=BDG11_9654";
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;


        }
        private void desconectar()
        {
            conexion.Close();

        }
        public DataTable Ejecutar_Select(string sql)
        {
            conectar();
            cmd.CommandText = sql;
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            desconectar();
            return tabla;

        }
        public void Insertar(string sqlInsertar)
        {
            conectar();
            cmd.CommandText = sqlInsertar;
            cmd.ExecuteNonQuery();
            desconectar();
        }
        public void Modificar(string sqlInsertar)
        {
            conectar();
            cmd.CommandText = sqlInsertar;
            cmd.ExecuteNonQuery();
            desconectar();
        }
        public void Borrar (string sqlBorrar)
        {
            conectar();
            cmd.CommandText = sqlBorrar;
            cmd.ExecuteNonQuery();
            desconectar();
        }

    }
}
