using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string DNI { get; set; }

   
        public Persona(string nombre, string apellido, int edad, string dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            DNI = dni;
            Console.WriteLine("Se ha creado un objeto Persona.");
        }

        
        ~Persona()
        {
            Console.WriteLine("Se ha destruido el objeto Persona.");
        }

      
        public string GetFullName()
        {
            return Nombre + " " + Apellido;
        }

      
        public int GetAge()
        {
            return Edad;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de uso
            Persona persona1 = new Persona("Juan", "Perez", 25, "32659856");
            Console.WriteLine("Nombre completo: " + persona1.GetFullName());
            Console.WriteLine("Edad: " + persona1.GetAge());

            Console.ReadKey();
        }
    }

}
