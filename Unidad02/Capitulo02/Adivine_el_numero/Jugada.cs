using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adivine_el_numero
{
    class Jugada
    {
        private int numeroAdivinar;
        private bool acierto;

        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            numeroAdivinar = rnd.Next(maxNumero);
        }

        public bool Acierto => acierto;

        public void ComprobarAdivinanza(int intento)
        {
            if (intento < 1 || intento > 100)
            {
                throw new ArgumentException("El número debe estar entre 1 y 100.");
            }

            if (intento == numeroAdivinar)
            {
                Console.WriteLine("¡Felicidades! ¡Has acertado!");
                acierto = true;
            }
            else if (intento < numeroAdivinar)
            {
                Console.WriteLine("Muy bajo. Intenta con un número más alto.");
            }
            else
            {
                Console.WriteLine("Muy alto. Intenta con un número más bajo.");
            }
        }
    }
}