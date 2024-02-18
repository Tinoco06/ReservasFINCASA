﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservasFINCASA
{

    internal class MantenimientoCabanhas
    {

        public void AccionesCabanhas(String IdCabanha, String NombreCabanha, 
            String DescrCabanha, int CapacidadCabanha, float PrecioCabanha, String Accion)
        {
            ConexionSQL conexionSQL = new ConexionSQL();
            using (SqlConnection conexion = conexionSQL.AbrirConexion())
            {
                if (conexion != null)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("SP_CRUD_CABANHAS", conexion);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IDcabanha", IdCabanha);
                        cmd.Parameters.AddWithValue("@Nombre", NombreCabanha);
                        cmd.Parameters.AddWithValue("@Descripcion", DescrCabanha);
                        cmd.Parameters.AddWithValue("@Capacidad", CapacidadCabanha);
                        cmd.Parameters.AddWithValue("@Precio", PrecioCabanha);
                        cmd.Parameters.AddWithValue("@Accion", Accion);

                        cmd.ExecuteNonQuery();

                        if(Accion == "agregar")
                            MessageBox.Show("Cabaña agregada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else if(Accion == "modificar")
                            MessageBox.Show("Información modificada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Cabaña eliminada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
