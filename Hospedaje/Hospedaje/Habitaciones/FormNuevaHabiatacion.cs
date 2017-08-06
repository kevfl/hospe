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
    public partial class FormNuevaHabiatacion : Form
    {
        Clases.ClassConexion bd = new Clases.ClassConexion();

        public FormNuevaHabiatacion()
        {
            InitializeComponent();
        }

        private void FormNuevaHabiatacion_Load(object sender, EventArgs e)
        {
            ActualizarDGV();
            Limpiar();
        }

        /*--------------------------------------*
        *-------------           --------------*
        *-------------  Metodos  --------------*
        *-------------           --------------*
        *--------------------------------------*/
        private void Limpiar()
        {
            txHabitacion.Text = "";
            lbEstado.Text = "";
            txHabitacion.Enabled = true;
            btAgregar.Enabled = false;
            btEliminar.Enabled = false;
            txHabitacion.Focus();
        }

        private void TitulosDGV()
        {
            DGV_Habitacion.Columns[0].HeaderText = "Habitación";
            DGV_Habitacion.Columns[1].HeaderText = "Estado";
            DGV_Habitacion.Columns[2].HeaderText = "Cantidad Personas";
            DGV_Habitacion.Columns[3].HeaderText = "Nacional + iv";
            DGV_Habitacion.Columns[4].HeaderText = "Extrajero + iv";
            DGV_Habitacion.Columns[5].HeaderText = "Gobierno + iv";
            DGV_Habitacion.Columns[6].HeaderText = "Modifico";
        }

        private void ActualizarDGV()
        {
            try
            {
                bd.conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT ID_HABITACION, ESTADO, CANTIDAD_PERSONAS, PRECIO_NACIONAL, PRECIO_EXTRANJERO, PRECIO_GOBIERNO, MODIFICA FROM TABLA_HABITACIONES ", bd.conexion);
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
                SqlCommand comando = new SqlCommand("SELECT * FROM TABLA_HABITACIONES WHERE (ID_HABITACION = '" + txHabitacion.Text + "')", bd.conexion);
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read() == true)
                {
                    txHabitacion.Enabled = false;
                    lbEstado.Text = registro["ESTADO"].ToString();
                    if (lbEstado.Text == "Libre")
                    {
                        btAgregar.Enabled = false;
                        btEliminar.Enabled = true;
                        btEliminar.Focus();
                    }
                    else
                    {
                        btEliminar.Enabled = false;
                        btLimpiar.Focus();
                    }
                }
                else
                {
                    btAgregar.Enabled = true;
                    btAgregar.Focus();
                }
                bd.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void Agregar()
        {
            try
            {
                bd.conexion.Open();
                SqlCommand comando = new SqlCommand("insert into TABLA_HABITACIONES(ID_HABITACION, ESTADO, ID_CLIENT, FECHA_INGRESO, FECHA_SALIDA, CANTIDAD_DIAS, CANTIDAD_PERSONAS, PRECIO_NACIONAL, PRECIO_EXTRANJERO, PRECIO_GOBIERNO, ADELANTO_DINERO, PENDIENTE_DINERO, MODIFICA)VALUES('" + txHabitacion.Text + "', 'Libre', 'Default', '01/01/1900', '01/01/1900',  '0', '0', '0','0','0', '0', '0', '" + lbModifica.Text + "')", bd.conexion);
                int i;
                i = comando.ExecuteNonQuery();
                bd.conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex);
            }            
        }

        private void Eliminar()
        {
            try
            {
                bd.conexion.Open();
                SqlCommand comando = new SqlCommand("delete TABLA_HABITACIONES  where (ID_HABITACION = '" + txHabitacion.Text + "')", bd.conexion);
                int i;
                i = comando.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("El registro se a ELIMINO correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ValidarAgregar()
        {
            if (txHabitacion.Text != string.Empty)
            {
                Agregar();
                Limpiar();
                ActualizarDGV();
            }
            else
            {
                MessageBox.Show("Faltan datos...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidarEliminar()
        {
            if (txHabitacion.Text != string.Empty)
            {
                if (lbEstado.Text == "Libre")
                {
                    Eliminar();
                    Limpiar();
                    ActualizarDGV();
                }
                else
                {
                    MessageBox.Show("La habitacion tiene que estar en estado de LIBRE para poder eliminarla.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Faltan datos...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        /*--------------------------------------*
        *-------------           --------------*
        *-------------  Botones  --------------*
        *-------------           --------------*
        *--------------------------------------*/

        private void btAgregar_Click(object sender, EventArgs e)
        {
            ValidarAgregar();
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            ValidarEliminar();
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
                txHabitacion.Text = DGV_Habitacion.CurrentRow.Cells[0].Value.ToString();
                ConsultarHabitacion();
            }
        }

        private void txHabitacion_KeyPress(object sender, KeyPressEventArgs e)
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
            if (txHabitacion.Text != string.Empty)
            {                
                if (e.KeyChar == 13)
                {
                    ConsultarHabitacion();
                }                
            }                        
        }        
    }
}
