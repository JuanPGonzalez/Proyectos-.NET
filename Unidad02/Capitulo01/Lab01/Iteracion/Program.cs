using System;


int cantIteraciones = 5;
string[] arrayStrings = new string[cantIteraciones];

for (int i = 0; i < cantIteraciones; i++)
{
    Console.WriteLine($"Ingrese el valor para la posición {i}:");
    arrayStrings[i] = Console.ReadLine();
}

Console.WriteLine("\nMostrando posiciones en orden inverso:");
for (int i = cantIteraciones - 1; i >= 0; i--)
{
    Console.WriteLine(arrayStrings[i]);
}


