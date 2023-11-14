﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoProgProyecto.Dominio
{
    public class EstadisticaPartido
    {
        public int Partido { get; set; }
        public int Jugador { get; set; }
        public int Goles { get; set; }
        public int Asistencias { get; set; }
        public int Amarillas { get; set; }
        public int Rojas { get; set; }
        public double TiempoJugado { get; set; }
        public EstadisticaPartido()
        {

        }
        public EstadisticaPartido(int partido, int jugador, int goles, int asistencias, int amarillas, int rojas, double tiempoJugado)
        {
            Partido = partido;
            Jugador = jugador;
            Goles = goles;
            Asistencias = asistencias;
            Amarillas = amarillas;
            Rojas = rojas;
            TiempoJugado = tiempoJugado;
        }
    }
}
