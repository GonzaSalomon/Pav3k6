using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PAV3k6;
using PAV3k6.Clases;

namespace PAV3k6.Negocio
{
    class NE_Propiedades
    {
        public string Pp_designacion { get; set; }
        public string Pp_calle { get; set; }
        public string Pp_numero { get; set; }
        public string Pp_departamento { get; set; }
        public string Pp_piso { get; set; }
        public string Pp_id_barrio { get; set; }
        public string Pp_id_tipo { get; set; }


        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public DataTable RecuperarTodos()
        {
            string sql = "SELECT designacion_catastral, calle, numero, piso, departamento, barrios.nombre as 'barrio', tipos_propiedad.nombre as 'tipo'  FROM propiedades INNER JOIN barrios ON propiedades.id_barrio = barrios.id_barrio INNER JOIN tipos_propiedad ON propiedades.id_tipo_propiedad = tipos_propiedad.id_tipo_propiedad";
            return _BD.Consulta(sql);
        }

        public DataTable RecuperarDesignacion(string designacion)
        {
            string sql = "SELECT designacion_catastral, calle, numero, piso, departamento, barrios.nombre as 'barrio', tipos_propiedad.nombre as 'tipo'  FROM propiedades INNER JOIN barrios ON propiedades.id_barrio = barrios.id_barrio INNER JOIN tipos_propiedad ON propiedades.id_tipo_propiedad = tipos_propiedad.id_tipo_propiedad WHERE designacion_catastral =" + designacion.ToString();
            return _BD.Consulta(sql);
        }

       public void insertarCompleto()
        {
            string sqlInsertar = @"INSERT INTO propiedades"
                               + " VALUES (" + Pp_designacion
                               + ", '" + Pp_calle + "'"
                               + ", " + Pp_numero + ""
                               + ", " + Pp_piso + ""
                               + ", " + Pp_departamento + ""
                               + ", " + Pp_id_barrio + ""
                               + ", " + Pp_id_tipo + ")";
            _BD.Consulta(sqlInsertar);
        }

        public void insertarsindepto()
        {
            string sqlInsertar = @"INSERT INTO propiedades (designacion_catastral, calle, numero, id_barrio, id_tipo_propiedad)"
                               + " VALUES (" + Pp_designacion
                               + ", '" + Pp_calle + "'"
                               + ", " + Pp_numero + ""
                               + ", " + Pp_id_barrio + ""
                               + ", " + Pp_id_tipo + ")";
            _BD.Consulta(sqlInsertar);
        }

        public void borrar (string designacion_catastral)
        {
            _BD.Consulta("DELETE FROM propiedades WHERE designacion_catastral = " + designacion_catastral);
        }

    }
}