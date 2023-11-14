using EquipoProgProyecto.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoProgProyecto.Dominio
{
    internal class Entrenador
    {
        public Club Club { get; set; }
        public Pais Pais { get; set; }
        public DateTime FechaNac { get; set; }
        public string Nombre { get; set;}
        public string Experiencia { get; set; }


        public Entrenador(Club club, Pais pais, DateTime fechaNac, string nombre, string experiencia)
        {
            Club = club;
            Pais = pais;
            FechaNac = fechaNac;
            Nombre = nombre;
            Experiencia = experiencia;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}

