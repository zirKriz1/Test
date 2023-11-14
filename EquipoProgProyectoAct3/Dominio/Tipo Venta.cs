using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoProgProyecto.Dominio
{
    public class TipoVenta
    {
        public string Nombre { get; set; }
        public TipoVenta()
        {

        }
        public TipoVenta(string nombre)
        {
            Nombre = nombre;
        }
    }
}
