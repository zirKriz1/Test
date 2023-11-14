using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoProgProyecto.Dominio
{
    internal class Entrenador_Contrato
    {
        Entrenador DirectorTecnico { get; set; }
        public double Sueldo { get; set; }
        public  DateTime FechaInicio { get; set; }
        public DateTime FechaFin {  get; set; }

        public Entrenador_Contrato(Entrenador directorTecnico, double sueldo, DateTime fechaInicio, DateTime fechaFin)
        {
            DirectorTecnico = directorTecnico;
            Sueldo = sueldo;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }

        public override string ToString()
        {
            return Sueldo+","+FechaInicio+","+FechaFin;
        }
    }
}
