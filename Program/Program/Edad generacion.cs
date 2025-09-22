using System;

class Program
{
    static void Main()
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
}