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
        String reservaAbrir = "";

        public frmReserva_Servicios(String NombreCliente, String CorreoCliente)
        {
            InitializeComponent();
            CargarCabañas();
            CargarServicios();
            lblCliente.Text = NombreCliente;
            lblCorreoCliente.Text = CorreoCliente;
            ExtraerID(NombreCliente);
            //dgvDetalleCabanhas.CellClick += dgvDetalleCabanhas_CellClick;
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

        public void ActualizarValor(string IDreserva, string cliente)
        {
            // Aquí puedes hacer lo que necesites con el valor recibido
            // Por ejemplo, podrías actualizar un control en este formulario
            reservaAbrir = IDreserva;

            // Consulta SQL para obtener los datos de las cabañas
            string queryCabanas = @"SELECT Reservas.ReservaID, DetalleReserva.CabanaID AS ID, Cabañas.Nombre AS Nombre, Cabañas.PrecioPorNoche AS Precio, CONVERT(date, DetalleReserva.FechaInicio) AS Inicio, CONVERT(date, DetalleReserva.FechaFin) AS Fin FROM Reservas LEFT JOIN DetalleReserva ON Reservas.ReservaID = DetalleReserva.ReservaID LEFT JOIN Cabañas ON DetalleReserva.CabanaID = Cabañas.CabanaID WHERE Reservas.ReservaID = @IDReserva;";

            // Consulta SQL para obtener los datos de los servicios
            string queryServicios = @"SELECT DetalleReservaServicios.ReservaID, ServiciosAdicionales.ServicioID AS ID, ServiciosAdicionales.Nombre AS Nombre, ServiciosAdicionales.Precio AS PrecioUnitario, DetalleReservaServicios.Cantidad, ServiciosAdicionales.Precio * DetalleReservaServicios.Cantidad AS Subtotal FROM DetalleReservaServicios LEFT JOIN ServiciosAdicionales ON DetalleReservaServicios.ServicioID = ServiciosAdicionales.ServicioID WHERE DetalleReservaServicios.ReservaID = @IDReserva;";

            // Cargar datos de las cabañas
            using (SqlConnection conexion = conexionSQL.AbrirConexion())
            {
                SqlCommand command = new SqlCommand(queryCabanas, conexion);
                command.Parameters.AddWithValue("@IDReserva", IDreserva);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable tableCabanas = new DataTable();
                adapter.Fill(tableCabanas);

                // Verificar si no hay columnas en el DataGridView
                if (dgvDetalleCabanhas.ColumnCount == 0)
                {
                    // Agregar las columnas al DataGridView
                    dgvDetalleCabanhas.Columns.Add("col1", "ID");
                    dgvDetalleCabanhas.Columns.Add("col2", "Nombre");
                    dgvDetalleCabanhas.Columns.Add("col3", "Precio");
                    dgvDetalleCabanhas.Columns.Add("col4", "Inicio");
                    dgvDetalleCabanhas.Columns.Add("col5", "Fin");
                    dgvDetalleCabanhas.Columns.Add("col6", "Subtotal");
                }

                // Agregar las filas al DataGridView
                foreach (DataRow row in tableCabanas.Rows)
                {
                    DateTime inicio = (DateTime)row["Inicio"];
                    DateTime fin = (DateTime)row["Fin"];
                    int dias = (int)(fin - inicio).TotalDays; // Calcular la diferencia de días
                    decimal precio = (decimal)row["Precio"];
                    decimal subtotal = precio * dias; // Calcular el subtotal

                    dgvDetalleCabanhas.Rows.Add(row["ID"], row["Nombre"], precio, inicio.ToString("d/M/yyyy"), fin.ToString("d/M/yyyy"), subtotal);
                }
            }


            // Cargar datos de los servicios
            using (SqlConnection conexion = conexionSQL.AbrirConexion())
            {
                SqlCommand command = new SqlCommand(queryServicios, conexion);
                command.Parameters.AddWithValue("@IDReserva", IDreserva);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable tableServicios = new DataTable();
                adapter.Fill(tableServicios);

                // Verificar si no hay columnas en el DataGridView
                if (dgvDetalleServicios.ColumnCount == 0)
                {
                    // Agregar las columnas al DataGridView
                    dgvDetalleServicios.Columns.Add("col1", "ID");
                    dgvDetalleServicios.Columns.Add("col2", "Nombre");
                    dgvDetalleServicios.Columns.Add("col3", "Precio");
                    dgvDetalleServicios.Columns.Add("col4", "Cantidad");
                    dgvDetalleServicios.Columns.Add("col5", "Subtotal");
                }

                // Agregar las filas al DataGridView
                foreach (DataRow row in tableServicios.Rows)
                {
                    dgvDetalleServicios.Rows.Add(row["ID"], row["Nombre"], row["PrecioUnitario"], row["Cantidad"], row["Subtotal"]);
                }
            }

            CalcularTotal();
            ExtraerID(cliente);
            lblCliente.Text = cliente.ToString();


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
                            DataGridViewCell primeraCelda = dgvDetalleCabanhas.Rows[0].Cells[0];
                            String valor = primeraCelda.Value.ToString();

                            SqlCommand commandReserva = new SqlCommand("INSERT INTO Reservas (ClienteID, CabanaID, Estado) VALUES (@ClienteID, @CabanaID, 'Confirmada'); SELECT SCOPE_IDENTITY();", conexion, transaction);
                            commandReserva.Parameters.AddWithValue("@CabanaID", valor);
                            commandReserva.Parameters.AddWithValue("@ClienteID", clienteID);

                            int reservaID = Convert.ToInt32(commandReserva.ExecuteScalar());

                            foreach (DataGridViewRow fila in dgvDetalleCabanhas.Rows)
                            {
                                if (!fila.IsNewRow)
                                {
                                    DateTime fechaInicio = Convert.ToDateTime(fila.Cells[3].Value);
                                    DateTime fechaFin = Convert.ToDateTime(fila.Cells[4].Value);
                                    string cabanaID = fila.Cells[0].Value.ToString();

                                    SqlCommand commandDetalleReserva = new SqlCommand("INSERT INTO DetalleReserva (ReservaID, CabanaID, FechaInicio, FechaFin) VALUES (@ReservaID, @CabanaID, @FechaInicio, @FechaFin);", conexion, transaction);
                                    commandDetalleReserva.Parameters.AddWithValue("@ReservaID", reservaID);
                                    commandDetalleReserva.Parameters.AddWithValue("@CabanaID", cabanaID);
                                    commandDetalleReserva.Parameters.AddWithValue("@FechaInicio", fechaInicio); // Supongamos que obtienes la fechaInicio de alguna manera
                                    commandDetalleReserva.Parameters.AddWithValue("@FechaFin", fechaFin); // Supongamos que obtienes la fechaFin de alguna manera

                                    commandDetalleReserva.ExecuteNonQuery();
                                }
                            }

                            // Insertar los servicios adicionales asociados a la reserva en la tabla DetalleReservaServicios
                            foreach (DataGridViewRow filaServicio in dgvDetalleServicios.Rows)
                            {
                                if (!filaServicio.IsNewRow)
                                {
                                    string servicioID = filaServicio.Cells[0].Value.ToString();
                                    int cantidad = Convert.ToInt32(filaServicio.Cells[3].Value);

                                    SqlCommand commandDetalleServicio = new SqlCommand("INSERT INTO DetalleReservaServicios (ReservaID, ServicioID, Cantidad) VALUES (@ReservaID, @ServicioID, @Cantidad);", conexion, transaction);
                                    commandDetalleServicio.Parameters.AddWithValue("@ReservaID", reservaID);
                                    commandDetalleServicio.Parameters.AddWithValue("@ServicioID", servicioID);
                                    commandDetalleServicio.Parameters.AddWithValue("@Cantidad", cantidad);

                                    commandDetalleServicio.ExecuteNonQuery();
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido una excepción: \n\n" +
                    "Mensaje: " + ex.Message + "\n\n" +
                    "Stack Trace: " + ex.StackTrace);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAbrirReserva abrir = new frmAbrirReserva();
            abrir.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnActualizarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = conexionSQL.AbrirConexion())
                {
                    String label = lblCodigo.Text;
                    int clienteID = int.Parse(label);
                    String reservaID = "";

                    // Obtener el ID de la reserva de la primera fila del DataGridView
                    if (dgvDetalleCabanhas.Rows.Count > 0)
                    {
                        reservaID = reservaAbrir; // Variable para almacenar el ID de la reserva
                    }
                    else
                    {
                        MessageBox.Show("Debe agregar al menos una cabaña para actualizar la reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    using (SqlTransaction transaction = conexion.BeginTransaction())
                    {
                        try
                        {
                            // Actualizar la reserva
                            SqlCommand commandReserva = new SqlCommand("UPDATE Reservas SET ClienteID = @ClienteID WHERE ReservaID = @ReservaID", conexion, transaction);
                            commandReserva.Parameters.AddWithValue("@ReservaID", reservaID);
                            commandReserva.Parameters.AddWithValue("@ClienteID", clienteID);
                            commandReserva.ExecuteNonQuery();

                            // Eliminar los detalles de reserva existentes
                            SqlCommand commandDeleteDetalles = new SqlCommand("DELETE FROM DetalleReserva WHERE ReservaID = @ReservaID", conexion, transaction);
                            commandDeleteDetalles.Parameters.AddWithValue("@ReservaID", reservaID);
                            commandDeleteDetalles.ExecuteNonQuery();

                            // Eliminar los servicios adicionales existentes
                            SqlCommand commandDeleteServicios = new SqlCommand("DELETE FROM DetalleReservaServicios WHERE ReservaID = @ReservaID", conexion, transaction);
                            commandDeleteServicios.Parameters.AddWithValue("@ReservaID", reservaID);
                            commandDeleteServicios.ExecuteNonQuery();

                            // Agregar los nuevos detalles de reserva
                            foreach (DataGridViewRow fila in dgvDetalleCabanhas.Rows)
                            {
                                if (!fila.IsNewRow)
                                {
                                    DateTime fechaInicio = Convert.ToDateTime(fila.Cells[3].Value);
                                    DateTime fechaFin = Convert.ToDateTime(fila.Cells[4].Value);
                                    string cabanaID = fila.Cells[0].Value.ToString();

                                    SqlCommand commandDetalleReserva = new SqlCommand("INSERT INTO DetalleReserva (ReservaID, CabanaID, FechaInicio, FechaFin) VALUES (@ReservaID, @CabanaID, @FechaInicio, @FechaFin);", conexion, transaction);
                                    commandDetalleReserva.Parameters.AddWithValue("@ReservaID", reservaID);
                                    commandDetalleReserva.Parameters.AddWithValue("@CabanaID", cabanaID);
                                    commandDetalleReserva.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                                    commandDetalleReserva.Parameters.AddWithValue("@FechaFin", fechaFin);
                                    commandDetalleReserva.ExecuteNonQuery();
                                }
                            }

                            // Agregar los nuevos servicios adicionales
                            foreach (DataGridViewRow filaServicio in dgvDetalleServicios.Rows)
                            {
                                if (!filaServicio.IsNewRow)
                                {
                                    string servicioID = filaServicio.Cells[0].Value.ToString();
                                    int cantidad = Convert.ToInt32(filaServicio.Cells[3].Value);

                                    SqlCommand commandDetalleServicio = new SqlCommand("INSERT INTO DetalleReservaServicios (ReservaID, ServicioID, Cantidad) VALUES (@ReservaID, @ServicioID, @Cantidad);", conexion, transaction);
                                    commandDetalleServicio.Parameters.AddWithValue("@ReservaID", reservaID);
                                    commandDetalleServicio.Parameters.AddWithValue("@ServicioID", servicioID);
                                    commandDetalleServicio.Parameters.AddWithValue("@Cantidad", cantidad);
                                    commandDetalleServicio.ExecuteNonQuery();
                                }
                            }

                            transaction.Commit();
                            MessageBox.Show("Reserva actualizada correctamente.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al ejecutar la transacción: " + ex.Message);
                            transaction.Rollback();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido una excepción: \n\n" +
                    "Mensaje: " + ex.Message + "\n\n" +
                    "Stack Trace: " + ex.StackTrace);
            }
        }

        private void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
            List<int> columnasExcluidas = new List<int> { 0, 2 }; // Excluir la tercera columna (índice 2) y la quinta columna (índice 4)
            string detalleCabanas = ObtenerDetallesDataGridView(dgvDetalleCabanhas, columnasExcluidas);
            string detalleServicios = ObtenerDetallesDataGridView(dgvDetalleServicios, columnasExcluidas);
            string nombreCliente = lblCliente.Text;
            string correoCliente = lblCorreoCliente.Text;

            // Construir el mensaje de correo electrónico
            string mensajeCorreo = frmEnviarReservacion.ConstruirMensajeCorreo(detalleCabanas, detalleServicios);

            // Crear instancia de frmEnviarReservacion y pasar los detalles
            frmEnviarReservacion enviarReservacionForm = new frmEnviarReservacion(detalleCabanas, detalleServicios, nombreCliente, correoCliente);
            enviarReservacionForm.Show();
        }

        private string ObtenerDetallesDataGridView(DataGridView dgv, List<int> excludedColumnIndexes)
        {
            StringBuilder detallesBuilder = new StringBuilder();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    if (!excludedColumnIndexes.Contains(i)) // Omitir las columnas excluidas
                    {
                        detallesBuilder.Append(row.Cells[i].Value.ToString() + "\t");
                    }
                }
                detallesBuilder.AppendLine();
            }

            return detallesBuilder.ToString();
        }

        private void dgvDetalleServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDetalleCabanhas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalleCabanhas.CurrentRow != null)
            {
                DataGridViewRow filaSeleccionada = dgvDetalleCabanhas.CurrentRow;

                // Obtener el ID de la fila seleccionada usando el índice de la columna
                string id = filaSeleccionada.Cells[0].Value.ToString();

                // Iterar sobre los elementos del ComboBox para encontrar la coincidencia
                for (int i = 0; i < cmbCabanhas.Items.Count; i++)
                {
                    // Obtener el texto del ComboBox y dividirlo por el separador " - "
                    string textoComboBox = cmbCabanhas.Items[i].ToString();
                    string[] partes = textoComboBox.Split(new string[] { " - " }, StringSplitOptions.None);
                    MessageBox.Show("partes 0> " + partes[0]);
                    // Verificar si la primera parte del ComboBox (ID) coincide con el ID de la fila seleccionada
                    if (partes.Length > 0 && partes[0].Trim() == id)
                    {
                        // Si hay coincidencia, seleccionar ese elemento en el ComboBox
                        cmbCabanhas.SelectedIndex = i;
                        break; // Salir del bucle una vez que se encuentra la coincidencia
                    }
                }



                // Obtener los valores de las celdas de la fila seleccionada
                string nombre = filaSeleccionada.Cells[1].Value.ToString();
                string precio = filaSeleccionada.Cells[2].Value.ToString();
                DateTime fechaInicio = Convert.ToDateTime(filaSeleccionada.Cells[3].Value);
                DateTime fechaFin = Convert.ToDateTime(filaSeleccionada.Cells[4].Value);

                // Establecer los valores en los controles correspondientes
                dtpInicioEstadia.Value = fechaInicio;
                dtpFinEstadia.Value = fechaFin;
            }

        }
    }
}