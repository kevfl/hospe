namespace Hospedaje.Administrador
{
    partial class FormInformacionEmpresa
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
            this.btSalir = new System.Windows.Forms.Button();
            this.txModifica = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txFacebook = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btActualizar = new System.Windows.Forms.Button();
            this.txLema = new System.Windows.Forms.TextBox();
            this.txCorreo = new System.Windows.Forms.TextBox();
            this.txTelefono = new System.Windows.Forms.TextBox();
            this.txUbicacion = new System.Windows.Forms.TextBox();
            this.txCedula = new System.Windows.Forms.TextBox();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.lbModifica = new System.Windows.Forms.Label();
            this.lbUsuarioLogueado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(380, 252);
            this.btSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(91, 34);
            this.btSalir.TabIndex = 40;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // txModifica
            // 
            this.txModifica.Enabled = false;
            this.txModifica.Location = new System.Drawing.Point(105, 205);
            this.txModifica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txModifica.MaxLength = 50;
            this.txModifica.Name = "txModifica";
            this.txModifica.Size = new System.Drawing.Size(367, 20);
            this.txModifica.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(17, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Modifico : ";
            // 
            // txFacebook
            // 
            this.txFacebook.Location = new System.Drawing.Point(106, 149);
            this.txFacebook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txFacebook.MaxLength = 50;
            this.txFacebook.Name = "txFacebook";
            this.txFacebook.Size = new System.Drawing.Size(367, 20);
            this.txFacebook.TabIndex = 26;
            this.txFacebook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txFacebook_KeyPress_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(17, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Facebook : ";
            // 
            // btActualizar
            // 
            this.btActualizar.Location = new System.Drawing.Point(105, 252);
            this.btActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(108, 34);
            this.btActualizar.TabIndex = 29;
            this.btActualizar.Text = "Actualizar";
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // txLema
            // 
            this.txLema.Location = new System.Drawing.Point(105, 177);
            this.txLema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txLema.MaxLength = 50;
            this.txLema.Name = "txLema";
            this.txLema.Size = new System.Drawing.Size(367, 20);
            this.txLema.TabIndex = 27;
            this.txLema.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txLema_KeyPress);
            // 
            // txCorreo
            // 
            this.txCorreo.Location = new System.Drawing.Point(106, 121);
            this.txCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txCorreo.MaxLength = 50;
            this.txCorreo.Name = "txCorreo";
            this.txCorreo.Size = new System.Drawing.Size(367, 20);
            this.txCorreo.TabIndex = 25;
            this.txCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txCorreo_KeyPress_1);
            // 
            // txTelefono
            // 
            this.txTelefono.Location = new System.Drawing.Point(106, 93);
            this.txTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txTelefono.MaxLength = 50;
            this.txTelefono.Name = "txTelefono";
            this.txTelefono.Size = new System.Drawing.Size(367, 20);
            this.txTelefono.TabIndex = 24;
            this.txTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txTelefono_KeyPress_1);
            // 
            // txUbicacion
            // 
            this.txUbicacion.Location = new System.Drawing.Point(106, 65);
            this.txUbicacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txUbicacion.MaxLength = 50;
            this.txUbicacion.Name = "txUbicacion";
            this.txUbicacion.Size = new System.Drawing.Size(367, 20);
            this.txUbicacion.TabIndex = 23;
            this.txUbicacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txUbicacion_KeyPress_1);
            // 
            // txCedula
            // 
            this.txCedula.Location = new System.Drawing.Point(106, 37);
            this.txCedula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txCedula.MaxLength = 50;
            this.txCedula.Name = "txCedula";
            this.txCedula.Size = new System.Drawing.Size(367, 20);
            this.txCedula.TabIndex = 22;
            this.txCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txCedula_KeyPress_1);
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(106, 9);
            this.txNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txNombre.MaxLength = 50;
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(367, 20);
            this.txNombre.TabIndex = 21;
            this.txNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txNombre_KeyPress_1);
            // 
            // lbModifica
            // 
            this.lbModifica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbModifica.AutoSize = true;
            this.lbModifica.ForeColor = System.Drawing.Color.Black;
            this.lbModifica.Location = new System.Drawing.Point(88, 365);
            this.lbModifica.Name = "lbModifica";
            this.lbModifica.Size = new System.Drawing.Size(47, 13);
            this.lbModifica.TabIndex = 39;
            this.lbModifica.Text = "Modifica";
            // 
            // lbUsuarioLogueado
            // 
            this.lbUsuarioLogueado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbUsuarioLogueado.AutoSize = true;
            this.lbUsuarioLogueado.ForeColor = System.Drawing.Color.Black;
            this.lbUsuarioLogueado.Location = new System.Drawing.Point(17, 365);
            this.lbUsuarioLogueado.Name = "lbUsuarioLogueado";
            this.lbUsuarioLogueado.Size = new System.Drawing.Size(52, 13);
            this.lbUsuarioLogueado.TabIndex = 38;
            this.lbUsuarioLogueado.Text = "Usuario : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(17, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Lema : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Cedula : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(17, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Correo : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ubicación : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Telefono : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nombre : ";
            // 
            // FormInformacionEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 386);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.txModifica);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txFacebook);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.txLema);
            this.Controls.Add(this.txCorreo);
            this.Controls.Add(this.txTelefono);
            this.Controls.Add(this.txUbicacion);
            this.Controls.Add(this.txCedula);
            this.Controls.Add(this.txNombre);
            this.Controls.Add(this.lbModifica);
            this.Controls.Add(this.lbUsuarioLogueado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FormInformacionEmpresa";
            this.Text = "Información Empresa";
            this.Load += new System.EventHandler(this.FormInformacionEmpresa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.TextBox txModifica;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txFacebook;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.TextBox txLema;
        private System.Windows.Forms.TextBox txCorreo;
        private System.Windows.Forms.TextBox txTelefono;
        private System.Windows.Forms.TextBox txUbicacion;
        private System.Windows.Forms.TextBox txCedula;
        private System.Windows.Forms.TextBox txNombre;
        public System.Windows.Forms.Label lbModifica;
        private System.Windows.Forms.Label lbUsuarioLogueado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}