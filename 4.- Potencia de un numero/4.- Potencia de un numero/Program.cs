using System;

class Program
{
    static long Potencia(int baseNum, int exponente)
    {
        if (exponente == 0)
            return 1;

        return baseNum * Potencia(baseNum, exponente - 1);
    }

    static void Main()
    {
        Console.Write("Ingrese el Numero base (No Negativo y Entero): ");
        int baseNum = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el Exponente: ");
        int exponente = int.Parse(Console.ReadLine());

        if (exponente < 0 || exponente > 30)
        {
            Console.WriteLine("Exponente Fuera de Rango.");
            return;
        }

        Console.WriteLine("Resultado: " + Potencia(baseNum, exponente));

    }
}