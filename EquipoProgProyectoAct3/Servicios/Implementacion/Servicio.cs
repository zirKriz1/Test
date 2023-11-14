using EquipoProgProyecto.Clases;
using EquipoProgProyecto.Datos.Implementacion;
using EquipoProgProyecto.Datos.Interfaz;
using EquipoProgProyecto.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoProgProyecto.Servicios.Implementacion
{
    internal class Servicio:IServicio
    {
        IJugadorDao JugadorDao;

        public Servicio()
        {
            JugadorDao= new JugadorDao(); 
        }

        public bool Crear(Jugador jugador)
        {
            return JugadorDao.Crear(jugador);
        }
        public List<Jugador> GetJugador()
        {
            return JugadorDao.GetJugador();
        }
        public bool Actualizar()
        {
            return JugadorDao.Actualizar();
        }
        public bool Eliminar()
        {
            return JugadorDao.Eliminar();
        }
        public List<Pais> GetPais()
        {
            return JugadorDao.GetPais();
        }
        public List<Club> GetClub()
        {
            return JugadorDao.GetClub();
        }
        public List<Posicion> GetPosicion()
        {
            return JugadorDao.GetPosicion();
        }

    }
}
