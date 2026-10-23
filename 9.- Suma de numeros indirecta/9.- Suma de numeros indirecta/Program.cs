using System;

class Program
{

    static int SumaA(int n)
    {
        if (n <= 0)
            return 0;

        return n + SumaB(n - 1);
    }

    static int SumaB(int n)
    {
        if (n <= 0)
            return 0;

        return n + SumaA(n - 1);
    }

    static void Main()
    {
        Console.Write("Ingrese un numero entero positivo: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 10000)
        {
            Console.WriteLine("Ingrese un numero entre 0 y 10000.");
            return;
        }

        Console.WriteLine("La suma es: " + SumaA(n));
    }
}