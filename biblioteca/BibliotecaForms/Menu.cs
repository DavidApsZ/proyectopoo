using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaForms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bt_libros_Click(object sender, EventArgs e)
        {
            FormLibros libs= new FormLibros();
            libs.Show();
        }

        private void bt_categorias_Click(object sender, EventArgs e)
        {
            FormCategorias formCategorias = new FormCategorias();
            formCategorias.Show();
        }

        private void bt_autores_Click(object sender, EventArgs e)
        {
            FormAutores formAutores = new FormAutores();
            formAutores.Show();
        }

        private void bt_editoriales_Click(object sender, EventArgs e)
        {
            // Aquí se abrirá el formulario de editoriales
            MessageBox.Show("Funcionalidad de Editoriales en desarrollo");
        }

        private void bt_prestamos_Click(object sender, EventArgs e)
        {
            // Aquí se abrirá el formulario de préstamos
            MessageBox.Show("Funcionalidad de Préstamos en desarrollo");
        }
    }
}
