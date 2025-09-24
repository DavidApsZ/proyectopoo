using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    internal static class RepositorioCategorias
    {
        private static List<Categoria> _lista= new List<Categoria>();
        public static List<Categoria> ObtenerCategorias()
        {
            LlenarCategorias();
            return _lista;
        }
        
        public static void LlenarCategorias()
        {
            Categoria cat = new Categoria
            {
                ID = 1,
                Nombre = "Accion"
            };
            _lista.Add(cat);

            cat = new Categoria
            {
                ID = 2,
                Nombre = "Novela"
            };
            _lista.Add(cat);
        }
    }
}
