using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGestionEquipoBeisbol
{
    class Equipo
    {
        public string Nombre;
        public string CiudadOrigen;
        public string Entrenador;
        public List<Jugador> Jugadores;

        public Equipo ()
        {
            Nombre = "No asignado";
            CiudadOrigen = "No asignado";
            Entrenador = "No asignado";
            Jugadores = new List<Jugador>();
        }

        public Equipo(string nombre)
        {
            Nombre = nombre;
            CiudadOrigen = "No asignado";
            Entrenador = "No asignado";
            Jugadores = new List<Jugador>();
        }
    }
}
