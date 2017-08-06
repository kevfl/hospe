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
    public partial class FormHx : Form
    {
        Clases.ClassConexion bd = new Clases.ClassConexion();

        public FormHx()
        {
            InitializeComponent();
        }

        private void FormHx_Load(object sender, EventArgs e)
        {
            
            ActualizarDGV();
            ConsultarHabitacion();
        }

        /*--------------------------------------*
         *-------------           --------------*
         *-------------  Metodos  --------------*
         *-------------           --------------*
         *--------------------------------------*/

        private void TitulosDGV()
        {
            DGV_Reservas.Columns[0].HeaderText = "Habitación";
            DGV_Reservas.Columns[1].HeaderText = "Estado";
            DGV_Reservas.Columns[2].HeaderText = "Cliente";
            DGV_Reservas.Columns[2].Width = 175;
            DGV_Reservas.Columns[3].HeaderText = "Fecha Ingreso";
            DGV_Reservas.Columns[4].HeaderText = "Fecha Salida";
            DGV_Reservas.Columns[5].HeaderText = "Precio Nacional";
            DGV_Reservas.Columns[6].HeaderText = "Precio Extranjero";
            DGV_Reservas.Columns[7].HeaderText = "Precio Gobierno";
            DGV_Reservas.Columns[8].HeaderText = "Fecha Ingreso Resrva";
            DGV_Reservas.Columns[9].HeaderText = "Fecha Salida Reserva";
            DGV_Reservas.Columns[10].HeaderText = "Fecha Limite Reserva";
        }

        private void ActualizarDGV()
        {
            try
            {
                bd.conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT * FROM TABLA_RESERVA ", bd.conexion);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DGV_Reservas.DataSource = dt;
                //TitulosDGV();                
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
                SqlCommand comando = new SqlCommand("SELECT * FROM TABLA_HABITACIONES WHERE (ID_HABITACION = '" + txHabiatacion.Text + "')", bd.conexion);
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read() == true)
                {
                    lbEstado.Text = registro["ESTADO"].ToString();
                    lbCliente.Text = registro["ID_CLIENT"].ToString();
                    lbCapacidadPersonas.Text = registro["CANTIDAD_PERSONAS"].ToString();
                    txFechaIngreso.Text = registro["FECHA_INGRESO"].ToString();
                    txFechaSalida.Text = registro["FECHA_SALIDA"].ToString();
                    lbCantidadDias.Text = registro["CANTIDAD_DIAS"].ToString();
                    lbNacional.Text = registro["PRECIO_NACIONAL"].ToString();
                    lbExtranjero.Text = registro["PRECIO_EXTRANJERO"].ToString();
                    lbGobierno.Text = registro["PRECIO_GOBIERNO"].ToString();
                }
                bd.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void FormHx_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black, 5, 5, 200, 125);
            e.Graphics.DrawRectangle(Pens.Black, 215, 5, 200, 125);
            e.Graphics.DrawRectangle(Pens.Black, 425, 5, 225, 125);
            e.Graphics.DrawRectangle(Pens.Black, 660, 5, 225, 125);
            e.Graphics.DrawLine(Pens.Black, 0, 188, 1500, 188);
            e.Graphics.DrawLine(Pens.Black, 0, 190, 1500, 190);
        }

        private void btBuscarCliente_Click(object sender, EventArgs e)
        {

        }



        /*--------------------------------------*
        *----------                ------------*
        *----------  Validaciones  ------------*
        *----------                ------------*
        *--------------------------------------*/

        /*--------------------------------------*
         *-------------           --------------*
         *-------------  Botones  --------------*
         *-------------           --------------*
         *--------------------------------------*/

        /*--------------------------------------*
         *-------------           --------------*
         *-------------  Eventos  --------------*
         *-------------           --------------*
         *--------------------------------------*/

        private void checkNacional_Click(object sender, EventArgs e)
        {
            checkExtranjero.Checked = false;
            checkGobierno.Checked = false;
        }

        private void checkExtranjero_Click(object sender, EventArgs e)
        {
            checkNacional.Checked = false;
            checkGobierno.Checked = false;
        }

        private void checkGobierno_Click(object sender, EventArgs e)
        {
            checkNacional.Checked = false;
            checkExtranjero.Checked = false;
        }
        
    }
}
