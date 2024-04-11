using System;

int n = 1;

int[] arrelgo=  new int[100];

for (int i = 0; i < 100; i++)
{
    arrelgo[i] = n;
    n = n + 1;
}

for  (int i = 0;i < 100; i++)
{ 
    if (arrelgo[i] % 2 == 0)
    {
        Console.WriteLine(arrelgo[i]);
    }

}