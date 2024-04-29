using System;

namespace Clases
{
    public class B : A
    {
        public B() : base("Instancia de A") { }

        public void M4()
        {
            Console.WriteLine("Metodo del hijo Invocado");
        }
    }
}
