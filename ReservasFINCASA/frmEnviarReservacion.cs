using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservasFINCASA
{
    public partial class frmEnviarReservacion : Form
    {
        //Definicion de variables de correo y detalles de los data grid
        const string Usuario = "tinocojorge6@gmail.com";
        const string Password = "poyl ucnu kiuv laos";
        private string detalleCabanas;
        private string detalleServicios;

        public frmEnviarReservacion(string detalleCabanas, string detalleServicios, string nombreCliente, string correoCliente)
        {
            InitializeComponent();
            this.detalleCabanas = detalleCabanas;
            this.detalleServicios = detalleServicios;

            // Construir el mensaje de correo electrónico
            string mensajeCorreo = ConstruirMensajeCorreo(detalleCabanas, detalleServicios);

            // Asignar el mensaje al TextBox
            txtMensaje.Text = $"¡Hola {nombreCliente}! \r\n\r\nUsted ha realizado una reservación en FINCASA, a continuación se muestra el detalle.\r\n\r\n" +
                $"{mensajeCorreo}\r\nLa hora de ingreso al complejo es a la 1:00 p.m, la hora de salida será a las 12 del mediodía según el último día de su reserva. \r\n\r\n" +
                $"Ubicados en: San Pedro Zacapa, Santa Bárbara\r\nhttps://maps.app.goo.gl/Vck1j7WtLxsLTH7M6\r\n\r\nAgradecemos su preferencia. No responda este mensaje.\r\n";                
            txtAsunto.Text = "Confirmación de reservación.";
            txtPara.Text = correoCliente;
            txtDe.Text = "tinocojorge6@gmail.com";

        }

        private void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
            //Enviar el mensaje con la funcion Enviar correo
            string Error = "";
            StringBuilder MensajeBuilder = new StringBuilder();
            MensajeBuilder.Append(txtMensaje.Text.Trim());
            EnviarCorreo(MensajeBuilder, DateTime.Now, txtDe.Text.Trim(), txtPara.Text.Trim(), txtAsunto.Text.Trim(), out Error);
        }

        //Extraer los datos del grid y agregarlos 
        public static string ConstruirMensajeCorreo(string detalleCabanas, string detalleServicios)
        {
            StringBuilder mensajeBuilder = new StringBuilder();

            mensajeBuilder.AppendLine("Detalles de Cabanas:");
            mensajeBuilder.AppendLine(detalleCabanas);
            mensajeBuilder.AppendLine();
            mensajeBuilder.AppendLine("Detalles de Servicios:");
            mensajeBuilder.AppendLine(detalleServicios);

            return mensajeBuilder.ToString();
        }

        //Enviar correo y asignar parametros al mismo
        public static void EnviarCorreo(StringBuilder Mensaje, DateTime FechaEnvio, string De, string Para, string Asunto, out string Error)
        {
            Error = "";
            try
            {
                Mensaje.Append(Environment.NewLine);
                Mensaje.Append(string.Format("Este correo ha sido enviado el dia {0:dd/MM/yyyy} a las {0:HH:mm:ss} Hrs:\n\n", FechaEnvio));
                Mensaje.Append(Environment.NewLine);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(De);
                mail.To.Add(Para);
                mail.Subject = Asunto;
                mail.Body = Mensaje.ToString();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(Usuario, Password);
                smtp.EnableSsl = true;
                smtp.Send(mail);
                Error = "Exito";
                MessageBox.Show(Error);

            }
            catch (Exception ex)
            {
                Error = "Error: " + ex.Message;
                MessageBox.Show(Error);
                return;
            }
        }

        //Botón cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Botón minimizar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
