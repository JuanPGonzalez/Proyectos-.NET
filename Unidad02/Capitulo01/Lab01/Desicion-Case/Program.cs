using System;
using System.ComponentModel.Design.Serialization;

Console.WriteLine("Ingrese un texto:");
string inputTexto = Console.ReadLine();

if (string.IsNullOrEmpty(inputTexto))
{
    Console.WriteLine("No ha ingresado ningún texto. La aplicación se cerrará.");
    return;
}


Console.WriteLine("Elija una opción:");
Console.WriteLine("1. Mostrar la frase en mayúsculas");
Console.WriteLine("2. Mostrar la frase en minúsculas");
Console.WriteLine("3. Mostrar la cantidad de caracteres de la frase");


ConsoleKeyInfo opcion = Console.ReadKey();

switch (opcion.Key)
{
    case ConsoleKey.D1:
        Console.WriteLine("\nFrase en mayúsculas: " + inputTexto.ToUpper());
        break;
    case ConsoleKey.D2:
        Console.WriteLine("\nFrase en minúsculas: " + inputTexto.ToLower());
        break;
    case ConsoleKey.D3:
        Console.WriteLine("\nCantidad de caracteres: " + inputTexto.Length);
        break;
    default:
        Console.WriteLine("\nOpción no válida. La aplicación se cerrará.");
        return;
}

