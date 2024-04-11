using System;

class program()
{
    static void Main()
    {
        string clave = "contraseña";
        int intentos = 0;
        
        for (int i = 1; i < 5; i++) { 
            intentos++;

            Console.WriteLine("Ingrese la clave: ");
            string iclave = Console.ReadLine();

            if (iclave == clave)
            {
                i = 5;
                Console.WriteLine("Clave Correcta!");
            }
            else
            {
                Console.WriteLine("Clave Incorrecta");
                Console.WriteLine($"Intentos: {i}");
            }
        }
    }
}