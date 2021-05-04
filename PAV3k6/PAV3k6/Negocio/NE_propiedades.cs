using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PAV3k6.Clases;


namespace PAV3k6.Negocio
{
    class NE_Propiedades
    {
        BE_BaseDatos _BD = new BE_BaseDatos();

        public DataTable RecuperarTodos()
        {
            string sql = "SELECT * FROM propiedades";
            return _BD.Consulta(sql);
        }

        public DataTable RecuperarDesignacion(int designacion)
        {
            string sql = "SELECT * FROM propiedades WHERE designacion_catastral =" + designacion.ToString();
            return _BD.Consulta(sql);
        }
    }
}