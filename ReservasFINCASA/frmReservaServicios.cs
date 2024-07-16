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
using static ReservasFINCASA.frmReservaServicios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ReservasFINCASA
{
    public partial class frmReservaServicios : Form
    {
        private ConexionSQL conexionSQL = new ConexionSQL();
        String reservaAbrir = "";
        DataGridViewRow filaSeleccionada;



        private bool esReserva;
        private ClsValidar validador;

        // Constructor
        public frmReservaServicios(String NombreCliente, String CorreoCliente, String ApellidoCliente, String DNIcliente, bool esReserva)
        {
            InitializeComponent();
            validador = new ClsValidar();
            this.Load += new System.EventHandler(this.frmReservaServicios_Load);
            this.dtpInicioEstadia.ValueChanged += new System.EventHandler(this.dtpInicioEstadia_ValueChanged);
            this.dtpFinEstadia.ValueChanged += new System.EventHandler(this.dtpFinEstadia_ValueChanged);
            btnActualizarServicio.Enabled = false;
            btnActualizarCabana.Enabled = false;
            // Almacena el modo de apertura
            this.esReserva = esReserva;

            //Validar cantidad de servicios
            ClsValidar form1 = new ClsValidar();
            txtCantidadServicios.KeyPress += new KeyPressEventHandler(form1.Precio_KeyPress);

            // Lógica para ajustar los controles según el modo de apertura
            if (!esReserva)
            {

                CargarGrids.CargarCabañas(cmbCabanhas);
                CargarGrids.CargarServicios(cmbServicioAdicional);
                lblCliente.Text = NombreCliente + " " + ApellidoCliente;
                lblCorreoCliente.Text = CorreoCliente;
                lblClienteDNI.Text = DNIcliente;
                lblCodigo.Text = ManejoReservas.AccionesReserva.ObtenerIdClientePorNombre(NombreCliente);
                btnCotizar.Visible = true;
                btnFacturar.Visible = true;

            }
            else
            {
                CargarGrids.CargarCabañas(cmbCabanhas);
                CargarGrids.CargarServicios(cmbServicioAdicional);
                lblCliente.Text = NombreCliente + " " + ApellidoCliente;
                lblCorreoCliente.Text = CorreoCliente;
                lblClienteDNI.Text = DNIcliente;
                lblCodigo.Text = ManejoReservas.AccionesReserva.ObtenerIdClientePorNombre(NombreCliente);
                btnCotizar.Visible = false;
                btnFacturar.Visible = false;
            }
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


        private void btnVolverCliente_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente(true);
            cliente.Show();
            this.Hide();
        }


        private void btnFacturar_Click(object sender, EventArgs e)
        {

            string reservaID = lblIdReserva.Text;



            if (!ManejoReservas.AccionesReserva.EstaFacturada(reservaID))
            {
                ManejoReservas.AccionesReserva.FacturarReserva(reservaID);
                String NombreCliente = lblCliente.Text, ClienteDNI = lblClienteDNI.Text, TotalReserva = lblTotal.Text;

                frmFactura facturaForm = new frmFactura(NombreCliente, ClienteDNI, TotalReserva);
                foreach (DataGridViewRow row in dgvDetalleCabanhas.Rows)
                {
                    DateTime fechaInicio = Convert.ToDateTime(row.Cells[3].Value);
                    DateTime fechaFin = Convert.ToDateTime(row.Cells[4].Value);
                    int cantidad = (fechaFin.Date - fechaInicio.Date).Days;
                    string descripcion = row.Cells[1].Value.ToString();
                    decimal precioUnitario = Convert.ToDecimal(row.Cells[2].Value);

                    // Agrega la fila al DataGridView de la factura
                    facturaForm.AgregarFilaFactura(cantidad, descripcion, precioUnitario);
                }

                foreach (DataGridViewRow row in dgvDetalleServicios.Rows)
                {
                    int cantidad = Convert.ToInt32(row.Cells[3].Value);
                    string descripcion = row.Cells[1].Value.ToString();
                    decimal precioUnitario = Convert.ToDecimal(row.Cells[2].Value);

                    // Agrega la fila al DataGridView de la factura
                    facturaForm.AgregarFilaFactura(cantidad, descripcion, precioUnitario);
                }

                facturaForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Esta reserva ya ha sido facturada.");
            }

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
            // Configurar los DateTimePicker para que no acepten fechas pasadas
            dtpInicioEstadia.MinDate = DateTime.Now.Date;
            dtpFinEstadia.MinDate = DateTime.Now.Date;
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
                    totalCabanhas += Convert.ToDecimal(row.Cells[5].Value);
                }
            }

            // Sumar los subtotales en el DataGridView dgvDetalleServicios
            foreach (DataGridViewRow row in dgvDetalleServicios.Rows)
            {
                if (!row.IsNewRow) // Verificar si la fila no es la fila de nuevo ingreso
                {
                    totalServicios += Convert.ToDecimal(row.Cells[4].Value);
                }
            }

            // Calcular el total general sumando los subtotales de ambos DataGridViews
            decimal totalGeneral = totalCabanhas + totalServicios;

            // Mostrar el total en el Label lblTotal
            lblTotal.Text = totalGeneral.ToString("N2");
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
            // Extraer los datos de los controles del formulario
            string textoComboBox = cmbCabanhas.Text;
            DateTime fechaInicio = dtpInicioEstadia.Value.Date;
            DateTime fechaFin = dtpFinEstadia.Value.Date;
            int diferenciaDias = (int)(fechaFin - fechaInicio).TotalDays;

            // Verificar si la diferencia de días es al menos 1
            if (diferenciaDias >= 1)
            {
                // Dividir el texto del combobox para obtener el ID de la cabaña
                string[] partes = textoComboBox.Split(new string[] { " - " }, StringSplitOptions.None);
                string cabanaID = partes[0];

                // Verificar si el elemento ya existe en el DataGridView
                bool elementoExistente = false;
                foreach (DataGridViewRow fila in dgvDetalleCabanhas.Rows)
                {
                    if (fila.Cells[0].Value != null && fila.Cells[0].Value.ToString() == cabanaID)
                    {
                        elementoExistente = true;
                        break;
                    }
                }

                if (!elementoExistente)
                {
                    // Antes de agregar, verificar si la cabaña está disponible
                    if (ManejoReservas.AccionesReserva.EsCabanaDisponible(cabanaID, fechaInicio, fechaFin))
                    {
                        decimal precioCabaña = decimal.Parse(partes[2].Substring(2)); // Obtener el precio de la cabaña (eliminar el "L.")
                        decimal subtotal = precioCabaña * diferenciaDias;

                        // Agregar columnas del grid si aún no existen
                        if (dgvDetalleCabanhas.ColumnCount == 0)
                        {
                            dgvDetalleCabanhas.Columns.Add("col1", "ID");
                            dgvDetalleCabanhas.Columns.Add("col2", "Nombre");
                            dgvDetalleCabanhas.Columns.Add("col3", "Precio");
                            dgvDetalleCabanhas.Columns.Add("col4", "Inicio");
                            dgvDetalleCabanhas.Columns.Add("col5", "Fin");
                            dgvDetalleCabanhas.Columns.Add("col6", "Subtotal");
                        }

                        // Agregar la cabaña al DataGridView
                        dgvDetalleCabanhas.Rows.Add(cabanaID, partes[1], precioCabaña, fechaInicio.ToShortDateString(), fechaFin.ToShortDateString(), subtotal);
                        limpiarCabanas();
                    }
                    else
                    {
                        MessageBox.Show("La cabaña seleccionada no está disponible en las fechas indicadas.", "Indisponible", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Esta cabaña ya ha sido agregada a la reserva, por favor seleccione otra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("La fecha de fin debe ser posterior a la fecha de inicio.");
            }

            // Recalcular el total después de agregar o fallar en agregar la cabaña
            CalcularTotal();
        }


        public void ActualizarValor(string IDreserva, string cliente, string apellido, string DNIcliente)
        {
            reservaAbrir = IDreserva;

            // Consulta SQL para obtener los datos de las cabañas
            string queryCabanas = @"SELECT Clientes.Apellido, Reservas.ReservaID, DetalleReserva.CabanaID AS ID, Cabañas.Nombre AS Nombre, Cabañas.PrecioPorNoche AS Precio, CONVERT(date, DetalleReserva.FechaInicio) AS Inicio, CONVERT(date, DetalleReserva.FechaFin) AS Fin FROM Reservas LEFT JOIN DetalleReserva ON Reservas.ReservaID = DetalleReserva.ReservaID LEFT JOIN Cabañas ON DetalleReserva.CabanaID = Cabañas.CabanaID LEFT JOIN Clientes ON Reservas.ClienteID = Clientes.ClienteID WHERE Reservas.ReservaID = @IDReserva;";

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
            lblCodigo.Text = ManejoReservas.AccionesReserva.ObtenerIdClientePorNombre(cliente);
            lblClienteDNI.Text = DNIcliente;
            lblCliente.Text = $"{cliente} {apellido}";
            lblIdReserva.Text = reservaAbrir.ToString();
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

            // Verificar si el elemento ya existe en el DataGridView
            bool elementoExistente = false;
            foreach (DataGridViewRow fila in dgvDetalleServicios.Rows)
            {
                if (fila.Cells[0].Value != null && fila.Cells[0].Value.ToString() == partes[0])
                {
                    elementoExistente = true;
                    break;
                }
            }

            if (!elementoExistente)
            {
                decimal precioServicio = decimal.Parse(partes[2].Substring(2)); // Obtener el precio del servicio (eliminar el "L")
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

                //Agregar una nueva fila al DataGridView si el elemento no existe
                dgvDetalleServicios.Rows.Add(partes[0], partes[1], precioServicio, cantidad, subtotal);

                // Limpia los controles después de agregar la fila
                limpiarServicios();
            }
            else
            {
                MessageBox.Show("Este servicio ya ha sido agregado a la reserva, por favor seleccione otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            CalcularTotal();
        }

        //Funcion que permite guardar la reserva en la base de datos
        private void btnGuardarReserva_Click(object sender, EventArgs e)
        {

            if (ValidarReserva())
            {
                ManejoReservas.AccionesReserva.InsertarReserva(dgvDetalleCabanhas, dgvDetalleServicios, lblCodigo.Text);
                LimpiarForm();
            }


        }

        //Botón que permite abrir una reserva ya guardada
        private void btnAbrirReserva_Click(object sender, EventArgs e)
        {
            frmAbrirReserva abrir = new frmAbrirReserva();
            abrir.Show();
            this.Hide();
        }


        //Permite actualizar la reserva presente en el formulario
        private void btnActualizarReserva_Click(object sender, EventArgs e)
        {

            if (ValidarReserva())
            {
                String ClienteID = lblCodigo.Text;
                ManejoReservas.AccionesReserva.ActualizarReserva(dgvDetalleCabanhas, dgvDetalleServicios, reservaAbrir, ClienteID);
                LimpiarForm();
            }

        }

        //Botón para el envío de la reserva mediante correo
        private void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
            if (ValidarReserva())
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

        private void dgvDetalleCabanhas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizarCabana.Enabled = true;

            if (e.RowIndex >= 0 && e.RowIndex < dgvDetalleCabanhas.Rows.Count)
            {
                filaSeleccionada = dgvDetalleCabanhas.Rows[e.RowIndex];

                // Obtener el ID de la fila seleccionada usando el índice de la columna
                string id = filaSeleccionada.Cells[0].Value.ToString();

                // Crear una lista para almacenar los elementos del ComboBox
                List<string> elementosCombo = new List<string>();

                // Iterar sobre los elementos del ComboBox para extraer el primer elemento de texto
                foreach (object item in cmbCabanhas.Items)
                {
                    // Obtener el DataRowView correspondiente a cada elemento del ComboBox
                    DataRowView rowView = item as DataRowView;
                    if (rowView != null)
                    {
                        // Obtener el valor deseado (primer elemento de texto)
                        string textoComboBox = rowView.Row[0].ToString();
                        string[] partes = textoComboBox.Split(new string[] { " - " }, StringSplitOptions.None);
                        if (partes.Length > 0)
                        {
                            elementosCombo.Add(partes[0].Trim());
                        }
                    }
                }

                // Iterar sobre los elementos extraídos del ComboBox para encontrar la coincidencia con el ID
                for (int i = 0; i < elementosCombo.Count; i++)
                {
                    if (elementosCombo[i] == id)
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

        private void btnActualizarCabana_Click(object sender, EventArgs e)
        {
            string textoComboBox = cmbCabanhas.Text;
            DateTime fechaInicio = dtpInicioEstadia.Value.Date;
            DateTime fechaFin = dtpFinEstadia.Value.Date;
            int diferenciaDias = (int)(fechaFin - fechaInicio).TotalDays;

            // Verificar si la diferencia de días es al menos 1
            if (diferenciaDias >= 1)
            {
                // Dividir el texto del combobox para obtener los datos
                string[] partes = textoComboBox.Split(new string[] { " - " }, StringSplitOptions.None);

                if (partes.Length >= 3)
                {
                    decimal precioCabaña = decimal.Parse(partes[2].Substring(2)); // Obtener el precio de la cabaña (eliminar el "L.")
                    decimal subtotal = precioCabaña * diferenciaDias;
                    string idCabaña = partes[0];

                    // Buscar la fila correspondiente en el DataGridView
                    DataGridViewRow filaActualizar = null;
                    foreach (DataGridViewRow fila in dgvDetalleCabanhas.Rows)
                    {
                        if (fila.Cells[0].Value.ToString() == idCabaña)
                        {
                            filaActualizar = fila;
                            break;
                        }
                    }

                    if (filaActualizar != null)
                    {
                        // Actualizar los valores de la fila encontrada
                        filaActualizar.Cells[2].Value = partes[2]; // Precio
                        filaActualizar.Cells[3].Value = fechaInicio.ToShortDateString(); // Inicio
                        filaActualizar.Cells[4].Value = fechaFin.ToShortDateString(); // Fin
                        filaActualizar.Cells[5].Value = subtotal; // Subtotal
                        limpiarCabanas();
                    }
                    else
                    {
                        MessageBox.Show("La cabaña no está en la lista para actualizar.");
                    }
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

            CalcularTotal(); // Llamar a la función para recalcular el total.
            btnActualizarCabana.Enabled = false;
        }

        private void dgvDetalleServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizarServicio.Enabled = true;
            if (e.RowIndex >= 0 && e.RowIndex < dgvDetalleServicios.Rows.Count)
            {
                filaSeleccionada = dgvDetalleServicios.Rows[e.RowIndex];

                // Obtener el ID de la fila seleccionada usando el índice de la columna
                string id = filaSeleccionada.Cells[0].Value.ToString();

                // Crear una lista para almacenar los elementos del ComboBox de servicios
                List<string> elementosComboServicios = new List<string>();

                // Iterar sobre los elementos del ComboBox de servicios para extraer el primer elemento de texto
                foreach (object item in cmbServicioAdicional.Items)
                {
                    DataRowView rowView = item as DataRowView;
                    if (rowView != null)
                    {
                        // Obtener el valor deseado (primer elemento de texto)
                        string textoComboBoxServicios = rowView.Row[0].ToString();
                        string[] partes = textoComboBoxServicios.Split(new string[] { " - " }, StringSplitOptions.None);
                        if (partes.Length > 0)
                        {
                            elementosComboServicios.Add(partes[0].Trim());

                            // Obtener el texto correspondiente a cada elemento del ComboBox de servicios
                        }
                    }
                }

                // Iterar sobre los elementos extraídos del ComboBox de servicios para encontrar la coincidencia con el ID
                for (int i = 0; i < elementosComboServicios.Count; i++)
                {
                    if (elementosComboServicios[i] == id)
                    {
                        // Si hay coincidencia, seleccionar ese elemento en el ComboBox de servicios
                        cmbServicioAdicional.SelectedIndex = i;
                        break; // Salir del bucle una vez que se encuentra la coincidencia
                    }
                }

                // Obtener la cantidad de servicios de la fila seleccionada
                string cantidadServicios = filaSeleccionada.Cells[3].Value.ToString();

                // Establecer el valor en el TextBox correspondiente
                txtCantidadServicios.Text = cantidadServicios;
            }
        }

        private void btnActualizarServicio_Click(object sender, EventArgs e)
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

                // Iterar sobre las filas existentes en el DataGridView para verificar si el servicio ya está presente
                bool servicioExistente = false;
                foreach (DataGridViewRow fila in dgvDetalleServicios.Rows)
                {
                    if (fila.Cells[0].Value.ToString() == partes[0]) // Comprueba si el ID del servicio coincide
                    {
                        // Actualiza los detalles del servicio existente
                        fila.Cells[1].Value = partes[1]; // Nombre
                        fila.Cells[2].Value = "L. " + precioServicio; // Precio
                        fila.Cells[3].Value = cantidad; // Cantidad
                        fila.Cells[4].Value = subtotal; // Subtotal

                        servicioExistente = true;
                        break;
                    }
                }

                if (!servicioExistente)
                {
                    // Agregar una nueva fila al DataGridView
                    dgvDetalleServicios.Rows.Add(partes[0], partes[1], "L. " + precioServicio, cantidad, subtotal);
                }

                // Limpia los controles después de agregar o actualizar la fila
                limpiarServicios();
            }
            else
            {
                MessageBox.Show("El formato del texto seleccionado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CalcularTotal();
            btnActualizarServicio.Enabled = false;
        }

        private void btnEliminarCabana_Click(object sender, EventArgs e)
        {
            // Verificar si la fila seleccionada no es nula y pertenece al DataGridView dgvDetalleCabanas
            if (filaSeleccionada != null && dgvDetalleCabanhas.Rows.Contains(filaSeleccionada))
            {
                dgvDetalleCabanhas.Rows.Remove(filaSeleccionada);
                CalcularTotal(); // Recalcula el total después de eliminar la fila
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila que contenga una cabaña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            btnActualizarServicio.Enabled = false;
            btnActualizarCabana.Enabled = false;

        }

        private void btnEliminarServicio_Click(object sender, EventArgs e)
        {
            // Verificar si la fila seleccionada no es nula y pertenece al DataGridView dgvDetalleCabanas
            if (filaSeleccionada != null && dgvDetalleServicios.Rows.Contains(filaSeleccionada))
            {
                dgvDetalleServicios.Rows.Remove(filaSeleccionada);
                CalcularTotal(); // Recalcula el total después de eliminar la fila
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila que contenga un servicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            btnActualizarServicio.Enabled = false;
            btnActualizarCabana.Enabled = false;
        }

        private void LimpiarForm()
        {
            lblCliente.Text = "";
            lblCodigo.Text = "";
            lblCorreoCliente.Text = "";
            lblTotal.Text = "";
            cmbCabanhas.SelectedIndex = 0;
            cmbServicioAdicional.SelectedIndex = 0;
            txtCantidadServicios.Text = "";
            dgvDetalleCabanhas.Columns.Clear();
            dgvDetalleCabanhas.Rows.Clear();
            dgvDetalleServicios.Columns.Clear();
            dgvDetalleServicios.Rows.Clear();
            dtpFinEstadia.Value = DateTime.Today;
            dtpInicioEstadia.Value = DateTime.Today;

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }

        private void btnVolverinicio_Click_1(object sender, EventArgs e)
        {
            frmInicio inicio = new frmInicio();
            inicio.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (ValidarReserva())
            {
                String NombreCliente = lblCliente.Text, ClienteDNI = lblClienteDNI.Text, TotalReserva = lblTotal.Text;


                frmFactura facturaForm = new frmFactura(NombreCliente, ClienteDNI, TotalReserva);
                foreach (DataGridViewRow row in dgvDetalleCabanhas.Rows)
                {
                    DateTime fechaInicio = Convert.ToDateTime(row.Cells[3].Value);
                    DateTime fechaFin = Convert.ToDateTime(row.Cells[4].Value);
                    int cantidad = (fechaFin.Date - fechaInicio.Date).Days;
                    string descripcion = row.Cells[1].Value.ToString();
                    decimal precioUnitario = Convert.ToDecimal(row.Cells[2].Value);

                    // Agrega la fila al DataGridView de la factura
                    facturaForm.AgregarFilaFactura(cantidad, descripcion, precioUnitario);
                }

                // Procesar el DataGridView de los servicios
                foreach (DataGridViewRow row in dgvDetalleServicios.Rows)
                {
                    int cantidad = Convert.ToInt32(row.Cells[3].Value);
                    string descripcion = row.Cells[1].Value.ToString();
                    decimal precioUnitario = Convert.ToDecimal(row.Cells[2].Value);

                    // Agrega la fila al DataGridView de la factura
                    facturaForm.AgregarFilaFactura(cantidad, descripcion, precioUnitario);
                }
                facturaForm.CambiarCotizacion();
                facturaForm.Show();
                this.Close();
            }

        }

        private void txtCantidadServicios_TextChanged(object sender, EventArgs e)
        {
            ClsValidar.ValidarNumerosMenoresQueCien(txtCantidadServicios);


        }
        // Verificar si el DataGridView de detalles de cabañas y servicios tiene al menos una fila
        public bool ValidarReserva()
        {

            if (dgvDetalleCabanhas.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos una cabaña para poder guardar la reserva.", "Validación de Reserva", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void frmReservaServicios_Load(object sender, EventArgs e)
        {
            // Configurar los DateTimePicker para que no acepten fechas pasadas
            dtpInicioEstadia.MinDate = DateTime.Now.Date;
            dtpFinEstadia.MinDate = DateTime.Now.Date;
        }

        private void cmbServicioAdicional_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpFinEstadia_ValueChanged(object sender, EventArgs e)
        {
            {
                DateTime selectedDate = dtpFinEstadia.Value;

                if (!validador.ValidarFechaNoPasada(selectedDate))
                {
                    // Mostrar mensaje de error
                    MessageBox.Show("No se puede seleccionar una fecha pasada.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Restablecer la fecha al día actual
                    dtpFinEstadia.Value = DateTime.Now.Date;
                }
            }
        }

        private void dtpInicioEstadia_ValueChanged(object sender, EventArgs e)
        {
            {
                DateTime selectedDate = dtpInicioEstadia.Value;

                if (!validador.ValidarFechaNoPasada(selectedDate))
                {
                    // Mostrar mensaje de error
                    MessageBox.Show("No se puede seleccionar una fecha pasada.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Restablecer la fecha al día actual
                    dtpInicioEstadia.Value = DateTime.Now.Date;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}