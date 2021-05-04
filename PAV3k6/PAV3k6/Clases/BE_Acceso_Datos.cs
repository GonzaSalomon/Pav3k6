using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PAV3k6.Clases
{
    class BE_Acceso_Datos
    {
        SqlConnection Conexion = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();
        string cadena_conexion = "Data Source=200.69.137.167,11333;" +
            "Initial Catalog=BD3K6G11_2021;Persist Security Info=True;" +
            "User ID=BD3K6G11_2021;Password=BDG11_9654";

        private void Conectar()
        {
            Conexion.ConnectionString = cadena_conexion;
            Conexion.Open();
            Cmd.Connection = Conexion;
            Cmd.CommandType = System.Data.CommandType.Text;
        }

        private void Desconectar()
        {
            Conexion.Close();
        }

        public DataTable Consulta(string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            DataTable tabla = new DataTable();
            tabla.Load(Cmd.ExecuteReader());
            Desconectar();
            return tabla;
        }

        public void Insertar(string sql)
        {
            InsModBorr(sql);
        }
        public void Modificar(string sql)
        {
            InsModBorr(sql);
        }
        public void Borrar(string sql)
        {
            InsModBorr(sql);
        }

        private void InsModBorr(string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            Cmd.ExecuteNonQuery();
            Desconectar();
        }
    }
}
