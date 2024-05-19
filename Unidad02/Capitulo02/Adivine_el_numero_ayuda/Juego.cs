﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivine_el_numero_ayuda
{
    class Juego
    {
        private Jugada jugada;
        private int intentos;
        private int record = int.MaxValue;

        public void ComenzarJuego()
        {
            Console.WriteLine("Bienvenido al Juego de Adivinanza de Números!");

            bool jugarOtraVez;
            do
            {
                jugada = new JugadaConAyuda(100); // Instanciación de JugadaConAyuda
                intentos = 0;

                while (!jugada.Acierto)
                {
                    int intentoUsuario;
                    Console.Write("Introduce tu adivinanza: ");
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out intentoUsuario))
                    {
                        Console.WriteLine("Por favor, introduce un número válido.");
                        continue;
                    }

                    try
                    {
                        intentos++;
                        jugada.Comparar(intentoUsuario);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                if (intentos < record)
                {
                    record = intentos;
                    Console.WriteLine("¡Nuevo récord! Menor cantidad de intentos para acertar: " + record);
                }

                Console.WriteLine("¿Quieres jugar otra partida? (s/n)");
                char respuesta = Console.ReadKey(true).KeyChar;
                jugarOtraVez = (respuesta == 's' || respuesta == 'S');
            } while (jugarOtraVez);

            Console.WriteLine("Gracias por jugar. Hasta luego.");
        }

        internal int Intentos => intentos;
    }
}