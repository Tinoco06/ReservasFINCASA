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
        ClsValidar validar = new ClsValidar();

        public frmAgregarServiciosExtras()
        {
            InitializeComponent();
            // Asignar el evento KeyPress del TextBox al manejador de eventos del formulario original
            ClsValidar form1 = new ClsValidar();
            txtDescripcionServicio.KeyPress += new KeyPressEventHandler(form1.GeneralKeyPressHandler);
            txtIDservicio.KeyPress += new KeyPressEventHandler(form1.GeneralKeyPressHandler);
            txtNombreServicio.KeyPress += new KeyPressEventHandler(form1.GeneralKeyPressHandler);
            txtPrecioServicio.KeyPress += new KeyPressEventHandler(form1.Precio_KeyPress);
        }

        //Botón de inicio 
        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            frmInicio frmInicio = new frmInicio();
            this.Hide();
            frmInicio.Show();
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
            CargarGrids.LlenarCRUDServicios(dgvServicios);
        }

        //Servicios se muestran al cargar el formulario
        private void frmAgregarExtras_Load(object sender, EventArgs e)
        {
           CargarDatos();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }



        //Botón que permite agregar servicios a la BDD mediante la instancia de la clase MantenimientoServicios
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Primero valida si todos los campos están vacíos
            if (!ClsValidar.ValidarFormularioServicios(txtIDservicio, txtNombreServicio, txtPrecioServicio))
            {
                return;
            }

            // Realiza las validaciones individuales de longitud mínima
            if (!ClsValidar.ValidarLongitudMinima(txtIDservicio.Text, 2))
            {
                MessageBox.Show("El identificador debe tener al menos 2 caracteres.");
                txtIDservicio.Focus();
                return;
            }
            if (!ClsValidar.ValidarLongitudMinima(txtPrecioServicio.Text, 2))
            {
                MessageBox.Show("El Precio debe tener al menos 2 dígitos.");
                txtPrecioServicio.Focus();
                return;
            }
            if (!ClsValidar.ValidarLongitudMinima(txtNombreServicio.Text, 3))
            {
                MessageBox.Show("El nombre debe tener al menos 3 caracteres.");
                txtNombreServicio.Focus();
                return;
            }
            if (!ClsValidar.ValidarLongitudMinima(txtDescripcionServicio.Text, 5))
            {
                MessageBox.Show("La descripción debe tener al menos 5 caracteres.");
                txtDescripcionServicio.Focus();
                return;
            }

            // Si todos los campos son válidos, realiza la acción de agregar
            string ID = txtIDservicio.Text;

            // Verificar si el ID ya existe en el dgv
            if (ClsValidar.EsIdServicioUnico(dgvServicios, ID))
            {
                string Nombre = txtNombreServicio.Text;
                string Descripcion = txtDescripcionServicio.Text;
                float Precio = float.Parse(txtPrecioServicio.Text);

                // Llama a la función de mantenimiento 
                mante.AccionesServicios(ID, Nombre, Descripcion, Precio, "agregar");

                limpiar();
                CargarDatos();
            }
            else
            {
                MessageBox.Show("El ID ingresado ya existe. Por favor ingrese un ID diferente.");
                txtIDservicio.Text = "";
                txtIDservicio.Focus();
            }
        }


        //Extrae los datos del grid a los controles del form
        private void dgvServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDservicio.Text = dgvServicios.CurrentRow.Cells[0].Value.ToString();
            txtNombreServicio.Text = dgvServicios.CurrentRow.Cells[1].Value.ToString();
            txtDescripcionServicio.Text = dgvServicios.CurrentRow.Cells[2].Value.ToString();
            txtPrecioServicio.Text = dgvServicios.CurrentRow.Cells[3].Value.ToString();
            txtIDservicio.Enabled = false;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;

        }

        //Botón que permite modificar servicios a la BDD mediante la instancia de la clase MantenimientoServicios
        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Primero valida si todos los campos están vacíos
            if (!ClsValidar.ValidarFormularioServicios(txtIDservicio, txtNombreServicio, txtPrecioServicio))
            {
                return;
            }

            // Realiza las validaciones individuales de longitud mínima
            if (!ClsValidar.ValidarLongitudMinima(txtNombreServicio.Text, 3))
            {
                MessageBox.Show("El nombre debe tener al menos 3 caracteres.");
                txtNombreServicio.Focus();
                return;
            }
            if (!ClsValidar.ValidarLongitudMinima(txtPrecioServicio.Text, 2))
            {
                MessageBox.Show("El Precio debe tener al menos 2 dígitos.");
                txtPrecioServicio.Focus();
                return;
            }
            if (!ClsValidar.ValidarLongitudMinima(txtDescripcionServicio.Text, 5))
            {
                MessageBox.Show("La descripción debe tener al menos 5 caracteres.");
                txtDescripcionServicio.Focus();
                return;
            }

            // Si todos los campos son válidos, realiza la acción de modificar
            string ID = txtIDservicio.Text;
            string Nombre = txtNombreServicio.Text;
            string Descripcion = txtDescripcionServicio.Text;
            float Precio = float.Parse(txtPrecioServicio.Text);

            // Llama a la función de mantenimiento 
            mante.AccionesServicios(ID, Nombre, Descripcion, Precio, "modificar");

            limpiar();
            CargarDatos();
            txtIDservicio.Enabled = true;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }


        //Botón que permite eliminar servicios a la BDD mediante la instancia de la clase MantenimientoServicios
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (ClsValidar.ValidarFormularioServicios(txtIDservicio, txtNombreServicio, txtPrecioServicio))
            {
                string ID = txtIDservicio.Text, Nombre = txtNombreServicio.Text, Descripcion = txtDescripcionServicio.Text;
                float Precio = float.Parse(txtPrecioServicio.Text);

                mante.AccionesServicios(ID, Nombre, Descripcion, Precio, "eliminar");

                limpiar();
                CargarDatos();
                btnAgregar.Enabled = true;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
                
        }

        private void txtPrecioServicio_TextChanged(object sender, EventArgs e)

        {
            ClsValidar.ValidarYCorregirPrecio(txtPrecioServicio);

        }

        private void txtIDservicio_TextChanged(object sender, EventArgs e)
        {            
            ClsValidar.ValidarYCorregirIdentificador(txtIDservicio);
        }

        private void txtNombreServicio_TextChanged(object sender, EventArgs e)
        {
            ClsValidar.ValidarYCorregirNombreServicio(txtNombreServicio);
        }

        private void txtDescripcionServicio_TextChanged(object sender, EventArgs e)
        {
            ClsValidar.ValidarYCorregirDescripcion(txtDescripcionServicio);
        }
    }

}
