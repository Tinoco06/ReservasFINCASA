using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace ReservasFINCASA
{
    class Placeholder:TextBox //Herencia para poder usar los componentes
    {

        //Constructor de la clase
        public Placeholder() 
        {
            //Adicion de los handler
            this.Enter += new EventHandler(txt_Enter);
            this.Leave += new EventHandler(txt_Leave);
            base.ForeColor = Color.DimGray;
        }

        //Atributo para la propiedad
        private String placeHolder;

        //Descripcion y categoria que apareceran en las propiedades de nuestro textbox
        [Description("Text para el placeholder")]
        [Category("FINCASA TextBox")]

        public String PlaceHolder 
        {  
            get { return placeHolder; }
            set {  placeHolder = value; }
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            //Obtener textbox que hizo la invocacion
            TextBox txt = sender as TextBox;

            //Si el TextBox tiene el placeholder cambia a vacío y cambia el color de la fuente
            if(txt.Text == placeHolder)
            {
                txt.Text = string.Empty;
                txt.ForeColor = Color.Black;
            }
        }

        //Método para el handler cuando el foco no esta en el TextBox
        private void txt_Leave(object sender, EventArgs e)
        {
            //Si esta vacío pone el string que se puso en el placeholder
            TextBox txt = sender as TextBox;
            if (txt.Text == string.Empty) 
            {
                txt.Text = placeHolder;
                txt.ForeColor = Color.DimGray;
            }
        }

    }
}
