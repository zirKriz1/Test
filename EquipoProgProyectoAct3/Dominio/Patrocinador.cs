using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoProgProyecto.Dominio
{
    internal class Patrocinador
    {
        Tipo_Patrocinador Tipo { get; set; }
        public string Descripcion { get; set; }
        public string Contacto { get; set; }

        public Patrocinador()
        {
            Tipo = new Tipo_Patrocinador();
            Descripcion = string.Empty;
            Contacto = string.Empty;
        }

        public Patrocinador(Tipo_Patrocinador tipo, string descripcion, string contacto)
        {
            Tipo = tipo;
            Descripcion = descripcion;
            Contacto = contacto;
        }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
