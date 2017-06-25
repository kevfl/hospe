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
    public partial class FormLicencia : Form
    {
        Clases.ClassConexion bd = new Clases.ClassConexion();

        public FormLicencia()
        {
            InitializeComponent();
        }

        private void FormLicencia_Load(object sender, EventArgs e)
        {
            txLicencia.Focus();
            ConsultarLicencia();
        }

        /*--------------------------------------*
         *-------------           --------------*
         *-------------  Metodos  --------------*
         *-------------           --------------*
        *--------------------------------------*/
        private void ConsultarLicencia()
        {
            string Lic = "0";

            try
            {
                bd.conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT * FROM TABLA_LICENCIA WHERE (ID = 1)", bd.conexion);
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read() == true)
                {
                    lbLicenciaActual.Text = registro["LICENCIA"].ToString();
                    Lic = lbLicenciaActual.Text;
                    if (Lic == "3RYTYN")
                    {
                        lbValida.Text = "31/12/2019";
                    }
                    else if (Lic == "73CLZH")
                    {
                        lbValida.Text = "31/12/2020";
                    }
                    else if (Lic == "GLHE6X")
                    {
                        lbValida.Text = "31/12/2021";
                    }
                    else if (Lic == "QNHV44")
                    {
                        lbValida.Text = "31/12/2022";
                    }
                    else if (Lic == "3AU34X")
                    {
                        lbValida.Text = "31/12/2023";
                    }
                    else if (Lic == "2QXHKZ")
                    {
                        lbValida.Text = "31/12/2024";
                    }
                    else if (Lic == "2C3VZV")
                    {
                        lbValida.Text = "31/12/2025";
                    }
                    else if (Lic == "87P783")
                    {
                        lbValida.Text = "31/12/2026";

                    }
                    else if (Lic == "RLH4CE")
                    {
                        lbValida.Text = "31/12/2027";
                    }
                    else if (Lic == "UXV6DR")
                    {
                        lbValida.Text = "31/12/2028";
                    }
                    else if (Lic == "7E8ZVX")
                    {
                        lbValida.Text = "31/12/2029";
                    }
                    else if (Lic == "EVA4CP")
                    {
                        lbValida.Text = "31/12/2030";
                    }
                    else
                    {
                        lbValida.Text = "No valida";
                    }
                    MessageBox.Show("Licencia: " + Lic + "\n\nValida: " + lbValida.Text, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo consultar la Licencia del Producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                SqlCommand comando = new SqlCommand("update TABLA_LICENCIA set LICENCIA = '" + txLicencia.Text + "', MODIFICA = '" + lbModifica.Text + "'  where (ID = 1)", bd.conexion);
                int i;
                i = comando.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("El registro se a modifico correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (i == 0)
                {
                    MessageBox.Show("El registro NO se a modifico correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                bd.conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex);
            }
        }

        private void Salir()
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("Debe reiniciar el sistema.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.OK)
            {
                //Application.Exit();
                Application.Restart();
            }
        }

        /*--------------------------------------*
         *----------                ------------*
         *----------  Validaciones  ------------*
         *----------                ------------*
         *--------------------------------------*/

        private void ValidarActualizar()
        {
            if (txLicencia.Text != string.Empty)
            {
                Modificar();
                ConsultarLicencia();
                Salir();
            }
            else
            {
                MessageBox.Show("No ha ingresado licencia", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txLicencia.Focus();
            }
        }

        /*--------------------------------------*
        *-------------           --------------*
        *-------------  Botones  --------------*
        *-------------           --------------*
        *--------------------------------------*/

        private void btActualizar_Click(object sender, EventArgs e)
        {
            ValidarActualizar();
        }

        /*--------------------------------------*
         *-------------           --------------*
         *-------------  Eventos  --------------*
         *-------------           --------------*
         *--------------------------------------*/

        private void txLicencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ValidarActualizar();
            }
        }

        




    }
}
