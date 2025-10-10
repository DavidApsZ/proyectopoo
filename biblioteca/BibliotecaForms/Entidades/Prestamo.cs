using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Prestamo
{
    public int ID { get; set; }
    public Libro Libro { get; set; }
    public DateTime FechaPrestamo { get; set; }
    public DateTime FechaDev { get; set; }
    public Cliente Cliente { get; set; }
}

