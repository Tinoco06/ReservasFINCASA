using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservasFINCASA
{
    internal class MantenimientoServicios
    {

        public void AccionesServicios(String IDservicio, String NombreServicio, String DescripcionServicio,
            float PrecioServicio, String Accion)
        {
            ConexionSQL conexionSQL = new ConexionSQL();
            using (SqlConnection conexion = conexionSQL.AbrirConexion())
            {
                if (conexion != null)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("SP_CRUD_SERVICIOS", conexion);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IDservicio", IDservicio);
                        cmd.Parameters.AddWithValue("@Nombre", NombreServicio);
                        cmd.Parameters.AddWithValue("@Descripcion", DescripcionServicio);
                        cmd.Parameters.AddWithValue("@Precio", PrecioServicio);
                        cmd.Parameters.AddWithValue("@Accion", Accion);

                        cmd.ExecuteNonQuery();

                        if (Accion == "agregar")
                            MessageBox.Show("Servicio agregado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else if (Accion == "modificar")
                            MessageBox.Show("Información modificada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Servicio eliminado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

