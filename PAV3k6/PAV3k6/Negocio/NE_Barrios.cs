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
            string sql = @"SELECT barrios.id_barrio as 'id_barrio', barrios.nombre as 'Barrio', localidades.nombre as 'Localidad', provincias.nombre as 'Provincia' FROM barrios INNER JOIN localidades ON barrios.id_localidad = localidades.id_localidad INNER JOIN provincias ON localidades.id_provincia = provincias.id_provincia";
            return _BD.Consulta(sql);
        }

        public DataTable BusquedaAvanzada(string sql)
        {
            return _BD.Consulta(sql);
        }

        public void AltaBarrio(string nombre, string id_localidad)
        {
            string sql = "INSERT INTO barrios (nombre, id_localidad) VALUES ('" + nombre + "', " + id_localidad.ToString() + ")";
            _BD.Insertar(sql);
        }

        public void ModBarrio(string id_barrio, string nombre, string id_localidad)
        {
            string sqlMod = "UPDATE barrios SET nombre = '" + nombre + "' , id_localidad = " + id_localidad + "WHERE id_barrio = " + id_barrio;
            _BD.Modificar(sqlMod);
        }
    }
}     
