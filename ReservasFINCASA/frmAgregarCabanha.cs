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
        //Instancias de conexión y clases
        private ConexionSQL conexionSQL = new ConexionSQL();
        MantenimientoCabanhas mante = new MantenimientoCabanhas();

        public frmAgregarCabanha()
        {
            InitializeComponent();
            ClsValidar form1 = new ClsValidar();
            txtDescripcionCabanha.KeyPress += new KeyPressEventHandler(form1.GeneralKeyPressHandler);
            txtIDcabaña.KeyPress += new KeyPressEventHandler(form1.GeneralKeyPressHandler);
            txtNombreCabanha.KeyPress += new KeyPressEventHandler(form1.GeneralKeyPressHandler);
            txtPrecioCabanha.KeyPress += new KeyPressEventHandler(form1.Precio_KeyPress);        
            txtCapacidadCabanha.KeyPress += new KeyPressEventHandler(form1.Precio_KeyPress);
        }

        //Boton inicio para regresar al menu
        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            frmInicio frmInicio = new frmInicio();
            this.Hide();
            frmInicio.Show();
            
        }

        private void CargarDatos()
        {
            CargarGrids.LlenarCRUDCabanas(dgvCabanhas);
        }

        //Mostrar los datos cuando el formulario se cargue
        private void frmAgregarCabanha_Load(object sender, EventArgs e)
        {
            CargarDatos();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        //Función para limpiar los controles del formulario
        public void limpiar()
        {
            txtIDcabaña.Text = "";
            txtNombreCabanha.Text = "";
            txtDescripcionCabanha.Text = "";
            txtCapacidadCabanha.Text = "";
            txtPrecioCabanha.Text = "";
        }

        //Agregar un registro a la BDD
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Primero valida si todos los campos están vacíos
            if (ClsValidar.ValidarFormularioCabanas(txtIDcabaña, txtNombreCabanha, txtPrecioCabanha, txtCapacidadCabanha))
            {
                // Si no están vacíos, realiza las validaciones individuales
                if (!ClsValidar.ValidarLongitudMinima(txtIDcabaña.Text, 2))
                {
                    MessageBox.Show("El identificador debe tener al menos 2 caracteres.");
                    txtIDcabaña.Focus();
                    return;
                }
                if (!ClsValidar.ValidarLongitudMinima(txtPrecioCabanha.Text, 3))
                {
                    MessageBox.Show("El Precio debe tener al menos 3 dígitos.");
                    txtPrecioCabanha.Focus();
                    return;
                }
                if (!ClsValidar.ValidarLongitudMinima(txtNombreCabanha.Text, 3))
                {
                    MessageBox.Show("El nombre debe tener al menos 3 caracteres.");
                    txtNombreCabanha.Focus();
                    return;
                }
                if (!ClsValidar.ValidarLongitudMinima(txtCapacidadCabanha.Text, 1))
                {
                    MessageBox.Show("En la Capacidad de Cabaña debe tener al menos 1 carácter.");
                    txtCapacidadCabanha.Focus();
                    return;
                }
                if (!ClsValidar.ValidarLongitudMinima(txtDescripcionCabanha.Text, 5))
                {
                    MessageBox.Show("En la descripción de cabaña debe tener al menos 5 carácteres.");
                    txtCapacidadCabanha.Focus();
                    return;
                }

                // Verificar si el ID ya existe en el dgv
                String ID = txtIDcabaña.Text;
                if (ClsValidar.EsIdCabanhaUnico(dgvCabanhas, ID))
                {
                    String nombre = txtNombreCabanha.Text;
                    String descripcion = txtDescripcionCabanha.Text;
                    int capacidad = int.Parse(txtCapacidadCabanha.Text);
                    float precio = float.Parse(txtPrecioCabanha.Text);

                    // Llama a la función de mantenimiento
                    mante.AccionesCabanhas(ID, nombre, descripcion, capacidad, precio, "agregar");

                    CargarDatos();
                    limpiar();
                }
                else
                {
                    MessageBox.Show("El ID ingresado ya existe. Por favor ingrese un ID diferente.");
                    txtIDcabaña.Text = "";
                    txtIDcabaña.Focus();
                }
            }
        }

        //Llenar los controles con la información del grid
        private void dgvCabanhas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDcabaña.Text = dgvCabanhas.CurrentRow.Cells[0].Value.ToString();
            txtNombreCabanha.Text = dgvCabanhas.CurrentRow.Cells[1].Value.ToString();
            txtDescripcionCabanha.Text = dgvCabanhas.CurrentRow.Cells[2].Value.ToString();
            txtCapacidadCabanha.Text = dgvCabanhas.CurrentRow.Cells[3].Value.ToString();
            txtPrecioCabanha.Text = dgvCabanhas.CurrentRow.Cells[4].Value.ToString();
            txtIDcabaña.Enabled = false;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;

        }

        //Modificar registro en la BDD
        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Primero valida si todos los campos están vacíos
            if (ClsValidar.ValidarFormularioCabanas(txtIDcabaña, txtNombreCabanha, txtPrecioCabanha, txtCapacidadCabanha))
            {
                // Si no están vacíos, realiza las validaciones individuales
                if (!ClsValidar.ValidarLongitudMinima(txtIDcabaña.Text, 2))
                {
                    MessageBox.Show("El identificador debe tener al menos 2 caracteres.");
                    txtIDcabaña.Focus();
                    return;
                }
                if (!ClsValidar.ValidarLongitudMinima(txtPrecioCabanha.Text, 3))
                {
                    MessageBox.Show("El Precio debe tener al menos 3 dígitos.");
                    txtPrecioCabanha.Focus();
                    return;
                }
                if (!ClsValidar.ValidarLongitudMinima(txtNombreCabanha.Text, 3))
                {
                    MessageBox.Show("El nombre debe tener al menos 3 caracteres.");
                    txtNombreCabanha.Focus();
                    return;
                }
                if (!ClsValidar.ValidarLongitudMinima(txtCapacidadCabanha.Text, 1))
                {
                    MessageBox.Show("La capacidad de la cabaña debe tener al menos 1 carácter.");
                    txtCapacidadCabanha.Focus();
                    return;
                }
                if (!ClsValidar.ValidarLongitudMinima(txtDescripcionCabanha.Text, 5))
                {
                    MessageBox.Show("En la descripción de cabaña debe tener al menos 5 carácteres.");
                    txtCapacidadCabanha.Focus();
                    return;
                }
                // Si todos los campos son válidos, realiza la modificación
                String ID = txtIDcabaña.Text;
                String nombre = txtNombreCabanha.Text;
                String descripcion = txtDescripcionCabanha.Text;
                int capacidad = int.Parse(txtCapacidadCabanha.Text);
                float precio = float.Parse(txtPrecioCabanha.Text);

                // Llama a la función de mantenimiento 
                mante.AccionesCabanhas(ID, nombre, descripcion, capacidad, precio, "modificar");

                CargarDatos();
                limpiar();

                btnAgregar.Enabled = true;
                txtIDcabaña.Enabled = true;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        //Eliminar registro en la BDD
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(ClsValidar.ValidarFormularioCabanas(txtIDcabaña, txtNombreCabanha, txtPrecioCabanha, txtCapacidadCabanha))
            {
                String ID = txtIDcabaña.Text, nombre = txtNombreCabanha.Text, descripcion = txtDescripcionCabanha.Text;
                int capacidad = int.Parse(txtCapacidadCabanha.Text);
                float precio = float.Parse(txtPrecioCabanha.Text);

                mante.AccionesCabanhas(ID, nombre, descripcion, capacidad, precio, "eliminar");

                CargarDatos();
                limpiar();
                btnAgregar.Enabled = true;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }   
        }

        //Botón limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txtIDcabaña_TextChanged(object sender, EventArgs e)
        {
            ClsValidar.ValidarYCorregirIdentificador(txtIDcabaña);
        }

        private void txtPrecioCabanha_TextChanged(object sender, EventArgs e)
        {
            ClsValidar.ValidarYCorregirPrecio(txtPrecioCabanha);
        }

        private void txtNombreCabanha_TextChanged(object sender, EventArgs e)
        {
            ClsValidar.ValidarYCorregirNombreServicio(txtNombreCabanha);
        }

        private void txtDescripcionCabanha_TextChanged(object sender, EventArgs e)
        {
            ClsValidar.ValidarYCorregirDescripcion(txtDescripcionCabanha);
        }

        private void txtCapacidadCabanha_TextChanged(object sender, EventArgs e)
        {
            ClsValidar.ValidarNumerosMenoresQueCien(txtCapacidadCabanha);
        }
    }
}
