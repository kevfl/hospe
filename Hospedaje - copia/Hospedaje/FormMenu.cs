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
    public partial class FormMenu : Form
    {
        Clases.ClassConexion bd = new Clases.ClassConexion();

        int Permiso = 0;

        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin Login = new FormLogin();
            Login.ShowDialog();

            if (Login.Logueado == true)
            {
                txNombreUsu.Text = Login.txNombreUsuario.Text;
                txTipoUsu.Text = Login.txTipoUsuario.Text;
                this.Show();

                ConsultarLicencia();

                if (Permiso == 1)
                {
                    Item_Reservas.Enabled = false;
                    Item_Facturación.Enabled = false;
                    Item_Reportes.Enabled = false;
                    Item_Administrador.Enabled = false;
                    Item_Usuario.Enabled = false;
                    Item_InformacionEmpre.Enabled = false;
                    Item_Licencia.Enabled = false;
                    Item_Programador.Enabled = false;

                    if (txTipoUsu.Text == "Programador")
                    {
                        Item_Reservas.Enabled = true;
                        Item_Facturación.Enabled = true;
                        Item_Reportes.Enabled = true;
                        Item_Administrador.Enabled = true;
                        Item_Usuario.Enabled = true;
                        Item_InformacionEmpre.Enabled = true;
                        Item_Licencia.Enabled = true;
                        Item_Programador.Enabled = true;
                    }
                    else if (txTipoUsu.Text == "Administrador")
                    {
                        Item_Reservas.Enabled = true;
                        Item_Facturación.Enabled = true;
                        Item_Reportes.Enabled = true;
                        Item_Administrador.Enabled = true;
                        Item_Usuario.Enabled = true;
                        Item_InformacionEmpre.Enabled = true;
                        Item_Licencia.Enabled = true;
                    }
                    else if (txTipoUsu.Text == "Defaul")
                    {
                        Item_Reservas.Enabled = true;
                        Item_Facturación.Enabled = true;
                        Item_Reportes.Enabled = true;                        
                    }                                        
                }
                else
                {
                    Item_Reservas.Enabled = false;
                    Item_Facturación.Enabled = false;
                    Item_Reportes.Enabled = false;
                    Item_Administrador.Enabled = true;
                    MessageBox.Show("La Licencia a caducado favor actualizar y reiniciar el sistema. \n Correo: cesar-flores-g@hotmail.com", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Administrador.FormLicencia Licencia = new Administrador.FormLicencia();
                    Licencia.lbModifica.Text = txNombreUsu.Text;
                    Licencia.ShowDialog();
                }
            }
            else
            {
                Close();
            }
        }

        /*--------------------------------------*
	     *-------------           --------------*
         *-------------  Metodos  --------------*
	     *-------------           --------------*
         *--------------------------------------*/

        public void ConsultarLicencia()
        {
            string Lic = "0";
            DateTime HOY = DateTime.Today.ToLocalTime();

            try
            {
                bd.conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT * FROM TABLA_LICENCIA WHERE (ID = 1)", bd.conexion);
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read() == true)
                {
                    Lic = registro["LICENCIA"].ToString();
                }
                else
                {
                    MessageBox.Show("No se pudo consultar la Licencia del Producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                bd.conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex);
            }

            try
            {
                if (Lic == "3RYTYN")
                {
                    if (HOY < DateTime.ParseExact("31/12/2019", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture))
                    {
                        Permiso = 1;
                    }
                    else
                    {
                        Permiso = 0;
                    }
                }
                if (Lic == "73CLZH")
                {
                    if (HOY < DateTime.ParseExact("31/12/2020", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture))
                    {
                        Permiso = 1;
                    }
                    else
                    {
                        Permiso = 0;
                    }
                }
                if (Lic == "GLHE6X")
                {
                    if (HOY < DateTime.ParseExact("31/12/2021", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture))
                    {
                        Permiso = 1;
                    }
                    else
                    {
                        Permiso = 0;
                    }
                }
                if (Lic == "QNHV44")
                {
                    if (HOY < DateTime.ParseExact("31/12/2022", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture))
                    {
                        Permiso = 1;
                    }
                    else
                    {
                        Permiso = 0;
                    }
                }
                if (Lic == "3AU34X")
                {
                    if (HOY < DateTime.ParseExact("31/12/2023", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture))
                    {
                        Permiso = 1;
                    }
                    else
                    {
                        Permiso = 0;
                    }
                }
                if (Lic == "2QXHKZ")
                {
                    if (HOY < DateTime.ParseExact("31/12/2024", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture))
                    {
                        Permiso = 1;
                    }
                    else
                    {
                        Permiso = 0;
                    }
                }
                if (Lic == "2C3VZV")
                {
                    if (HOY < DateTime.ParseExact("31/12/2025", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture))
                    {
                        Permiso = 1;
                    }
                    else
                    {
                        Permiso = 0;
                    }
                }
                if (Lic == "87P783")
                {
                    if (HOY < DateTime.ParseExact("31/12/2026", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture))
                    {
                        Permiso = 1;
                    }
                    else
                    {
                        Permiso = 0;
                    }
                }
                if (Lic == "RLH4CE")
                {
                    if (HOY < DateTime.ParseExact("31/12/2027", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture))
                    {
                        Permiso = 1;
                    }
                    else
                    {
                        Permiso = 0;
                    }
                }
                if (Lic == "UXV6DR")
                {
                    if (HOY < DateTime.ParseExact("31/12/2028", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture))
                    {
                        Permiso = 1;
                    }
                    else
                    {
                        Permiso = 0;
                    }
                }
                if (Lic == "7E8ZVX")
                {
                    if (HOY < DateTime.ParseExact("31/12/2029", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture))
                    {
                        Permiso = 1;
                    }
                    else
                    {
                        Permiso = 0;
                    }
                }
                if (Lic == "EVA4CP")
                {
                    if (HOY < DateTime.ParseExact("31/12/2030", "dd/MM/yyyy",System.Globalization.CultureInfo.InvariantCulture))
                    {
                        Permiso = 1;
                    }
                    else
                    {
                        Permiso = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }

        }

        private void Salir()
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("Desea salir ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                Close();
            }
        }

        /*--------------------------------------*
	     *-------------           --------------*
         *-------------  Botones  --------------*
	     *-------------           --------------*
         *--------------------------------------*/

        private void Item_Habitaciones_Click(object sender, EventArgs e)
        {
            Reserva.FormHabitaciones Habitaciones = new Reserva.FormHabitaciones();
            Habitaciones.lbModifica.Text = txNombreUsu.Text;
            Habitaciones.ShowDialog();
            this.Show();
        }

        private void Item_Usuario_Click(object sender, EventArgs e)
        {
            Administrador.FormUsuario Usuario = new Administrador.FormUsuario();
            Usuario.lbModifica.Text = txNombreUsu.Text;
            Usuario.ShowDialog();
            this.Show();
        }

        private void Item_InformacionEmpre_Click(object sender, EventArgs e)
        {
            Administrador.FormInformacionEmpresa InformacionEmpresa = new Administrador.FormInformacionEmpresa();
            InformacionEmpresa.lbModifica.Text = txNombreUsu.Text;
            InformacionEmpresa.ShowDialog();
            this.Show();
        }

        private void Item_Licencia_Click(object sender, EventArgs e)
        {
            Administrador.FormLicencia Licencia = new Administrador.FormLicencia();
            Licencia.lbModifica.Text = txNombreUsu.Text;
            Licencia.ShowDialog();
        }

        private void Item_NuemeroFact_Click(object sender, EventArgs e)
        {
            Administrador.FormNumeroFactura NumeroFactura = new Administrador.FormNumeroFactura();
            NumeroFactura.lbModifica.Text = txNombreUsu.Text;
            NumeroFactura.ShowDialog();
            this.Show();
        }

        private void Item_CerrarSeción_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Item_Salir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        
    }
}
