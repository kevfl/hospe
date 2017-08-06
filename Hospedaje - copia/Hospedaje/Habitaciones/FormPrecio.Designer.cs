namespace Hospedaje.Habitaciones
{
    partial class FormPrecio
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
            this.txHabiatacionPrecio = new System.Windows.Forms.TextBox();
            this.txCantidadPersonas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txPNacional = new System.Windows.Forms.TextBox();
            this.txPExtranjero = new System.Windows.Forms.TextBox();
            this.txPGobierno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btModificar = new System.Windows.Forms.Button();
            this.DGV_Habitacion = new System.Windows.Forms.DataGridView();
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
            this.lbUsuarioLogueado.TabIndex = 67;
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
            this.lbModifica.TabIndex = 68;
            this.lbModifica.Text = "Modifica";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 69;
            this.label1.Text = "ID Habitación";
            // 
            // txHabiatacionPrecio
            // 
            this.txHabiatacionPrecio.Enabled = false;
            this.txHabiatacionPrecio.Location = new System.Drawing.Point(173, 13);
            this.txHabiatacionPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txHabiatacionPrecio.Name = "txHabiatacionPrecio";
            this.txHabiatacionPrecio.Size = new System.Drawing.Size(100, 22);
            this.txHabiatacionPrecio.TabIndex = 70;
            // 
            // txCantidadPersonas
            // 
            this.txCantidadPersonas.Location = new System.Drawing.Point(173, 45);
            this.txCantidadPersonas.Margin = new System.Windows.Forms.Padding(4);
            this.txCantidadPersonas.Name = "txCantidadPersonas";
            this.txCantidadPersonas.Size = new System.Drawing.Size(100, 22);
            this.txCantidadPersonas.TabIndex = 72;
            this.txCantidadPersonas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txCantidadPersonas_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 71;
            this.label2.Text = "Cantidad de Personas";
            // 
            // txPNacional
            // 
            this.txPNacional.Enabled = false;
            this.txPNacional.Location = new System.Drawing.Point(173, 77);
            this.txPNacional.Margin = new System.Windows.Forms.Padding(4);
            this.txPNacional.Name = "txPNacional";
            this.txPNacional.Size = new System.Drawing.Size(100, 22);
            this.txPNacional.TabIndex = 74;
            this.txPNacional.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txPNacional_KeyPress);
            // 
            // txPExtranjero
            // 
            this.txPExtranjero.Enabled = false;
            this.txPExtranjero.Location = new System.Drawing.Point(173, 109);
            this.txPExtranjero.Margin = new System.Windows.Forms.Padding(4);
            this.txPExtranjero.Name = "txPExtranjero";
            this.txPExtranjero.Size = new System.Drawing.Size(100, 22);
            this.txPExtranjero.TabIndex = 76;
            this.txPExtranjero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txPExtranjero_KeyPress);
            // 
            // txPGobierno
            // 
            this.txPGobierno.Enabled = false;
            this.txPGobierno.Location = new System.Drawing.Point(173, 141);
            this.txPGobierno.Margin = new System.Windows.Forms.Padding(4);
            this.txPGobierno.Name = "txPGobierno";
            this.txPGobierno.Size = new System.Drawing.Size(100, 22);
            this.txPGobierno.TabIndex = 78;
            this.txPGobierno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txPGobierno_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 17);
            this.label6.TabIndex = 79;
            this.label6.Text = "Precio Nacional + iv";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 112);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 17);
            this.label7.TabIndex = 81;
            this.label7.Text = "Precio Extrajero + iv";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 144);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 17);
            this.label8.TabIndex = 83;
            this.label8.Text = "Precio Gobierno + iv";
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(173, 195);
            this.btModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(100, 28);
            this.btModificar.TabIndex = 86;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
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
            this.DGV_Habitacion.Location = new System.Drawing.Point(281, 12);
            this.DGV_Habitacion.Margin = new System.Windows.Forms.Padding(4);
            this.DGV_Habitacion.Name = "DGV_Habitacion";
            this.DGV_Habitacion.ReadOnly = true;
            this.DGV_Habitacion.RowHeadersVisible = false;
            this.DGV_Habitacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Habitacion.Size = new System.Drawing.Size(938, 626);
            this.DGV_Habitacion.TabIndex = 88;
            this.DGV_Habitacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Habitacion_CellClick);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(20, 195);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btLimpiar.TabIndex = 89;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // FormPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 653);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.DGV_Habitacion);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txPGobierno);
            this.Controls.Add(this.txPExtranjero);
            this.Controls.Add(this.txPNacional);
            this.Controls.Add(this.txCantidadPersonas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txHabiatacionPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbUsuarioLogueado);
            this.Controls.Add(this.lbModifica);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrecio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Precio";
            this.Load += new System.EventHandler(this.FormPrecio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Habitacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsuarioLogueado;
        public System.Windows.Forms.Label lbModifica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txHabiatacionPrecio;
        private System.Windows.Forms.TextBox txCantidadPersonas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txPNacional;
        private System.Windows.Forms.TextBox txPExtranjero;
        private System.Windows.Forms.TextBox txPGobierno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.DataGridView DGV_Habitacion;
        private System.Windows.Forms.Button btLimpiar;
    }
}