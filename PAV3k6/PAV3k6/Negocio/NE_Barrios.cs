using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PAV3k6.Clases;

namespace PAV3k6.Negocio
{
    class NE_Barrios
    {
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public DataTable RecuperarTodos()
        {
            string sql = "SELECT * FROM barrios";
            return _BD.Consulta(sql);
        }

        public DataTable MostrarEnPantalla()
        {
            string sql = @"SELECT barrios.nombre as 'Barrio', localidades.nombre as 'Localidad', provincias.nombre as 'Provincia' FROM barrios INNER JOIN localidades ON barrios.id_localidad = localidades.id_localidad INNER JOIN provincias ON localidades.id_provincia = provincias.id_provincia";
            return _BD.Consulta(sql);
        }

        public DataTable BusquedaAvanzada(string sql)
        {
            return _BD.Consulta(sql);
        }
    }
}
