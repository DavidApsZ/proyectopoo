using System;

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

