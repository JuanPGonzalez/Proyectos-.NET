using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Array que contiene todas las provincias de Argentina
        string[] provincias = {
            "Buenos Aires", "Catamarca", "Chaco", "Chubut", "Córdoba", "Corrientes",
            "Entre Ríos", "Formosa", "Jujuy", "La Pampa", "La Rioja", "Mendoza",
            "Misiones", "Neuquén", "Río Negro", "Salta", "San Juan", "San Luis",
            "Santa Cruz", "Santa Fe", "Santiago del Estero", "Tierra del Fuego", "Tucumán"
        };

        // Usando LINQ para filtrar las provincias que comienzan con "S" o "T"
        var provinciasST = provincias.Where(p => p.StartsWith("S") || p.StartsWith("T"));

        // Mostrar las provincias filtradas por consola
        Console.WriteLine("Provincias que empiezan con 'S' o 'T':");
        foreach (var provincia in provinciasST)
        {
            Console.WriteLine(provincia);
        }
    }
}