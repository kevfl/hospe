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
    public partial class FormInformacionEmpresa : Form
    {
        Clases.ClassConexion bd = new Clases.ClassConexion();

        public FormInformacionEmpresa()
        {
            InitializeComponent();
        }

        private void FormInformacionEmpresa_Load(object sender, EventArgs e)
        {
            ConsultaEmpre();
        }

        /*--------------------------------------*
	     *-------------           --------------*
         *-------------  Metodos  --------------*
	     *-------------           --------------*
         *--------------------------------------*/

        private void ConsultaEmpre()
        {
            try
            {
                bd.conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT * FROM TABLA_INFO_EMPRE WHERE (ID_EMPRE = 1)", bd.conexion);
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read() == true)
                {
                    txNombre.Text = registro["NOMBRE"].ToString();
                    txCedula.Text = registro["CEDULA"].ToString();
                    txUbicacion.Text = registro["UBICACION"].ToString();
                    txTelefono.Text = registro["TELEFONO"].ToString();
                    txCorreo.Text = registro["CORREO"].ToString();
                    txFacebook.Text = registro["FACEBOOK"].ToString();
                    txLema.Text = registro["LEMA"].ToString();
                    txLema.Text = registro["LEMA"].ToString();
                    txModifica.Text = registro["MODIFICA"].ToString();
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
                SqlCommand comando = new SqlCommand("update TABLA_INFO_EMPRE set NOMBRE = '" + txNombre.Text + "', CEDULA = '" + txCedula.Text + "', UBICACION = '" + txUbicacion.Text + "', TELEFONO = '" + txTelefono.Text + "', CORREO = '" + txCorreo.Text + "', FACEBOOK = '" + txFacebook.Text + "', LEMA = '" + txLema.Text + "', MODIFICA = '" + lbModifica.Text + "'  where (ID_EMPRE = 1)", bd.conexion);
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

        /*--------------------------------------*
	     *-------------           --------------*
         *-------------  Botones  --------------*
	     *-------------           --------------*
         *--------------------------------------*/

        private void btActualizar_Click(object sender, EventArgs e)
        {
            Modificar();
            ConsultaEmpre();
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

        private void txNombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (txNombre.Text != "")
            {
                if (e.KeyChar == 13)
                {
                    txCedula.Focus();
                }
            }
            else
            {
                txNombre.Focus();
            }
        }

        private void txCedula_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (txCedula.Text != "")
            {
                if (e.KeyChar == 13)
                {
                    txUbicacion.Focus();
                }
            }
            else
            {
                txCedula.Focus();
            }
        }

        private void txUbicacion_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (txUbicacion.Text != "")
            {
                if (e.KeyChar == 13)
                {
                    txTelefono.Focus();
                }
            }
            else
            {
                txUbicacion.Focus();
            }
        }

        private void txTelefono_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (txTelefono.Text != "")
            {
                if (e.KeyChar == 13)
                {
                    txCorreo.Focus();
                }
            }
            else
            {
                txTelefono.Focus();
            }
        }

        private void txCorreo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (txCorreo.Text != "")
            {
                if (e.KeyChar == 13)
                {
                    txFacebook.Focus();
                }
            }
            else
            {
                txCorreo.Focus();
            }
        }

        private void txFacebook_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (txFacebook.Text != "")
            {
                if (e.KeyChar == 13)
                {
                    txLema.Focus();
                }
            }
            else
            {
                txFacebook.Focus();
            }
        }

        private void txLema_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txLema.Text != "")
            {
                if (e.KeyChar == 13)
                {
                    btActualizar.Focus();
                }
            }
            else
            {
                txLema.Focus();
            }
        }
    }
}
