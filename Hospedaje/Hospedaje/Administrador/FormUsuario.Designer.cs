namespace Hospedaje.Administrador
{
    partial class FormUsuario
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
            this.lbUsuarioLogueado = new System.Windows.Forms.Label();
            this.btSalir = new System.Windows.Forms.Button();
            this.GridViewUsuario = new System.Windows.Forms.DataGridView();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txContraseña = new System.Windows.Forms.TextBox();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.txUsuario = new System.Windows.Forms.TextBox();
            this.txTipoUsuario = new System.Windows.Forms.ComboBox();
            this.lbContraseña = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbModifica = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUsuarioLogueado
            // 
            this.lbUsuarioLogueado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbUsuarioLogueado.AutoSize = true;
            this.lbUsuarioLogueado.ForeColor = System.Drawing.Color.Black;
            this.lbUsuarioLogueado.Location = new System.Drawing.Point(14, 574);
            this.lbUsuarioLogueado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsuarioLogueado.Name = "lbUsuarioLogueado";
            this.lbUsuarioLogueado.Size = new System.Drawing.Size(72, 18);
            this.lbUsuarioLogueado.TabIndex = 30;
            this.lbUsuarioLogueado.Text = "Usuario : ";
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(412, 166);
            this.btSalir.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(122, 45);
            this.btSalir.TabIndex = 26;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click_1);
            // 
            // GridViewUsuario
            // 
            this.GridViewUsuario.AllowUserToAddRows = false;
            this.GridViewUsuario.AllowUserToDeleteRows = false;
            this.GridViewUsuario.AllowUserToResizeColumns = false;
            this.GridViewUsuario.AllowUserToResizeRows = false;
            this.GridViewUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridViewUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewUsuario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridViewUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewUsuario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.GridViewUsuario.EnableHeadersVisualStyles = false;
            this.GridViewUsuario.Location = new System.Drawing.Point(11, 218);
            this.GridViewUsuario.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.GridViewUsuario.MultiSelect = false;
            this.GridViewUsuario.Name = "GridViewUsuario";
            this.GridViewUsuario.ReadOnly = true;
            this.GridViewUsuario.RowTemplate.Height = 24;
            this.GridViewUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewUsuario.Size = new System.Drawing.Size(1107, 345);
            this.GridViewUsuario.TabIndex = 29;
            this.GridViewUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewUsuario_CellClick_1);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(284, 164);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(122, 45);
            this.btEliminar.TabIndex = 25;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click_1);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(156, 164);
            this.btModificar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(122, 45);
            this.btModificar.TabIndex = 24;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click_1);
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(26, 164);
            this.btAgregar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(122, 45);
            this.btAgregar.TabIndex = 23;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tipo Usuario";
            // 
            // txContraseña
            // 
            this.txContraseña.Location = new System.Drawing.Point(142, 87);
            this.txContraseña.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txContraseña.Name = "txContraseña";
            this.txContraseña.Size = new System.Drawing.Size(132, 24);
            this.txContraseña.TabIndex = 19;
            this.txContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txContraseña_KeyPress_1);
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(142, 49);
            this.txNombre.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(306, 24);
            this.txNombre.TabIndex = 18;
            this.txNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txNombre_KeyPress_1);
            // 
            // txUsuario
            // 
            this.txUsuario.Location = new System.Drawing.Point(142, 13);
            this.txUsuario.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.Size = new System.Drawing.Size(132, 24);
            this.txUsuario.TabIndex = 16;
            this.txUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txUsuario_KeyPress_1);
            // 
            // txTipoUsuario
            // 
            this.txTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txTipoUsuario.FormattingEnabled = true;
            this.txTipoUsuario.Items.AddRange(new object[] {
            "Defaul",
            "Administrador"});
            this.txTipoUsuario.Location = new System.Drawing.Point(142, 123);
            this.txTipoUsuario.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txTipoUsuario.Name = "txTipoUsuario";
            this.txTipoUsuario.Size = new System.Drawing.Size(306, 25);
            this.txTipoUsuario.TabIndex = 21;
            this.txTipoUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txTipoUsuario_KeyPress_1);
            // 
            // lbContraseña
            // 
            this.lbContraseña.AutoSize = true;
            this.lbContraseña.BackColor = System.Drawing.Color.White;
            this.lbContraseña.ForeColor = System.Drawing.Color.Black;
            this.lbContraseña.Location = new System.Drawing.Point(30, 90);
            this.lbContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbContraseña.Name = "lbContraseña";
            this.lbContraseña.Size = new System.Drawing.Size(85, 18);
            this.lbContraseña.TabIndex = 22;
            this.lbContraseña.Text = "Contraseña";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.BackColor = System.Drawing.Color.White;
            this.lbNombre.ForeColor = System.Drawing.Color.Black;
            this.lbNombre.Location = new System.Drawing.Point(60, 53);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(62, 18);
            this.lbNombre.TabIndex = 20;
            this.lbNombre.Text = "Nombre";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.BackColor = System.Drawing.Color.White;
            this.lbUsuario.ForeColor = System.Drawing.Color.Black;
            this.lbUsuario.Location = new System.Drawing.Point(62, 17);
            this.lbUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(60, 18);
            this.lbUsuario.TabIndex = 28;
            this.lbUsuario.Text = "Usuario";
            // 
            // lbModifica
            // 
            this.lbModifica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbModifica.AutoSize = true;
            this.lbModifica.ForeColor = System.Drawing.Color.Black;
            this.lbModifica.Location = new System.Drawing.Point(108, 574);
            this.lbModifica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbModifica.Name = "lbModifica";
            this.lbModifica.Size = new System.Drawing.Size(64, 18);
            this.lbModifica.TabIndex = 17;
            this.lbModifica.Text = "Modifica";
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 603);
            this.Controls.Add(this.lbUsuarioLogueado);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.GridViewUsuario);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txContraseña);
            this.Controls.Add(this.txNombre);
            this.Controls.Add(this.txUsuario);
            this.Controls.Add(this.txTipoUsuario);
            this.Controls.Add(this.lbContraseña);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lbModifica);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsuarioLogueado;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.DataGridView GridViewUsuario;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txContraseña;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.TextBox txUsuario;
        private System.Windows.Forms.ComboBox txTipoUsuario;
        private System.Windows.Forms.Label lbContraseña;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbUsuario;
        public System.Windows.Forms.Label lbModifica;
    }
}