using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("========== MENU ==========");
            Console.WriteLine("1. Calcula factorial");
            Console.WriteLine("2. Verifica si el numero es primo");
            Console.WriteLine("3. Clasifica edad por generacion");
            Console.WriteLine("4. Verifica mayor o menor edad");
            Console.WriteLine("5. Crear lista e ingresar números");
            Console.WriteLine("6. Verifica numero par o impar");
            Console.WriteLine("7. Constructor persona y edad");
            Console.WriteLine("8. Añadir personas");
            Console.WriteLine("9. Salir");
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
                    CrearLista();
                    break;
                case 6:
                    OpcionParImpar();
                    break;
                case 7:
                    IngresarPersona();
                    break;
                case 8:
                    AñadirPersonas();
                    break;
                case 9:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine("\n-------------------------\n");

        } while (opcion != 9);
    }

    // ================= FUNCIONES NUMERICAS =================

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

    // ================= OPCIONES DEL MENU =================

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
            Console.WriteLine($"Número: {num} - {(EsPar(num) ? "Es PAR" : "Es IMPAR")}");
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

    // ================= CONSTRUCTOR PERSONA =================

    static void IngresarPersona()
    {
        Console.Write("Ingresa el nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingresa el apellido: ");
        string apellido = Console.ReadLine();

        Console.Write("Ingresa la fecha de nacimiento (dd/mm/yyyy): ");
        DateTime nacimiento;
        string formatoFecha = "dd/MM/yyyy";

        while (!DateTime.TryParseExact(Console.ReadLine(), formatoFecha, null, System.Globalization.DateTimeStyles.None, out nacimiento))
        {
            Console.Write("Fecha inválida, por favor ingresa de nuevo (dd/mm/yyyy): ");
        }

        // Crear persona y calcular la edad
        Persona persona = new Persona(nombre, apellido, nacimiento);

        // Mostrar la edad actualizada
        Console.WriteLine($"Edad de {persona.Nombre}: {persona.Edad} años.");
        Console.WriteLine("Presiona cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static List<Persona> personas = new List<Persona>();

    static void AñadirPersonas()
    {
        string respuesta;
        do
        {
            Console.Write("Ingresa el nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingresa el apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("Ingresa la fecha de nacimiento (dd/mm/yyyy): ");
            DateTime nacimiento;
            string formatoFecha = "dd/MM/yyyy";

            while (!DateTime.TryParseExact(Console.ReadLine(), formatoFecha, null, System.Globalization.DateTimeStyles.None, out nacimiento))
            {
                Console.Write("Fecha inválida, por favor ingresa de nuevo (dd/mm/yyyy): ");
            }

            // Crear persona y agregarla a la lista
            Persona persona = new Persona(nombre, apellido, nacimiento);
            personas.Add(persona);

            // Preguntar si desea agregar otra persona
            Console.Write("¿Quieres añadir otra persona? (si/no): ");
            respuesta = Console.ReadLine().ToLower();
        }
        while (respuesta == "si");

        // Contar las clasificaciones por grupo
        int contadorBebe = 0, contadorNino = 0, contadorAdolescente = 0, contadorAdulto = 0, contadorAdultoMayor = 0;

        foreach (var persona in personas)
        {
            string clasificacion = ClasificarEdadPorGeneracion(persona.Edad);

            if (clasificacion == "Bebé") contadorBebe++;
            else if (clasificacion == "Niño") contadorNino++;
            else if (clasificacion == "Adolescente") contadorAdolescente++;
            else if (clasificacion == "Adulto") contadorAdulto++;
            else if (clasificacion == "Adulto mayor") contadorAdultoMayor++;
        }

        // Mostrar resumen de clasificación
        Console.WriteLine("\nResumen de personas por clasificación:");
        Console.WriteLine($"Bebés: {contadorBebe}");
        Console.WriteLine($"Niños: {contadorNino}");
        Console.WriteLine($"Adolescentes: {contadorAdolescente}");
        Console.WriteLine($"Adultos: {contadorAdulto}");
        Console.WriteLine($"Adultos mayores: {contadorAdultoMayor}");

        // Mostrar las personas por clasificación
        Console.WriteLine("\nDetalles de personas por clasificación:");

        if (contadorBebe > 0)
        {
            Console.WriteLine("\nBebés:");
            foreach (var persona in personas)
            {
                if (ClasificarEdadPorGeneracion(persona.Edad) == "Bebé")
                {
                    Console.WriteLine($"{persona.Nombre} {persona.Apellido} - Edad: {persona.Edad}");
                }
            }
        }

        if (contadorNino > 0)
        {
            Console.WriteLine("\nNiños:");
            foreach (var persona in personas)
            {
                if (ClasificarEdadPorGeneracion(persona.Edad) == "Niño")
                {
                    Console.WriteLine($"{persona.Nombre} {persona.Apellido} - Edad: {persona.Edad}");
                }
            }
        }

        if (contadorAdolescente > 0)
        {
            Console.WriteLine("\nAdolescentes:");
            foreach (var persona in personas)
            {
                if (ClasificarEdadPorGeneracion(persona.Edad) == "Adolescente")
                {
                    Console.WriteLine($"{persona.Nombre} {persona.Apellido} - Edad: {persona.Edad}");
                }
            }
        }

        if (contadorAdulto > 0)
        {
            Console.WriteLine("\nAdultos:");
            foreach (var persona in personas)
            {
                if (ClasificarEdadPorGeneracion(persona.Edad) == "Adulto")
                {
                    Console.WriteLine($"{persona.Nombre} {persona.Apellido} - Edad: {persona.Edad}");
                }
            }
        }

        if (contadorAdultoMayor > 0)
        {
            Console.WriteLine("\nAdultos mayores:");
            foreach (var persona in personas)
            {
                if (ClasificarEdadPorGeneracion(persona.Edad) == "Adulto mayor")
                {
                    Console.WriteLine($"{persona.Nombre} {persona.Apellido} - Edad: {persona.Edad}");
                }
            }
        }
    }

    static string ClasificarEdadPorGeneracion(int edad)
    {
        if (edad < 4) return "Bebé";
        else if (edad < 13) return "Niño";
        else if (edad < 18) return "Adolescente";
        else if (edad < 60) return "Adulto";
        else return "Adulto mayor";
    }
}

// ================= CLASE PERSONA =================
public class Persona
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateTime Nacimiento { get; set; }
    public int Edad { get; set; }

    // Constructor de la clase
    public Persona(string nombre, string apellido, DateTime nacimiento)
    {
        Nombre = nombre;
        Apellido = apellido;
        Nacimiento = nacimiento;

        // Calcula la edad
        Edad = DateTime.Now.Year - Nacimiento.Year;

        // Si no ha cumplido este año, restamos 1 a la edad
        if (DateTime.Now.Month < Nacimiento.Month || (DateTime.Now.Month == Nacimiento.Month && DateTime.Now.Day < Nacimiento.Day))
        {
            Edad--;
        }
    }
}
