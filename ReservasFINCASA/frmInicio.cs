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
            frmCliente cliente = new frmCliente();
            cliente.Show();

            this.Hide();
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
            lblHora.Text = DateTime.Now.ToString("h:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.Show();

            this.Hide();
        }

        private void btnConsultarFechas_Click(object sender, EventArgs e)
        {
            frmCalendario calendario = new frmCalendario();
            calendario.Show();
            this.Hide();
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            frmCotizacion cotizar = new frmCotizacion();
            cotizar.Show();
            this.Hide();
        }



        private void gunaAdvenceTileButton1_Click_1(object sender, EventArgs e)
        {
            frmConsultarReservaciones reserva = new frmConsultarReservaciones();
            reserva.Show();
            this.Hide();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            AnimacionInicio.Start();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }
    }
}
