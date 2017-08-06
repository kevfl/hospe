namespace Hospedaje
{
    partial class FormMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Item_MenuHabitaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.Item_Habitaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.Item_Facturas = new System.Windows.Forms.ToolStripMenuItem();
            this.Item_Precios = new System.Windows.Forms.ToolStripMenuItem();
            this.Item_NuevaHabitacion = new System.Windows.Forms.ToolStripMenuItem();
            this.Item_Reportes = new System.Windows.Forms.ToolStripMenuItem();
            this.Item_Administrador = new System.Windows.Forms.ToolStripMenuItem();
            this.Item_Usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.Item_InformacionEmpre = new System.Windows.Forms.ToolStripMenuItem();
            this.Item_Licencia = new System.Windows.Forms.ToolStripMenuItem();
            this.Item_NuemeroFact = new System.Windows.Forms.ToolStripMenuItem();
            this.Item_Programador = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.Item_CerrarSeción = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Item_Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.txNombreUsu = new System.Windows.Forms.TextBox();
            this.txTipoUsu = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Item_MenuHabitaciones,
            this.Item_Reportes,
            this.Item_Administrador,
            this.toolStripMenuItem5,
            this.Item_CerrarSeción,
            this.toolStripMenuItem2,
            this.Item_Salir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(914, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Item_MenuHabitaciones
            // 
            this.Item_MenuHabitaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Item_Habitaciones,
            this.Item_Facturas,
            this.Item_Precios,
            this.Item_NuevaHabitacion});
            this.Item_MenuHabitaciones.Name = "Item_MenuHabitaciones";
            this.Item_MenuHabitaciones.Size = new System.Drawing.Size(88, 20);
            this.Item_MenuHabitaciones.Text = "Habitaciones";
            // 
            // Item_Habitaciones
            // 
            this.Item_Habitaciones.Name = "Item_Habitaciones";
            this.Item_Habitaciones.Size = new System.Drawing.Size(169, 22);
            this.Item_Habitaciones.Text = "Habitaciones";
            this.Item_Habitaciones.Click += new System.EventHandler(this.Item_Habitaciones_Click);
            // 
            // Item_Facturas
            // 
            this.Item_Facturas.Name = "Item_Facturas";
            this.Item_Facturas.Size = new System.Drawing.Size(169, 22);
            this.Item_Facturas.Text = "Facturas";
            this.Item_Facturas.Click += new System.EventHandler(this.Item_Facturas_Click);
            // 
            // Item_Precios
            // 
            this.Item_Precios.Name = "Item_Precios";
            this.Item_Precios.Size = new System.Drawing.Size(169, 22);
            this.Item_Precios.Text = "Precio";
            this.Item_Precios.Click += new System.EventHandler(this.Item_Precios_Click);
            // 
            // Item_NuevaHabitacion
            // 
            this.Item_NuevaHabitacion.Name = "Item_NuevaHabitacion";
            this.Item_NuevaHabitacion.Size = new System.Drawing.Size(169, 22);
            this.Item_NuevaHabitacion.Text = "Nueva Habitación";
            this.Item_NuevaHabitacion.Click += new System.EventHandler(this.Item_NuevaHabitacion_Click);
            // 
            // Item_Reportes
            // 
            this.Item_Reportes.Name = "Item_Reportes";
            this.Item_Reportes.Size = new System.Drawing.Size(65, 20);
            this.Item_Reportes.Text = "Reportes";
            // 
            // Item_Administrador
            // 
            this.Item_Administrador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Item_Usuario,
            this.Item_InformacionEmpre,
            this.Item_Licencia,
            this.Item_NuemeroFact,
            this.Item_Programador});
            this.Item_Administrador.Name = "Item_Administrador";
            this.Item_Administrador.Size = new System.Drawing.Size(95, 20);
            this.Item_Administrador.Text = "Administrador";
            // 
            // Item_Usuario
            // 
            this.Item_Usuario.Name = "Item_Usuario";
            this.Item_Usuario.Size = new System.Drawing.Size(187, 22);
            this.Item_Usuario.Text = "Usuario";
            this.Item_Usuario.Click += new System.EventHandler(this.Item_Usuario_Click);
            // 
            // Item_InformacionEmpre
            // 
            this.Item_InformacionEmpre.Name = "Item_InformacionEmpre";
            this.Item_InformacionEmpre.Size = new System.Drawing.Size(187, 22);
            this.Item_InformacionEmpre.Text = "Información Empresa";
            this.Item_InformacionEmpre.Click += new System.EventHandler(this.Item_InformacionEmpre_Click);
            // 
            // Item_Licencia
            // 
            this.Item_Licencia.Name = "Item_Licencia";
            this.Item_Licencia.Size = new System.Drawing.Size(187, 22);
            this.Item_Licencia.Text = "Licencia";
            this.Item_Licencia.Click += new System.EventHandler(this.Item_Licencia_Click);
            // 
            // Item_NuemeroFact
            // 
            this.Item_NuemeroFact.Name = "Item_NuemeroFact";
            this.Item_NuemeroFact.Size = new System.Drawing.Size(187, 22);
            this.Item_NuemeroFact.Text = "Número Factura";
            this.Item_NuemeroFact.Click += new System.EventHandler(this.Item_NuemeroFact_Click);
            // 
            // Item_Programador
            // 
            this.Item_Programador.Name = "Item_Programador";
            this.Item_Programador.Size = new System.Drawing.Size(187, 22);
            this.Item_Programador.Text = "Programador";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem5.Text = " ";
            // 
            // Item_CerrarSeción
            // 
            this.Item_CerrarSeción.Name = "Item_CerrarSeción";
            this.Item_CerrarSeción.Size = new System.Drawing.Size(89, 20);
            this.Item_CerrarSeción.Text = "Cerrar Seción";
            this.Item_CerrarSeción.Click += new System.EventHandler(this.Item_CerrarSeción_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem2.Text = " ";
            // 
            // Item_Salir
            // 
            this.Item_Salir.Name = "Item_Salir";
            this.Item_Salir.Size = new System.Drawing.Size(41, 20);
            this.Item_Salir.Text = "Salir";
            this.Item_Salir.Click += new System.EventHandler(this.Item_Salir_Click);
            // 
            // txNombreUsu
            // 
            this.txNombreUsu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txNombreUsu.Enabled = false;
            this.txNombreUsu.Location = new System.Drawing.Point(682, 36);
            this.txNombreUsu.Margin = new System.Windows.Forms.Padding(4);
            this.txNombreUsu.Name = "txNombreUsu";
            this.txNombreUsu.Size = new System.Drawing.Size(214, 20);
            this.txNombreUsu.TabIndex = 1;
            // 
            // txTipoUsu
            // 
            this.txTipoUsu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txTipoUsu.Enabled = false;
            this.txTipoUsu.Location = new System.Drawing.Point(682, 70);
            this.txTipoUsu.Margin = new System.Windows.Forms.Padding(4);
            this.txTipoUsu.Name = "txTipoUsu";
            this.txTipoUsu.Size = new System.Drawing.Size(214, 20);
            this.txTipoUsu.TabIndex = 2;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 342);
            this.Controls.Add(this.txTipoUsu);
            this.Controls.Add(this.txNombreUsu);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Item_MenuHabitaciones;
        private System.Windows.Forms.ToolStripMenuItem Item_Reportes;
        private System.Windows.Forms.ToolStripMenuItem Item_CerrarSeción;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem Item_Salir;
        private System.Windows.Forms.ToolStripMenuItem Item_Administrador;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        public System.Windows.Forms.TextBox txNombreUsu;
        public System.Windows.Forms.TextBox txTipoUsu;
        private System.Windows.Forms.ToolStripMenuItem Item_Usuario;
        private System.Windows.Forms.ToolStripMenuItem Item_InformacionEmpre;
        private System.Windows.Forms.ToolStripMenuItem Item_Licencia;
        private System.Windows.Forms.ToolStripMenuItem Item_NuemeroFact;
        private System.Windows.Forms.ToolStripMenuItem Item_Programador;
        private System.Windows.Forms.ToolStripMenuItem Item_Habitaciones;
        private System.Windows.Forms.ToolStripMenuItem Item_Precios;
        private System.Windows.Forms.ToolStripMenuItem Item_Facturas;
        private System.Windows.Forms.ToolStripMenuItem Item_NuevaHabitacion;
    }
}

