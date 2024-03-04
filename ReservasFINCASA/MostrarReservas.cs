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
    internal class MostrarReservas
    {

        public void EjecutarSQL()
        {
            ConexionSQL conexionSQL = new ConexionSQL();
            using (SqlConnection conexion = conexionSQL.AbrirConexion())
            {
                if (conexion != null)
                {
                    //Try catch para manejo de excepciones
                    try
                    {
                        //Llamar el procedimiento almacenado y agregar los valores
                        SqlCommand cmd = new SqlCommand("SP_MOSTRAR_RESERVA", conexion);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.ExecuteNonQuery();

                        //Mensaje de acuerdo a la acción realizada


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
            }

        }
    }
}
