 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABM_Edificios.BE_abmEdificios;
using System.Data;
using System.Windows.Forms;

namespace ABM_Edificios.NE_abmEdificios
{
    class NE_edificios
    {
        public string Pp_id { get; set; }
        public string Pp_domicilio { get; set; }
        public string Pp_ascensor { get; set; }
        public string Pp_cant_ascensor { get; set; }
        public string Pp_id_barrio { get; set; }

        BE_Edificios _BD = new BE_Edificios();
        DataTable tabla = new DataTable();

        public DataTable RecuperarEdificios()
        {
            string sql = "SELECT TOP (1000) [ID],[DOMICILIO],[ASCENSOR],[CANT_ASCENSORES] ,b.nombre as BARRIO FROM [BD3K6G11_2021].[dbo].[edificios] e join dbo.barrios b on b.id_barrio = e.ID_BARRIO";
            return _BD.Ejecutar_Select(sql);


        }
        public DataTable RecuperarBarrio(string fk_barrio)
        {
            string sql = "SELECT TOP (1000) [ID],[DOMICILIO],[ASCENSOR],[CANT_ASCENSORES] ,b.nombre as BARRIO FROM [BD3K6G11_2021].[dbo].[edificios] e join dbo.barrios b on b.id_barrio = e.ID_BARRIO WHERE e.id_barrio = " + fk_barrio;
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable RecuperarID(string id)
        {
            string sql = "SELECT [ID],[DOMICILIO],[ASCENSOR],[CANT_ASCENSORES] ,e.id_barrio as BARRIO FROM [BD3K6G11_2021].[dbo].[edificios] e join dbo.barrios b on b.id_barrio = e.ID_BARRIO WHERE e.id ='" + id+"'";
            return _BD.Ejecutar_Select(sql);
        }

        public void Insertar()
        {
            string sqlInsertar = "INSERT INTO edificios (DOMICILIO,ASCENSOR,CANT_ASCENSORES,ID_BARRIO) VALUES('"+Pp_domicilio+"' , '"+Pp_ascensor+"' , '" + Pp_cant_ascensor + "' , '" + Pp_id_barrio + " ' )";

            _BD.Insertar(sqlInsertar);
        }

        public void Modificar()
        {
            string sql = "UPDATE edificios SET Domicilio ='"+Pp_domicilio+"', ascensor ='"+ Pp_ascensor+"', cant_ascensores = '"+Pp_cant_ascensor+ "', id_barrio ='" + Pp_id_barrio + "' WHERE id ='"+Pp_id+"'";
            _BD.Ejecutar_Select(sql);
        }
        public void Borrar()
        {
            string sqlBorrar = "DELETE FROM edificios where id ='" + Pp_id + "'";
            _BD.Ejecutar_Select(sqlBorrar);
        }
    }
}
