using System;
using System.Windows.Forms;

namespace ReservasFINCASA
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }


        private void FechayHora_Tick(object sender, EventArgs e)
        {
            LabelHora.Text = DateTime.Now.ToString("h:mm:ss");
            LabelFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btnCotizaciones_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente(false);
            cliente.SetInstrucciones("Ingrese los datos del cliente o seleccione uno para continuar con su cotización.");
            cliente.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente(true);
            cliente.SetInstrucciones("Ingrese los datos del cliente o seleccione uno para continuar con su reserva.");
            cliente.Show();
            this.Hide();
        }

        private void btnSalirLogIn_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void btnAgregarCabanha_Click(object sender, EventArgs e)
        {
            frmAgregarCabanha cabanha = new frmAgregarCabanha();
            this.Hide();
            cabanha.Show();
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            frmAgregarServiciosExtras frmServicios = new frmAgregarServiciosExtras();
            frmServicios.Show();
            this.Hide();
        }

        private void btnConsultaFechas_Click(object sender, EventArgs e)
        {
            frmConsultaFechas fechas = new frmConsultaFechas();
            fechas.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void btnConsultaReserva_Click_1(object sender, EventArgs e)
        {
            frmAbrirReserva reservas = new frmAbrirReserva();
            
            reservas.Show();
            this.Hide();
        }
    }
}
