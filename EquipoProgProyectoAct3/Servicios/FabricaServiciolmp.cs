using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquipoProgProyecto.Servicios;
using EquipoProgProyecto.Servicios.Interfaz;

namespace EquipoProgProyecto.Servicios
{
    internal class FabricaServiciolmp: FabricaServicio
    {
        public override IServicio CrearServicio()
        {
            return new Servicios.Implementacion.Servicio();
        }
    }
}
