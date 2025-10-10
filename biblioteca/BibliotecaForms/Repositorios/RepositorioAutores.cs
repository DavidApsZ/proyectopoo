using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


internal class RepositorioAutores : IRepositorio<Autor>
{
    private static List<Autor> _lista = new List<Autor>();

    public static List<Autor> ObtenerAutores()
    {
        _lista.Clear();
        LlenarAutores();
        return _lista;
    }

    private static void LlenarAutores()
    {
        Autor autor = new Autor
        {
            ID = 1,
            Nombre = "Gabriel García Márquez"
        };
        _lista.Add(autor);

        autor = new Autor
        {
            ID = 2,
            Nombre = "Stephen King"
        };
        _lista.Add(autor);
        
        autor = new Autor
        {
            ID = 3,
            Nombre = "J.K. Rowling"
        };
        _lista.Add(autor);
    }

    /// <summary>
    /// Retorna una lista de autores
    /// </summary>
    /// <returns></returns>
    public List<Autor> ObtenerDatos()
    {
        _lista.Clear(); // Limpiar la lista antes de cargar datos
        Autor autor = new Autor
        {
            ID = 0,
            Nombre = "",
            Apellido = "",
            Nacionalidad = ""
        };
        _lista.Add(autor);
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3306;uid=root;pwd=hola12345;database=biblioteca;charset=utf8mb4;");
        MySqlCommand comm = new MySqlCommand("SELECT * FROM autores", conn);
        comm.CommandType = System.Data.CommandType.Text;
        try
        {
            conn.Open();
            MySqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Autor autorBD = new Autor
                    {
                        ID = Convert.ToInt32(dr["IDAutor"].ToString()),
                        Nombre = dr["Nombre"].ToString(),
                        Apellido = dr["Apellido"] != DBNull.Value ? dr["Apellido"].ToString() : "",
                        Nacionalidad = dr["Nacionalidad"] != DBNull.Value ? dr["Nacionalidad"].ToString() : ""
                    };
                    _lista.Add(autorBD);
                }
            }
            dr.Close();
        }
        catch (Exception ex)
        {
        }
        finally
        {
            conn.Close();
        }
        return _lista;
    }

    /// <summary>
    /// Realiza una busqueda de autores por nombre
    /// </summary>
    /// <param name="nombre">Nombre del autor</param>
    /// <returns>DataTable con la lista de autores</returns>
    public DataTable BuscarAutorPorNombre(string nombre)
    {
        DataTable dtAutores = new DataTable();
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3306;uid=root;pwd=hola12345;database=biblioteca;charset=utf8mb4;");
        MySqlCommand comm = new MySqlCommand(
            "SELECT * FROM autores WHERE nombre LIKE @nombre OR apellido LIKE @nombre", conn);
        comm.CommandType = System.Data.CommandType.Text;
        comm.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
        try
        {
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(dtAutores);
        }
        catch (Exception ex)
        { }
        finally
        {
            conn.Close();
        }
        return dtAutores;
    }

    public static Autor ObtenerAutorPorId(int IdAutor)
    {
        if (_lista.Count == 0)
        {
            LlenarAutores();
        }
        return _lista.Find(autor => autor.ID == IdAutor);
    }

    public static Autor ObtenerAutorPorNombre(string nombre)
    {
        if (_lista.Count == 0)
        {
            LlenarAutores();
        }
        return _lista.Find(autor => autor.Nombre.Contains(nombre));
    }

    public void RegistrarAutor(string nombre, string apellido, string nacionalidad)
    {
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3306;uid=root;pwd=hola12345;database=biblioteca;charset=utf8mb4;");
        MySqlCommand comm = new MySqlCommand("INSERT INTO autores (Nombre, Apellido, Nacionalidad) VALUES (@nombre, @apellido, @nacionalidad)", conn);
        comm.CommandType = System.Data.CommandType.Text;
        comm.Parameters.AddWithValue("@nombre", nombre);
        comm.Parameters.AddWithValue("@apellido", apellido);
        comm.Parameters.AddWithValue("@nacionalidad", nacionalidad);
        
        try
        {
            conn.Open();
            comm.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
        }
        finally
        {
            conn.Close();
        }
    }

    public List<Autor> BuscarAutor(string nombre)
    {
        List<Autor> listaFiltrada = new List<Autor>();
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3306;uid=root;pwd=hola12345;database=biblioteca;charset=utf8mb4;");
        MySqlCommand comm = new MySqlCommand("SELECT * FROM autores WHERE Nombre LIKE @nombre OR Apellido LIKE @nombre", conn);
        comm.CommandType = System.Data.CommandType.Text;
        comm.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
        
        try
        {
            conn.Open();
            MySqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Autor autor = new Autor
                    {
                        ID = Convert.ToInt32(dr["IDAutor"].ToString()),
                        Nombre = dr["Nombre"].ToString(),
                        Apellido = dr["Apellido"].ToString(),
                        Nacionalidad = dr["Nacionalidad"].ToString()
                    };
                    listaFiltrada.Add(autor);
                }
            }
            dr.Close();
        }
        catch (Exception ex)
        {
        }
        finally
        {
            conn.Close();
        }
        return listaFiltrada;
    }
}
