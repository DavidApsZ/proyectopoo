namespace BibliotecaForms
{
    partial class FormLibros
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
            this.button1 = new System.Windows.Forms.Button();
            this.tb_titulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gv_libros = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_fecha = new System.Windows.Forms.TextBox();
            this.tb_paginas = new System.Windows.Forms.TextBox();
            this.tb_autor = new System.Windows.Forms.TextBox();
            this.tb_categoria = new System.Windows.Forms.TextBox();
            this.tb_editorial = new System.Windows.Forms.TextBox();
            this.tb_buscar = new System.Windows.Forms.TextBox();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.cmb_categorias = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_autor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv_libros)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_titulo
            // 
            this.tb_titulo.Location = new System.Drawing.Point(76, 21);
            this.tb_titulo.Name = "tb_titulo";
            this.tb_titulo.Size = new System.Drawing.Size(149, 20);
            this.tb_titulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Titulo";
            // 
            // gv_libros
            // 
            this.gv_libros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_libros.Location = new System.Drawing.Point(38, 232);
            this.gv_libros.Name = "gv_libros";
            this.gv_libros.Size = new System.Drawing.Size(513, 158);
            this.gv_libros.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Paginas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Autor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Categoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Editorial";
            // 
            // tb_fecha
            // 
            this.tb_fecha.Location = new System.Drawing.Point(284, 21);
            this.tb_fecha.Name = "tb_fecha";
            this.tb_fecha.Size = new System.Drawing.Size(100, 20);
            this.tb_fecha.TabIndex = 10;
            // 
            // tb_paginas
            // 
            this.tb_paginas.Location = new System.Drawing.Point(441, 21);
            this.tb_paginas.Name = "tb_paginas";
            this.tb_paginas.Size = new System.Drawing.Size(100, 20);
            this.tb_paginas.TabIndex = 11;
            // 
            // tb_autor
            // 
            this.tb_autor.Location = new System.Drawing.Point(74, 50);
            this.tb_autor.Name = "tb_autor";
            this.tb_autor.Size = new System.Drawing.Size(151, 20);
            this.tb_autor.TabIndex = 12;
            // 
            // tb_categoria
            // 
            this.tb_categoria.Location = new System.Drawing.Point(284, 53);
            this.tb_categoria.Name = "tb_categoria";
            this.tb_categoria.Size = new System.Drawing.Size(100, 20);
            this.tb_categoria.TabIndex = 13;
            // 
            // tb_editorial
            // 
            this.tb_editorial.Location = new System.Drawing.Point(441, 50);
            this.tb_editorial.Name = "tb_editorial";
            this.tb_editorial.Size = new System.Drawing.Size(100, 20);
            this.tb_editorial.TabIndex = 14;
            // 
            // tb_buscar
            // 
            this.tb_buscar.Location = new System.Drawing.Point(39, 138);
            this.tb_buscar.Name = "tb_buscar";
            this.tb_buscar.Size = new System.Drawing.Size(197, 20);
            this.tb_buscar.TabIndex = 15;
            // 
            // bt_buscar
            // 
            this.bt_buscar.Location = new System.Drawing.Point(424, 164);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(75, 23);
            this.bt_buscar.TabIndex = 16;
            this.bt_buscar.Text = "Buscar";
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.bt_buscar_Click);
            // 
            // cmb_categorias
            // 
            this.cmb_categorias.FormattingEnabled = true;
            this.cmb_categorias.Location = new System.Drawing.Point(263, 138);
            this.cmb_categorias.Name = "cmb_categorias";
            this.cmb_categorias.Size = new System.Drawing.Size(121, 21);
            this.cmb_categorias.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Categoria";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Titulo";
            // 
            // cmb_autor
            // 
            this.cmb_autor.FormattingEnabled = true;
            this.cmb_autor.Location = new System.Drawing.Point(39, 190);
            this.cmb_autor.Name = "cmb_autor";
            this.cmb_autor.Size = new System.Drawing.Size(121, 21);
            this.cmb_autor.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Autor:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 402);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmb_autor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_categorias);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.tb_buscar);
            this.Controls.Add(this.tb_editorial);
            this.Controls.Add(this.tb_categoria);
            this.Controls.Add(this.tb_autor);
            this.Controls.Add(this.tb_paginas);
            this.Controls.Add(this.tb_fecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gv_libros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_titulo);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_libros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gv_libros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_fecha;
        private System.Windows.Forms.TextBox tb_paginas;
        private System.Windows.Forms.TextBox tb_autor;
        private System.Windows.Forms.TextBox tb_categoria;
        private System.Windows.Forms.TextBox tb_editorial;
        private System.Windows.Forms.TextBox tb_buscar;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.ComboBox cmb_categorias;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_autor;
        private System.Windows.Forms.Label label9;
    }
}

