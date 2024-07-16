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
            linkRecuperar.Visible = false;
        }
 

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {

            ClaseAccesoLogin login = new ClaseAccesoLogin();

            string user = txtUsuario.Text;
            string pass = txtPassword.Text;

            if (ClaseAccesoLogin.VerificarCredenciales(user, pass))
            {
                frmInicio inicio = new frmInicio();
                inicio.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            string textoValidado = ClsValidar.ValidarUsuario(txtUsuario.Text);
            if (txtUsuario.Text != textoValidado)
            {
                txtUsuario.Text = textoValidado;
                txtUsuario.SelectionStart = txtUsuario.Text.Length; // Mantiene el cursor al final del texto
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.Text = ClsValidar.ValidarContrasena(txtPassword.Text);
            txtPassword.SelectionStart = txtPassword.Text.Length; // Mantiene el cursor al final del texto
        }
    }
    }

