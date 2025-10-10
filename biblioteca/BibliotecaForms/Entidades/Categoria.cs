using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Categoria
{
    public int ID { get; set; }
    public int IDCategoria { get { return ID; } set { ID = value; } }
    public string Nombre { get; set; }
}

