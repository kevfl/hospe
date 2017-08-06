namespace Hospedaje.Habitaciones
{
    partial class FormNuevaHabiatacion
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
            this.lbModifica = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txHabitacion = new System.Windows.Forms.TextBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.DGV_Habitacion = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.btLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Habitacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUsuarioLogueado
            // 
            this.lbUsuarioLogueado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbUsuarioLogueado.AutoSize = true;
            this.lbUsuarioLogueado.ForeColor = System.Drawing.Color.Black;
            this.lbUsuarioLogueado.Location = new System.Drawing.Point(14, 610);
            this.lbUsuarioLogueado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbUsuarioLogueado.Name = "lbUsuarioLogueado";
            this.lbUsuarioLogueado.Size = new System.Drawing.Size(69, 17);
            this.lbUsuarioLogueado.TabIndex = 69;
            this.lbUsuarioLogueado.Text = "Usuario : ";
            // 
            // lbModifica
            // 
            this.lbModifica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbModifica.AutoSize = true;
            this.lbModifica.ForeColor = System.Drawing.Color.Black;
            this.lbModifica.Location = new System.Drawing.Point(14, 627);
            this.lbModifica.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbModifica.Name = "lbModifica";
            this.lbModifica.Size = new System.Drawing.Size(60, 17);
            this.lbModifica.TabIndex = 70;
            this.lbModifica.Text = "Modifica";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 71;
            this.label1.Text = "ID Habitación";
            // 
            // txHabitacion
            // 
            this.txHabitacion.Location = new System.Drawing.Point(124, 12);
            this.txHabitacion.Margin = new System.Windows.Forms.Padding(4);
            this.txHabitacion.Name = "txHabitacion";
            this.txHabitacion.Size = new System.Drawing.Size(100, 22);
            this.txHabitacion.TabIndex = 72;
            this.txHabitacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txHabitacion_KeyPress);
            // 
            // btAgregar
            // 
            this.btAgregar.Enabled = false;
            this.btAgregar.Location = new System.Drawing.Point(80, 100);
            this.btAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(100, 28);
            this.btAgregar.TabIndex = 73;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Enabled = false;
            this.btEliminar.Location = new System.Drawing.Point(80, 206);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(100, 28);
            this.btEliminar.TabIndex = 74;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // DGV_Habitacion
            // 
            this.DGV_Habitacion.AllowUserToAddRows = false;
            this.DGV_Habitacion.AllowUserToDeleteRows = false;
            this.DGV_Habitacion.AllowUserToResizeColumns = false;
            this.DGV_Habitacion.AllowUserToResizeRows = false;
            this.DGV_Habitacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Habitacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Habitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Habitacion.Location = new System.Drawing.Point(232, 12);
            this.DGV_Habitacion.Margin = new System.Windows.Forms.Padding(4);
            this.DGV_Habitacion.MultiSelect = false;
            this.DGV_Habitacion.Name = "DGV_Habitacion";
            this.DGV_Habitacion.ReadOnly = true;
            this.DGV_Habitacion.RowHeadersVisible = false;
            this.DGV_Habitacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Habitacion.Size = new System.Drawing.Size(987, 626);
            this.DGV_Habitacion.TabIndex = 75;
            this.DGV_Habitacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Habitacion_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 76;
            this.label2.Text = "Estado";
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(120, 58);
            this.lbEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(0, 17);
            this.lbEstado.TabIndex = 77;
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(80, 153);
            this.btLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btLimpiar.TabIndex = 78;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // FormNuevaHabiatacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 653);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGV_Habitacion);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.txHabitacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbUsuarioLogueado);
            this.Controls.Add(this.lbModifica);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNuevaHabiatacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Habiatación";
            this.Load += new System.EventHandler(this.FormNuevaHabiatacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Habitacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsuarioLogueado;
        public System.Windows.Forms.Label lbModifica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txHabitacion;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.DataGridView DGV_Habitacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Button btLimpiar;
    }
}