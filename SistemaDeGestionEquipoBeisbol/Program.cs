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

            Equipo Aleman = new Equipo("Aleman\t");
            Equipo Judio = new Equipo("Yaquis\t");

            equipos.Add(Aleman);
            equipos.Add(Judio);

            //Equipo Aleman
            Jugador Hitler1 = new Jugador("\t\tHitler1", "\t\t66");
            Jugador Hitler2 = new Jugador("\t\tHitler2", "\t\t64");
            Jugador Hitler3 = new Jugador("\t\tHitler3", "\t\t83");
            Jugador Hitler4 = new Jugador("\t\tHitler4", "\t\t8");
            Jugador Hitler5 = new Jugador("\t\tHitler5", "\t\t73");
            Jugador Hitler6 = new Jugador("\t\tHitler6", "\t\t9");
            Jugador Hitler7 = new Jugador("\t\tHitler7", "\t\t6");
            Jugador Hitler8 = new Jugador("\t\tHitler8", "\t\t97");
            Jugador Hitler9 = new Jugador("\t\tHitler9", "\t\t7");
            //Equipo Judio
            Jugador Jabon1 = new Jugador("\t\tJabon1", "\t\t61");
            Jugador Jabon2 = new Jugador("\t\tJabon2", "\t\t63");
            Jugador Jabon3 = new Jugador("\t\tJabon3", "\t\t83");
            Jugador Jabon4 = new Jugador("\t\tJabon4", "\t\t89");
            Jugador Jabon5 = new Jugador("\t\tJabon5", "\t\t73");
            Jugador Jabon6 = new Jugador("\t\tJabon6", "\t\t92");
            Jugador Jabon7 = new Jugador("\t\tJabon7", "\t\t67");
            Jugador Jabon8 = new Jugador("\t\tJabon8", "\t\t93");
            Jugador Jabon9 = new Jugador("\t\tJabon9", "\t\t78");

            Aleman.jugadores.Add(Hitler1);
            Aleman.jugadores.Add(Hitler2);
            Aleman.jugadores.Add(Hitler3);
            Aleman.jugadores.Add(Hitler4);
            Aleman.jugadores.Add(Hitler5);
            Aleman.jugadores.Add(Hitler6);
            Aleman.jugadores.Add(Hitler7);
            Aleman.jugadores.Add(Hitler8);
            Aleman.jugadores.Add(Hitler9);

            Judio.jugadores.Add(Jabon1);
            Judio.jugadores.Add(Jabon2);
            Judio.jugadores.Add(Jabon3);
            Judio.jugadores.Add(Jabon4);
            Judio.jugadores.Add(Jabon5);
            Judio.jugadores.Add(Jabon6);
            Judio.jugadores.Add(Jabon7);
            Judio.jugadores.Add(Jabon8);
            Judio.jugadores.Add(Jabon9);

            foreach (Equipo equipo in equipos)
            {
                Console.WriteLine("\n\tEquipo:\t" + equipo.Nombre);
                Console.WriteLine("\tLista de jugadores:\t");

                foreach (Jugador jugador in equipo.jugadores)
                {
                    Console.WriteLine("\tNombre:" + jugador.Nombre);
                    Console.WriteLine("\tNumero:" + jugador.Numero);
                    
                }
            }

            Console.ReadLine();


        }
    }
}
