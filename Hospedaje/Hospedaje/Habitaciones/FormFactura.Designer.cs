namespace Hospedaje.Habitaciones
{
    partial class FormFactura
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
            this.lbTipoUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbUsuarioLogueado
            // 
            this.lbUsuarioLogueado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbUsuarioLogueado.AutoSize = true;
            this.lbUsuarioLogueado.ForeColor = System.Drawing.Color.Black;
            this.lbUsuarioLogueado.Location = new System.Drawing.Point(14, 626);
            this.lbUsuarioLogueado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbUsuarioLogueado.Name = "lbUsuarioLogueado";
            this.lbUsuarioLogueado.Size = new System.Drawing.Size(69, 17);
            this.lbUsuarioLogueado.TabIndex = 71;
            this.lbUsuarioLogueado.Text = "Usuario : ";
            // 
            // lbModifica
            // 
            this.lbModifica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbModifica.AutoSize = true;
            this.lbModifica.ForeColor = System.Drawing.Color.Black;
            this.lbModifica.Location = new System.Drawing.Point(93, 626);
            this.lbModifica.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbModifica.Name = "lbModifica";
            this.lbModifica.Size = new System.Drawing.Size(60, 17);
            this.lbModifica.TabIndex = 72;
            this.lbModifica.Text = "Modifica";
            // 
            // lbTipoUsuario
            // 
            this.lbTipoUsuario.AutoSize = true;
            this.lbTipoUsuario.Location = new System.Drawing.Point(13, 598);
            this.lbTipoUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTipoUsuario.Name = "lbTipoUsuario";
            this.lbTipoUsuario.Size = new System.Drawing.Size(85, 17);
            this.lbTipoUsuario.TabIndex = 73;
            this.lbTipoUsuario.Text = "TipoUsuario";
            // 
            // FormFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 653);
            this.Controls.Add(this.lbTipoUsuario);
            this.Controls.Add(this.lbUsuarioLogueado);
            this.Controls.Add(this.lbModifica);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormFactura";
            this.Text = "FormFactura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsuarioLogueado;
        public System.Windows.Forms.Label lbModifica;
        public System.Windows.Forms.Label lbTipoUsuario;
    }
}