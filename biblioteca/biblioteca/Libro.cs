using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Libro
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public DateTime Fecha { get; set; }
        public int Paginas { get; set; }
        public Categoria Categoria { get; set; }
        public Editorial Editorial { get; set; }
        public Autor Autor { get; set; }







    }
}
