using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoProgProyecto.Dominio
{
    internal class Tipo_Patrocinador
    {
        public string Tipo { get; set; }

        public Tipo_Patrocinador()
        {
            Tipo = string.Empty;
        }

        public Tipo_Patrocinador(string tipo)
        {
            Tipo = tipo;
        }

        public override string ToString()
        {
            return Tipo;
        }
    }
}
