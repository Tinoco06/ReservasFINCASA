using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservasFINCASA
{
    public partial class frmConsultaFechas : Form
    {
        int Month, Year;

        //Variables estaticas para pasarlas al otro form de consulta
        public static int StaticMonthInicio, StaticYearInicio, StaticMonthFin, StaticYearFin;

        public frmConsultaFechas()
        {
            InitializeComponent();
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmConsultaFechas_Load(object sender, EventArgs e)
        {
            displaDays();
        }


        private void displaDays() {

            DateTime now = DateTime.Now;
            Month = now.Month;  
            Year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(Month);
            LBDATE.Text = monthname + " " + Year;

            StaticMonthInicio = Month;
            StaticYearInicio = Year;


            
            //LETS get the first day of the month.
            DateTime startofthemonth = new DateTime(Year, Month, 1);
            //get the count of days of the month
            int days = DateTime.DaysInMonth(Year, Month);
            //convert the startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //first ets create a blank usercontrol

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }


            //Crear un usuario de control para los días
            for(int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);  
            }


        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            // Limpiar contenedor
            daycontainer.Controls.Clear();

            // Decrementar el mes para ir al anterior, pero no ir más atrás del mes actual
            DateTime now = DateTime.Now;

            if (Year > now.Year || (Year == now.Year && Month > now.Month))
            {
                if (Month > 1)
                {
                    Month--;
                }
                else if (Month == 1)
                {
                    Month = 12;
                    Year--;
                }
            }

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(Month);
            LBDATE.Text = monthname + " " + Year;

            // Extraer los días del mes y el día de inicio
            DateTime startofthemonth = new DateTime(Year, Month, 1);
            int days = DateTime.DaysInMonth(Year, Month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            // Crear un UserControl en blanco
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            // Crear un UserControl para los días
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void btnVolverFormCliente_Click(object sender, EventArgs e)
        {
            frmInicio inicio = new frmInicio();
            inicio.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSiguienteMes_Click(object sender, EventArgs e)
        {
            // Limpiar contenedor
            daycontainer.Controls.Clear();

            // Incrementar el mes para ir al siguiente, pero no ir más allá de 10 meses en el futuro
            DateTime now = DateTime.Now;
            DateTime futureLimit = now.AddMonths(10);

            DateTime currentMonth = new DateTime(Year, Month, 1);
            DateTime nextMonth = currentMonth.AddMonths(1);

            if (nextMonth <= futureLimit)
            {
                // Incrementar el mes y año
                if (Month == 12)
                {
                    Month = 1;
                    Year++;
                }
                else
                {
                    Month++;
                }
            }

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(Month);
            LBDATE.Text = monthname + " " + Year;

            StaticMonthFin = Month;
            StaticYearFin = Year;

            // Convertir días e inicio de mes
            DateTime startofthemonth = new DateTime(Year, Month, 1);
            int days = DateTime.DaysInMonth(Year, Month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            // Crear nuevos UserControl
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            // Crear un UserControl para los días
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
    }
    }