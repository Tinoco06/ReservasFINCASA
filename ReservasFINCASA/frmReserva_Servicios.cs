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
using static ReservasFINCASA.frmReserva_Servicios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ReservasFINCASA
{
    public partial class frmReserva_Servicios : Form
    {

        private ConexionSQL conexionSQL = new ConexionSQL();


        public frmReserva_Servicios(String NombreCliente)
        {
            InitializeComponent();
            CargarCabañas();
            CargarServicios();
            lblCliente.Text = NombreCliente;
            ExtraerID(NombreCliente);
        }

        public void ExtraerID(string Nombre)
        {
            using (SqlConnection conexion = conexionSQL.AbrirConexion())
            {
                if (conexion != null)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("SP_MOSTRAR_IDCLIENTE", conexion);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NombreCliente", Nombre);

                        // Obtener el resultado del procedimiento almacenado
                        object resultado = cmd.ExecuteScalar();

                        // Verificar si se devolvió un resultado
                        if (resultado != null)
                        {
                            // Asignar el resultado al texto de la etiqueta
                            lblCodigo.Text = resultado.ToString();
                        }
                        else
                        {
                            // Manejar el caso en el que no se encuentre un ClienteID para el nombre dado
                            lblCodigo.Text = "No se encontró un ClienteID para el nombre especificado.";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }


        private void CargarCabañas()
        {
            using (SqlConnection conexion = conexionSQL.AbrirConexion())
            {
                using (SqlCommand command = new SqlCommand("SP_LLENAR_CABANAS", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    cmbCabanhas.DisplayMember = "DisplayText";
                    cmbCabanhas.ValueMember = "CabanaID";
                    cmbCabanhas.DataSource = dataTable;

                }
            }
        }

        private void CargarServicios()
        {
            using (SqlConnection conexion = conexionSQL.AbrirConexion())
            {
                using (SqlCommand command = new SqlCommand("SP_LLENAR_SERVICIOS", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    cmbServicioAdicional.DisplayMember = "DisplayText";
                    cmbServicioAdicional.ValueMember = "ServicioID";
                    cmbServicioAdicional.DataSource = dataTable;

                }
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void cmbCabanhas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmReserva_Servicios_Load(object sender, EventArgs e)
        {


        }

        private void CalcularTotal()
        {
            decimal totalCabanhas = 0;
            decimal totalServicios = 0;

            // Sumar los subtotales en el DataGridView dvgDetalleCabanhas
            foreach (DataGridViewRow row in dgvDetalleCabanhas.Rows)
            {
                if (!row.IsNewRow) // Verificar si la fila no es la fila de nuevo ingreso
                {
                    totalCabanhas += Convert.ToDecimal(row.Cells[5].Value); // La columna "Subtotal" está en la posición 5
                }
            }

            // Sumar los subtotales en el DataGridView dgvDetalleServicios
            foreach (DataGridViewRow row in dgvDetalleServicios.Rows)
            {
                if (!row.IsNewRow) // Verificar si la fila no es la fila de nuevo ingreso
                {
                    totalServicios += Convert.ToDecimal(row.Cells[4].Value); // La columna "Subtotal" está en la posición 4
                }
            }

            // Calcular el total general sumando los subtotales de ambos DataGridViews
            decimal totalGeneral = totalCabanhas + totalServicios;

            // Mostrar el total en el Label lblTotal
            lblTotal.Text = "L " + totalGeneral.ToString("N2"); // "N2" formatea el número con dos decimales
        }

        // Método que se llamará desde un botón para calcular el total
        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            // Verificar si ambos DataGridViews tienen datos
            if (dgvDetalleCabanhas.Rows.Count > 0 && dgvDetalleServicios.Rows.Count > 0)
            {
                CalcularTotal();
            }
            else
            {
                MessageBox.Show("Debe agregar datos a los DataGridViews antes de calcular el total.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void limpiarCabanas()
        {
            dtpFinEstadia.Value = DateTime.Today;
            dtpInicioEstadia.Value = DateTime.Today;
            cmbCabanhas.SelectedIndex = 0;
        }

        private void limpiarServicios()
        {
            cmbServicioAdicional.SelectedIndex = 0;
            txtCantidadServicios.Text = "";
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {

            //Extraer los datos de los controles del formulario
            string textoComboBox = cmbCabanhas.Text;
            DateTime fechaInicio = dtpInicioEstadia.Value.Date;
            DateTime fechaFin = dtpFinEstadia.Value.Date;
            int diferenciaDias = (int)(fechaFin - fechaInicio).TotalDays;


            // Verificar si la diferencia de días es al menos 1
            if (diferenciaDias >= 1)
            {
                // Dividir el texto del combobox para meterlo al grid
                string[] partes = textoComboBox.Split(new string[] { " - " }, StringSplitOptions.None);

                if (partes.Length >= 3)
                {
                    decimal precioCabaña = decimal.Parse(partes[2].Substring(2)); // Obtener el precio de la cabaña (eliminar el "L.")
                    decimal subtotal = precioCabaña * diferenciaDias;

                    // Agregar columnas del grid
                    if (dgvDetalleCabanhas.ColumnCount == 0)
                    {
                        dgvDetalleCabanhas.Columns.Add("col1", "ID");
                        dgvDetalleCabanhas.Columns.Add("col2", "Nombre");
                        dgvDetalleCabanhas.Columns.Add("col3", "Precio");
                        dgvDetalleCabanhas.Columns.Add("col4", "Inicio");
                        dgvDetalleCabanhas.Columns.Add("col5", "Fin");
                        dgvDetalleCabanhas.Columns.Add("col6", "Subtotal");
                    }

                    //Agregar una nueva fila al grid
                    dgvDetalleCabanhas.Rows.Add(partes[0], partes[1], partes[2], fechaInicio.ToShortDateString(), fechaFin.ToShortDateString(), subtotal);

                    limpiarCabanas();

                }
                else
                {
                    MessageBox.Show("El formato del texto seleccionado no es válido.");
                }
            }
            else
            {
                MessageBox.Show("La fecha de fin debe ser posterior a la fecha de inicio.");
            }

            CalcularTotal();


        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            string textoComboBox = cmbServicioAdicional.Text;
            int cantidad = 0; // Inicializamos la cantidad a cero por defecto

            // Verificar si la cantidad ingresada es un número válido
            if (!int.TryParse(txtCantidadServicios.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Dividir el texto del combobox para meterlo al grid
            string[] partes = textoComboBox.Split(new string[] { " - " }, StringSplitOptions.None);

            if (partes.Length >= 3)
            {
                decimal precioServicio = decimal.Parse(partes[2].Substring(2)); // Obtener el precio del servicio (eliminar el "L.")
                decimal subtotal = cantidad * precioServicio; // Calcular el subtotal

                // Agregar columnas al DataGridView si aún no existen
                if (dgvDetalleServicios.ColumnCount == 0)
                {
                    dgvDetalleServicios.Columns.Add("col1", "ID");
                    dgvDetalleServicios.Columns.Add("col2", "Nombre");
                    dgvDetalleServicios.Columns.Add("col3", "Precio");
                    dgvDetalleServicios.Columns.Add("col4", "Cantidad");
                    dgvDetalleServicios.Columns.Add("col5", "Subtotal");
                }

                //Agregar una nueva fila al DataGridView
                dgvDetalleServicios.Rows.Add(partes[0], partes[1], "L. " + precioServicio, cantidad, subtotal);

                // Limpia los controles después de agregar la fila
                limpiarServicios();
            }
            else
            {
                MessageBox.Show("El formato del texto seleccionado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CalcularTotal();
        }

        private void btnGuardarReserva_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection conexion = conexionSQL.AbrirConexion())
                {

                    String label = lblCodigo.Text;
                    int clienteID = int.Parse(label);

                    using (SqlTransaction transaction = conexion.BeginTransaction())
                    {
                        try
                        {
                            // Insertar la reserva
                            DataGridViewCell primeraCelda = dgvDetalleCabanhas.Rows[1].Cells[0];
                            String valor = primeraCelda.Value.ToString();

                            SqlCommand commandReserva = new SqlCommand("INSERT INTO Reservas (ClienteID, CabanaID, FechaInicio, FechaFin, Estado) VALUES (@ClienteID, @CabanaID, @FechaInicio, @FechaFin, 'Confirmada'); SELECT SCOPE_IDENTITY();", conexion, transaction);
                            commandReserva.Parameters.AddWithValue("@CabanaID", valor);
                            commandReserva.Parameters.AddWithValue("@ClienteID", clienteID);
                            commandReserva.Parameters.AddWithValue("@FechaInicio", dtpInicioEstadia.Value.Date);
                            commandReserva.Parameters.AddWithValue("@FechaFin", dtpFinEstadia.Value.Date);

                            int reservaID = Convert.ToInt32(commandReserva.ExecuteScalar());

                            // Insertar las cabañas asociadas a la reserva en la tabla DetalleReserva
                            foreach (DataGridViewRow fila in dgvDetalleCabanhas.Rows)
                            {
                                if (!fila.IsNewRow)
                                {
                                    string cabanaID = fila.Cells[0].Value.ToString();
                                    DateTime fechaInicio = Convert.ToDateTime(fila.Cells[3].Value);
                                    DateTime fechaFin = Convert.ToDateTime(fila.Cells[4].Value);

                                    SqlCommand commandDetalleReserva = new SqlCommand("INSERT INTO DetalleReserva (ReservaID, CabanaID, FechaInicio, FechaFin) VALUES (@ReservaID, @CabanaID, @FechaInicio, @FechaFin);", conexion, transaction);
                                    commandDetalleReserva.Parameters.AddWithValue("@ReservaID", reservaID);
                                    commandDetalleReserva.Parameters.AddWithValue("@CabanaID", cabanaID);
                                    commandDetalleReserva.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                                    commandDetalleReserva.Parameters.AddWithValue("@FechaFin", fechaFin);

                                    commandDetalleReserva.ExecuteNonQuery();
                                }
                            }

                            // Insertar los servicios adicionales asociados a la reserva en la tabla ReservaServicios
                            foreach (DataGridViewRow filaServicio in dgvDetalleServicios.Rows)
                            {
                                if (!filaServicio.IsNewRow)
                                {
                                    string servicioID = filaServicio.Cells[0].Value.ToString();

                                    SqlCommand commandServicio = new SqlCommand("INSERT INTO ReservaServicios (ReservaID, ServicioID) VALUES (@ReservaID, @ServicioID);", conexion, transaction);
                                    commandServicio.Parameters.AddWithValue("@ReservaID", reservaID);
                                    commandServicio.Parameters.AddWithValue("@ServicioID", servicioID);

                                    commandServicio.ExecuteNonQuery();
                                }
                            }

                            transaction.Commit();
                            MessageBox.Show("Reserva insertada correctamente.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al ejecutar la transacción: " + ex.Message);
                            transaction.Rollback();
                        }
                    }

                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido una excepción: \n\n" +
                    "Mensaje: " + ex.Message + "\n\n" +
                    "Stack Trace: " + ex.StackTrace);
            }
        }


    }
}

