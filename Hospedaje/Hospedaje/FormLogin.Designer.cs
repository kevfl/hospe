namespace Hospedaje
{
    partial class FormLogin
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
            this.txUsuario = new System.Windows.Forms.TextBox();
            this.txContraseña = new System.Windows.Forms.TextBox();
            this.txNombreUsuario = new System.Windows.Forms.TextBox();
            this.txTipoUsuario = new System.Windows.Forms.TextBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txUsuario
            // 
            this.txUsuario.Location = new System.Drawing.Point(222, 12);
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.Size = new System.Drawing.Size(100, 20);
            this.txUsuario.TabIndex = 0;
            this.txUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txUsuario_KeyPress);
            // 
            // txContraseña
            // 
            this.txContraseña.Location = new System.Drawing.Point(222, 38);
            this.txContraseña.Name = "txContraseña";
            this.txContraseña.Size = new System.Drawing.Size(100, 20);
            this.txContraseña.TabIndex = 1;
            this.txContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txContraseña_KeyPress);
            // 
            // txNombreUsuario
            // 
            this.txNombreUsuario.Location = new System.Drawing.Point(222, 131);
            this.txNombreUsuario.Name = "txNombreUsuario";
            this.txNombreUsuario.Size = new System.Drawing.Size(100, 20);
            this.txNombreUsuario.TabIndex = 2;
            this.txNombreUsuario.Visible = false;
            // 
            // txTipoUsuario
            // 
            this.txTipoUsuario.Location = new System.Drawing.Point(222, 158);
            this.txTipoUsuario.Name = "txTipoUsuario";
            this.txTipoUsuario.Size = new System.Drawing.Size(100, 20);
            this.txTipoUsuario.TabIndex = 3;
            this.txTipoUsuario.Visible = false;
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(166, 78);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 4;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(247, 78);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 5;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 89);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contraseña";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 117);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.txTipoUsuario);
            this.Controls.Add(this.txNombreUsuario);
            this.Controls.Add(this.txContraseña);
            this.Controls.Add(this.txUsuario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txUsuario;
        private System.Windows.Forms.TextBox txContraseña;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btSalir;
        public System.Windows.Forms.TextBox txNombreUsuario;
        public System.Windows.Forms.TextBox txTipoUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}