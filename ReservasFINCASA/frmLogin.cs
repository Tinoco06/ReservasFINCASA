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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {                
                frmInicio inicio = new frmInicio();
                inicio.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al mostrar el formulario frmCliente: " + ex.Message);
            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            try
            {
                frmInicio inicio = new frmInicio();
                inicio.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al mostrar el formulario frmCliente: " + ex.Message);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            gunaAnimateWindow1.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
