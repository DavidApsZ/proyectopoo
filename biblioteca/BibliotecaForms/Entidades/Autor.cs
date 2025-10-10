using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Autor
{
    public int ID { get; set; }
    public int IDAutor { get { return ID; } set { ID = value; } }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Nacionalidad { get; set; }
}

