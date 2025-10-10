namespace BibliotecaForms
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_libros = new System.Windows.Forms.Button();
            this.bt_categorias = new System.Windows.Forms.Button();
            this.bt_autores = new System.Windows.Forms.Button();
            this.bt_editoriales = new System.Windows.Forms.Button();
            this.bt_prestamos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_libros
            // 
            this.bt_libros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_libros.Location = new System.Drawing.Point(25, 144);
            this.bt_libros.Name = "bt_libros";
            this.bt_libros.Size = new System.Drawing.Size(200, 50);
            this.bt_libros.TabIndex = 0;
            this.bt_libros.Text = "Libros";
            this.bt_libros.UseVisualStyleBackColor = true;
            this.bt_libros.Click += new System.EventHandler(this.bt_libros_Click);
            // 
            // bt_categorias
            // 
            this.bt_categorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.bt_categorias.Location = new System.Drawing.Point(252, 73);
            this.bt_categorias.Name = "bt_categorias";
            this.bt_categorias.Size = new System.Drawing.Size(200, 50);
            this.bt_categorias.TabIndex = 1;
            this.bt_categorias.Text = "Categorias";
            this.bt_categorias.UseVisualStyleBackColor = true;
            this.bt_categorias.Click += new System.EventHandler(this.bt_categorias_Click);
            // 
            // bt_autores
            // 
            this.bt_autores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.bt_autores.Location = new System.Drawing.Point(514, 73);
            this.bt_autores.Name = "bt_autores";
            this.bt_autores.Size = new System.Drawing.Size(200, 50);
            this.bt_autores.TabIndex = 2;
            this.bt_autores.Text = "Autores";
            this.bt_autores.UseVisualStyleBackColor = true;
            this.bt_autores.Click += new System.EventHandler(this.bt_autores_Click);
            // 
            // bt_editoriales
            // 
            this.bt_editoriales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.bt_editoriales.Location = new System.Drawing.Point(252, 210);
            this.bt_editoriales.Name = "bt_editoriales";
            this.bt_editoriales.Size = new System.Drawing.Size(200, 50);
            this.bt_editoriales.TabIndex = 3;
            this.bt_editoriales.Text = "Editoriales";
            this.bt_editoriales.UseVisualStyleBackColor = true;
            this.bt_editoriales.Click += new System.EventHandler(this.bt_editoriales_Click);
            // 
            // bt_prestamos
            // 
            this.bt_prestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.bt_prestamos.Location = new System.Drawing.Point(514, 210);
            this.bt_prestamos.Name = "bt_prestamos";
            this.bt_prestamos.Size = new System.Drawing.Size(200, 50);
            this.bt_prestamos.TabIndex = 4;
            this.bt_prestamos.Text = "Prestamos";
            this.bt_prestamos.UseVisualStyleBackColor = true;
            this.bt_prestamos.Click += new System.EventHandler(this.bt_prestamos_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 360);
            this.Controls.Add(this.bt_prestamos);
            this.Controls.Add(this.bt_editoriales);
            this.Controls.Add(this.bt_autores);
            this.Controls.Add(this.bt_categorias);
            this.Controls.Add(this.bt_libros);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_libros;
        private System.Windows.Forms.Button bt_categorias;
        private System.Windows.Forms.Button bt_autores;
        private System.Windows.Forms.Button bt_editoriales;
        private System.Windows.Forms.Button bt_prestamos;
    }
}