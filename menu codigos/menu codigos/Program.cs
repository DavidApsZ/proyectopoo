using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("========== MENÚ ==========");
            Console.WriteLine("1. Calcular factorial");
            Console.WriteLine("2. Verificar si un número es primo");
            Console.WriteLine("3. Clasificar edad (bebé, niño, adolescente, adulto, adulto mayor)");
            Console.WriteLine("4. Verificar si eres mayor o menor de edad");
            Console.WriteLine("5. Salir");
            Console.WriteLine("6. Crear lista e ingresar números");
            Console.WriteLine("7. Verificar si un número es par o impar");
            Console.Write("Elige una opción: ");

            opcion = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    OpcionFactorial();
                    break;
                case 2:
                    OpcionPrimo();
                    break;
                case 3:
                    ClasificarEdad();
                    break;
                case 4:
                    MayorOMenor();
                    break;
                case 5:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                case 6:
                    CrearLista();
                    break;
                case 7:
                    OpcionParImpar();
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine("\n-------------------------\n");

        } while (opcion != 5);
    }

    // ================= FUNCIONES NUMÉRICAS =================

    static int CalcularFactorial(int n)
    {
        int fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }
        return fact;
    }

    static bool EsPrimo(int n)
    {
        if (n <= 1) return false;

        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    static bool EsPar(int n)
    {
        return n % 2 == 0;
    }

    // ================= OPCIONES DEL MENÚ =================

    static void OpcionFactorial()
    {
        Console.Write("Ingresa un número: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"El factorial de {n} es: {CalcularFactorial(n)}");
    }

    static void OpcionPrimo()
    {
        Console.Write("Ingresa un número: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(EsPrimo(n) ? $"{n} es primo" : $"{n} no es primo");
    }

    static void ClasificarEdad()
    {
        Console.Write("Ingresa tu edad: ");
        int edad = int.Parse(Console.ReadLine());

        if (edad < 4)
            Console.WriteLine("Bebé");
        else if (edad < 13)
            Console.WriteLine("Niño");
        else if (edad < 18)
            Console.WriteLine("Adolescente");
        else if (edad < 60)
            Console.WriteLine("Adulto");
        else
            Console.WriteLine("Adulto mayor");
    }

    static void MayorOMenor()
    {
        Console.Write("Ingresa tu edad: ");
        int edad = int.Parse(Console.ReadLine());

        if (edad >= 18)
            Console.WriteLine("Mayor de edad");
        else
            Console.WriteLine("Menor de edad");
    }

    static void CrearLista()
    {
        Console.Write("¿Cuántos números quieres ingresar?: ");
        int n = int.Parse(Console.ReadLine());
        List<int> lista = new List<int>();

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Número {i + 1}: ");
            int num = int.Parse(Console.ReadLine());
            lista.Add(num);
        }

        Console.WriteLine("\nResultados de la lista:\n");
        foreach (int num in lista)
        {
            Console.WriteLine($"Número: {num}");
            Console.WriteLine(EsPar(num) ? " - Es PAR" : " - Es IMPAR");
            Console.WriteLine($" - Factorial: {CalcularFactorial(num)}");
            Console.WriteLine(EsPrimo(num) ? " - Es PRIMO" : " - NO es primo");
            Console.WriteLine();
        }
    }

    static void OpcionParImpar()
    {
        Console.Write("Ingresa un número: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(EsPar(n) ? $"{n} es PAR" : $"{n} es IMPAR");
    }
}
