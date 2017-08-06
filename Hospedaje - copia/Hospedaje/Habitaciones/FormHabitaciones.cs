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
    public partial class FormHabitaciones : Form
    {
        Clases.ClassConexion bd = new Clases.ClassConexion();

        public FormHabitaciones()
        {
            InitializeComponent();
        }

        private void FormHabitaciones_Load(object sender, EventArgs e)
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
            txHabiatacion.Text = "";
            lbEstado.Text = "";
            txHabiatacion.Enabled = false;            
        }
        
        private void TitulosDGV()
        {
            DGV_Habitacion.Columns[0].HeaderText = "Habitación";
            DGV_Habitacion.Columns[1].HeaderText = "Estado";
            DGV_Habitacion.Columns[2].HeaderText = "Cliente";
            DGV_Habitacion.Columns[2].Width = 175;
            DGV_Habitacion.Columns[3].HeaderText = "Fecha Ingreso";
            DGV_Habitacion.Columns[4].HeaderText = "Fecha Salida";
            DGV_Habitacion.Columns[5].HeaderText = "Precio Nacional";
            DGV_Habitacion.Columns[6].HeaderText = "Precio Extranjero";
            DGV_Habitacion.Columns[7].HeaderText = "Precio Gobierno";
            DGV_Habitacion.Columns[8].HeaderText = "Fecha Ingreso Resrva";
            DGV_Habitacion.Columns[9].HeaderText = "Fecha Salida Reserva";
            DGV_Habitacion.Columns[10].HeaderText = "Fecha Limite Reserva";
            DGV_Habitacion.Columns[11].HeaderText = "Cliente Reserva";
            DGV_Habitacion.Columns[11].Width = 175;
        }

        private void ActualizarDGV()
        {
            try
            {
                bd.conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT h.ID_HABITACION, h.ESTADO, h.ID_CLIENT, h.FECHA_INGRESO, h.FECHA_SALIDA, h.PRECIO_NACIONAL, h.PRECIO_EXTRANJERO, h.PRECIO_GOBIERNO, r.FECHA_INGRESO_RESERVA, r.FECHA_SALIDA_RESERVA, r.FECHA_LIMITE_RESERVA, r.ID_CLIENT FROM TABLA_HABITACIONES h LEFT OUTER JOIN TABLA_RESERVA r ON h.ID_HABITACION = r.ID_HABITACION_RESERVA", bd.conexion);
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
                SqlCommand comando = new SqlCommand("SELECT * FROM TABLA_HABITACIONES WHERE (ID_HABITACION = '" + txHabiatacion.Text + "')", bd.conexion);
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read() == true)
                {
                    lbEstado.Text = registro["ESTADO"].ToString();                    
                }
                bd.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
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

        private void btEditar_Click(object sender, EventArgs e)
        {
            Habitaciones.FormHx Hx = new Habitaciones.FormHx();
            Hx.txHabiatacion.Text = txHabiatacion.Text;
            Hx.lbModifica.Text = lbModifica.Text;
            Hx.ShowDialog();
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            ActualizarDGV();
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
                txHabiatacion.Text = DGV_Habitacion.CurrentRow.Cells[0].Value.ToString();
                ConsultarHabitacion();
            }
        }
    }
}
