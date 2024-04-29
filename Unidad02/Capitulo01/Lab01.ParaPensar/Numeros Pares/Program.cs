using System;

int n = 1;

int[] arreglo=  new int[100];

for (int i = 0; i < 100; i++)
{
    arreglo[i] = n;
    n = n + 1;
}

for  (int i = 0;i < 100; i++)
{ 
    if (arreglo[i] % 2 == 0)
    {
        Console.WriteLine(arreglo[i]);
    }

}
