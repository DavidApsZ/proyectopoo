using System;
using System.Windows.Forms;

namespace BibliotecaForms
{
    public partial class FormLibros : Form
    {
        public FormLibros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string titulo = tb_titulo.Text;
                string fecha = tb_fecha.Text;
                
                // Validar que los campos no estén vacíos
                if (string.IsNullOrEmpty(titulo) || string.IsNullOrEmpty(fecha) || string.IsNullOrEmpty(tb_paginas.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }
                
                int paginas = Convert.ToInt32(tb_paginas.Text);
                
                // Usar valores por defecto si los ComboBox no tienen selección
                int autor = 1;  // ID por defecto
                int categoria = 1;  // ID por defecto
                int editorial = 1;  // ID por defecto
                
                // Si hay ComboBox configurados, usar sus valores
                if (cmb_categorias.SelectedValue != null && cmb_categorias.SelectedValue.ToString() != "0")
                {
                    categoria = Convert.ToInt32(cmb_categorias.SelectedValue);
                }
                
                if (cmb_autor.SelectedValue != null && cmb_autor.SelectedValue.ToString() != "0")
                {
                    autor = Convert.ToInt32(cmb_autor.SelectedValue);
                }

                RepositorioLibros repLibros = new RepositorioLibros();
                repLibros.RegistrarLibro(titulo, fecha, paginas, autor, categoria, editorial);
                
                // Limpiar campos
                tb_titulo.Text = "";
                tb_paginas.Text = "";
                tb_fecha.Text = "";

                // Recargar datos
                gv_libros.DataSource = repLibros.ObtenerDatos();
                
                MessageBox.Show("Libro agregado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el libro: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargar libros
                RepositorioLibros repLibros = new RepositorioLibros();
                gv_libros.DataSource = repLibros.ObtenerDatos();

                // Cargar categorías
                RepositorioCategorias repCat = new RepositorioCategorias();
                cmb_categorias.DataSource = repCat.ObtenerDatos();
                cmb_categorias.DisplayMember = "Nombre";
                cmb_categorias.ValueMember = "IDCategoria";
                
                // Cargar autores
                RepositorioAutores repAutores = new RepositorioAutores();
                var autores = repAutores.ObtenerDatos();
                cmb_autor.DataSource = autores;
                cmb_autor.DisplayMember = "Nombre";
                cmb_autor.ValueMember = "IDAutor";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            string titulo = tb_buscar.Text;
            int idcat =Convert.ToInt32( cmb_categorias.SelectedValue);

            RepositorioLibros repLibros =
                new RepositorioLibros();
            gv_libros.DataSource =
                repLibros.BuscarTitulo(titulo,idcat);
        }
    }   
}
