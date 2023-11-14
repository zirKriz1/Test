using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoProgProyecto.Clases
{
    public class Club
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public int Ubicacion { get; set; }
        public string Estadio { get; set; }
        public DateTime FechaFundacion { get; set; }


        public Club()
        {
            Id = 0;
            nombre = string.Empty;
            Ubicacion = 0;
            Estadio = string.Empty;
            FechaFundacion = DateTime.Today;
         
        }

        public Club(int id, string nombre, int ubicacion, string estadio, DateTime fechaFundacion)
        {
            Id = id;
            this.nombre = nombre;
            Ubicacion = ubicacion;
            Estadio = estadio;
            FechaFundacion = fechaFundacion;
        }
    }
}
