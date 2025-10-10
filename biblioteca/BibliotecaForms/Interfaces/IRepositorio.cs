using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal interface IRepositorio<T>
{
    List<T> ObtenerDatos();
}

