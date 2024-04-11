using System;


class program()
{
    static void Main()
    {
        Console.WriteLine("Ingrese el numero de filas:");
        int filas = int.Parse(Console.ReadLine());

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < filas - i - 1; j++)
            {
                Console.Write(" ");
            }

          
            for (int k = 0; k < 2 * i + 1; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}