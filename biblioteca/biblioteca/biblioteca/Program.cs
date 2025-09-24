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

            Console.WriteLine("Libros");
            foreach (Libro libro in libros)
            { 
                Console.WriteLine(libro.Titulo);
            }

            Console.WriteLine("Categorias");
            foreach (Categoria categoria in categorias)
            {
                Console.WriteLine(categoria.Nombre);
            }
        }
    }
}
