namespace Hospedaje.Administrador
{
    partial class FormNumeroFactura
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
            this.lbModifica = new System.Windows.Forms.Label();
            this.lbUsuarioLogueado = new System.Windows.Forms.Label();
            this.btSalir = new System.Windows.Forms.Button();
            this.lbUltimoNumero = new System.Windows.Forms.Label();
            this.txUltimoNumero = new System.Windows.Forms.TextBox();
            this.btActualizar = new System.Windows.Forms.Button();
            this.lbEtiquetaNuevoNumero = new System.Windows.Forms.Label();
            this.lbEtiquetaUltimoNumero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbModifica
            // 
            this.lbModifica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbModifica.AutoSize = true;
            this.lbModifica.ForeColor = System.Drawing.Color.Black;
            this.lbModifica.Location = new System.Drawing.Point(107, 224);
            this.lbModifica.Name = "lbModifica";
            this.lbModifica.Size = new System.Drawing.Size(47, 13);
            this.lbModifica.TabIndex = 16;
            this.lbModifica.Text = "Modifica";
            // 
            // lbUsuarioLogueado
            // 
            this.lbUsuarioLogueado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbUsuarioLogueado.AutoSize = true;
            this.lbUsuarioLogueado.ForeColor = System.Drawing.Color.Black;
            this.lbUsuarioLogueado.Location = new System.Drawing.Point(45, 224);
            this.lbUsuarioLogueado.Name = "lbUsuarioLogueado";
            this.lbUsuarioLogueado.Size = new System.Drawing.Size(43, 13);
            this.lbUsuarioLogueado.TabIndex = 15;
            this.lbUsuarioLogueado.Text = "Usuario";
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(240, 152);
            this.btSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(100, 34);
            this.btSalir.TabIndex = 11;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // lbUltimoNumero
            // 
            this.lbUltimoNumero.AutoSize = true;
            this.lbUltimoNumero.ForeColor = System.Drawing.Color.Black;
            this.lbUltimoNumero.Location = new System.Drawing.Point(237, 24);
            this.lbUltimoNumero.Name = "lbUltimoNumero";
            this.lbUltimoNumero.Size = new System.Drawing.Size(10, 13);
            this.lbUltimoNumero.TabIndex = 14;
            this.lbUltimoNumero.Text = "-";
            // 
            // txUltimoNumero
            // 
            this.txUltimoNumero.Location = new System.Drawing.Point(240, 53);
            this.txUltimoNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txUltimoNumero.Name = "txUltimoNumero";
            this.txUltimoNumero.Size = new System.Drawing.Size(100, 20);
            this.txUltimoNumero.TabIndex = 9;
            this.txUltimoNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txUltimoNumero_KeyPress_1);
            // 
            // btActualizar
            // 
            this.btActualizar.Location = new System.Drawing.Point(240, 96);
            this.btActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(100, 34);
            this.btActualizar.TabIndex = 10;
            this.btActualizar.Text = "Actualizar";
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // lbEtiquetaNuevoNumero
            // 
            this.lbEtiquetaNuevoNumero.AutoSize = true;
            this.lbEtiquetaNuevoNumero.ForeColor = System.Drawing.Color.Black;
            this.lbEtiquetaNuevoNumero.Location = new System.Drawing.Point(88, 56);
            this.lbEtiquetaNuevoNumero.Name = "lbEtiquetaNuevoNumero";
            this.lbEtiquetaNuevoNumero.Size = new System.Drawing.Size(117, 13);
            this.lbEtiquetaNuevoNumero.TabIndex = 13;
            this.lbEtiquetaNuevoNumero.Text = "Nuevo Ultimo Numero :";
            // 
            // lbEtiquetaUltimoNumero
            // 
            this.lbEtiquetaUltimoNumero.AutoSize = true;
            this.lbEtiquetaUltimoNumero.ForeColor = System.Drawing.Color.Black;
            this.lbEtiquetaUltimoNumero.Location = new System.Drawing.Point(88, 24);
            this.lbEtiquetaUltimoNumero.Name = "lbEtiquetaUltimoNumero";
            this.lbEtiquetaUltimoNumero.Size = new System.Drawing.Size(85, 13);
            this.lbEtiquetaUltimoNumero.TabIndex = 12;
            this.lbEtiquetaUltimoNumero.Text = "Ultimo Numero : ";
            // 
            // FormNumeroFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.lbModifica);
            this.Controls.Add(this.lbUsuarioLogueado);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.lbUltimoNumero);
            this.Controls.Add(this.txUltimoNumero);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.lbEtiquetaNuevoNumero);
            this.Controls.Add(this.lbEtiquetaUltimoNumero);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNumeroFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNumeroFactura";
            this.Load += new System.EventHandler(this.FormNumeroFactura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbModifica;
        private System.Windows.Forms.Label lbUsuarioLogueado;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Label lbUltimoNumero;
        private System.Windows.Forms.TextBox txUltimoNumero;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Label lbEtiquetaNuevoNumero;
        private System.Windows.Forms.Label lbEtiquetaUltimoNumero;
    }
}