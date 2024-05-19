using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Crear una lista de empleados
        List<Empleado> empleados = new List<Empleado>();

        // Pedir al usuario que ingrese información de empleados
        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("Ingrese información del empleado:");
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Sueldo: ");
            decimal sueldo = decimal.Parse(Console.ReadLine());

            // Agregar el nuevo empleado a la lista
            empleados.Add(new Empleado(id, nombre, sueldo));

            Console.Write("¿Desea agregar otro empleado? (s/n): ");
            continuar = Console.ReadLine().ToLower() == "s";
        }

        // Mostrar la lista de empleados ordenada por sueldo de manera ascendente
        Console.WriteLine("\nLista de empleados ordenada por sueldo de manera ascendente:");
        ListarEmpleados(empleados.OrderBy(e => e.Sueldo).ToList());

        // Mostrar la lista de empleados ordenada por sueldo de manera descendente
        Console.WriteLine("\nLista de empleados ordenada por sueldo de manera descendente:");
        ListarEmpleados(empleados.OrderByDescending(e => e.Sueldo).ToList());
    }

    // Método para mostrar la lista de empleados
    static void ListarEmpleados(List<Empleado> empleados)
    {
        foreach (var empleado in empleados)
        {
            Console.WriteLine($"ID: {empleado.Id}, Nombre: {empleado.Nombre}, Sueldo: {empleado.Sueldo}");
        }
    }
}

// Clase Empleado con propiedades Id, Nombre y Sueldo
class Empleado
{
    public int Id { get; }
    public string Nombre { get; }
    public decimal Sueldo { get; }

    public Empleado(int id, string nombre, decimal sueldo)
    {
        Id = id;
        Nombre = nombre;
        Sueldo = sueldo;
    }
}
