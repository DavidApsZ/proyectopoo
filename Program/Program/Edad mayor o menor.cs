using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa tu edad: ");
        int edad = int.Parse(Console.ReadLine());

        if (edad >= 18)
            Console.WriteLine("Mayor de edad");
        else
            Console.WriteLine("Menor de edad");
    }
}
