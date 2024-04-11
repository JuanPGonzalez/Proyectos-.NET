using System;

float num1, num2;

Console.WriteLine("Ingrese el primer numero:");
num1 = float.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero:");
num2 = float.Parse(Console.ReadLine());

float resultado = num1 + num2;

Console.WriteLine($"El resultado de la suma de {num1} y {num2} es {resultado}");