using System;

class Program
{
    static bool EsPrimo(int numero)
    {
        if (numero <= 1)
            return false;
        if (numero <= 3)
            return true;
        if (numero % 2 == 0 || numero % 3 == 0)
            return false;
        int i = 5;
        while (i * i <= numero)
        {
            if (numero % i == 0 || numero % (i + 2) == 0)
                return false;
            i += 6;
        }
        return true;
    }

    static void NumerosPrimosGemelos(int N)
    {
        int contador = 0;
        int numero = 2;
        while (contador < N)
        {
            if (EsPrimo(numero) && EsPrimo(numero + 2))
            {
                Console.WriteLine("{2}({0}, {1})", numero, numero + 2, contador+1);
                contador++;
            }
            numero++;
        }
    }

    static void Main()
    {
        Console.Write("Ingrese la cantidad de números primos gemelos que desea calcular: ");
        int N = int.Parse(Console.ReadLine());
        NumerosPrimosGemelos(N);
    }
}