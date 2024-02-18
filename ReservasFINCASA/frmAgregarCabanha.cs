using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservasFINCASA
{
    public partial class frmAgregarCabanha : Form
    {
        private ConexionSQL conexionSQL = new ConexionSQL();
        MantenimientoCabanhas mante = new MantenimientoCabanhas();

        public frmAgregarCabanha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            frmInicio frmInicio = new frmInicio();
            this.Hide();
            frmInicio.Show();
            
        }

        private void LlenardgvCabanhas()
        {
            using (SqlConnection conexion = conexionSQL.AbrirConexion())
            {
                if (conexion != null)
                {
                    try
                    {
                        SqlCommand comando = new SqlCommand("SELECT * FROM Cabañas", conexion);
                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataTable tablaCabañas = new DataTable();
                        adaptador.Fill(tablaCabañas);

                        dgvCabanhas.DataSource = tablaCabañas;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al llenar el DataGridView: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CargarDatos()
        {
            LlenardgvCabanhas();
        }
        private void frmAgregarCabanha_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        public void limpiar()
        {
            txtIDcabaña.Text = "";
            txtNombreCabanha.Text = "";
            txtDescripcionCabanha.Text = "";
            txtCapacidadCabanha.Text = "";
            txtPrecioCabanha.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String ID = txtIDcabaña.Text, nombre = txtNombreCabanha.Text, descripcion = txtDescripcionCabanha.Text;
            int capacidad = int.Parse(txtCapacidadCabanha.Text);      
            float precio = float.Parse(txtPrecioCabanha.Text);

            mante.AccionesCabanhas(ID, nombre, descripcion, capacidad, precio, "agregar");

            CargarDatos();
            limpiar();
        }

        private void dgvCabanhas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvCabanhas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDcabaña.Text = dgvCabanhas.CurrentRow.Cells[0].Value.ToString();
            txtNombreCabanha.Text = dgvCabanhas.CurrentRow.Cells[1].Value.ToString();
            txtDescripcionCabanha.Text = dgvCabanhas.CurrentRow.Cells[2].Value.ToString();
            txtCapacidadCabanha.Text = dgvCabanhas.CurrentRow.Cells[3].Value.ToString();
            txtPrecioCabanha.Text = dgvCabanhas.CurrentRow.Cells[4].Value.ToString();
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            String ID = txtIDcabaña.Text, nombre = txtNombreCabanha.Text, descripcion = txtDescripcionCabanha.Text;
            int capacidad = int.Parse(txtCapacidadCabanha.Text);
            float precio = float.Parse(txtPrecioCabanha.Text);

            mante.AccionesCabanhas(ID, nombre, descripcion, capacidad, precio, "modificar");

            CargarDatos();
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String ID = txtIDcabaña.Text, nombre = txtNombreCabanha.Text, descripcion = txtDescripcionCabanha.Text;
            int capacidad = int.Parse(txtCapacidadCabanha.Text);
            float precio = float.Parse(txtPrecioCabanha.Text);

            mante.AccionesCabanhas(ID, nombre, descripcion, capacidad, precio, "eliminar");

            CargarDatos();
            limpiar();
        }
    }
}
