using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAV3k6
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_AMB_Propiedades());
            //Application.Run(new FRM_Alta_Propiedades());
            //Application.Run(new Frm_Modificar_Propiedades());
        }
    }
}
