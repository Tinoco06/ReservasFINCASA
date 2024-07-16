using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private bool esReserva;
        public frmCliente(bool esReserva)
        {
            InitializeComponent();

            if (!esReserva)
            {
                btnCotizar.Visible = true;
                btnCabanasServicios.Visible = false;
            }
            else
            {
                btnCotizar.Visible = false;
                btnCabanasServicios.Visible = true;
            }

        }


        // Método para actualizar el texto del Label
        public void SetInstrucciones(string mensaje)
        {
            lblInstrucciones.Text = mensaje;
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
            CargarGrids.LlenarCRUDClientes(dgvClientes);
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
            if (!VerificarCampos())
            {
                MessageBox.Show("Por favor, completa todos los campos requeridos.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string apellidoCliente = txtApellidoCliente.Text, correoCliente = txtEmailCliente.Text, nombreCliente = txtNombreCliente.Text, clienteDNI = txtDNICliente.Text;
                frmReservaServicios detalles = new frmReservaServicios(nombreCliente, correoCliente, apellidoCliente, clienteDNI, true);
                detalles.Show();
                this.Close();
            }

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
            string nombreSinEspacios = ClsValidar.EliminarEspacios(txtNombreCliente.Text);
            string apellidoSinEspacios = ClsValidar.EliminarEspacios(txtApellidoCliente.Text);

            ClsValidar.ValidarEmailTextBox(txtEmailCliente);

            // Verifica si todos los campos están vacíos
            if (!VerificarCampos())
            {
                MessageBox.Show("Por favor, completa todos los campos requeridos.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Realiza las validaciones individuales
            if (txtEmailCliente.BackColor == System.Drawing.Color.LightCoral)
            {
                MessageBox.Show("El correo electrónico ingresado no es válido.");
                txtEmailCliente.Focus();
                return;
            }

            if (!ClsValidar.ValidarLongitudMinima(txtDNICliente.Text, 13))
            {
                MessageBox.Show("El DNI debe tener al menos 13 caracteres.");
                txtDNICliente.Focus();
                return;
            }

            if (!ClsValidar.ValidarLongitudMinima(nombreSinEspacios, 3))
            {
                MessageBox.Show("Ingrese un nombre válido.");
                txtNombreCliente.Focus();
                return;
            }

            if (!ClsValidar.ValidarLongitudMinima(apellidoSinEspacios, 3))
            {
                MessageBox.Show("Ingrese un apellido válido.");
                txtApellidoCliente.Focus();
                return;
            }

            if (!ClsValidar.ValidarLongitudMinima(txtCelularCliente.Text, 8))
            {
                MessageBox.Show("El Número de teléfono debe tener al menos 8 dígitos.");
                txtCelularCliente.Focus();
                return;
            }

            if (!ClsValidar.ValidarLongitudMinima(txtEmailCliente.Text, 3))
            {
                MessageBox.Show("El Email debe tener al menos 3 caracteres.");
                txtEmailCliente.Focus();
                return;
            }

            if (!ClsValidar.ValidarLongitudMinima(txtProcedenciaCliente.Text, 3))
            {
                MessageBox.Show("El lugar de procedencia debe tener al menos 3 caracteres.");
                txtProcedenciaCliente.Focus();
                return;
            }

            // Valida el campo de empresa
            if (!ClsValidar.ValidarEmpresaTextBox(txtEmpresaCliente))
            {
                MessageBox.Show("El nombre de la empresa debe tener al menos 3 caracteres.");
                txtEmpresaCliente.Focus();
                return;
            }

            // Si todas las validaciones pasan
            String DNI = txtDNICliente.Text, nombreCliente = txtNombreCliente.Text, apellidoCliente = txtApellidoCliente.Text,
            correoCliente = txtEmailCliente.Text, telefonoCliente = txtCelularCliente.Text, procedenciaCliente = txtProcedenciaCliente.Text, empresaCliente = txtEmpresaCliente.Text;

            mante.AccionesClientes(codigo, DNI, nombreCliente, apellidoCliente, correoCliente, telefonoCliente, procedenciaCliente, empresaCliente, "agregar");

            limpiar();
            CargarDatos();
            btnAgregar.Enabled = true;
            txtDNICliente.Enabled = true;
        }

        ////Botón para moficar clientes mediante la clase MantenimientoClientes con sus respectivos parámetros
        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombreSinEspacios = ClsValidar.EliminarEspacios(txtNombreCliente.Text);
            string apellidoSinEspacios = ClsValidar.EliminarEspacios(txtApellidoCliente.Text);

            ClsValidar.ValidarEmailTextBox(txtEmailCliente);

            // Verifica si todos los campos están vacíos
            if (!VerificarCampos())
            {
                MessageBox.Show("Por favor, completa todos los campos requeridos.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Realiza las validaciones individuales
            if (txtEmailCliente.BackColor == System.Drawing.Color.LightCoral)
            {
                MessageBox.Show("El correo electrónico ingresado no es válido.");
                txtEmailCliente.Focus();
                return;
            }

            if (!ClsValidar.ValidarLongitudMinima(txtDNICliente.Text, 13))
            {
                MessageBox.Show("El DNI debe tener al menos 13 caracteres.");
                txtDNICliente.Focus();
                return;
            }

            if (!ClsValidar.ValidarLongitudMinima(nombreSinEspacios, 3))
            {
                MessageBox.Show("Ingrese un nombre válido.");
                txtNombreCliente.Focus();
                return;
            }

            if (!ClsValidar.ValidarLongitudMinima(apellidoSinEspacios, 3))
            {
                MessageBox.Show("Ingrese un apellido válido.");
                txtApellidoCliente.Focus();
                return;
            }

            if (!ClsValidar.ValidarLongitudMinima(txtCelularCliente.Text, 8))
            {
                MessageBox.Show("El Número de teléfono debe tener al menos 8 dígitos.");
                txtCelularCliente.Focus();
                return;
            }

            if (!ClsValidar.ValidarLongitudMinima(txtEmailCliente.Text, 3))
            {
                MessageBox.Show("El Email debe tener al menos 3 caracteres.");
                txtEmailCliente.Focus();
                return;
            }

            if (!ClsValidar.ValidarLongitudMinima(txtProcedenciaCliente.Text, 3))
            {
                MessageBox.Show("El lugar de procedencia debe tener al menos 3 caracteres.");
                txtProcedenciaCliente.Focus();
                return;
            }

            // Valida el campo de empresa
            if (!ClsValidar.ValidarEmpresaTextBox(txtEmpresaCliente))
            {
                MessageBox.Show("El nombre de la empresa debe tener al menos 3 caracteres.");
                txtEmpresaCliente.Focus();
                return;
            }

            // Si todas las validaciones pasan
            String DNI = txtDNICliente.Text, nombreCliente = txtNombreCliente.Text, apellidoCliente = txtApellidoCliente.Text,
            correoCliente = txtEmailCliente.Text, telefonoCliente = txtCelularCliente.Text, procedenciaCliente = txtProcedenciaCliente.Text, empresaCliente = txtEmpresaCliente.Text;

            mante.AccionesClientes(codigo, DNI, nombreCliente, apellidoCliente, correoCliente, telefonoCliente, procedenciaCliente, empresaCliente, "modificar");

            limpiar();
            CargarDatos();
            btnAgregar.Enabled = true;
            txtDNICliente.Enabled = true;
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
            btnAgregar.Enabled = false;
            txtDNICliente.Enabled = false;
        }

        //Botón para eliminar clientes mediante la clase MantenimientoClientes con sus respectivos parámetros
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!VerificarCampos())
            {
                MessageBox.Show("Por favor, seleccione un cliente para eliminar.", "No ha hecho una selección.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                String DNI = txtDNICliente.Text, nombreCliente = txtNombreCliente.Text, apellidoCliente = txtApellidoCliente.Text,
                correoCliente = txtEmailCliente.Text, telefonoCliente = txtCelularCliente.Text, procedenciaCliente = txtProcedenciaCliente.Text, empresaCliente = txtEmpresaCliente.Text;

                mante.AccionesClientes(codigo, DNI, nombreCliente, apellidoCliente, correoCliente, telefonoCliente, procedenciaCliente, empresaCliente, "eliminar");

                limpiar();
                CargarDatos();

                btnAgregar.Enabled = true;
            }

            
        }

        private void txtDNICliente_TextChanged(object sender, EventArgs e)
        {

            ClsValidar.ValidarDNI(txtDNICliente);
            txtDNICliente.MaxLength = 13;
        }

        private void txtCelularCliente_TextChanged(object sender, EventArgs e)
        {
            ClsValidar.ValidarTelefono(txtCelularCliente);
            txtCelularCliente.MaxLength = 8;
        }

        private void txtCelularCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        //Verificar campos vacíos
        private bool VerificarCampos()
        {
            // Verificar si cada textbox no está vacío
            if (string.IsNullOrWhiteSpace(txtDNICliente.Text))
                return false;
            if (string.IsNullOrWhiteSpace(txtNombreCliente.Text))
                return false;
            if (string.IsNullOrWhiteSpace(txtApellidoCliente.Text))
                return false;
            if (string.IsNullOrWhiteSpace(txtEmailCliente.Text))
                return false;
            if (string.IsNullOrWhiteSpace(txtCelularCliente.Text))
                return false;
            if (string.IsNullOrWhiteSpace(txtProcedenciaCliente.Text))
                return false;


            // Si todos los campos requeridos están llenos retorna verdadero
            return true;
        }


        private void btnCotizar_Click(object sender, EventArgs e)
        {
            if (!VerificarCampos())
            {
                MessageBox.Show("Por favor, completa todos los campos requeridos.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string apellidoCliente = txtApellidoCliente.Text, correoCliente = txtEmailCliente.Text, nombreCliente = txtNombreCliente.Text, clienteDNI = txtDNICliente.Text;
                frmReservaServicios detalles = new frmReservaServicios(nombreCliente, correoCliente, apellidoCliente, clienteDNI, false);
                detalles.Show();
                this.Close();
            }
        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {
            ClsValidar.ValidarNombreApellidoTextBox(txtNombreCliente);
        }

        private void txtApellidoCliente_TextChanged(object sender, EventArgs e)
        {
            ClsValidar.ValidarNombreApellidoTextBox(txtApellidoCliente);
        }

        private void txtEmailCliente_TextChanged(object sender, EventArgs e)
        {
            ClsValidar.ValidarEmailTextBox(txtEmailCliente);
        }

        private void txtProcedenciaCliente_TextChanged(object sender, EventArgs e)
        {
            ClsValidar.ValidarLugarProcedenciaTextBox(txtProcedenciaCliente);
        }

        private void txtEmpresaCliente_TextChanged(object sender, EventArgs e)
        {
            ClsValidar.ValidarEmpresaTextBox(txtEmpresaCliente);
        }
        private bool ExisteDniEnGrid(string dni)
        {
            foreach (DataGridViewRow row in dgvClientes.Rows)
            {
                if (row.Cells["DNI"].Value.ToString().Equals(dni))
                {
                    return true; // Se encontró una coincidencia
                }
            }
            return false; // No se encontró una coincidencia
        }
    }
}

