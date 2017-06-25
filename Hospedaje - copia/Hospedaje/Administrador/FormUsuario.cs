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

namespace Hospedaje.Administrador
{
    public partial class FormUsuario : Form
    {
        Clases.ClassConexion bd = new Clases.ClassConexion();

        public FormUsuario()
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
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
                SqlCommand comando = new SqlCommand("SELECT * FROM TABLA_USUARIO ", bd.conexion);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridViewUsuario.DataSource = dt;
                GridViewUsuario.AutoResizeColumns();
                bd.conexion.Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Error : " + ex);
            }
        }

        private void Limpiar()
        {
            txUsuario.Text = "";
            txNombre.Text = "";
            txContraseña.Text = "";
            txTipoUsuario.Text = "";
            txNombre.Enabled = false;
            txContraseña.Enabled = false;
            txTipoUsuario.Enabled = false;
            btAgregar.Enabled = false;
            btModificar.Enabled = false;
            btEliminar.Enabled = false;
            txUsuario.Focus();
            ActualizarGridView();
        }

        private void ConsultaUsuario()
        {
            try
            {
                bd.conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT * FROM TABLA_USUARIO WHERE (ID_USUARIO = '" + txUsuario.Text + "')", bd.conexion);
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read() == true)
                {
                    txNombre.Text = registro["NOMBRE_USUARIO"].ToString();
                    txContraseña.Text = registro["CONTRASEÑA_USUARIO"].ToString();
                    txTipoUsuario.Text = registro["TIPO_USUARIO"].ToString();
                    txNombre.Enabled = true;
                    txContraseña.Enabled = true;
                    txTipoUsuario.Enabled = true;
                    btAgregar.Enabled = false;
                    btModificar.Enabled = true;
                    btEliminar.Enabled = true;
                    txNombre.Focus();
                }
                else
                {
                    txNombre.Text = "";
                    txContraseña.Text = "";
                    txTipoUsuario.Text = "";
                    txNombre.Enabled = true;
                    txContraseña.Enabled = true;
                    txTipoUsuario.Enabled = true;
                    btAgregar.Enabled = true;
                    btModificar.Enabled = false;
                    btEliminar.Enabled = false;
                    txNombre.Focus();
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
            if (txUsuario.Text != string.Empty)
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

        private void btAgregar_Click_1(object sender, EventArgs e)
        {
            ValidarAgregar();
        }

        private void btModificar_Click_1(object sender, EventArgs e)
        {
            ValidarModificar();
        }

        private void btEliminar_Click_1(object sender, EventArgs e)
        {
            ValidarEliminar();
        }

        private void btSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        /*--------------------------------------*
         *-------------           --------------*
         *-------------  Eventos  --------------*
         *-------------           --------------*
         *--------------------------------------*/

        private void txUsuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (txUsuario.Text != "")
            {
                if (e.KeyChar == 13)
                {
                    ConsultaUsuario();
                }
            }
            else
            {
                txUsuario.Focus();
            }
        }

        private void txNombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (txNombre.Text != "")
            {
                if (e.KeyChar == 13)
                {
                    txContraseña.Focus();
                }
            }
            else
            {
                txNombre.Focus();
            }
        }

        private void txContraseña_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (txContraseña.Text != "")
            {
                if (e.KeyChar == 13)
                {
                    txTipoUsuario.Focus();
                }
            }
            else
            {
                txContraseña.Focus();
            }
        }

        private void txTipoUsuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (txTipoUsuario.Text != "")
            {
                if (e.KeyChar == 13)
                {
                    if (btAgregar.Enabled == true)
                    {
                        btAgregar.Focus();
                    }
                    else if (btModificar.Enabled == true)
                    {
                        btModificar.Focus();
                    }
                }
            }
            else
            {
                txTipoUsuario.Focus();
            }
        }

        private void GridViewUsuario_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (GridViewUsuario.DataSource == null)
            {
                return;
            }
            else
            {
                txUsuario.Text = GridViewUsuario.CurrentRow.Cells[0].Value.ToString();
                ConsultaUsuario();
            }
        }
    }
}
