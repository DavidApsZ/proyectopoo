using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa un número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        bool esPrimo = true;

        if (numero <= 1)
        {
            esPrimo = false;
        }
        else
        {
            // Solo verificamos hasta la raíz cuadrada
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }
        }

        Console.WriteLine(esPrimo
            ? $"{numero} es primo"
            : $"{numero} no es primo");
    }
}
