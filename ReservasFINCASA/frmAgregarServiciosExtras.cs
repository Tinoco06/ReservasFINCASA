using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservasFINCASA
{
    public partial class frmAgregarServiciosExtras : Form
    {
        //Instancias para conexión y clases
        private ConexionSQL conexionSQL = new ConexionSQL();
        MantenimientoServicios mante = new MantenimientoServicios();

        public frmAgregarServiciosExtras()
        {
            InitializeComponent();
        }

        //Botón de inicio 
        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            frmInicio frmInicio = new frmInicio();
            this.Hide();
            frmInicio.Show();
        }

        //Llenar el datagrid con los datos de la tabla servicios adicionales
        private void LlenardgvServicios()
        {
            using (SqlConnection conexion = conexionSQL.AbrirConexion())
            {
                if (conexion != null)
                {
                    try
                    {
                        SqlCommand comando = new SqlCommand("SELECT * FROM ServiciosAdicionales", conexion);
                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataTable tablaServicios = new DataTable();
                        adaptador.Fill(tablaServicios);

                        dgvServicios.DataSource = tablaServicios;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al llenar el DataGridView: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //Limpiar los controles del formulario
        public void limpiar()
        {
            txtIDservicio.Text = "";
            txtNombreServicio.Text = "";
            txtDescripcionServicio.Text = "";
            txtPrecioServicio.Text = "";
        }

        //Llamar funcion cargar servicios
        private void CargarDatos()
        {
            LlenardgvServicios();
        }

        //Servicios se muestran al cargar el formulario
        private void frmAgregarExtras_Load(object sender, EventArgs e)
        {
           CargarDatos();
        }

        //Botón que permite agregar servicios a la BDD mediante la instancia de la clase MantenimientoServicios
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string ID = txtIDservicio.Text, Nombre = txtNombreServicio.Text, Descripcion = txtDescripcionServicio.Text;
            float Precio = float.Parse(txtPrecioServicio.Text);

            mante.AccionesServicios(ID, Nombre, Descripcion, Precio, "agregar");

            limpiar();
            CargarDatos();

        }

        //Extrae los datos del grid a los controles del form
        private void dgvServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDservicio.Text = dgvServicios.CurrentRow.Cells[0].Value.ToString();
            txtNombreServicio.Text = dgvServicios.CurrentRow.Cells[1].Value.ToString();
            txtDescripcionServicio.Text = dgvServicios.CurrentRow.Cells[2].Value.ToString();
            txtPrecioServicio.Text = dgvServicios.CurrentRow.Cells[3].Value.ToString();

        }

        //Botón que permite modificar servicios a la BDD mediante la instancia de la clase MantenimientoServicios
        private void btnModificar_Click(object sender, EventArgs e)
        {
            string ID = txtIDservicio.Text, Nombre = txtNombreServicio.Text, Descripcion = txtDescripcionServicio.Text;
            float Precio = float.Parse(txtPrecioServicio.Text);

            mante.AccionesServicios(ID, Nombre, Descripcion, Precio, "modificar");

            limpiar();
            CargarDatos();
        }

        //Botón que permite eliminar servicios a la BDD mediante la instancia de la clase MantenimientoServicios
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string ID = txtIDservicio.Text, Nombre = txtNombreServicio.Text, Descripcion = txtDescripcionServicio.Text;
            float Precio = float.Parse(txtPrecioServicio.Text);

            mante.AccionesServicios(ID, Nombre, Descripcion, Precio, "eliminar");

            limpiar();
            CargarDatos();
        }

        //Botón para limpiar los controles
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
