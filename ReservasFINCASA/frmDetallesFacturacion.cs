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
    public partial class frmDetallesFacturacion : Form
    {
        public frmDetallesFacturacion()
        {
            InitializeComponent();
        }

        private void btnVolverCliente_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.Show();
            this.Hide();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            frmFactura factura = new frmFactura();
            factura.Show();
            this.Hide();
        }
    }
}
