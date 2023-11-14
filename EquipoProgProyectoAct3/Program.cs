using EquipoProgProyecto;
using EquipoProgProyecto.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipoProgProyectoAct3
{
    internal static class Program
    {
        private static FabricaServicio fabrica;


        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal(fabrica));
        }
    }
}
