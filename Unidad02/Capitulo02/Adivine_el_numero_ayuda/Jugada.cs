using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivine_el_numero_ayuda
{
    class Jugada
    {
        protected int NumeroAdivinar;
        protected internal bool Acierto;

        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            NumeroAdivinar = rnd.Next(maxNumero);
        }

        public virtual void Comparar(int intento)
        {
            if (intento == NumeroAdivinar)
            {
                Console.WriteLine("¡Felicidades! ¡Has acertado!");
                Acierto = true;
            }
            else if (intento < NumeroAdivinar)
            {
                Console.WriteLine("Muy bajo. Intenta con un número más alto.");
            }
            else
            {
                Console.WriteLine("Muy alto. Intenta con un número más bajo.");
            }
        }

        public bool GetAcierto()
        {
            return Acierto;
        }
    }
}
