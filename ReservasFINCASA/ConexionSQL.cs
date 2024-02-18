using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasFINCASA
{

        public class ConexionSQL
        {
            private string cadenaConexion;

            public ConexionSQL()
            {
                // Cadena de conexión utilizando autenticación de SQL Server
                cadenaConexion = "Data Source=.;Initial Catalog=BD_FINCASA;User ID=user1;Password=Semeolvida1";
            }

            public SqlConnection AbrirConexion()
            {
                try
                {
                    SqlConnection conexion = new SqlConnection(cadenaConexion);
                    conexion.Open();
                    return conexion;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al abrir la conexión: " + ex.Message);
                    return null;
                }
            }

            public void CerrarConexion(SqlConnection conexion)
            {
                try
                {
                    if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                    {
                        conexion.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
                }
            }
        }
}

