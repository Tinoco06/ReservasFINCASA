using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ReservasFINCASA
{
    public partial class frmFactura : Form
    {
        public frmFactura(String NombreCliente, String DNIcliente, String TotalReserva)
        {
            InitializeComponent();

            //Llenar los datos con los grids del form anterior
            txtNombreCliente.Text = NombreCliente;
            txtClienteDNI.Text = DNIcliente;
            txtFechaFactura.Text = DateTime.Now.ToString("dd/MM/yy");

            // Configurar las columnas del DataGridView
            dgvDetalleFactura.Columns.Add("cantidad", "CANTIDAD");
            dgvDetalleFactura.Columns.Add("descripcion", "DESCRIPCIÓN");
            dgvDetalleFactura.Columns.Add("precioUnitario", "PRECIO UNITARIO");
            dgvDetalleFactura.Columns.Add("total", "TOTAL");

            // Ajustar el estilo de las columnas si es necesario
            dgvDetalleFactura.Columns["precioUnitario"].DefaultCellStyle.Format = "L 0.00";
            dgvDetalleFactura.Columns["total"].DefaultCellStyle.Format = "L 0.00";

            // Ajustar la anchura de las columnas
            dgvDetalleFactura.Columns["cantidad"].Width = 90;
            dgvDetalleFactura.Columns["descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDetalleFactura.Columns["precioUnitario"].Width = 100;
            dgvDetalleFactura.Columns["total"].Width = 100;

            txtTotalAPagar.Text = TotalReserva;
            float Total = float.Parse(TotalReserva);
            float ImpuestoTurismo = 0, ISV15 = 0;

            ImpuestoTurismo = Total * 0.04f;
            ISV15 = Total * 0.15F;

            txtImporteTurismo.Text = ImpuestoTurismo.ToString();
            txtISV15.Text = ISV15.ToString();

        }

        // Método para agregar filas al DataGridView
        public void AgregarFilaFactura(int cantidad, string descripcion, decimal precioUnitario)
        {
            // Calcular el total
            decimal total = cantidad * precioUnitario;

            // Agregar la fila al DataGridView
            dgvDetalleFactura.Rows.Add(cantidad, descripcion, precioUnitario, total);
        }

        //Función imprimir donde obtiene el área del formulario y a su vez obtener una captura para poder imprimirla.
        void ImprimirForm(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X; //Representa la coordenada x 
            int y = SystemInformation.WorkingArea.Y; //Representa la coordenada y
            int ancho = this.Width;
            int alto = this.Height;

            Rectangle limites = new Rectangle(x, y, ancho, alto); //Establece los límites del formulario

            Bitmap img = new Bitmap(ancho, alto); //Objeto usado para trabajar con imágenes definidos por data pixeles

            this.DrawToBitmap(img, limites);//Recibe el width y height y los límites que va a imprimir.
            Point p = new Point(100, 100);//Representa el par de coordenadas (x,y) que está definido por un punto en un plano bidimensional.
            e.Graphics.DrawImage(img, p);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            frmInicio inicio = new frmInicio();
            inicio.Show();
            this.Hide();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            btnInicio.Visible = false;
            btnCerrar.Visible = false;
            btnImprimir.Visible = false;
            btnMinimizar.Visible = false;
            PrintDocument imp = new PrintDocument();
            imp.PrintPage += new PrintPageEventHandler(ImprimirForm);
            imp.Print();
            btnInicio.Visible = true;
            btnCerrar.Visible = true;
            btnImprimir.Visible = true;
            btnMinimizar.Visible = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public void CambiarCotizacion()
        {
            lblTitulo.Text = "COTIZACIÓN";
            lblCAI.Visible = false;
            lblFactura.Visible= false;
            lblNumeroExento.Visible= false;
            txtNumeroExento.Visible = false;
            lblRegistroExonerado.Visible= false;
            txtRegistroExonerado.Visible = false;
            lblIdentificativoSAG.Visible= false;
            txtIdentificativoSAG.Visible = false;
            txtImporteExento.Visible= false;
            lblImporteExento.Visible=false;
            lblImporteExonerado.Visible = false;
            txtImporteExonerado.Visible = false;
            txtImporteGravado15.Visible= false;
            lblImporteGravado15.Visible= false;
            txtImporteGravado18.Visible= false;
            lblImporteGravado18.Visible= false;

        }

        private void frmFactura_Load(object sender, EventArgs e)
        {

        }

        private void txtClienteDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtImporteExonerado_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDetalleFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtNumeroExento_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRegistroExonerado_Click(object sender, EventArgs e)
        {

        }
    }
}
