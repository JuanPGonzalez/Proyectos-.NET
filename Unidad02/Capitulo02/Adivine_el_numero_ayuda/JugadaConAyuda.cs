using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivine_el_numero_ayuda
{
    class JugadaConAyuda : Jugada
    {
        public JugadaConAyuda(int maxNumero) : base(maxNumero)
        {
        }

        public override void Comparar(int intento)
        {
            int diferencia = Math.Abs(intento - NumeroAdivinar);

            if (intento == NumeroAdivinar)
            {
                Console.WriteLine("¡Felicidades! ¡Has acertado!");
                Acierto = true;
            }
            else if (intento < NumeroAdivinar)
            {
                Console.WriteLine("Muy bajo.");

                if (diferencia > 50)
                {
                    Console.WriteLine("Estás muy lejos del número.");
                }
                else if (diferencia > 10)
                {
                    Console.WriteLine("Estás lejos del número.");
                }
                else
                {
                    Console.WriteLine("Estás cerca del número.");
                }
            }
            else
            {
                Console.WriteLine("Muy alto.");

                if (diferencia > 50)
                {
                    Console.WriteLine("Estás muy lejos del número.");
                }
                else if (diferencia > 10)
                {
                    Console.WriteLine("Estás lejos del número.");
                }
                else
                {
                    Console.WriteLine("Estás cerca del número.");
                }
            }
        }
    }
}
