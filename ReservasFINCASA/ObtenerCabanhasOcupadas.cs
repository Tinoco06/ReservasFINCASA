using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasFINCASA
{
    internal class ObtenerCabanhasOcupadas
    {
        public DataTable ObtenerDatosCabanhasOcupadas(string fechaInicio, string fechaFin)
        {
            DataTable dataTable = new DataTable();

            ConexionSQL conexionSQL = new ConexionSQL();
            using (SqlConnection conexion = conexionSQL.AbrirConexion())
            {
                try
                {
                    //Llamar el procedimiento almacenado
                    SqlCommand cmd = new SqlCommand("SP_Cabanhas_Ocupadas", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", fechaFin);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    // Manejo de la excepción (puede imprimirse o registrarse según sea necesario)
                    Console.WriteLine("Error al ejecutar el procedimiento almacenado: " + ex.Message);
                }
            }

            return dataTable;
        }
    }
}
