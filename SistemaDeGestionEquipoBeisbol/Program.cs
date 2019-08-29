using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGestionEquipoBeisbol
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> equipos = new List<Equipo>();

            Equipo Aleman = new Equipo("Aleman");
            Aleman.Entrenador = "\tHitler";
            Aleman.CiudadOrigen = "\tAlemania\n";
            Equipo Judio = new Equipo("Yaquis");
            Judio.Entrenador = "\tSeñor Blanco";
            Judio.CiudadOrigen = "\tAlemania\n";

            equipos.Add(Aleman);
            equipos.Add(Judio);

            //Equipo Aleman
            Jugador Hitler1 = new Jugador("\tHitler1", "\t\t66");
            Jugador Hitler2 = new Jugador("\tHitler2", "\t\t64");
            Jugador Hitler3 = new Jugador("\tHitler3", "\t\t83");
            Jugador Hitler4 = new Jugador("\tHitler4", "\t\t8");
            Jugador Hitler5 = new Jugador("\tHitler5", "\t\t73");
            Jugador Hitler6 = new Jugador("\tHitler6", "\t\t9");
            Jugador Hitler7 = new Jugador("\tHitler7", "\t\t6");
            Jugador Hitler8 = new Jugador("\tHitler8", "\t\t97");
            Jugador Hitler9 = new Jugador("\tHitler9", "\t\t7");
            //Equipo Judio
            Jugador Jabon1 = new Jugador("\tJabon1", "\t\t61");
            Jugador Jabon2 = new Jugador("\tJabon2", "\t\t63");
            Jugador Jabon3 = new Jugador("\tJabon3", "\t\t83");
            Jugador Jabon4 = new Jugador("\tJabon4", "\t\t89");
            Jugador Jabon5 = new Jugador("\tJabon5", "\t\t73");
            Jugador Jabon6 = new Jugador("\tJabon6", "\t\t92");
            Jugador Jabon7 = new Jugador("\tJabon7", "\t\t67");
            Jugador Jabon8 = new Jugador("\tJabon8", "\t\t93");
            Jugador Jabon9 = new Jugador("\tJabon9", "\t\t78");

            Aleman.Jugadores.Add(Hitler1);
            Aleman.Jugadores.Add(Hitler2);
            Aleman.Jugadores.Add(Hitler3);
            Aleman.Jugadores.Add(Hitler4);
            Aleman.Jugadores.Add(Hitler5);
            Aleman.Jugadores.Add(Hitler6);
            Aleman.Jugadores.Add(Hitler7);
            Aleman.Jugadores.Add(Hitler8);
            Aleman.Jugadores.Add(Hitler9);

            Judio.Jugadores.Add(Jabon1);
            Judio.Jugadores.Add(Jabon2);
            Judio.Jugadores.Add(Jabon3);
            Judio.Jugadores.Add(Jabon4);
            Judio.Jugadores.Add(Jabon5);
            Judio.Jugadores.Add(Jabon6);
            Judio.Jugadores.Add(Jabon7);
            Judio.Jugadores.Add(Jabon8);
            Judio.Jugadores.Add(Jabon9);

            foreach (Equipo equipo in equipos)
            {
                Console.WriteLine("\n\tEquipo: " + equipo.Nombre);
                Console.WriteLine("\tLista de jugadores: ");
                Console.WriteLine("\tEntrenador: " + equipo.Entrenador);
                Console.WriteLine("\tCiudad: " + equipo.CiudadOrigen);

                foreach (Jugador jugador in equipo.Jugadores)
                {
                    Console.WriteLine("-" + "\tNombre: " + jugador.Nombre);
                    Console.WriteLine("*" + "\tNumero: " + jugador.Numero);
                    
                }
            }

            Console.ReadLine();


        }
    }
}
