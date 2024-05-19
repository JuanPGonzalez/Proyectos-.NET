using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // Crear un ArrayList que contiene las ciudades con su nombre y código postal
        ArrayList ciudades = new ArrayList()
        {
            new Ciudad("Rosario", "2000"),
            new Ciudad("Buenos Aires", "1000"),
            new Ciudad("Córdoba", "5000"),
            new Ciudad("Mendoza", "5500"),
            new Ciudad("La Plata", "1900"),
            new Ciudad("Santa Fe", "3000"),
            new Ciudad("San Juan", "5400"),
            new Ciudad("Salta", "4400"),
            new Ciudad("Tucumán", "4000"),
            new Ciudad("Mar del Plata", "7600")
        };

        // Pedir al usuario que ingrese una expresión de búsqueda de tres caracteres
        Console.WriteLine("Ingresa una expresión de búsqueda de tres caracteres:");
        string busqueda = Console.ReadLine().ToLower(); // Convertir la búsqueda a minúsculas

        // Usar LINQ para filtrar las ciudades cuyo nombre contiene la expresión de búsqueda
        var ciudadesFiltradas = ciudades.Cast<Ciudad>()
                                         .Where(c => c.Nombre.ToLower().Contains(busqueda));

        // Mostrar los códigos postales de las ciudades filtradas por consola
        Console.WriteLine("Códigos postales de las ciudades que incluyen la expresión de búsqueda:");
        foreach (var ciudad in ciudadesFiltradas)
        {
            Console.WriteLine($"Nombre: {ciudad.Nombre}, Código Postal: {ciudad.CodigoPostal}");
        }
    }
}

// Clase Ciudad que representa una ciudad con su nombre y código postal
class Ciudad
{
    public string Nombre { get; }
    public string CodigoPostal { get; }

    public Ciudad(string nombre, string codigoPostal)
    {
        Nombre = nombre;
        CodigoPostal = codigoPostal;
    }
}
