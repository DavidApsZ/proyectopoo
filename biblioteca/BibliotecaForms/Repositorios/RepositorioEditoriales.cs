using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


internal class RepositorioEditoriales : IRepositorio<Editorial>
{
    private static List<Editorial> _lista = new List<Editorial>();

    public static List<Editorial> ObtenerEditoriales()
    {
        _lista.Clear();
        LlenarEditoriales();
        return _lista;
    }

    private static void LlenarEditoriales()
    {
        Editorial editorial = new Editorial
        {
            ID = 1,
            Nombre = "Penguin Random House"
        };
        _lista.Add(editorial);

        editorial = new Editorial
        {
            ID = 2,
            Nombre = "HarperCollins"
        };
        _lista.Add(editorial);
        
        editorial = new Editorial
        {
            ID = 3,
            Nombre = "Simon & Schuster"
        };
        _lista.Add(editorial);
    }

    /// <summary>
    /// Retorna una lista de editoriales
    /// </summary>
    /// <returns></returns>
    public List<Editorial> ObtenerDatos()
    {
        _lista.Clear(); // Limpiar la lista antes de cargar datos
        Editorial editorial = new Editorial
        {
            ID = 0,
            Nombre = "",
            Direccion = "",
            Telefono = ""
        };
        _lista.Add(editorial);
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;uid=root;database=biblioteca;charset=utf8mb4;");
        MySqlCommand comm = new MySqlCommand("SELECT * FROM editoriales", conn);
        comm.CommandType = System.Data.CommandType.Text;
        try
        {
            conn.Open();
            MySqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Editorial editorialBD = new Editorial
                    {
                        ID = Convert.ToInt32(dr["IDEditorial"].ToString()),
                        Nombre = dr["Nombre"].ToString(),
                        Direccion = dr["Direccion"] != DBNull.Value ? dr["Direccion"].ToString() : "",
                        Telefono = dr["Telefono"] != DBNull.Value ? dr["Telefono"].ToString() : ""
                    };
                    _lista.Add(editorialBD);
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
    /// Realiza una busqueda de editoriales por nombre
    /// </summary>
    /// <param name="nombre">Nombre de la editorial</param>
    /// <returns>DataTable con la lista de editoriales</returns>
    public DataTable BuscarEditorialPorNombre(string nombre)
    {
        DataTable dtEditoriales = new DataTable();
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;uid=root;database=biblioteca;charset=utf8mb4;");
        MySqlCommand comm = new MySqlCommand(
            "SELECT * FROM editoriales WHERE nombre LIKE @nombre", conn);
        comm.CommandType = System.Data.CommandType.Text;
        comm.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
        try
        {
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(dtEditoriales);
        }
        catch (Exception ex)
        { }
        finally
        {
            conn.Close();
        }
        return dtEditoriales;
    }

    public static Editorial ObtenerEditorialPorId(int IdEditorial)
    {
        if (_lista.Count == 0)
        {
            LlenarEditoriales();
        }
        return _lista.Find(editorial => editorial.ID == IdEditorial);
    }

    public static Editorial ObtenerEditorialPorNombre(string nombre)
    {
        if (_lista.Count == 0)
        {
            LlenarEditoriales();
        }
        return _lista.Find(editorial => editorial.Nombre.Contains(nombre));
    }

    public void RegistrarEditorial(string nombre, string direccion, string telefono)
    {
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;uid=root;database=biblioteca;charset=utf8mb4;");
        MySqlCommand comm = new MySqlCommand("INSERT INTO editoriales (Nombre, Direccion, Telefono) VALUES (@nombre, @direccion, @telefono)", conn);
        comm.CommandType = System.Data.CommandType.Text;
        comm.Parameters.AddWithValue("@nombre", nombre);
        comm.Parameters.AddWithValue("@direccion", direccion);
        comm.Parameters.AddWithValue("@telefono", telefono);
        
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

    public List<Editorial> BuscarEditorial(string nombre)
    {
        List<Editorial> listaFiltrada = new List<Editorial>();
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;uid=root;database=biblioteca;charset=utf8mb4;");
        MySqlCommand comm = new MySqlCommand("SELECT * FROM editoriales WHERE Nombre LIKE @nombre", conn);
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
                    Editorial editorial = new Editorial
                    {
                        ID = Convert.ToInt32(dr["IDEditorial"].ToString()),
                        Nombre = dr["Nombre"].ToString(),
                        Direccion = dr["Direccion"] != DBNull.Value ? dr["Direccion"].ToString() : "",
                        Telefono = dr["Telefono"] != DBNull.Value ? dr["Telefono"].ToString() : ""
                    };
                    listaFiltrada.Add(editorial);
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