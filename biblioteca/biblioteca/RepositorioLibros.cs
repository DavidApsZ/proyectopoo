using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal static class RepositorioLibros
    {
        private static  List<Libro> _lista = new List<Libro>();
        public static List<Libro> ObtenerLibros()
        {
            llenarLibros();
            return _lista;
        }

        private static void llenarLibros()
        {

            Libro lib = new Libro
            {
                ID = 1,
                Titulo = "Señor de los anillos",
                Autor = new Autor
                {
                    ID = 1,
                    Nombre="Juan"
                },
                Categoria=new Categoria
                {
                    ID = 1,
                    Nombre="Accion"
                },
                Paginas=450

            };
            _lista.Add(lib);
            lib = new Libro
            {
                ID = 3,
                Titulo = "Señor de los anillos 2",
                Autor = new Autor
                {
                    ID = 1,
                    Nombre = "Juan"
                },
                Categoria = new Categoria
                {
                    ID = 1,
                    Nombre = "Accion"
                },
                Paginas = 450
            };
            _lista.Add(lib);

        }

        public static Libro ObtenerLibroPorId(int IdLibro)
        {
            llenarLibros();
            return _lista.Find(libro => libro.ID == IdLibro);
        }
    }
}
