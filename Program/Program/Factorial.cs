using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa un número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        long factorial = 1;

        for (int i = 1; i <= numero; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"El factorial de {numero} es: {factorial}");
    }
}
