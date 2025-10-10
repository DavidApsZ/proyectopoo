using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Editorial
{
    public int ID { get; set; }
    public int IDEditorial { get { return ID; } set { ID = value; } }
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
}

