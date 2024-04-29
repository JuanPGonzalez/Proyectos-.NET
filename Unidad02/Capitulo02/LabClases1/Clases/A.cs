using System;
using System.ComponentModel;

namespace Clases
{
    public class A
    {
        string nombre;
        public string NombreInstancia { get { return nombre; } set { nombre = value; } }

        public A()
        {
            NombreInstancia = "Instancia Sin Nombre";
        }

        public A(string nombre)
        {
            NombreInstancia = nombre;   
        }

        public void MostrarNombre()
        {
            Console.WriteLine(NombreInstancia);
        }

        public void M1(){ Console.WriteLine("Se invoco el metodo 1"); }

        public void M2() { Console.WriteLine("Se invoco el metodo 2"); }

        public void M3() { Console.WriteLine("Se invoco el metodo 3"); }
    
    }
}
