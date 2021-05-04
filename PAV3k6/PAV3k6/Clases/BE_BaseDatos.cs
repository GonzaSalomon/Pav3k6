using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PAV3k6.Clases
{
    class BE_BaseDatos
    {
        SqlConnection Conexion = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();
        string Cadena_conexion = "";

        private void Conectar()
        {
            Conexion.ConnectionString = Cadena_conexion;
            Conexion.Open();
            Cmd.Connection = Conexion;
            Cmd.CommandType = System.Data.CommandType.Text;
        }

        private void Desconectar()
        {
            Conexion.Close();
        }

        public DataTable Consulta(string Sql)
        {
            Conectar();
            Cmd.CommandText = Sql;
            DataTable tabla = new DataTable();
            tabla.Load(Cmd.ExecuteReader());
            Desconectar();
            return tabla;
        }



    }
}
