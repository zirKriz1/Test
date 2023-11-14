using EquipoProgProyecto.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoProgProyecto.Datos.Interfaz
{
    public interface IJugadorDao
    {
        bool Crear(Jugador oJugador);
        List<Jugador> GetJugador();
        bool Actualizar();
        bool Eliminar();
        List<Pais> GetPais();
        List<Club> GetClub();
        List<Posicion> GetPosicion();

    }
}
