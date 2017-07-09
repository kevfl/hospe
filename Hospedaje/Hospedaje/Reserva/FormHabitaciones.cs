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

namespace Hospedaje.Reserva
{
    public partial class FormHabitaciones : Form
    {
        Clases.ClassConexion bd = new Clases.ClassConexion();

        public FormHabitaciones()
        {
            InitializeComponent();
        }

        private void FormHabitaciones_Load(object sender, EventArgs e)
        {
            ActualizarGridView();
            Limpiar();
        }



        /*--------------------------------------*
	     *-------------           --------------*
         *-------------  Metodos  --------------*
	     *-------------           --------------*
         *--------------------------------------*/

        private void ActualizarGridView()
        {
            try
            {
                bd.conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT * FROM TABLA_HABITACION ", bd.conexion);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvHabiataciones.DataSource = dt;
                dgvHabiataciones.AutoResizeColumns();
                bd.conexion.Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Error : " + ex);
            }
        }

        private void Limpiar()
        {
            txNumHabitacion.Text = "";
            txCategoria.Text = "";
            txNumPersonas.Text = "";
            txPrecioNacional.Text = "";
            txPrecioExtranjero.Text = "";
            txPrecioGobierno.Text = "";
            txPrecioNacionalImp.Text = "";
            txPrecioGobiernoImp.Text = "";
            txPrecioExtranjeroImp.Text = "";
            btAgregar.Enabled = false;
            btModificar.Enabled = false;
            btEliminar.Enabled = false;
            txNumHabitacion.Focus();
            ActualizarGridView();
        }

        private void ConsultaUsuario()
        {
            try
            {
                bd.conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT * FROM TABLA_HABITACION WHERE (ID_HABITACION = '" + txNumHabitacion.Text + "')", bd.conexion);
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read() == true)
                {
                    txNumHabitacion.Text = registro["NOMBRE_USUARIO"].ToString();
                    txCategoria.Text = registro["NOMBRE_USUARIO"].ToString();
                    txNumPersonas.Text = registro["NOMBRE_USUARIO"].ToString();
                    txPrecioNacional.Text = registro["NOMBRE_USUARIO"].ToString();
                    txPrecioExtranjero.Text = registro["NOMBRE_USUARIO"].ToString();
                    txPrecioGobierno.Text = registro["NOMBRE_USUARIO"].ToString();
                    txPrecioNacionalImp.Text = registro["NOMBRE_USUARIO"].ToString();
                    txPrecioGobiernoImp.Text = registro["NOMBRE_USUARIO"].ToString();
                    txPrecioExtranjeroImp.Text = registro["NOMBRE_USUARIO"].ToString();
                    txCategoria.Enabled = true;
                    txNumPersonas.Enabled = true;
                    txPrecioNacionalImp.Enabled = true;
                    txPrecioGobiernoImp.Enabled = true;
                    txPrecioExtranjeroImp.Enabled = true;
                    btAgregar.Enabled = false;
                    btModificar.Enabled = true;
                    btEliminar.Enabled = true;
                    txCategoria.Focus();
                }
                else
                {
                    txCategoria.Text = "";
                    txNumPersonas.Text = "";
                    txPrecioNacional.Text = "";
                    txPrecioExtranjero.Text = "";
                    txPrecioGobierno.Text = "";
                    txPrecioNacionalImp.Text = "";
                    txPrecioGobiernoImp.Text = "";
                    txPrecioExtranjeroImp.Text = "";
                    txCategoria.Enabled = true;
                    txNumPersonas.Enabled = true;
                    txPrecioNacionalImp.Enabled = true;
                    txPrecioGobiernoImp.Enabled = true;
                    txPrecioExtranjeroImp.Enabled = true;
                    btAgregar.Enabled = true;
                    btModificar.Enabled = false;
                    btEliminar.Enabled = false;
                    txCategoria.Focus();
                }
                bd.conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex);
            }
        }

        private void Agregar()
        {
            try
            {
                bd.conexion.Open();
                SqlCommand comando = new SqlCommand("insert into TABLA_USUARIO(ID_USUARIO, NOMBRE_USUARIO, CONTRASEÑA_USUARIO, TIPO_USUARIO, MODIFICA)VALUES('" + txUsuario.Text + "', '" + txNombre.Text + "', '" + txContraseña.Text + "', '" + txTipoUsuario.Text + "', '" + lbModifica.Text + "')", bd.conexion);
                int i;
                i = comando.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("El registro se a Agrego correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El registro NO se a Agrego correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                bd.conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex);
            }
        }

        private void Modificar()
        {
            try
            {
                bd.conexion.Open();
                SqlCommand comando = new SqlCommand("update TABLA_USUARIO set ID_USUARIO = '" + txUsuario.Text + "', NOMBRE_USUARIO = '" + txNombre.Text + "', CONTRASEÑA_USUARIO = '" + txContraseña.Text + "', TIPO_USUARIO = '" + txTipoUsuario.Text + "'  where (ID_USUARIO = '" + txUsuario.Text + "')", bd.conexion);
                int i;
                i = comando.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("El registro se a Modifico correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El registro NO se a Modifico correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                SqlCommand comando = new SqlCommand("delete TABLA_USUARIO  where (ID_USUARIO = '" + txUsuario.Text + "')", bd.conexion);
                int i;
                i = comando.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("El registro se a Elimino correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El registro NO se a Elimino correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (txUsuario.Text != string.Empty)
            {
                if (txNombre.Text != string.Empty)
                {
                    if (txContraseña.Text != string.Empty)
                    {
                        if (txTipoUsuario.Text != string.Empty)
                        {
                            Agregar();
                            ActualizarGridView();
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("No se puede agregar falta tipo de usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede agregar falta contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("No se puede agregar falta nombre de usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No se puede agregar falta ID de usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ValidarModificar()
        {
            if (txUsuario.Text != string.Empty)
            {
                if (txNombre.Text != string.Empty)
                {
                    if (txContraseña.Text != string.Empty)
                    {
                        if (txTipoUsuario.Text != string.Empty)
                        {
                            Modificar();
                            ActualizarGridView();
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("No se puede modificar falta tipo de usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede modificar falta contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("No se puede modificar falta nombre de usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No se puede modificar falta ID de usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ValidarEliminar()
        {
            if (txNumHabitacion.Text != string.Empty)
            {
                Eliminar();
                ActualizarGridView();
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se puede modificar falta ID de usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /*--------------------------------------*
         *-------------           --------------*
         *-------------  Botones  --------------*
         *-------------           --------------*
         *--------------------------------------*/

        private void btAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btModificar_Click(object sender, EventArgs e)
        {

        }

        private void btEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }





        /*--------------------------------------*
         *-------------           --------------*
         *-------------  Eventos  --------------*
         *-------------           --------------*
         *--------------------------------------*/
        private void dgvHabiataciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHabiataciones.DataSource == null)
            {
                return;
            }
            else
            {
                txNumHabitacion.Text = dgvHabiataciones.CurrentRow.Cells[0].Value.ToString();
                ConsultaUsuario();
            }
        }

    }
}
