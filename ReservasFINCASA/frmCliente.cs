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
    public partial class frmCliente : Form
    {
        private ConexionSQL conexionSQL = new ConexionSQL();
        MantenimientoClientes mante = new MantenimientoClientes();

        int codigo = 0;

        public frmCliente()
        {
            InitializeComponent();
        }

        private void LlenardgvClientes()
        {
            using (SqlConnection conexion = conexionSQL.AbrirConexion())
            {
                if (conexion != null)
                {
                    try
                    {
                        SqlCommand comando = new SqlCommand("SELECT * FROM Clientes", conexion);
                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataTable tablaCabañas = new DataTable();
                        adaptador.Fill(tablaCabañas);

                        dgvClientes.DataSource = tablaCabañas;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al llenar el DataGridView: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void limpiar()
        {
            txtDNICliente.Text = "";
            txtNombreCliente.Text = "";
            txtApellidoCliente.Text = "";
            txtEmpresaCliente.Text = "";
            txtCelularCliente.Text = "";
            txtProcedenciaCliente.Text = "";
            txtEmpresaCliente.Text = "";
        }

        private void CargarDatos()
        {
            LlenardgvClientes();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            frmConsultaFechas calendario = new frmConsultaFechas();
            calendario.Show();
            this.Hide();

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void panelCliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReservacion_Click(object sender, EventArgs e)
        {
            frmInicio inicio = new frmInicio();
            inicio.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string nombreCliente = txtNombreCliente.Text;
            frmReserva_Servicios detalles = new frmReserva_Servicios(nombreCliente);
            detalles.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String DNI = txtDNICliente.Text, nombreCliente = txtNombreCliente.Text, apellidoCliente = txtApellidoCliente.Text, 
                correoCliente = txtEmailCliente.Text, telefonoCliente = txtCelularCliente.Text, procedenciaCliente = txtProcedenciaCliente.Text, empresaCliente = txtEmpresaCliente.Text; 

            mante.AccionesCabanhas(0, DNI, nombreCliente, apellidoCliente, correoCliente, telefonoCliente, procedenciaCliente, empresaCliente, "agregar");
            
            limpiar();
            CargarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            String DNI = txtDNICliente.Text, nombreCliente = txtNombreCliente.Text, apellidoCliente = txtApellidoCliente.Text,
                correoCliente = txtEmailCliente.Text, telefonoCliente = txtCelularCliente.Text, procedenciaCliente = txtProcedenciaCliente.Text, empresaCliente = txtEmpresaCliente.Text;

            mante.AccionesCabanhas(codigo, DNI, nombreCliente, apellidoCliente, correoCliente, telefonoCliente, procedenciaCliente, empresaCliente, "modificar");

            limpiar();
            CargarDatos();

        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = int.Parse(dgvClientes.CurrentRow.Cells[0].Value.ToString()); 
            txtDNICliente.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            txtNombreCliente.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            txtApellidoCliente.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            txtEmailCliente.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
            txtCelularCliente.Text = dgvClientes.CurrentRow.Cells[5].Value.ToString();
            txtProcedenciaCliente.Text = dgvClientes.CurrentRow.Cells[6].Value.ToString();
            txtEmpresaCliente.Text = dgvClientes.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String DNI = txtDNICliente.Text, nombreCliente = txtNombreCliente.Text, apellidoCliente = txtApellidoCliente.Text,
                correoCliente = txtEmailCliente.Text, telefonoCliente = txtCelularCliente.Text, procedenciaCliente = txtProcedenciaCliente.Text, empresaCliente = txtEmpresaCliente.Text;

            mante.AccionesCabanhas(codigo, DNI, nombreCliente, apellidoCliente, correoCliente, telefonoCliente, procedenciaCliente, empresaCliente, "eliminar");

            limpiar();
            CargarDatos();
        }
    }
}
