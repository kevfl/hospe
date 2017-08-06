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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
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
            this.txUsuario.Location = new System.Drawing.Point(296, 15);
            this.txUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.Size = new System.Drawing.Size(132, 24);
            this.txUsuario.TabIndex = 0;
            this.txUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txUsuario_KeyPress);
            // 
            // txContraseña
            // 
            this.txContraseña.Location = new System.Drawing.Point(296, 49);
            this.txContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txContraseña.Name = "txContraseña";
            this.txContraseña.PasswordChar = '*';
            this.txContraseña.Size = new System.Drawing.Size(132, 24);
            this.txContraseña.TabIndex = 1;
            this.txContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txContraseña_KeyPress);
            // 
            // txNombreUsuario
            // 
            this.txNombreUsuario.Location = new System.Drawing.Point(296, 172);
            this.txNombreUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txNombreUsuario.Name = "txNombreUsuario";
            this.txNombreUsuario.Size = new System.Drawing.Size(132, 24);
            this.txNombreUsuario.TabIndex = 2;
            this.txNombreUsuario.Visible = false;
            // 
            // txTipoUsuario
            // 
            this.txTipoUsuario.Location = new System.Drawing.Point(296, 206);
            this.txTipoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txTipoUsuario.Name = "txTipoUsuario";
            this.txTipoUsuario.Size = new System.Drawing.Size(132, 24);
            this.txTipoUsuario.TabIndex = 3;
            this.txTipoUsuario.Visible = false;
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(222, 102);
            this.btAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(100, 30);
            this.btAceptar.TabIndex = 4;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(330, 102);
            this.btSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(100, 30);
            this.btSalir.TabIndex = 5;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hospedaje.Properties.Resources.Hotel_info;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contraseña";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 153);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.txTipoUsuario);
            this.Controls.Add(this.txNombreUsuario);
            this.Controls.Add(this.txContraseña);
            this.Controls.Add(this.txUsuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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