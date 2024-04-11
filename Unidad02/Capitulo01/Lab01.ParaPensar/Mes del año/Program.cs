using System;
using System.Linq.Expressions;


    Console.WriteLine("Ingrese el mes");
    string mes = Console.ReadLine();

    switch (mes)
     {
        case "enero":
            Console.WriteLine($"{mes} 1");
            break;
        case "febrero":
            Console.WriteLine($"{mes} 2");
            break;
        case "marzo":
            Console.WriteLine($"{mes} 3");
            break;
        case "abril":
            Console.WriteLine($"{mes} 4");
            break;
        case "mayo":
            Console.WriteLine($"{mes} 5");
            break;
        case "junio":
            Console.WriteLine($"{mes} 6");
            break;
        case "julio":
            Console.WriteLine($"{mes} 7");
            break;
        case "agosto":
            Console.WriteLine($"{mes} 8");
            break;
        case "octubre":
            Console.WriteLine($"{mes} 9");
            break;
        case "septiembre":
            Console.WriteLine($"{mes} 10");
            break;
        case "noviembre":
            Console.WriteLine($"{mes} 11");
            break;
        case "diciembre":
            Console.WriteLine($"{mes} 12");
            break;
        default:
            Console.WriteLine("Error");
            break;

    }