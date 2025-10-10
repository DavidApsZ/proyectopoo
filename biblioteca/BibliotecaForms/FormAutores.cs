using System;
using System.Windows.Forms;

namespace BibliotecaForms
{
    public partial class FormAutores : Form
    {
        public FormAutores()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = tb_nombre.Text;
            string apellido = tb_apellido.Text;
            string nacionalidad = tb_nacionalidad.Text;

            RepositorioAutores repAutores = new RepositorioAutores();
            repAutores.RegistrarAutor(nombre, apellido, nacionalidad);
            
            // Limpiar campos
            tb_nombre.Text = "";
            tb_apellido.Text = "";
            tb_nacionalidad.Text = "";

            // Actualizar la grilla
            gv_autores.DataSource = repAutores.ObtenerDatos();
        }

        private void FormAutores_Load(object sender, EventArgs e)
        {
            RepositorioAutores repAutores = new RepositorioAutores();
            gv_autores.DataSource = repAutores.ObtenerDatos();
        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            string nombre = tb_buscar.Text;

            RepositorioAutores repAutores = new RepositorioAutores();
            gv_autores.DataSource = repAutores.BuscarAutor(nombre);
        }
    }
}