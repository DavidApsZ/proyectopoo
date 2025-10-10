using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    internal static class RepositorioLibros
    {
        private static List<Libro> _lista = new List<Libro>();
        public static List<Libro> ObtenerLibros()
        {
            LlenarLibros();
            return _lista;

        }
        public static void LlenarLibros()
        {
            Libro lib = new Libro
            {
                ID = 1,
                Titulo = "La casa azul",
                Autor = new Autor
                {
                    ID = 1,
                    Nombre = "Luis Pérez",
                },
                Categoria = new Categoria
                {
                    ID = 1,
                    Nombre = "Novela"
                },
                Paginas = 120
            };
            _lista.Add(lib);

            Libro lib2 = new Libro
            {
                ID = 2,
                Titulo = "El bosque perdido",
                Autor = new Autor
                {
                    ID = 2,
                    Nombre = "Ana Torres",
                },
                Categoria = new Categoria
                {
                    ID = 2,
                    Nombre = "Aventura"
                },
                Paginas = 200
            };
            _lista.Add(lib2);

            Libro lib3 = new Libro
            {
                ID = 3,
                Titulo = "Días de verano",
                Autor = new Autor
                {
                    ID = 3,
                    Nombre = "Carlos López",
                },
                Categoria = new Categoria
                {
                    ID = 3,
                    Nombre = "Romance"
                },
                Paginas = 150
            };
            _lista.Add(lib3);

            Libro lib4 = new Libro
            {
                ID = 4,
                Titulo = "Sombras en la noche",
                Autor = new Autor
                {
                    ID = 4,
                    Nombre = "Maria Gómez",
                },
                Categoria = new Categoria
                {
                    ID = 4,
                    Nombre = "Misterio"
                },
                Paginas = 180
            };
            _lista.Add(lib4);

            Libro lib5 = new Libro
            {
                ID = 5,
                Titulo = "Historias del mar",
                Autor = new Autor
                {
                    ID = 5,
                    Nombre = "José Ramírez",
                },
                Categoria = new Categoria
                {
                    ID = 5,
                    Nombre = "Infantil"
                },
                Paginas = 95
            };
            _lista.Add(lib5);

            Libro lib6 = new Libro
            {
                ID = 6,
                Titulo = "Caminos de piedra",
                Autor = new Autor
                {
                    ID = 6,
                    Nombre = "Elena Ruiz",
                },
                Categoria = new Categoria
                {
                    ID = 6,
                    Nombre = "Historico"
                },
                Paginas = 220
            };
            _lista.Add(lib6);
        }

        public static Libro ObtenerLibroPorID(int IdLibro)
        {
            return _lista.Find(libro => libro.ID == IdLibro);
        }

    }

}