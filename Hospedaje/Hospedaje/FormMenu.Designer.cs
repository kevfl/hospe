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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Item_Reservas = new System.Windows.Forms.ToolStripMenuItem();
            this.Item_Habitaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.Item_Facturación = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.Item_Reportes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Item_Reservas,
            this.toolStripMenuItem3,
            this.Item_Facturación,
            this.toolStripMenuItem4,
            this.Item_Reportes,
            this.toolStripMenuItem1,
            this.Item_Administrador,
            this.toolStripMenuItem5,
            this.Item_CerrarSeción,
            this.toolStripMenuItem2,
            this.Item_Salir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(685, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Item_Reservas
            // 
            this.Item_Reservas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Item_Habitaciones});
            this.Item_Reservas.Name = "Item_Reservas";
            this.Item_Reservas.Size = new System.Drawing.Size(64, 20);
            this.Item_Reservas.Text = "Reservas";
            // 
            // Item_Habitaciones
            // 
            this.Item_Habitaciones.Name = "Item_Habitaciones";
            this.Item_Habitaciones.Size = new System.Drawing.Size(152, 22);
            this.Item_Habitaciones.Text = "Habitaciones";
            this.Item_Habitaciones.Click += new System.EventHandler(this.Item_Habitaciones_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem3.Text = " ";
            // 
            // Item_Facturación
            // 
            this.Item_Facturación.Name = "Item_Facturación";
            this.Item_Facturación.Size = new System.Drawing.Size(81, 20);
            this.Item_Facturación.Text = "Facturación";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem4.Text = " ";
            // 
            // Item_Reportes
            // 
            this.Item_Reportes.Name = "Item_Reportes";
            this.Item_Reportes.Size = new System.Drawing.Size(65, 20);
            this.Item_Reportes.Text = "Reportes";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem1.Text = " ";
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
            this.txNombreUsu.Location = new System.Drawing.Point(511, 27);
            this.txNombreUsu.Name = "txNombreUsu";
            this.txNombreUsu.Size = new System.Drawing.Size(162, 20);
            this.txNombreUsu.TabIndex = 1;
            // 
            // txTipoUsu
            // 
            this.txTipoUsu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txTipoUsu.Enabled = false;
            this.txTipoUsu.Location = new System.Drawing.Point(511, 53);
            this.txTipoUsu.Name = "txTipoUsu";
            this.txTipoUsu.Size = new System.Drawing.Size(162, 20);
            this.txTipoUsu.TabIndex = 2;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 261);
            this.Controls.Add(this.txTipoUsu);
            this.Controls.Add(this.txNombreUsu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Item_Reservas;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem Item_Facturación;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem Item_Reportes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
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
    }
}

