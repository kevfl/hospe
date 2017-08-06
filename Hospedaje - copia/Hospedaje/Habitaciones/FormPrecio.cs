using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Hospedaje.Habitaciones
{
    public partial class FormPrecio : Form
    {
        Clases.ClassConexion bd = new Clases.ClassConexion();

        public FormPrecio()
        {
            InitializeComponent();
        }

        private void FormPrecio_Load(object sender, EventArgs e)
        {
            Limpiar();
            ActualizarDGV();
        }

        /*--------------------------------------*
         *-------------           --------------*
         *-------------  Metodos  --------------*
         *-------------           --------------*
         *--------------------------------------*/
         
        private void Limpiar()
        {
            txHabiatacionPrecio.Text = "";
            txCantidadPersonas.Text = "";
            txPNacional.Text = "";
            txPExtranjero.Text = "";
            txPGobierno.Text = "";
            txCantidadPersonas.Enabled = false;
            txPNacional.Enabled = false;
            txPExtranjero.Enabled = false;
            txPGobierno.Enabled = false;
            btModificar.Enabled = false;
            txCantidadPersonas.Focus();
        }

        private void TitulosDGV()
        {
            DGV_Habitacion.Columns[0].HeaderText = "Habitación";
            DGV_Habitacion.Columns[1].HeaderText = "Cantidad Personas";
            DGV_Habitacion.Columns[2].HeaderText = "Nacional + iv";
            DGV_Habitacion.Columns[3].HeaderText = "Extrajero + iv";
            DGV_Habitacion.Columns[4].HeaderText = "Gobierno + iv";
            DGV_Habitacion.Columns[5].HeaderText = "Modifico";
        }

        private void ActualizarDGV()
        {
            try
            {
                bd.conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT ID_HABITACION, CANTIDAD_PERSONAS, PRECIO_NACIONAL, PRECIO_EXTRANJERO, PRECIO_GOBIERNO, MODIFICA FROM TABLA_HABITACIONES ", bd.conexion);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DGV_Habitacion.DataSource = dt;
                TitulosDGV();
                bd.conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void ConsultarHabitacion()
        {
            try
            {
                bd.conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT * FROM TABLA_HABITACIONES WHERE (ID_HABITACION = '" + txHabiatacionPrecio.Text + "')", bd.conexion);
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read() == true)
                {
                    txCantidadPersonas.Text = registro["CANTIDAD_PERSONAS"].ToString();
                    txPNacional.Text = registro["PRECIO_NACIONAL"].ToString();
                    txPExtranjero.Text = registro["PRECIO_EXTRANJERO"].ToString();
                    txPGobierno.Text = registro["PRECIO_GOBIERNO"].ToString();
                    txCantidadPersonas.Enabled = true;
                    txPNacional.Enabled = true;
                    txPExtranjero.Enabled = true;
                    txPGobierno.Enabled = true;
                    btModificar.Enabled = true;
                    txCantidadPersonas.Focus();
                }
                bd.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void Modificar()
        {
            try
            {
                bd.conexion.Open();
                SqlCommand comando = new SqlCommand("update TABLA_HABITACIONES set CANTIDAD_PERSONAS = '" + txCantidadPersonas.Text + "', PRECIO_NACIONAL= '" + txPNacional.Text + "', PRECIO_EXTRANJERO= '" + txPExtranjero.Text + "', PRECIO_GOBIERNO= '" + txPGobierno.Text + "', MODIFICA= '" + lbModifica.Text + "' where (ID_HABITACION= '" + txHabiatacionPrecio.Text + "')", bd.conexion);
                int i;
                i = comando.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("El registro se a MODIFICO correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                bd.conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex);
            }
        }

        /*--------------------------------------*
        *----------                ------------*
        *----------  Validaciones  ------------*
        *----------                ------------*
        *--------------------------------------*/
        private void ValidarModificar()
        {
            if (txCantidadPersonas.Text != string.Empty)
            {
                if (txPNacional.Text != string.Empty)
                {
                    if (txPExtranjero.Text != string.Empty)
                    {
                        if (txPGobierno.Text != string.Empty)
                        {
                            Modificar();
                            Limpiar();
                            ActualizarDGV();
                        }
                        else
                        {
                            MessageBox.Show("No se puede modificar si existren espacios vacios.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede modificar si existren espacios vacios.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No se puede modificar si existren espacios vacios.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No se puede modificar si existren espacios vacios.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }
        /*--------------------------------------*
         *-------------           --------------*
         *-------------  Botones  --------------*
         *-------------           --------------*
         *--------------------------------------*/

        private void btModificar_Click(object sender, EventArgs e)
        {
            ValidarModificar();
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /*--------------------------------------*
        *-------------           --------------*
        *-------------  Eventos  --------------*
        *-------------           --------------*
        *--------------------------------------*/
        private void DGV_Habitacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_Habitacion.DataSource == null)
            {
                return;
            }
            else
            {
                txHabiatacionPrecio.Text = DGV_Habitacion.CurrentRow.Cells[0].Value.ToString();
                ConsultarHabitacion();
            }
        }

        private void txCantidadPersonas_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo Numeros
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            //Enter
            if (txCantidadPersonas.Text != string.Empty)
            {

                if (e.KeyChar == 13)
                {
                    txPNacional.Focus();
                }
            }
        }

        private void txPNacional_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo Numeros
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            //Enter
            if (txCantidadPersonas.Text != string.Empty)
            {

                if (e.KeyChar == 13)
                {
                    txPExtranjero.Focus();
                }
            }
        }

        private void txPExtranjero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo Numeros
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            //Enter
            if (txCantidadPersonas.Text != string.Empty)
            {

                if (e.KeyChar == 13)
                {
                    txPGobierno.Focus();
                }
            }
        }

        private void txPGobierno_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo Numeros
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            //Enter
            if (txCantidadPersonas.Text != string.Empty)
            {

                if (e.KeyChar == 13)
                {
                    btModificar.Focus();
                }
            }
        }

        
    }
}
