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
        public string ciudadOrigen;
        public string entrenador;
        public List<Jugador> jugadores;

        public Equipo ()
        {
            Nombre = "No asignado";
            ciudadOrigen = "No asignado";
            entrenador = "No asignado";
            jugadores = new List<Jugador>();
        }

        public Equipo(string nombre)
        {
            Nombre = nombre;
            ciudadOrigen = "No asignado";
            entrenador = "No asignado";
            jugadores = new List<Jugador>();
        }
    }
}
