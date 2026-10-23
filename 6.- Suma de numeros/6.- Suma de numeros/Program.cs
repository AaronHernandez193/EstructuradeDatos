using System;

class Program
{
    static int SumarDigitos(int n)
    {
        if (n == 0)
            return 0;

        return n % 10 + SumarDigitos(n / 10);
    }
    static void Main()
    {
        Console.Write("Ingrese un numero entero positivo: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Ingrese un numero positivo");
        }

        Console.WriteLine("La suma de los digitos es: " + SumarDigitos(n));
    }
}