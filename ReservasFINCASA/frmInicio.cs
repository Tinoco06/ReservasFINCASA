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
            frmCalendario calendario = new frmCalendario();
            calendario.Show();
            this.Hide();
        }

        private void btnCotización_Click(object sender, EventArgs e)
        {
            frmCotizacion cotizar = new frmCotizacion();
            cotizar.Show();
            this.Hide();
        }

        private void btnConsultarReservaciones_Click(object sender, EventArgs e)
        {
            frmConsultarReservaciones reserva = new frmConsultarReservaciones();
            reserva.Show();
            this.Hide();
        }
    }
}
