using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Libro> libros = RepositorioLibros.ObtenerLibros();
            List<Categoria> categorias = RepositorioCategorias.ObtenerCategorias();
            List<Cliente> clientes = RepositorioClientes.ObtenerClientes();
            //Console.WriteLine("Categorias");
            //foreach (Categoria categoria in categorias)
            //{
            //    Console.WriteLine(categoria.Nombre);
            //}


            List<Prestamo> prestamos = new List<Prestamo>();
            Prestamo prestamo = new Prestamo();
            Libro libroPrestado = null;
            Cliente clienteActual = null;
            int opcion = 0;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("--------MENU---------");
                Console.WriteLine("Que desea realizar:");
                Console.WriteLine("0 - Salir");
                Console.WriteLine("1 - Prestamo");
                Console.WriteLine("2 - Deolucion");
                Console.WriteLine("3 - Ver Prestamos");
                Console.WriteLine("4 - Ver Clientes");
                Console.WriteLine("5 - Ver Libros");

                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();


                if (opcion == 1)
                {
                    prestamo = new Prestamo();
                    libroPrestado = null;
                    clienteActual = null;
                    prestamo.ID = prestamos.Count + 1;//asignacion de prueba de id
                    Console.WriteLine("Ingresar Datos de prestamo");
                    while (libroPrestado == null)
                    {
                        Console.WriteLine("Indique el libro: ");
                        int idLibro = Convert.ToInt32(Console.ReadLine());
                        libroPrestado = RepositorioLibros.ObtenerLibroPorId(idLibro);
                        if (libroPrestado == null)
                        {
                            Console.WriteLine("El libro no existe!!!!!");
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
                        clienteActual = RepositorioClientes.ObtenerClientePorId(idCliente);
                        if (clienteActual == null)
                        {
                            Console.WriteLine("El cliente no existe!!!!!");
                        }
                        else
                        {
                            prestamo.Cliente = clienteActual;
                        }
                    }
                    prestamo.FechaPrestamo = DateTime.Now;
                    prestamos.Add(prestamo);
                    Console.WriteLine("El prestamo fue realizado correctamente");
                }
                else if (opcion == 2)
                {
                    int idPrestamo = 0;
                    Console.Write("Indique el prestamoa  devolver:");
                    idPrestamo = Convert.ToInt32(Console.ReadLine());
                    int _index = prestamos.FindIndex(p => p.ID == idPrestamo);
                    prestamos[_index].FechaDev = DateTime.Now;
                    Console.WriteLine("La devolicion fue realizada correctamente");

                }
                else if (opcion == 3)
                {
                    //Console.WriteLine("| ID |        Titulo        |   CLiente    | Fecha Prestamo    |    Fecha Dev  |");
                    //Console.WriteLine("-------------------------------------------------------------------------");
                    foreach (Prestamo p in prestamos)
                    {
                        DateTime fechadev = p.FechaDev;
                        string sFechaDev = " ------ ";
                        if (fechadev > Convert.ToDateTime("01-02-0001"))
                        {
                            sFechaDev= fechadev.ToString();
                        }
                        Console.WriteLine($"| " +
                            $"{p.ID} | " +
                            $"{p.Libro.Titulo} | " +
                            $"{p.Cliente.Nombre} | " +
                            $"{p.FechaPrestamo} | " +
                            $"{sFechaDev} |");
                    }
                }
                else if (opcion == 4)
                {
                    foreach (Cliente cliente in clientes)
                    {
                        Console.WriteLine($"{cliente.ID} - {cliente.Nombre}");
                    }
                }
                else if (opcion == 5)
                {
                    foreach (Libro libro in libros)
                    {
                        Console.WriteLine($"{libro.ID} - {libro.Titulo}");
                    }
                }
            } while (opcion > 0);

        }
    }
}
