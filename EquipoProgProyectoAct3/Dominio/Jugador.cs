using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquipoProgProyecto.Dominio;

namespace EquipoProgProyecto.Clases
{
    public class Jugador 
    {
        public int Numero { get; set; }
        public Pais Pais { get; set; }
        public Posicion posicion { get; set; }
        public Club club { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        


        public Jugador(int num, Pais pa, Posicion po,Club cl,string nom,string ap,DateTime dat,double alt,double pe)
        {
            Numero = num;
            Pais = pa;
            posicion = po;
            club = cl;
            Nombre = nom;
            Apellido = ap;
            FechaNacimiento = dat;
            Altura = alt;
            Peso = pe;
            
        }
        
            
        
    } 

}

