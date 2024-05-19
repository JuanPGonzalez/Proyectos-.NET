using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Pedir al usuario que ingrese una lista de números separados por comas
        Console.WriteLine("Ingresa una lista de números separados por comas:");
        string entrada = Console.ReadLine();

        // Dividir la entrada en una matriz de cadenas utilizando la coma como delimitador
        string[] numerosStr = entrada.Split(',');

        // Convertir las cadenas en números enteros y almacenarlos en una lista
        List<int> numeros = new List<int>();
        foreach (string numStr in numerosStr)
        {
            if (int.TryParse(numStr.Trim(), out int num))
            {
                numeros.Add(num);
            }
        }

        // Usando LINQ para filtrar los números mayores a 20
        var numerosMayoresA20 = numeros.Where(n => n > 20);

        // Mostrar los números mayores a 20 por consola
        Console.WriteLine("Números mayores a 20:");
        foreach (var numero in numerosMayoresA20)
        {
            Console.WriteLine(numero);
        }
    }
}