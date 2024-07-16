using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservasFINCASA
{
    public partial class FrmFechasParaReservas : Form
    {
        ObtenerCabanhasOcupadas obtenerCabanhas = new ObtenerCabanhasOcupadas();
        private ClsValidar validador;

        public FrmFechasParaReservas()
        {
            InitializeComponent();
            validador = new ClsValidar();
            this.Load += new System.EventHandler(this.FrmFechasParaReservas_Load);
            this.dtpInicioEstadia.ValueChanged += new System.EventHandler(this.dtpInicioEstadia_ValueChanged);
            this.dtpFinEstadia.ValueChanged += new System.EventHandler(this.dtpFinEstadia_ValueChanged);
        }

        private void FrmFechasParaReservas_Load(object sender, EventArgs e)
        {
            //Capturar la fecha del click
            string fechaTexto = frmConsultaFechas.StaticYearInicio + "-" + frmConsultaFechas.StaticMonthInicio + "-" + UserControlDays.Static_dayInicio;

            //Analizar el texto a una fecha
            DateTime.TryParse(fechaTexto, out DateTime fechaInicio);
            dtpInicioEstadia.Value = fechaInicio;
            // Configurar los DateTimePicker para que no acepten fechas pasadas
            dtpInicioEstadia.MinDate = DateTime.Now.Date;
            dtpFinEstadia.MinDate = DateTime.Now.Date;

        }


        private void bntConsultarReservas_Click(object sender, EventArgs e)
        {
            MostrarCabanhasEnDataGridView();

        }


        //Extrae las cabañas ocupadas en las fechas establecidas
        private void MostrarCabanhasEnDataGridView()
        {
            int indexColumna = 0;
            DateTime FechaExtraidaFin = dtpFinEstadia.Value, FechaExtraidaInicio = dtpInicioEstadia.Value;
            string FechaFinEstadia = FechaExtraidaFin.ToString("yyyy-MM-dd"), FechaInicioEstadia = FechaExtraidaInicio.ToString("yyyy-MM-dd");

            int DiferenciaDias = (FechaExtraidaFin - FechaExtraidaInicio).Days;

            if (DiferenciaDias >= 1)
            {

                ObtenerCabanhasOcupadas obtenerCabanhas = new ObtenerCabanhasOcupadas();
                DataTable datosCabanhas = obtenerCabanhas.ObtenerDatosCabanhasOcupadas(FechaFinEstadia, FechaInicioEstadia);
                // Asignar los datos al DataGridView
                dgvCabanasDisponibles.DataSource = datosCabanhas;


            }
            else
            {
                MessageBox.Show("La diferencia de días debe ser mayor a 1", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvCabanasDisponibles.DataSource = null;
        }

        private void btnVolverCalendario_Click(object sender, EventArgs e)
        {
            frmConsultaFechas fechas = new frmConsultaFechas();
            fechas.Show();
            this.Close();
        }

        private void dtpInicioEstadia_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpInicioEstadia.Value;

            if (!validador.ValidarFechaNoPasada(selectedDate))
            {
                // Mostrar mensaje de error
                MessageBox.Show("No se puede seleccionar una fecha pasada.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Restablecer la fecha al día actual
                dtpInicioEstadia.Value = DateTime.Now.Date;
            }
        }

        private void dtpFinEstadia_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpFinEstadia.Value;

            if (!validador.ValidarFechaNoPasada(selectedDate))
            {
                // Mostrar mensaje de error
                MessageBox.Show("No se puede seleccionar una fecha pasada.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Restablecer la fecha al día actual
                dtpFinEstadia.Value = DateTime.Now.Date;
            }
        }

    }
}