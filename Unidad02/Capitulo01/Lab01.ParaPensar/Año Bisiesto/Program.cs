using System;

try
{
    Console.Write("Ingrese un año: ");
    int anio = int.Parse(Console.ReadLine());

    if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0))
    {
        Console.WriteLine($"{anio} es un año bisiesto.");
    }
    else
    {
        Console.WriteLine($"{anio} no es un año bisiesto.");
    }
}
catch (FormatException)
{
    Console.WriteLine("Por favor, ingrese un año válido.");
}