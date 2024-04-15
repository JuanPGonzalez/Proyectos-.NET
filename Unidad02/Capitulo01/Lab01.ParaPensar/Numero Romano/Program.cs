using System;

string[] simbolos = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
int[] valores = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
string numeroRomano = "";
int indice = 12;

Console.WriteLine("Ingrese un numero:");
int numero = int.Parse(Console.ReadLine());
int num = numero;

if (numero < 1 || numero > 3999)
{
    Console.WriteLine("El número está fuera del rango permitido (1-3999).");
}
else
{
    while (numero > 0)
    {
        if (numero - valores[indice] >= 0)
        {
            numeroRomano += simbolos[indice];
            numero -= valores[indice];
        }
        else
        {
            indice--;
        }
    }
    Console.WriteLine($"El número {num} en números romanos es: {numeroRomano}");
}
