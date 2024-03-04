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
        //Instancias para conexión y clase MantenimientoClientes
        private ConexionSQL conexionSQL = new ConexionSQL();
        MantenimientoClientes mante = new MantenimientoClientes();

        //Variable que permite extraer el codigo del cliente y hacer las modificaciones
        int codigo = 0;

        public frmCliente()
        {
            InitializeComponent();
        }

        //Función para llenar el grid de cliente
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

        //Función para limpiar los controles del formulario
        public void limpiar()
        {
            txtDNICliente.Text = "";
            txtNombreCliente.Text = "";
            txtApellidoCliente.Text = "";
            txtEmpresaCliente.Text = "";
            txtEmailCliente.Text = "";
            txtCelularCliente.Text = "";
            txtProcedenciaCliente.Text = "";
            txtEmpresaCliente.Text = "";
        }

        //Cargar datos
        private void CargarDatos()
        {
            LlenardgvClientes();
        }

        //Llenar el grid cuando se cargue el form
        private void frmCliente_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        //Botón volver a inicio
        private void btnRegresarInicio_Click(object sender, EventArgs e)
        {
            frmInicio inicio = new frmInicio();
            inicio.Show();
            this.Hide();
        }

        //Boton para hacer la reserva de cabañas y servicios, envía el nombre del cliente
        private void btnCabanasServicios_Click(object sender, EventArgs e)
        {
            string nombreCliente = txtNombreCliente.Text, correoCliente = txtEmailCliente.Text;
            
            frmReserva_Servicios detalles = new frmReserva_Servicios(nombreCliente, correoCliente);
            detalles.Show();
            this.Hide();
        }

        //Minimizar pantalla
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Cerrar programa
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        //Botón para agregar clientes mediante la clase MantenimientoClientes con sus respectivos parámetros
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String DNI = txtDNICliente.Text, nombreCliente = txtNombreCliente.Text, apellidoCliente = txtApellidoCliente.Text, 
                correoCliente = txtEmailCliente.Text, telefonoCliente = txtCelularCliente.Text, procedenciaCliente = txtProcedenciaCliente.Text, empresaCliente = txtEmpresaCliente.Text; 

            mante.AccionesClientes(0, DNI, nombreCliente, apellidoCliente, correoCliente, telefonoCliente, procedenciaCliente, empresaCliente, "agregar");
            
            limpiar();
            CargarDatos();
        }

        ////Botón para moficar clientes mediante la clase MantenimientoClientes con sus respectivos parámetros
        private void btnModificar_Click(object sender, EventArgs e)
        {
            String DNI = txtDNICliente.Text, nombreCliente = txtNombreCliente.Text, apellidoCliente = txtApellidoCliente.Text,
                correoCliente = txtEmailCliente.Text, telefonoCliente = txtCelularCliente.Text, procedenciaCliente = txtProcedenciaCliente.Text, empresaCliente = txtEmpresaCliente.Text;

            mante.AccionesClientes(codigo, DNI, nombreCliente, apellidoCliente, correoCliente, telefonoCliente, procedenciaCliente, empresaCliente, "modificar");

            limpiar();
            CargarDatos();

        }

        //Regresar los datos del grid a los controles del form
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

        //Botón para eliminar clientes mediante la clase MantenimientoClientes con sus respectivos parámetros
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String DNI = txtDNICliente.Text, nombreCliente = txtNombreCliente.Text, apellidoCliente = txtApellidoCliente.Text,
                correoCliente = txtEmailCliente.Text, telefonoCliente = txtCelularCliente.Text, procedenciaCliente = txtProcedenciaCliente.Text, empresaCliente = txtEmpresaCliente.Text;

            mante.AccionesClientes(codigo, DNI, nombreCliente, apellidoCliente, correoCliente, telefonoCliente, procedenciaCliente, empresaCliente, "eliminar");

            limpiar();
            CargarDatos();
        }
    }
}
