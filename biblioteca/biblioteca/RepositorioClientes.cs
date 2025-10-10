using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal static class RepositorioClientes
    {
        public static List<Cliente> _lista = new List<Cliente>();

        public static List<Cliente> ObtenerClientes()
        {
            LlenarClientes();
            return _lista;
        }
        private static void LlenarClientes()
        {
            Cliente cliente = new Cliente
            {
                ID = 1,
                Nombre="Juan",
                Email="juan@correo.com",
                Telefono="1234567890"
            };
            _lista.Add(cliente);
            cliente = new Cliente
            {
                ID = 2,
                Nombre = "Luis",
                Email = "luis@correo.com",
                Telefono = "0987654321"
            };
            _lista.Add(cliente);
        }

        public static Cliente ObtenerClientePorId(int IdCliente)
        {
            LlenarClientes();
            return _lista.Find(cliente =>
            cliente.ID == IdCliente);
        }
    }
}
