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
    
    public partial class frmAbrirReserva : Form
    {
        //Instancias de conexión y clases
        private ConexionSQL conexionSQL = new ConexionSQL();
        MostrarReservas mostrar = new MostrarReservas();

        public frmAbrirReserva()
        {
            InitializeComponent();
            MostrarReservas mostrar = new MostrarReservas();
            CargarReservas();
        }

        //Llenar el datagrid view de reservas
        private void CargarReservas()
        {
            try
            {
                // Abre la conexión a la base de datos
                using (SqlConnection conexion = conexionSQL.AbrirConexion())
                {

                    // Crear el comando para ejecutar el procedimiento almacenado
                    SqlCommand command = new SqlCommand("SP_MOSTRAR_RESERVAS", conexion);
                    command.CommandType = CommandType.StoredProcedure;

                    // Crear un SqlDataAdapter para ejecutar el comando y llenar un DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvDetalleReserva.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las reservas: " + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVolverCliente_Click(object sender, EventArgs e)
        {
            frmReserva_Servicios reservas = new frmReserva_Servicios("", "");
            reservas.Show();
            this.Hide();
        }

        private void frmAbrirReserva_Load(object sender, EventArgs e)
        {

        }

        private void txtBuscarDNI_TextChanged(object sender, EventArgs e)
        {
            BusquedaDNI();
        }

        private void BusquedaDNI()
        {
            string buscarDNI = txtBuscarDNI.Text.Trim();

            // Obtener la tabla de datos actual del DataGridView (si está enlazado a un origen de datos)
            DataTable tabla = (DataTable)dgvDetalleReserva.DataSource;

            if (tabla != null)
            {
                // Crear una expresión de filtro para buscar coincidencias parciales 
                string filtro = $"NumeroIdentidadCliente LIKE '%{buscarDNI}%'";

                // Aplicar el filtro a la tabla de datos
                tabla.DefaultView.RowFilter = filtro;
            }
        }

        //Función para enviar el numero de reserva que se va cargar
        private void dgvDetalleReserva_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //e para el evento cellclick del datagrid
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvDetalleReserva.Rows[e.RowIndex];

                // Extraer el valor de la primera posición del arreglo seleccionado
                string valor = selectedRow.Cells[0].Value.ToString();
                string nombreCliente = selectedRow.Cells[2].Value.ToString();
                string correocliente = selectedRow.Cells[3].Value.ToString();

                frmReserva_Servicios reservas = new frmReserva_Servicios("",correocliente);
                reservas.ActualizarValor(valor, nombreCliente);
                reservas.Show();
                this.Hide();    
            }
        }

        private void dgvDetalleReserva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
