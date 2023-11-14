using EquipoProgProyecto.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoProgProyecto.Dominio
{
    internal class Ciudad
    {
        public string Nombre { get; set; }
        Pais Pais { get; set; }

        public Ciudad()
        {
            Nombre=string.Empty;
        }
    }
}
