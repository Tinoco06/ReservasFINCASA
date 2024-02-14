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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConsultaFechas_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCotización_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConsultarReservaciones_Click(object sender, EventArgs e)
        {
            
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
           
        }

        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.Show();

            this.Hide();
        }

        private void btnConsultarFechas_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            
        }



        private void gunaAdvenceTileButton1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            AnimacionInicio.Start();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
           
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void btnReservacion_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.Show();

            this.Hide();
        }

        private void btnConsultaReserva_Click(object sender, EventArgs e)
        {
            frmConsultarReservaciones reserva = new frmConsultarReservaciones();
            reserva.Show();
            this.Hide();
        }

        private void btnFechas_Click(object sender, EventArgs e)
        {
            frmConsultaFechas fechas = new frmConsultaFechas();
            fechas.Show();
            this.Hide();
        }

        private void btnCotizacion_Click(object sender, EventArgs e)
        {
            frmCotizacion cotizar = new frmCotizacion();
            cotizar.Show();
            this.Hide();
        }

        private void FechayHora_Tick(object sender, EventArgs e)
        {
            LabelHora.Text = DateTime.Now.ToString("h:mm:ss");
            LabelFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }
    }
}
