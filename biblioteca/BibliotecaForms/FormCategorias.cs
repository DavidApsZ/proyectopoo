using System;
using System.Windows.Forms;

namespace BibliotecaForms
{
    public partial class FormCategorias : Form
    {
        public FormCategorias()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = tb_nombre.Text;

            RepositorioCategorias repCategorias = new RepositorioCategorias();
            repCategorias.RegistrarCategoria(nombre);
            
            // Limpiar campos
            tb_nombre.Text = "";

            // Actualizar la grilla
            gv_categorias.DataSource = repCategorias.ObtenerDatos();
        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            RepositorioCategorias repCategorias = new RepositorioCategorias();
            gv_categorias.DataSource = repCategorias.ObtenerDatos();
        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            string nombre = tb_buscar.Text;

            RepositorioCategorias repCategorias = new RepositorioCategorias();
            gv_categorias.DataSource = repCategorias.BuscarCategoria(nombre);
        }
    }
}