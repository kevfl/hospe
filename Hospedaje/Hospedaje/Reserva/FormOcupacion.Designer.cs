namespace Hospedaje.Reserva
{
    partial class FormOcupacion
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
            this.SuspendLayout();
            // 
            // lbUsuarioLogueado
            // 
            this.lbUsuarioLogueado.AutoSize = true;
            this.lbUsuarioLogueado.ForeColor = System.Drawing.Color.Black;
            this.lbUsuarioLogueado.Location = new System.Drawing.Point(16, 312);
            this.lbUsuarioLogueado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsuarioLogueado.Name = "lbUsuarioLogueado";
            this.lbUsuarioLogueado.Size = new System.Drawing.Size(72, 18);
            this.lbUsuarioLogueado.TabIndex = 34;
            this.lbUsuarioLogueado.Text = "Usuario : ";
            // 
            // lbModifica
            // 
            this.lbModifica.AutoSize = true;
            this.lbModifica.ForeColor = System.Drawing.Color.Black;
            this.lbModifica.Location = new System.Drawing.Point(94, 312);
            this.lbModifica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbModifica.Name = "lbModifica";
            this.lbModifica.Size = new System.Drawing.Size(64, 18);
            this.lbModifica.TabIndex = 33;
            this.lbModifica.Text = "Modifica";
            // 
            // FormOcupacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 342);
            this.Controls.Add(this.lbUsuarioLogueado);
            this.Controls.Add(this.lbModifica);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormOcupacion";
            this.Text = "FormOcupacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsuarioLogueado;
        public System.Windows.Forms.Label lbModifica;
    }
}