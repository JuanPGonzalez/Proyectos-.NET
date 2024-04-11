using System;

int sum = 1;

Console.WriteLine("Ingrese la cantidad de iteraciones de la serie a calcular:");
int cant = int.Parse(Console.ReadLine());

if (cant <= 0)
{
    sum = 0;
}
else if (cant == 1)
{

    sum = 1;
}
else
{

    int[] fibSequence = new int[cant];
    fibSequence[0] = 0;
    fibSequence[1] = 1;
    for (int i = 2; i < cant; i++)
    {
        fibSequence[i] = fibSequence[i - 1] + fibSequence[i - 2];
        sum += fibSequence[i];
    }
}



Console.WriteLine($"La suma de los primeros {cant} términos de la serie de Fibonacci es: {sum}");