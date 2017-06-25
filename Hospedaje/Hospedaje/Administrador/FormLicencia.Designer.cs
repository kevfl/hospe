namespace Hospedaje.Administrador
{
    partial class FormLicencia
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
            this.lbValida = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btActualizar = new System.Windows.Forms.Button();
            this.txLicencia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbLicenciaActual = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbUsuarioLogueado
            // 
            this.lbUsuarioLogueado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbUsuarioLogueado.AutoSize = true;
            this.lbUsuarioLogueado.BackColor = System.Drawing.Color.White;
            this.lbUsuarioLogueado.ForeColor = System.Drawing.Color.Black;
            this.lbUsuarioLogueado.Location = new System.Drawing.Point(23, 196);
            this.lbUsuarioLogueado.Name = "lbUsuarioLogueado";
            this.lbUsuarioLogueado.Size = new System.Drawing.Size(52, 13);
            this.lbUsuarioLogueado.TabIndex = 26;
            this.lbUsuarioLogueado.Text = "Usuario : ";
            // 
            // lbModifica
            // 
            this.lbModifica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbModifica.AutoSize = true;
            this.lbModifica.BackColor = System.Drawing.Color.White;
            this.lbModifica.ForeColor = System.Drawing.Color.Black;
            this.lbModifica.Location = new System.Drawing.Point(92, 196);
            this.lbModifica.Name = "lbModifica";
            this.lbModifica.Size = new System.Drawing.Size(47, 13);
            this.lbModifica.TabIndex = 25;
            this.lbModifica.Text = "Modifica";
            // 
            // lbValida
            // 
            this.lbValida.AutoSize = true;
            this.lbValida.BackColor = System.Drawing.Color.White;
            this.lbValida.ForeColor = System.Drawing.Color.Black;
            this.lbValida.Location = new System.Drawing.Point(144, 42);
            this.lbValida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbValida.Name = "lbValida";
            this.lbValida.Size = new System.Drawing.Size(25, 13);
            this.lbValida.TabIndex = 24;
            this.lbValida.Text = "000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Valida hasta:";
            // 
            // btActualizar
            // 
            this.btActualizar.Location = new System.Drawing.Point(148, 112);
            this.btActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(133, 37);
            this.btActualizar.TabIndex = 22;
            this.btActualizar.Text = "Actualizar";
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // txLicencia
            // 
            this.txLicencia.Location = new System.Drawing.Point(148, 80);
            this.txLicencia.Margin = new System.Windows.Forms.Padding(4);
            this.txLicencia.Name = "txLicencia";
            this.txLicencia.Size = new System.Drawing.Size(132, 20);
            this.txLicencia.TabIndex = 21;
            this.txLicencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txLicencia_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nueva Licencia:";
            // 
            // lbLicenciaActual
            // 
            this.lbLicenciaActual.AutoSize = true;
            this.lbLicenciaActual.BackColor = System.Drawing.Color.White;
            this.lbLicenciaActual.ForeColor = System.Drawing.Color.Black;
            this.lbLicenciaActual.Location = new System.Drawing.Point(144, 15);
            this.lbLicenciaActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLicenciaActual.Name = "lbLicenciaActual";
            this.lbLicenciaActual.Size = new System.Drawing.Size(25, 13);
            this.lbLicenciaActual.TabIndex = 19;
            this.lbLicenciaActual.Text = "000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Licencia Actual:";
            // 
            // FormLicencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 224);
            this.Controls.Add(this.lbUsuarioLogueado);
            this.Controls.Add(this.lbModifica);
            this.Controls.Add(this.lbValida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.txLicencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbLicenciaActual);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLicencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Licencia";
            this.Load += new System.EventHandler(this.FormLicencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsuarioLogueado;
        public System.Windows.Forms.Label lbModifica;
        private System.Windows.Forms.Label lbValida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.TextBox txLicencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbLicenciaActual;
        private System.Windows.Forms.Label label1;
    }
}