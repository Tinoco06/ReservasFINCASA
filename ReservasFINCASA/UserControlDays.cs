using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservasFINCASA
{
    public partial class UserControlDays : UserControl
    {
        public static string Static_dayInicio, Static_dayFin, StaticDaySeleccion;

        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void days(int numday)
        {
            lbdays.Text = numday + "";
        }

        private void UserControlDays_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void UserControlDays_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            Static_dayInicio = lbdays.Text;
            FrmFechasParaReservas fechas = new FrmFechasParaReservas();
            fechas.Show();

        }
    }
    
    }

