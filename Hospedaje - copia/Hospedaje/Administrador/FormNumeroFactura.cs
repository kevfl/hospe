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
    public partial class FormNumeroFactura : Form
    {
        Clases.ClassConexion bd = new Clases.ClassConexion();

        public FormNumeroFactura()
        {
            InitializeComponent();
        }

        private void FormNumeroFactura_Load(object sender, EventArgs e)
        {
            ConsultaUltimoNumero();
        }

        /*--------------------------------------*
	     *-------------           --------------*
         *-------------  Metodos  --------------*
	     *-------------           --------------*
         *--------------------------------------*/

        private void Limpiar()
        {
            txUltimoNumero.Text = "";
            txUltimoNumero.Focus();
            ConsultaUltimoNumero();
        }

        private void ConsultaUltimoNumero()
        {
            try
            {
                bd.conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT * FROM TABLA_NUM_FACTURA where (ID_FACTURA = 1)", bd.conexion);
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    lbUltimoNumero.Text = registro["ID_ULTIMO_FACTURA"].ToString();
                    txUltimoNumero.Focus();
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
                SqlCommand comando = new SqlCommand("update TABLA_NUM_FACTURA set ID_ULTIMO_FACTURA = '" + txUltimoNumero.Text + "', MODIFICA = '" + lbModifica.Text + "' where(ID_FACTURA = 1)", bd.conexion);
                int i;
                i = comando.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("El registro se a Modifico correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El registro xNO se a Modifico correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Limpiar();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*--------------------------------------*
	     *----------                ------------*
         *----------  Validaciones  ------------*
	     *----------                ------------*
         *--------------------------------------*/

        private void SoloNumeros(KeyPressEventArgs e)
        {
            try
            {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Solo se puede digitar numeros:" + ex, "Adevertencia", MessageBoxButtons.OK);
            }
        }

        /*--------------------------------------*
         *-------------           --------------*
         *-------------  Eventos  --------------*
         *-------------           --------------*
         *--------------------------------------*/

        private void txUltimoNumero_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);

            if (txUltimoNumero.Text != "")
            {
                if (e.KeyChar == 13)
                {
                    Modificar();
                    ConsultaUltimoNumero();
                    Limpiar();
                }
            }
        }
    }
}
