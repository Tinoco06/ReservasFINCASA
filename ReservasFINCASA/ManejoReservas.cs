using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservasFINCASA
{
    internal class ManejoReservas
    {
        public class AccionesReserva
        {
            //Función que valida si esta cabaña se encuentra disponible o no
            public static bool EsCabanaDisponible(string cabanaID, DateTime fechaInicio, DateTime fechaFin)
            {
                ConexionSQL conexionSQL = new ConexionSQL();
                bool disponible = false;

                try
                {
                    using (SqlConnection conexion = conexionSQL.AbrirConexion())
                    {
                        // Consulta para verificar si la cabaña está disponible en las fechas indicadas
                        SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM DetalleReserva WHERE CabanaID = @CabanaID AND NOT ((FechaFin <= @FechaInicio) OR (FechaInicio >= @FechaFin));", conexion);
                        command.Parameters.AddWithValue("@CabanaID", cabanaID);
                        command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                        command.Parameters.AddWithValue("@FechaFin", fechaFin);

                        int count = (int)command.ExecuteScalar();

                        // Si count es 0, no hay reservas que se solapen y la cabaña está disponible
                        disponible = count == 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha producido una excepción al verificar la disponibilidad de la cabaña: \n\n" +
                        "Mensaje: " + ex.Message + "\n\n" +
                        "Stack Trace: " + ex.StackTrace);
                }

                return disponible;
            }

            //Funcion que permite ingresar las reservas a la BDD   
            public static void InsertarReserva(DataGridView dgvDetalleCabanhas, DataGridView dgvDetalleServicios, string clienteID)
            {
                ConexionSQL conexionSQL = new ConexionSQL();

                try
                {
                    using (SqlConnection conexion = conexionSQL.AbrirConexion())
                    {
                        int clienteId = int.Parse(clienteID);

                        using (SqlTransaction transaction = conexion.BeginTransaction())
                        {
                            try
                            {
                                // Insertar la reserva
                                DataGridViewCell primeraCelda = dgvDetalleCabanhas.Rows[0].Cells[0];
                                String valor = primeraCelda.Value.ToString();

                                SqlCommand commandReserva = new SqlCommand("INSERT INTO Reservas (ClienteID, CabanaID, Estado) VALUES (@ClienteID, @CabanaID, 'Pendiente'); SELECT SCOPE_IDENTITY();", conexion, transaction);
                                commandReserva.Parameters.AddWithValue("@CabanaID", valor);
                                commandReserva.Parameters.AddWithValue("@ClienteID", clienteId);

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
                                        commandDetalleReserva.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                                        commandDetalleReserva.Parameters.AddWithValue("@FechaFin", fechaFin);

                                        commandDetalleReserva.ExecuteNonQuery();
                                    }
                                }

                                if (dgvDetalleServicios.Rows.Count >= 1)
                                {
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


            public static void FacturarReserva(string reservaID)
            {
                ConexionSQL conexionSQL = new ConexionSQL();
                try
                {
                    using (SqlConnection conexion = conexionSQL.AbrirConexion())
                    {
                        using (SqlTransaction transaction = conexion.BeginTransaction())
                        {
                            try
                            {
                                SqlCommand command = new SqlCommand("UPDATE Reservas SET Estado = 'Confirmada' WHERE ReservaID = @ReservaID", conexion, transaction);
                                command.Parameters.AddWithValue("@ReservaID", reservaID);

                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    transaction.Commit();
                                    MessageBox.Show("La reserva ha sido actualizada a facturada.");
                                }
                                else
                                {
                                    MessageBox.Show("No se encontró la reserva especificada.");
                                    transaction.Rollback();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error al actualizar la reserva: " + ex.Message);
                                transaction.Rollback();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexión: " + ex.Message);
                }
            }

            public static void ActualizarReserva(DataGridView dgvDetalleCabanhas, DataGridView dgvDetalleServicios, string reservaAbrir, string clienteID)
            {
                ConexionSQL conexionSQL = new ConexionSQL();

                try
                {
                    using (SqlConnection conexion = conexionSQL.AbrirConexion())
                    {

                        int clienteId = int.Parse(clienteID);
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
                                commandReserva.Parameters.AddWithValue("@ClienteID", clienteId);
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

                                if (dgvDetalleServicios.Rows.Count >= 1)
                                {
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

            public static void InsertarFactura(int IDReserva, int IDCliente)
            {
                ConexionSQL conexionSQL = new ConexionSQL();
                using (SqlConnection conexion = conexionSQL.AbrirConexion())
                {
                    if (conexion != null)
                    {
                        try
                        {
                            // Llamar al procedimiento almacenado y agregar los valores
                            SqlCommand cmd = new SqlCommand("SP_INSERTAR_FACTURA", conexion);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@IDReserva", IDReserva);
                            cmd.Parameters.AddWithValue("@IDCliente", IDCliente);

                            cmd.ExecuteNonQuery();

                            // Mensaje de éxito
                            MessageBox.Show("Factura creada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al crear la factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            public static string ObtenerIdClientePorNombre(string Nombre)
            {
                string idCliente = string.Empty;
                ConexionSQL conexionSQL = new ConexionSQL();
                using (SqlConnection conexion = conexionSQL.AbrirConexion())
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
                            idCliente = resultado.ToString();
                        }
                        else
                        {
                            // Manejar el caso en el que no se encuentre un ClienteID para el nombre dado
                            idCliente = "No se encontró un ClienteID para el nombre especificado.";
                        }

                        conexionSQL.CerrarConexion(conexion);
                    }
                    catch (Exception ex)
                    {
                        // Manejar la excepción
                        idCliente = "Error al obtener el ClienteID: " + ex.Message;
                    }
                }

                return idCliente;
            }

            public static bool EstaFacturada(string reservaID)
            {
                ConexionSQL conexionSQL = new ConexionSQL();
                try
                {
                    using (SqlConnection conexion = conexionSQL.AbrirConexion())
                    {
                        SqlCommand command = new SqlCommand("SELECT Estado FROM Reservas WHERE ReservaID = @ReservaID", conexion);
                        command.Parameters.AddWithValue("@ReservaID", reservaID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string estado = reader["Estado"].ToString();
                                return estado == "Confirmada";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar el estado de la reserva: " + ex.Message);
                }
                return false;
            }


        }


    }
}
