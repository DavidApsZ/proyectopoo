using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


internal class RepositorioCategorias: IRepositorio<Categoria>
{
    private static List<Categoria> _lista = new List<Categoria>();

    public static List<Categoria> ObtenerCategorias()
    {
        _lista.Clear();
        LlenarCategorias();
        return _lista;
    }

    private static void LlenarCategorias()
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
        cat = new Categoria
        {
            ID = 3,
            Nombre = "Infantil"
        };
        _lista.Add(cat);
    }

    /// <summary>
    /// Retorna una lista de categorias
    /// </summary>
    /// <returns></returns>
    public List<Categoria> ObtenerDatos()
    {
        _lista.Clear(); // Limpiar la lista antes de cargar datos
        Categoria cat = new Categoria
        {
            ID = 0,
            Nombre=""
        };
        _lista.Add(cat);
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3306;uid=root;pwd=hola12345;database=biblioteca;charset=utf8mb4;");
        MySqlCommand comm = new MySqlCommand("SELECT * FROM categorias", conn);
        comm.CommandType = System.Data.CommandType.Text;
        try
        {
            conn.Open();
            MySqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Categoria categoria= new Categoria
                    {
                        ID = Convert.ToInt32(dr["IDCategoria"].ToString()),
                        Nombre = dr["Nombre"].ToString()
                    };
                    _lista.Add(categoria);
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

    public void RegistrarCategoria(string nombre)
    {
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3306;uid=root;pwd=hola12345;database=biblioteca;charset=utf8mb4;");
        MySqlCommand comm = new MySqlCommand("INSERT INTO categorias (Nombre) VALUES (@nombre)", conn);
        comm.CommandType = System.Data.CommandType.Text;
        comm.Parameters.AddWithValue("@nombre", nombre);
        
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

    public List<Categoria> BuscarCategoria(string nombre)
    {
        List<Categoria> listaFiltrada = new List<Categoria>();
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3306;uid=root;pwd=hola12345;database=biblioteca;charset=utf8mb4;");
        MySqlCommand comm = new MySqlCommand("SELECT * FROM categorias WHERE Nombre LIKE @nombre", conn);
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
                    Categoria categoria = new Categoria
                    {
                        ID = Convert.ToInt32(dr["IDCategoria"].ToString()),
                        Nombre = dr["Nombre"].ToString()
                    };
                    listaFiltrada.Add(categoria);
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

