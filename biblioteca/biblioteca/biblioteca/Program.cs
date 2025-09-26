using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Libro> libros = RepositorioLibros.ObtenerLibros();
            List<Categoria> categorias = RepositorioCategorias.ObtenerCategorias();
            List<Cliente> clientes = RepositorioClientes.ObtenerClientes();

            Console.WriteLine("Libros:");
            foreach (Libro libro in libros)
            {
                Console.WriteLine($"{libro.ID} - {libro.Titulo}");
            }

            Console.WriteLine();


            Console.WriteLine("Categorias:");
            foreach (Categoria categoria in categorias)
            {
                Console.WriteLine(categoria.Nombre);
            }
            Console.WriteLine();

            Console.WriteLine("Clientes:");
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine($"{cliente.ID} - {cliente.Nombre}");
            }

            List<Prestamos> prestamos = new List<Prestamos>();
            Prestamos prestamo = new Prestamos();
            Libro libroPrestado = null;
            Cliente clienteActual = null;
            int opcion = 0;
            do
            {

                Console.WriteLine("Que desea realizar: ");
                Console.WriteLine("1 - Prestamo");
                Console.WriteLine("2 - Devolucion");
                Console.WriteLine("3 - Ver prestamos");
                opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine("Ingresar datos de prestamo");
                    while (libroPrestado == null)
                    {
                        Console.WriteLine("Indique el libro: ");
                        int idLibro = Convert.ToInt32(Console.ReadLine());
                        libroPrestado = RepositorioLibros.ObtenerLibroPorID(idLibro);
                        if (libroPrestado == null)
                        {
                            Console.WriteLine("El libro no existe!");
                        }
                        else
                        {
                            prestamo.Libro = libroPrestado;
                        }

                    }
                    while (clienteActual == null)
                    {
                        Console.WriteLine("Indique el cliente: ");
                        int idCliente = Convert.ToInt32(Console.ReadLine());
                        clienteActual = RepositorioClientes.ObtenerClientePorID(idCliente);
                        if (clienteActual == null)
                        {
                            Console.WriteLine("El cliente no existe!");
                        }
                        else
                        {
                            prestamo.Cliente = clienteActual;
                        }
                    }
                    prestamo.FechaPrestamo = DateTime.Now;
                    prestamos.Add(prestamo);
                }
                else if (opcion == 2)
                {

                }
                else if (opcion == 3)
                {
                    foreach (Prestamos p in prestamos)
                    {
                        Console.WriteLine($"{p.ID} - {p.Libro.Titulo} - {p.Cliente.Nombre}");
                    }
                }

            } while (opcion > 0);

        }
    }

}