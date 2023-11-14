using EquipoProgProyecto.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoProgProyecto.Servicios.Interfaz
{
    public interface IServicio
    {
        bool Crear(Clases.Jugador oJugador);
        List<Clases.Jugador> GetJugador();
        bool Actualizar();
        bool Eliminar();
        List<Pais> GetPais();
        List<Club> GetClub();
        List<Posicion> GetPosicion();
    }
}
