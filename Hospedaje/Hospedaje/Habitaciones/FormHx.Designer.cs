namespace Hospedaje.Habitaciones
{
    partial class FormHx
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbEstado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txHabiatacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbUsuarioLogueado = new System.Windows.Forms.Label();
            this.lbModifica = new System.Windows.Forms.Label();
            this.btLibre = new System.Windows.Forms.Button();
            this.btOcupado = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btBuscarCliente1 = new System.Windows.Forms.Button();
            this.DGV_Reservas = new System.Windows.Forms.DataGridView();
            this.lbCliente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.txFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbCapacidadPersonas = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.checkNacional = new System.Windows.Forms.CheckBox();
            this.checkExtranjero = new System.Windows.Forms.CheckBox();
            this.checkGobierno = new System.Windows.Forms.CheckBox();
            this.lbCantidadDias = new System.Windows.Forms.Label();
            this.lbNacional = new System.Windows.Forms.Label();
            this.lbExtranjero = new System.Windows.Forms.Label();
            this.lbGobierno = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbPrecioXnoche = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lbMontoPagar = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btFacturar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Reservas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(101, 55);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(40, 13);
            this.lbEstado.TabIndex = 107;
            this.lbEstado.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 106;
            this.label3.Text = "Estado";
            // 
            // txHabiatacion
            // 
            this.txHabiatacion.Enabled = false;
            this.txHabiatacion.Location = new System.Drawing.Point(104, 17);
            this.txHabiatacion.Name = "txHabiatacion";
            this.txHabiatacion.Size = new System.Drawing.Size(76, 20);
            this.txHabiatacion.TabIndex = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 104;
            this.label1.Text = "ID Habitación";
            // 
            // lbUsuarioLogueado
            // 
            this.lbUsuarioLogueado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbUsuarioLogueado.AutoSize = true;
            this.lbUsuarioLogueado.ForeColor = System.Drawing.Color.Black;
            this.lbUsuarioLogueado.Location = new System.Drawing.Point(8, 489);
            this.lbUsuarioLogueado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsuarioLogueado.Name = "lbUsuarioLogueado";
            this.lbUsuarioLogueado.Size = new System.Drawing.Size(52, 13);
            this.lbUsuarioLogueado.TabIndex = 102;
            this.lbUsuarioLogueado.Text = "Usuario : ";
            // 
            // lbModifica
            // 
            this.lbModifica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbModifica.AutoSize = true;
            this.lbModifica.ForeColor = System.Drawing.Color.Black;
            this.lbModifica.Location = new System.Drawing.Point(8, 503);
            this.lbModifica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbModifica.Name = "lbModifica";
            this.lbModifica.Size = new System.Drawing.Size(47, 13);
            this.lbModifica.TabIndex = 103;
            this.lbModifica.Text = "Modifica";
            // 
            // btLibre
            // 
            this.btLibre.Location = new System.Drawing.Point(17, 84);
            this.btLibre.Margin = new System.Windows.Forms.Padding(2);
            this.btLibre.Name = "btLibre";
            this.btLibre.Size = new System.Drawing.Size(75, 24);
            this.btLibre.TabIndex = 108;
            this.btLibre.Text = "Libre";
            this.btLibre.UseVisualStyleBackColor = true;
            // 
            // btOcupado
            // 
            this.btOcupado.Location = new System.Drawing.Point(101, 84);
            this.btOcupado.Margin = new System.Windows.Forms.Padding(2);
            this.btOcupado.Name = "btOcupado";
            this.btOcupado.Size = new System.Drawing.Size(75, 24);
            this.btOcupado.TabIndex = 109;
            this.btOcupado.Text = "Ocupado";
            this.btOcupado.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 110;
            this.label2.Text = "Cliente";
            // 
            // btBuscarCliente1
            // 
            this.btBuscarCliente1.Location = new System.Drawing.Point(262, 20);
            this.btBuscarCliente1.Margin = new System.Windows.Forms.Padding(2);
            this.btBuscarCliente1.Name = "btBuscarCliente1";
            this.btBuscarCliente1.Size = new System.Drawing.Size(90, 24);
            this.btBuscarCliente1.TabIndex = 112;
            this.btBuscarCliente1.Text = "Buscar Cliente";
            this.btBuscarCliente1.UseVisualStyleBackColor = true;
            this.btBuscarCliente1.Click += new System.EventHandler(this.btBuscarCliente_Click);
            // 
            // DGV_Reservas
            // 
            this.DGV_Reservas.AllowUserToAddRows = false;
            this.DGV_Reservas.AllowUserToDeleteRows = false;
            this.DGV_Reservas.AllowUserToResizeColumns = false;
            this.DGV_Reservas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DGV_Reservas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Reservas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Reservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Reservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Reservas.Location = new System.Drawing.Point(203, 205);
            this.DGV_Reservas.Name = "DGV_Reservas";
            this.DGV_Reservas.ReadOnly = true;
            this.DGV_Reservas.RowHeadersVisible = false;
            this.DGV_Reservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Reservas.Size = new System.Drawing.Size(668, 261);
            this.DGV_Reservas.TabIndex = 113;
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Location = new System.Drawing.Point(270, 55);
            this.lbCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(39, 13);
            this.lbCliente.TabIndex = 114;
            this.lbCliente.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 115;
            this.label4.Text = "Reservas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 116;
            this.label5.Text = "Fecha Ingreso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 117;
            this.label6.Text = "Fecha Salida";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(440, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 118;
            this.label7.Text = "Cantidad de días";
            // 
            // txFechaIngreso
            // 
            this.txFechaIngreso.CustomFormat = "dd/MM/aaaa";
            this.txFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txFechaIngreso.Location = new System.Drawing.Point(534, 14);
            this.txFechaIngreso.Name = "txFechaIngreso";
            this.txFechaIngreso.Size = new System.Drawing.Size(100, 20);
            this.txFechaIngreso.TabIndex = 119;
            this.txFechaIngreso.Value = new System.DateTime(2017, 8, 6, 11, 51, 53, 0);
            // 
            // txFechaSalida
            // 
            this.txFechaSalida.CustomFormat = "dd/MM/aaaa";
            this.txFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txFechaSalida.Location = new System.Drawing.Point(534, 49);
            this.txFechaSalida.Name = "txFechaSalida";
            this.txFechaSalida.Size = new System.Drawing.Size(100, 20);
            this.txFechaSalida.TabIndex = 120;
            this.txFechaSalida.Value = new System.DateTime(2017, 8, 6, 11, 51, 53, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(670, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 122;
            this.label8.Text = "Precio Nacional";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(670, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 124;
            this.label9.Text = "Precio Extranjero";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(670, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 126;
            this.label10.Text = "Precio Gobierno";
            // 
            // lbCapacidadPersonas
            // 
            this.lbCapacidadPersonas.AutoSize = true;
            this.lbCapacidadPersonas.Location = new System.Drawing.Point(349, 90);
            this.lbCapacidadPersonas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCapacidadPersonas.Name = "lbCapacidadPersonas";
            this.lbCapacidadPersonas.Size = new System.Drawing.Size(13, 13);
            this.lbCapacidadPersonas.TabIndex = 129;
            this.lbCapacidadPersonas.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(226, 90);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 13);
            this.label12.TabIndex = 128;
            this.label12.Text = "Capacidad Personas";
            // 
            // checkNacional
            // 
            this.checkNacional.AutoSize = true;
            this.checkNacional.Location = new System.Drawing.Point(851, 20);
            this.checkNacional.Name = "checkNacional";
            this.checkNacional.Size = new System.Drawing.Size(15, 14);
            this.checkNacional.TabIndex = 130;
            this.checkNacional.UseVisualStyleBackColor = true;
            this.checkNacional.Click += new System.EventHandler(this.checkNacional_Click);
            // 
            // checkExtranjero
            // 
            this.checkExtranjero.AutoSize = true;
            this.checkExtranjero.Location = new System.Drawing.Point(851, 55);
            this.checkExtranjero.Name = "checkExtranjero";
            this.checkExtranjero.Size = new System.Drawing.Size(15, 14);
            this.checkExtranjero.TabIndex = 131;
            this.checkExtranjero.UseVisualStyleBackColor = true;
            this.checkExtranjero.Click += new System.EventHandler(this.checkExtranjero_Click);
            // 
            // checkGobierno
            // 
            this.checkGobierno.AutoSize = true;
            this.checkGobierno.Location = new System.Drawing.Point(851, 90);
            this.checkGobierno.Name = "checkGobierno";
            this.checkGobierno.Size = new System.Drawing.Size(15, 14);
            this.checkGobierno.TabIndex = 132;
            this.checkGobierno.UseVisualStyleBackColor = true;
            this.checkGobierno.Click += new System.EventHandler(this.checkGobierno_Click);
            // 
            // lbCantidadDias
            // 
            this.lbCantidadDias.AutoSize = true;
            this.lbCantidadDias.Location = new System.Drawing.Point(533, 90);
            this.lbCantidadDias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCantidadDias.Name = "lbCantidadDias";
            this.lbCantidadDias.Size = new System.Drawing.Size(13, 13);
            this.lbCantidadDias.TabIndex = 133;
            this.lbCantidadDias.Text = "0";
            // 
            // lbNacional
            // 
            this.lbNacional.AutoSize = true;
            this.lbNacional.Location = new System.Drawing.Point(767, 20);
            this.lbNacional.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNacional.Name = "lbNacional";
            this.lbNacional.Size = new System.Drawing.Size(13, 13);
            this.lbNacional.TabIndex = 134;
            this.lbNacional.Text = "0";
            // 
            // lbExtranjero
            // 
            this.lbExtranjero.AutoSize = true;
            this.lbExtranjero.Location = new System.Drawing.Point(767, 55);
            this.lbExtranjero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbExtranjero.Name = "lbExtranjero";
            this.lbExtranjero.Size = new System.Drawing.Size(13, 13);
            this.lbExtranjero.TabIndex = 135;
            this.lbExtranjero.Text = "0";
            // 
            // lbGobierno
            // 
            this.lbGobierno.AutoSize = true;
            this.lbGobierno.Location = new System.Drawing.Point(767, 90);
            this.lbGobierno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGobierno.Name = "lbGobierno";
            this.lbGobierno.Size = new System.Drawing.Size(13, 13);
            this.lbGobierno.TabIndex = 136;
            this.lbGobierno.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 137;
            this.label11.Text = "Precio por noche";
            // 
            // lbPrecioXnoche
            // 
            this.lbPrecioXnoche.AutoSize = true;
            this.lbPrecioXnoche.Location = new System.Drawing.Point(122, 151);
            this.lbPrecioXnoche.Name = "lbPrecioXnoche";
            this.lbPrecioXnoche.Size = new System.Drawing.Size(13, 13);
            this.lbPrecioXnoche.TabIndex = 138;
            this.lbPrecioXnoche.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(226, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 139;
            this.label13.Text = "Adelanto";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(286, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 140;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(393, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 141;
            this.label14.Text = "Monto a Pagar";
            // 
            // lbMontoPagar
            // 
            this.lbMontoPagar.AutoSize = true;
            this.lbMontoPagar.Location = new System.Drawing.Point(485, 151);
            this.lbMontoPagar.Name = "lbMontoPagar";
            this.lbMontoPagar.Size = new System.Drawing.Size(13, 13);
            this.lbMontoPagar.TabIndex = 142;
            this.lbMontoPagar.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(623, 151);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 144;
            this.label15.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(531, 151);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 13);
            this.label16.TabIndex = 143;
            this.label16.Text = "Monto a Pagar";
            // 
            // btFacturar
            // 
            this.btFacturar.Location = new System.Drawing.Point(791, 145);
            this.btFacturar.Name = "btFacturar";
            this.btFacturar.Size = new System.Drawing.Size(75, 24);
            this.btFacturar.TabIndex = 145;
            this.btFacturar.Text = "Facturar";
            this.btFacturar.UseVisualStyleBackColor = true;
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(705, 145);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 24);
            this.btGuardar.TabIndex = 146;
            this.btGuardar.Text = "Guargar";
            this.btGuardar.UseVisualStyleBackColor = true;
            // 
            // FormHx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 531);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btFacturar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lbMontoPagar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbPrecioXnoche);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbGobierno);
            this.Controls.Add(this.lbExtranjero);
            this.Controls.Add(this.lbNacional);
            this.Controls.Add(this.lbCantidadDias);
            this.Controls.Add(this.checkGobierno);
            this.Controls.Add(this.checkExtranjero);
            this.Controls.Add(this.checkNacional);
            this.Controls.Add(this.lbCapacidadPersonas);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txFechaSalida);
            this.Controls.Add(this.txFechaIngreso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCliente);
            this.Controls.Add(this.DGV_Reservas);
            this.Controls.Add(this.btBuscarCliente1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btOcupado);
            this.Controls.Add(this.btLibre);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txHabiatacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbUsuarioLogueado);
            this.Controls.Add(this.lbModifica);
            this.Name = "FormHx";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hx";
            this.Load += new System.EventHandler(this.FormHx_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormHx_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Reservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUsuarioLogueado;
        public System.Windows.Forms.Label lbModifica;
        public System.Windows.Forms.TextBox txHabiatacion;
        private System.Windows.Forms.Button btLibre;
        private System.Windows.Forms.Button btOcupado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btBuscarCliente1;
        private System.Windows.Forms.DataGridView DGV_Reservas;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txFechaIngreso;
        private System.Windows.Forms.DateTimePicker txFechaSalida;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbCapacidadPersonas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkNacional;
        private System.Windows.Forms.CheckBox checkExtranjero;
        private System.Windows.Forms.CheckBox checkGobierno;
        private System.Windows.Forms.Label lbCantidadDias;
        private System.Windows.Forms.Label lbNacional;
        private System.Windows.Forms.Label lbExtranjero;
        private System.Windows.Forms.Label lbGobierno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbPrecioXnoche;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbMontoPagar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btFacturar;
        private System.Windows.Forms.Button btGuardar;
    }
}