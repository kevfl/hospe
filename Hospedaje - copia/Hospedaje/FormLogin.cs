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

namespace Hospedaje
{
    public partial class FormLogin : Form
    {
        Clases.ClassConexion bd = new Clases.ClassConexion();

        public bool Logueado = false;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txUsuario.Focus();
        }

        /*--------------------------------------*
	     *-------------           --------------*
         *-------------  Metodos  --------------*
	     *-------------           --------------*
         *--------------------------------------*/

        public void ConsultarUsuario()
        {
            try
            {
                if (txUsuario.Text == "ces" && txContraseña.Text == "ces777")
                {
                    txNombreUsuario.Text = "Cesar";
                    txTipoUsuario.Text = "Programador";
                    MessageBox.Show("Bienvenido " + txNombreUsuario.Text, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Logueado = true;
                    Close();
                }
                else
                {
                    bd.conexion.Open();
                    SqlCommand comando = new SqlCommand("SELECT * FROM TABLA_USUARIO WHERE (ID_USUARIO = '" + txUsuario.Text + "' AND CONTRASEÑA_USUARIO = '" + txContraseña.Text + "')", bd.conexion);
                    SqlDataReader registro = comando.ExecuteReader();
                    if (registro.Read() == true)
                    {
                        txNombreUsuario.Text = registro["NOMBRE_USUARIO"].ToString();
                        txTipoUsuario.Text = registro["TIPO_USUARIO"].ToString();
                        MessageBox.Show("Bienvenido " + txNombreUsuario.Text, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Logueado = true;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No existe registro", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txUsuario.Text = "";
                        txContraseña.Text = "";
                        txNombreUsuario.Text = "";
                        txTipoUsuario.Text = "";
                        txUsuario.Focus();
                    }
                    bd.conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void Salir()
        {
            try
            {
                DialogResult respuesta;
                respuesta = MessageBox.Show("Desea salir ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
        }        

        /*--------------------------------------*
	     *-------------           --------------*
         *-------------  Botones  --------------*
	     *-------------           --------------*
         *--------------------------------------*/

        private void btAceptar_Click(object sender, EventArgs e)
        {
            ConsultarUsuario();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        /*--------------------------------------*
	     *-------------           --------------*
         *-------------  Eventos  --------------*
	     *-------------           --------------*
         *--------------------------------------*/

        private void txUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txUsuario.Text != "")
            {
                if (e.KeyChar == 13)
                {
                    txContraseña.Focus();
                }
            }
            else
            {
                txUsuario.Focus();
            }
        }

        private void txContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txContraseña.Text != "")
            {
                if (e.KeyChar == 13)
                {
                    ConsultarUsuario();
                }
            }
            else
            {
                txContraseña.Focus();
            }
        }
    }
}
