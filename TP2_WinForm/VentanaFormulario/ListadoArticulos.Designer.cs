﻿namespace TP2_WinForm.VentanaFormulario
{
    partial class ListadoArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoArticulos));
            this.lbl_ListadoArticulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnvolver = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtArticuloCategoria = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtArticuloMarca = new System.Windows.Forms.TextBox();
            this.txtArticuloImagenUrl = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtArticuloPrecio = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtArticuloDescripcion = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtArticuloNombre = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtArticuloCodigo = new System.Windows.Forms.TextBox();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbCodigoArticulo = new System.Windows.Forms.Label();
            this.dgvArticulo = new System.Windows.Forms.DataGridView();
            this.AgregariconoPc = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgregariconoPc)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ListadoArticulo
            // 
            this.lbl_ListadoArticulo.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ListadoArticulo.ForeColor = System.Drawing.Color.White;
            this.lbl_ListadoArticulo.Location = new System.Drawing.Point(420, 38);
            this.lbl_ListadoArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ListadoArticulo.Name = "lbl_ListadoArticulo";
            this.lbl_ListadoArticulo.Size = new System.Drawing.Size(564, 58);
            this.lbl_ListadoArticulo.TabIndex = 0;
            this.lbl_ListadoArticulo.Text = "LISTADO DE ARTICULOS";
            this.lbl_ListadoArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.btnvolver);
            this.panel1.Controls.Add(this.lbl_ListadoArticulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 135);
            this.panel1.TabIndex = 1;
            // 
            // btnvolver
            // 
            this.btnvolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnvolver.BackgroundImage")));
            this.btnvolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnvolver.FlatAppearance.BorderSize = 0;
            this.btnvolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnvolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnvolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvolver.Location = new System.Drawing.Point(1122, 18);
            this.btnvolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(129, 89);
            this.btnvolver.TabIndex = 12;
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.txtArticuloCategoria);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.txtArticuloMarca);
            this.panel2.Controls.Add(this.txtArticuloImagenUrl);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.txtArticuloPrecio);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.txtArticuloDescripcion);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtArticuloNombre);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.txtArticuloCodigo);
            this.panel2.Controls.Add(this.lblImagen);
            this.panel2.Controls.Add(this.lbPrecio);
            this.panel2.Controls.Add(this.lbCategoria);
            this.panel2.Controls.Add(this.lbMarca);
            this.panel2.Controls.Add(this.lbDescripcion);
            this.panel2.Controls.Add(this.lbNombre);
            this.panel2.Controls.Add(this.lbCodigoArticulo);
            this.panel2.Location = new System.Drawing.Point(52, 145);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 417);
            this.panel2.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(291, 254);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(456, 2);
            this.panel8.TabIndex = 52;
            // 
            // txtArticuloCategoria
            // 
            this.txtArticuloCategoria.BackColor = System.Drawing.Color.Silver;
            this.txtArticuloCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArticuloCategoria.Enabled = false;
            this.txtArticuloCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArticuloCategoria.ForeColor = System.Drawing.Color.Black;
            this.txtArticuloCategoria.Location = new System.Drawing.Point(291, 225);
            this.txtArticuloCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtArticuloCategoria.Name = "txtArticuloCategoria";
            this.txtArticuloCategoria.Size = new System.Drawing.Size(456, 23);
            this.txtArticuloCategoria.TabIndex = 51;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(291, 205);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(456, 2);
            this.panel7.TabIndex = 44;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(291, 355);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(456, 2);
            this.panel6.TabIndex = 50;
            // 
            // txtArticuloMarca
            // 
            this.txtArticuloMarca.BackColor = System.Drawing.Color.Silver;
            this.txtArticuloMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArticuloMarca.Enabled = false;
            this.txtArticuloMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArticuloMarca.ForeColor = System.Drawing.Color.Black;
            this.txtArticuloMarca.Location = new System.Drawing.Point(291, 177);
            this.txtArticuloMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtArticuloMarca.Name = "txtArticuloMarca";
            this.txtArticuloMarca.Size = new System.Drawing.Size(456, 23);
            this.txtArticuloMarca.TabIndex = 43;
            // 
            // txtArticuloImagenUrl
            // 
            this.txtArticuloImagenUrl.BackColor = System.Drawing.Color.Silver;
            this.txtArticuloImagenUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArticuloImagenUrl.Enabled = false;
            this.txtArticuloImagenUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArticuloImagenUrl.ForeColor = System.Drawing.Color.Black;
            this.txtArticuloImagenUrl.Location = new System.Drawing.Point(291, 328);
            this.txtArticuloImagenUrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtArticuloImagenUrl.Name = "txtArticuloImagenUrl";
            this.txtArticuloImagenUrl.Size = new System.Drawing.Size(456, 23);
            this.txtArticuloImagenUrl.TabIndex = 49;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(291, 305);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(184, 2);
            this.panel5.TabIndex = 48;
            // 
            // txtArticuloPrecio
            // 
            this.txtArticuloPrecio.BackColor = System.Drawing.Color.Silver;
            this.txtArticuloPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArticuloPrecio.Enabled = false;
            this.txtArticuloPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArticuloPrecio.ForeColor = System.Drawing.Color.Black;
            this.txtArticuloPrecio.Location = new System.Drawing.Point(291, 275);
            this.txtArticuloPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtArticuloPrecio.Name = "txtArticuloPrecio";
            this.txtArticuloPrecio.Size = new System.Drawing.Size(184, 23);
            this.txtArticuloPrecio.TabIndex = 47;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(291, 152);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(456, 2);
            this.panel4.TabIndex = 42;
            // 
            // txtArticuloDescripcion
            // 
            this.txtArticuloDescripcion.BackColor = System.Drawing.Color.Silver;
            this.txtArticuloDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArticuloDescripcion.Enabled = false;
            this.txtArticuloDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArticuloDescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtArticuloDescripcion.Location = new System.Drawing.Point(291, 123);
            this.txtArticuloDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtArticuloDescripcion.Name = "txtArticuloDescripcion";
            this.txtArticuloDescripcion.Size = new System.Drawing.Size(456, 23);
            this.txtArticuloDescripcion.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(291, 108);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(336, 2);
            this.panel3.TabIndex = 40;
            // 
            // txtArticuloNombre
            // 
            this.txtArticuloNombre.BackColor = System.Drawing.Color.Silver;
            this.txtArticuloNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArticuloNombre.Enabled = false;
            this.txtArticuloNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArticuloNombre.ForeColor = System.Drawing.Color.Black;
            this.txtArticuloNombre.Location = new System.Drawing.Point(291, 78);
            this.txtArticuloNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtArticuloNombre.Name = "txtArticuloNombre";
            this.txtArticuloNombre.Size = new System.Drawing.Size(336, 23);
            this.txtArticuloNombre.TabIndex = 39;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Black;
            this.panel11.Location = new System.Drawing.Point(291, 62);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(231, 2);
            this.panel11.TabIndex = 38;
            // 
            // txtArticuloCodigo
            // 
            this.txtArticuloCodigo.BackColor = System.Drawing.Color.Silver;
            this.txtArticuloCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArticuloCodigo.Enabled = false;
            this.txtArticuloCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtArticuloCodigo.ForeColor = System.Drawing.Color.Black;
            this.txtArticuloCodigo.Location = new System.Drawing.Point(291, 32);
            this.txtArticuloCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtArticuloCodigo.Name = "txtArticuloCodigo";
            this.txtArticuloCodigo.Size = new System.Drawing.Size(231, 23);
            this.txtArticuloCodigo.TabIndex = 37;
            this.txtArticuloCodigo.Leave += new System.EventHandler(this.txtArticuloCodigo_Leave);
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.Location = new System.Drawing.Point(124, 328);
            this.lblImagen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(144, 27);
            this.lblImagen.TabIndex = 36;
            this.lblImagen.Text = "URL Imagen:";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecio.Location = new System.Drawing.Point(174, 275);
            this.lbPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(108, 27);
            this.lbPrecio.TabIndex = 35;
            this.lbPrecio.Text = "Precio: ";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.Location = new System.Drawing.Point(138, 225);
            this.lbCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(144, 27);
            this.lbCategoria.TabIndex = 33;
            this.lbCategoria.Text = "Categoría: ";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarca.Location = new System.Drawing.Point(184, 177);
            this.lbMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(84, 27);
            this.lbMarca.TabIndex = 31;
            this.lbMarca.Text = "Marca:";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion.Location = new System.Drawing.Point(114, 128);
            this.lbDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(168, 27);
            this.lbDescripcion.TabIndex = 29;
            this.lbDescripcion.Text = "Descripción: ";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(172, 83);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(96, 27);
            this.lbNombre.TabIndex = 27;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbCodigoArticulo
            // 
            this.lbCodigoArticulo.AutoSize = true;
            this.lbCodigoArticulo.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoArticulo.Location = new System.Drawing.Point(30, 37);
            this.lbCodigoArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCodigoArticulo.Name = "lbCodigoArticulo";
            this.lbCodigoArticulo.Size = new System.Drawing.Size(252, 27);
            this.lbCodigoArticulo.TabIndex = 25;
            this.lbCodigoArticulo.Text = "Codigo de artículo: ";
            // 
            // dgvArticulo
            // 
            this.dgvArticulo.AllowUserToAddRows = false;
            this.dgvArticulo.AllowUserToDeleteRows = false;
            this.dgvArticulo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvArticulo.BackgroundColor = System.Drawing.Color.White;
            this.dgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgvArticulo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulo.Location = new System.Drawing.Point(147, 570);
            this.dgvArticulo.MultiSelect = false;
            this.dgvArticulo.Name = "dgvArticulo";
            this.dgvArticulo.ReadOnly = true;
            this.dgvArticulo.RowHeadersWidth = 62;
            this.dgvArticulo.RowTemplate.Height = 28;
            this.dgvArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulo.Size = new System.Drawing.Size(999, 255);
            this.dgvArticulo.TabIndex = 6;
            this.dgvArticulo.SelectionChanged += new System.EventHandler(this.dgvArticulo_SelectionChanged);
            // 
            // AgregariconoPc
            // 
            this.AgregariconoPc.Image = ((System.Drawing.Image)(resources.GetObject("AgregariconoPc.Image")));
            this.AgregariconoPc.Location = new System.Drawing.Point(850, 145);
            this.AgregariconoPc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AgregariconoPc.Name = "AgregariconoPc";
            this.AgregariconoPc.Size = new System.Drawing.Size(400, 417);
            this.AgregariconoPc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AgregariconoPc.TabIndex = 13;
            this.AgregariconoPc.TabStop = false;
            // 
            // ListadoArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 862);
            this.Controls.Add(this.AgregariconoPc);
            this.Controls.Add(this.dgvArticulo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ListadoArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado articulos";
            this.Load += new System.EventHandler(this.ListadoArticulos_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgregariconoPc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_ListadoArticulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbCodigoArticulo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtArticuloImagenUrl;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvArticulo;
        private System.Windows.Forms.PictureBox AgregariconoPc;
        private System.Windows.Forms.TextBox txtArticuloPrecio;
        private System.Windows.Forms.TextBox txtArticuloDescripcion;
        private System.Windows.Forms.TextBox txtArticuloNombre;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtArticuloCodigo;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtArticuloCategoria;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtArticuloMarca;
        private System.Windows.Forms.Button btnvolver;
    }
}