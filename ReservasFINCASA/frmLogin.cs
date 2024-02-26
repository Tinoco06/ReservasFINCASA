using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
           
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            
            frmInicio inicio = new frmInicio();
            inicio.Show();
            this.Hide();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
