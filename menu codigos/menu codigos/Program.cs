using System;

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
            Console.Write("Elige una opción: ");

            opcion = int.Parse(Console.ReadLine());
            Console.WriteLine(); // salto de línea

            switch (opcion)
            {
                case 1:
                    Factorial();
                    break;
                case 2:
                    Primo();
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
                default:
                    Console.WriteLine("Opción no válida, intenta de nuevo.");
                    break;
            }

            Console.WriteLine("\n-------------------------\n");

        } while (opcion != 5);
    }

    // 🔹 Función 1: Factorial
    static void Factorial()
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

    // 🔹 Función 2: Verificar número primo
    static void Primo()
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

    // 🔹 Función 3: Clasificación por edad
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

    // 🔹 Función 4: Mayor o menor de edad
    static void MayorOMenor()
    {
        Console.Write("Ingresa tu edad: ");
        int edad = int.Parse(Console.ReadLine());

        if (edad >= 18)
            Console.WriteLine("Mayor de edad");
        else
            Console.WriteLine("Menor de edad");
    }
}
