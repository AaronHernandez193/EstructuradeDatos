using System;

class Program
{
    static long CalcularFactorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;

        return n * CalcularFactorial(n - 1);
    }

    static void Main()
    {
        Console.Write("Ingrese un numero entero positivo: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            if (numero < 0)
            {
                Console.WriteLine("Numero invalido, Ingrese un numero positivo");
            }
            else
            {
                long resultado = CalcularFactorial(numero);
                Console.WriteLine($"El Factorial es: " + resultado);
            }
        }
        else
        {
            Console.WriteLine("Ingrese un numero valido.");
        }
    }
}