using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 29, 10, 14, 37, 13 };
        Console.WriteLine("Arreglo original:");
        Mostrar(numeros);
        for (int i = 0; i < numeros.Length - 1; i++)
        {
            int min = i; 
            for (int j = i + 1; j < numeros.Length; j++)
            {
                if (numeros[j] < numeros[min])
                {
                    min = j;
                }
            }
            int temp = numeros[min];
            numeros[min] = numeros[i];
            numeros[i] = temp;
        }

        Console.WriteLine("\nArreglo ordenado:");
        Mostrar(numeros);
    }
    static void Mostrar(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
