using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservasFINCASA
{
    internal class ClaseAccesoLogin
    {
        //Instancia clase conexion
        private static ConexionSQL conexionSQL = new ConexionSQL();
        public static bool VerificarCredenciales(string usuario, string contrasena)
        {
            try
            {
                using (SqlConnection conexion = conexionSQL.AbrirConexion())
                {
                    //Select para validar los datos ingresados en el login
                    SqlCommand comando = new SqlCommand("SELECT NombreUsuario, PasswordUsuario FROM USUARIOS WHERE NombreUsuario = @vusuario AND PasswordUsuario = @vcontrasena", conexion);
                    comando.Parameters.AddWithValue("@vusuario", usuario);
                    comando.Parameters.AddWithValue("@vcontrasena", contrasena);

                    SqlDataReader lector = comando.ExecuteReader();                
                    return lector.Read();
                    conexionSQL.CerrarConexion(conexion);

                }
            }
            //Manejo de excepcion
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar ingresar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
