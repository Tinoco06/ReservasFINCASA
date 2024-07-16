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
    
    public partial class frmAbrirReserva : Form
    {
        //Instancias de conexión y clases
        private ConexionSQL conexionSQL = new ConexionSQL();
        MostrarReservas mostrar = new MostrarReservas();

        public frmAbrirReserva()
        {
            InitializeComponent();
            MostrarReservas mostrar = new MostrarReservas();
            CargarGrids.CargarReservas(dgvDetalleReserva);
        }        

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVolverCliente_Click(object sender, EventArgs e)
        {
            frmReservaServicios reservas = new frmReservaServicios("", "","", "",false);
            reservas.Show();
            this.Hide();
        }

        private void frmAbrirReserva_Load(object sender, EventArgs e)
        {

        }

        private void txtBuscarDNI_TextChanged(object sender, EventArgs e)
        {
            txtBuscarDNI.MaxLength = 13;
            ClsValidar.ValidarDNI(txtBuscarDNI);
            BusquedaDNI();
        }

        private void BusquedaDNI()
        {
            string buscarDNI = txtBuscarDNI.Text.Trim();

            // Obtener la tabla de datos actual del DataGridView (si está enlazado a un origen de datos)
            DataTable tabla = (DataTable)dgvDetalleReserva.DataSource;

            if (tabla != null)
            {
                // Crear una expresión de filtro para buscar coincidencias parciales 
                string filtro = $"NumeroIdentidadCliente LIKE '%{buscarDNI}%'";

                // Aplicar el filtro a la tabla de datos
                tabla.DefaultView.RowFilter = filtro;
            }
        }

        //Función para enviar el numero de reserva que se va cargar
        private void dgvDetalleReserva_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvDetalleReserva.Rows[e.RowIndex];

            //Extrae los valores del datagrid
            string valor = selectedRow.Cells[0].Value.ToString();
            string nombreCliente = selectedRow.Cells[2].Value.ToString();
            string apellidoCliente = selectedRow.Cells[3].Value.ToString(); 
            string CorreoCliente = selectedRow.Cells[4].Value.ToString();
            string DNIcliente = selectedRow.Cells[5].Value.ToString();

            frmReservaServicios reservas = new frmReservaServicios("", CorreoCliente, "", "", false);
            reservas.ActualizarValor(valor, nombreCliente, apellidoCliente, DNIcliente);
            reservas.Show();
            this.Hide();
        }


    }
}
