using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservasFINCASA
{
    //Clase para cargar los grids en los formularios
    internal class CargarGrids
    {
        private static ConexionSQL conexionSQL = new ConexionSQL();
        //Función que permite cargar las cabañas disponibles en el combobox
        public static void CargarCabañas(ComboBox cmbCabanhas)
        {            
            using (SqlConnection conexion = conexionSQL.AbrirConexion())
            {
                //Llamado del procedimiento almacenado
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
                conexionSQL.CerrarConexion(conexion);
            }
        }

        //Función que permite cargar las cabañas disponibles en el combobox
        public static void CargarServicios(ComboBox cmbServicioAdicional)
        {
            using (SqlConnection conexion = conexionSQL.AbrirConexion())
            {
                //Llamado del procedimiento almacenado
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
                conexionSQL.CerrarConexion(conexion);
            }            
        }

        public static void CargarReservas(DataGridView dgvDetalleReserva)
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
                    conexionSQL.CerrarConexion(conexion); // Cerrar la conexión al final del método
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las reservas: " + ex.Message);
            }

            
        }

        public static void LlenarCRUDCabanas(DataGridView dgv)
        {
            using (SqlConnection conexion = conexionSQL.AbrirConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand("SELECT * FROM Cabañas", conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tablaCabañas = new DataTable();
                    adaptador.Fill(tablaCabañas);

                    dgv.DataSource = tablaCabañas;
                    conexionSQL.CerrarConexion(conexion);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al llenar el DataGridView: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void LlenarCRUDServicios(DataGridView dgv)
        {
            using (SqlConnection conexion = conexionSQL.AbrirConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand("SELECT * FROM ServiciosAdicionales", conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tablaServicios = new DataTable();
                    adaptador.Fill(tablaServicios);

                    dgv.DataSource = tablaServicios;
                    conexionSQL.CerrarConexion(conexion);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al llenar el DataGridView: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void LlenarCRUDClientes(DataGridView dgv)
        {
            using (SqlConnection conexion = conexionSQL.AbrirConexion())
            {
                try
                {                 
                    SqlCommand comando = new SqlCommand("SELECT * FROM Clientes", conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tablaClientes = new DataTable();
                    adaptador.Fill(tablaClientes);

                    dgv.DataSource = tablaClientes;
                    conexionSQL.CerrarConexion(conexion);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al llenar el DataGridView: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
