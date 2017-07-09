namespace Hospedaje.Reserva
{
    partial class FormHabitaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHabitaciones));
            this.txNumHabitacion = new System.Windows.Forms.TextBox();
            this.txNumPersonas = new System.Windows.Forms.TextBox();
            this.txPrecioNacional = new System.Windows.Forms.TextBox();
            this.txPrecioExtranjero = new System.Windows.Forms.TextBox();
            this.txPrecioGobiernoImp = new System.Windows.Forms.TextBox();
            this.txPrecioExtranjeroImp = new System.Windows.Forms.TextBox();
            this.txPrecioNacionalImp = new System.Windows.Forms.TextBox();
            this.txPrecioGobierno = new System.Windows.Forms.TextBox();
            this.lbUsuarioLogueado = new System.Windows.Forms.Label();
            this.lbModifica = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.DGV_Habiataciones = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txCategoria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Habiataciones)).BeginInit();
            this.SuspendLayout();
            // 
            // txNumHabitacion
            // 
            this.txNumHabitacion.Location = new System.Drawing.Point(184, 15);
            this.txNumHabitacion.Margin = new System.Windows.Forms.Padding(4);
            this.txNumHabitacion.Name = "txNumHabitacion";
            this.txNumHabitacion.Size = new System.Drawing.Size(175, 24);
            this.txNumHabitacion.TabIndex = 0;
            // 
            // txNumPersonas
            // 
            this.txNumPersonas.Location = new System.Drawing.Point(184, 78);
            this.txNumPersonas.Margin = new System.Windows.Forms.Padding(4);
            this.txNumPersonas.Name = "txNumPersonas";
            this.txNumPersonas.Size = new System.Drawing.Size(175, 24);
            this.txNumPersonas.TabIndex = 2;
            // 
            // txPrecioNacional
            // 
            this.txPrecioNacional.Enabled = false;
            this.txPrecioNacional.Location = new System.Drawing.Point(184, 112);
            this.txPrecioNacional.Margin = new System.Windows.Forms.Padding(4);
            this.txPrecioNacional.Name = "txPrecioNacional";
            this.txPrecioNacional.Size = new System.Drawing.Size(175, 24);
            this.txPrecioNacional.TabIndex = 3;
            // 
            // txPrecioExtranjero
            // 
            this.txPrecioExtranjero.Enabled = false;
            this.txPrecioExtranjero.Location = new System.Drawing.Point(184, 146);
            this.txPrecioExtranjero.Margin = new System.Windows.Forms.Padding(4);
            this.txPrecioExtranjero.Name = "txPrecioExtranjero";
            this.txPrecioExtranjero.Size = new System.Drawing.Size(175, 24);
            this.txPrecioExtranjero.TabIndex = 4;
            // 
            // txPrecioGobiernoImp
            // 
            this.txPrecioGobiernoImp.Location = new System.Drawing.Point(184, 282);
            this.txPrecioGobiernoImp.Margin = new System.Windows.Forms.Padding(4);
            this.txPrecioGobiernoImp.Name = "txPrecioGobiernoImp";
            this.txPrecioGobiernoImp.Size = new System.Drawing.Size(175, 24);
            this.txPrecioGobiernoImp.TabIndex = 8;
            // 
            // txPrecioExtranjeroImp
            // 
            this.txPrecioExtranjeroImp.Location = new System.Drawing.Point(184, 248);
            this.txPrecioExtranjeroImp.Margin = new System.Windows.Forms.Padding(4);
            this.txPrecioExtranjeroImp.Name = "txPrecioExtranjeroImp";
            this.txPrecioExtranjeroImp.Size = new System.Drawing.Size(175, 24);
            this.txPrecioExtranjeroImp.TabIndex = 7;
            // 
            // txPrecioNacionalImp
            // 
            this.txPrecioNacionalImp.Location = new System.Drawing.Point(184, 214);
            this.txPrecioNacionalImp.Margin = new System.Windows.Forms.Padding(4);
            this.txPrecioNacionalImp.Name = "txPrecioNacionalImp";
            this.txPrecioNacionalImp.Size = new System.Drawing.Size(175, 24);
            this.txPrecioNacionalImp.TabIndex = 6;
            // 
            // txPrecioGobierno
            // 
            this.txPrecioGobierno.Enabled = false;
            this.txPrecioGobierno.Location = new System.Drawing.Point(184, 180);
            this.txPrecioGobierno.Margin = new System.Windows.Forms.Padding(4);
            this.txPrecioGobierno.Name = "txPrecioGobierno";
            this.txPrecioGobierno.Size = new System.Drawing.Size(175, 24);
            this.txPrecioGobierno.TabIndex = 5;
            // 
            // lbUsuarioLogueado
            // 
            this.lbUsuarioLogueado.AutoSize = true;
            this.lbUsuarioLogueado.ForeColor = System.Drawing.Color.Black;
            this.lbUsuarioLogueado.Location = new System.Drawing.Point(13, 403);
            this.lbUsuarioLogueado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsuarioLogueado.Name = "lbUsuarioLogueado";
            this.lbUsuarioLogueado.Size = new System.Drawing.Size(72, 18);
            this.lbUsuarioLogueado.TabIndex = 50;
            this.lbUsuarioLogueado.Text = "Usuario : ";
            // 
            // lbModifica
            // 
            this.lbModifica.AutoSize = true;
            this.lbModifica.ForeColor = System.Drawing.Color.Black;
            this.lbModifica.Location = new System.Drawing.Point(90, 403);
            this.lbModifica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbModifica.Name = "lbModifica";
            this.lbModifica.Size = new System.Drawing.Size(64, 18);
            this.lbModifica.TabIndex = 50;
            this.lbModifica.Text = "Modifica";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 50;
            this.label1.Text = "N° Habitación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 50;
            this.label2.Text = "N° Personas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 50;
            this.label3.Text = "Precio Nacional";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 18);
            this.label4.TabIndex = 50;
            this.label4.Text = "Precio Extranjero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 286);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 18);
            this.label5.TabIndex = 50;
            this.label5.Text = "Precio Gobierno + iv";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 18);
            this.label6.TabIndex = 50;
            this.label6.Text = "Precio Extranjero + iv";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 218);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 18);
            this.label7.TabIndex = 50;
            this.label7.Text = "Precio Nacional + iv";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 184);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 18);
            this.label8.TabIndex = 50;
            this.label8.Text = "Precio Gobierno";
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(44, 335);
            this.btAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(100, 30);
            this.btAgregar.TabIndex = 9;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(152, 335);
            this.btModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(100, 30);
            this.btModificar.TabIndex = 10;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(260, 335);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(100, 30);
            this.btEliminar.TabIndex = 11;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(260, 391);
            this.btSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(100, 30);
            this.btSalir.TabIndex = 13;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // DGV_Habiataciones
            // 
            this.DGV_Habiataciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Habiataciones.Location = new System.Drawing.Point(400, 13);
            this.DGV_Habiataciones.Name = "DGV_Habiataciones";
            this.DGV_Habiataciones.RowTemplate.Height = 24;
            this.DGV_Habiataciones.Size = new System.Drawing.Size(708, 405);
            this.DGV_Habiataciones.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 52);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 18);
            this.label9.TabIndex = 50;
            this.label9.Text = "Categoria";
            // 
            // txCategoria
            // 
            this.txCategoria.Location = new System.Drawing.Point(184, 47);
            this.txCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txCategoria.Name = "txCategoria";
            this.txCategoria.Size = new System.Drawing.Size(175, 24);
            this.txCategoria.TabIndex = 1;
            // 
            // FormHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 430);
            this.Controls.Add(this.txCategoria);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DGV_Habiataciones);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbUsuarioLogueado);
            this.Controls.Add(this.lbModifica);
            this.Controls.Add(this.txPrecioGobiernoImp);
            this.Controls.Add(this.txPrecioExtranjeroImp);
            this.Controls.Add(this.txPrecioNacionalImp);
            this.Controls.Add(this.txPrecioGobierno);
            this.Controls.Add(this.txPrecioExtranjero);
            this.Controls.Add(this.txPrecioNacional);
            this.Controls.Add(this.txNumPersonas);
            this.Controls.Add(this.txNumHabitacion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHabitaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Habitaciones";
            this.Load += new System.EventHandler(this.FormHabitaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Habiataciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txNumHabitacion;
        private System.Windows.Forms.TextBox txNumPersonas;
        private System.Windows.Forms.TextBox txPrecioNacional;
        private System.Windows.Forms.TextBox txPrecioExtranjero;
        private System.Windows.Forms.TextBox txPrecioGobiernoImp;
        private System.Windows.Forms.TextBox txPrecioExtranjeroImp;
        private System.Windows.Forms.TextBox txPrecioNacionalImp;
        private System.Windows.Forms.TextBox txPrecioGobierno;
        private System.Windows.Forms.Label lbUsuarioLogueado;
        public System.Windows.Forms.Label lbModifica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.DataGridView DGV_Habiataciones;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txCategoria;
    }
}