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
    internal class MantenimientoClientes
    {
        //Creación del método parametrizado
        public void AccionesClientes(int codigo, String DNI, String Nombre,
           String Apellido, String Correo, String Telefono, String Procedencia, String Empresa, String Accion)
        {
            //Conectar la base de datos
            ConexionSQL conexionSQL = new ConexionSQL();
            using (SqlConnection conexion = conexionSQL.AbrirConexion())
            {
                if (conexion != null)
                {
                    //Try catch para manejo de excepciones
                    try
                    {
                        //Llamar el procedimiento almacenado y agregar los valores
                        SqlCommand cmd = new SqlCommand("SP_CRUD_CLIENTES", conexion);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IDcliente", codigo);
                        cmd.Parameters.AddWithValue("@DNI", DNI);
                        cmd.Parameters.AddWithValue("@Nombre", Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", Apellido);
                        cmd.Parameters.AddWithValue("@Correo", Correo);
                        cmd.Parameters.AddWithValue("@Telefono", Telefono);
                        cmd.Parameters.AddWithValue("@Procedencia", Procedencia);
                        cmd.Parameters.AddWithValue("@Empresa", Empresa);
                        cmd.Parameters.AddWithValue("@Accion", Accion);

                        cmd.ExecuteNonQuery();

                        //Mensaje de acuerdo a la acción realizada
                        if (Accion == "agregar")
                            MessageBox.Show("Cliente agregado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else if (Accion == "modificar")
                            MessageBox.Show("Información modificada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Cliente eliminado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

