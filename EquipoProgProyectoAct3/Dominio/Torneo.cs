using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoProgProyecto.Dominio
{
    public class Torneo
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Torneo()
        {

        }
        public Torneo(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}
