using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ReservasFINCASA
{
    internal class ClsValidar
    {
        //Función que valida el número de Identidad, lo extrae en un string
        public static void ValidarDNI(TextBox textBox)
        {
            string dniStr = textBox.Text;

            // Eliminar caracteres no numéricos
            dniStr = new String(dniStr.Where(Char.IsDigit).ToArray());

            if (!string.IsNullOrEmpty(dniStr))
            {
                // Regla para el primer dígito (0 o 1)
                if (dniStr.Length > 0 && (dniStr[0] != '0' && dniStr[0] != '1'))
                {
                    dniStr = "";
                }

                // Regla para el segundo dígito (1-8)
                if (dniStr.Length > 1 && (dniStr[1] < '0' || dniStr[1] > '8'))
                {
                    dniStr = dniStr.Substring(0, 1);
                }

                // Regla para el tercer dígito (0-2)
                if (dniStr.Length > 2 && (dniStr[2] < '0' || dniStr[2] > '2'))
                {
                    dniStr = dniStr.Substring(0, 2);
                }

                // Regla para evitar '111' en los primeros tres dígitos
                if (dniStr.Length > 2 && dniStr.Substring(0, 3) == "111")
                {
                    dniStr = dniStr.Substring(0, 2);
                }

                // Regla para el cuarto dígito (0-8)
                if (dniStr.Length > 3 && (dniStr[3] < '0' || dniStr[3] > '8'))
                {
                    dniStr = dniStr.Substring(0, 3);
                }

                // Regla para evitar '00' en el tercer y cuarto dígito
                if (dniStr.Length > 3 && dniStr.Substring(2, 2) == "00")
                {
                    dniStr = dniStr.Substring(0, 3);
                }

                // Validación del año en los próximos 4 dígitos (debe estar entre 1900 y el año actual)
                if (dniStr.Length > 7)
                {
                    string yearStr = dniStr.Substring(4, Math.Min(4, dniStr.Length - 4));
                    int year;
                    if (yearStr.Length == 4 && int.TryParse(yearStr, out year) && (year >= 1900 && year <= DateTime.Now.Year))
                    {
                        // Año válido
                    }
                    else
                    {
                        dniStr = dniStr.Substring(0, 4);
                    }
                }

                // Regla para el quinto dígito (permitir cualquier valor de 0 a 9)
                if (dniStr.Length > 8)
                {
                    string middleDigits = dniStr.Substring(8, Math.Min(4, dniStr.Length - 8));
                    if (!middleDigits.All(c => c >= '0' && c <= '9'))
                    {
                        dniStr = dniStr.Substring(0, 8);
                    }
                }

                // Regla para el decimotercer dígito (no puede ser 0)
                if (dniStr.Length > 12 && dniStr[12] == '0')
                {
                    dniStr = dniStr.Substring(0, 12);
                }
            }

            textBox.Text = dniStr;
            textBox.SelectionStart = dniStr.Length;
        }


        public static void ValidarTelefono(TextBox textBox)
        {
            if (textBox != null)
            {
                textBox.MaxLength = 8;
                string texto = textBox.Text;

                // Verificar si el texto no está vacío y el primer carácter si no es permitido
                if (!string.IsNullOrEmpty(texto) && !NumeroPermitido(texto[0]))
                {
                    // Eliminar el primer carácter si no permitido
                    textBox.Text = texto.Substring(1);
                    // Colocar el cursor al final del texto
                    textBox.SelectionStart = textBox.TextLength;
                }

                string Tlf = textBox.Text;

                // Permitir retroceso
                if (Tlf.Length > 0 && Tlf[Tlf.Length - 1] == '\b')
                    return;

                // Verificar caracteres repetidos más de cuatro veces consecutivas, para cualquier número
                for (int i = 0; i <= Tlf.Length - 5; i++)
                {
                    if (Tlf[i] == Tlf[i + 1] && Tlf[i] == Tlf[i + 2] && Tlf[i] == Tlf[i + 3] && Tlf[i] == Tlf[i + 4])
                    {
                        MessageBox.Show("No se permiten más de cuatro caracteres repetidos consecutivamente.");
                        textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1); // Eliminar el último carácter
                        textBox.SelectionStart = textBox.Text.Length; // Colocar el cursor al final
                        return;
                    }
                }

                // Verificar que no haya más de cuatro ceros consecutivos
                for (int i = 0; i <= Tlf.Length - 5; i++)
                {
                    if (Tlf.Substring(i, 5).Equals("00000"))
                    {
                        MessageBox.Show("No se permiten más de cuatro ceros consecutivos.");
                        textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1); // Eliminar el último carácter
                        textBox.SelectionStart = textBox.Text.Length; // Colocar el cursor al final
                        return;
                    }
                }
            }
        }



        private static bool NumeroPermitido(char caracter)
        {
            return (caracter == '3' || caracter == '8' || caracter == '9' || caracter == '2');
        }

        //Validaciones Jose

        //Validar si ya hay una cabaña con el ID ingresado
        public static bool EsIdCabanhaUnico(DataGridView dgv, string idCabanha)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells["CabanaID"].Value.ToString().Equals(idCabanha, StringComparison.OrdinalIgnoreCase))
                {
                    // Si el ID de la cabaña ya existe devuelve false
                    return false;
                }
            }
            // Si el ID de la cabaña no existe devuelve true
            return true;
        }

        public static bool EsIdServicioUnico(DataGridView dgv, string idServicio)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells["ServicioID"].Value.ToString().Equals(idServicio, StringComparison.OrdinalIgnoreCase))
                {
                    // Si el ID del servicio ya existe devuelve false
                    return false;
                }
            }
            // Si el ID del servicio no existe devuelve true
            return true;
        }



        //Validar txt individual
        public static bool ValidarTextBox(TextBox textBox)
        {
            // Retorna true si no está vacío
            return textBox != null && !string.IsNullOrWhiteSpace(textBox.Text);
        }

        // Método para validar todo el formulario servicios
        public static bool ValidarFormularioServicios(TextBox txtIdentificador, TextBox txtNombre, TextBox txtPrecio)
        {
            // Verifica si todos los campos están vacíos
            bool todosVacios = string.IsNullOrWhiteSpace(txtIdentificador.Text) &&
                               string.IsNullOrWhiteSpace(txtNombre.Text) &&
                               string.IsNullOrWhiteSpace(txtPrecio.Text);

            if (todosVacios)
            {
                MessageBox.Show("Todos los campos están vacíos. Por favor, complete al menos uno.");
                txtIdentificador.Focus();
                return false;
            }

            // Valida cada campo individualmente
            if (!ValidarTextBox(txtIdentificador))
            {
                MessageBox.Show("El identificador del servicio es requerido.");
                txtIdentificador.Focus();
                return false;
            }
            if (!ValidarTextBox(txtNombre))
            {
                MessageBox.Show("El nombre del servicio es requerido.");
                txtNombre.Focus();
                return false;
            }
            if (!ValidarTextBox(txtPrecio))
            {
                MessageBox.Show("El precio es requerido.");
                txtPrecio.Focus();
                return false;
            }

            // Si todo está correcto, retorna true
            return true;
        }



        // Método para validar todo el formulario cabañas
        public static bool ValidarFormularioCabanas(TextBox txtIdentificador, TextBox txtNombre, TextBox txtPrecio, TextBox txtCapacidad)
        {            
                bool todosVacios = string.IsNullOrWhiteSpace(txtIdentificador.Text) &&
                                   string.IsNullOrWhiteSpace(txtNombre.Text) &&
                                   string.IsNullOrWhiteSpace(txtPrecio.Text) &&
                                   string.IsNullOrWhiteSpace(txtCapacidad.Text);

                if (todosVacios)
                {
                    MessageBox.Show("Todos los campos están vacíos. Por favor, complete al menos uno.");
                    txtIdentificador.Focus();
                    return false;
                }

                if (!ValidarTextBox(txtIdentificador))
                {
                    MessageBox.Show("El identificador de la cabaña es requerido.");
                    txtIdentificador.Focus();
                    return false;
                }
                if (!ValidarTextBox(txtNombre))
                {
                    MessageBox.Show("El nombre de la cabaña es requerido.");
                    txtNombre.Focus();
                    return false;
                }
                if (!ValidarTextBox(txtPrecio))
                {
                    MessageBox.Show("El precio por noche es requerido.");
                    txtPrecio.Focus();
                    return false;
                }
                if (!ValidarTextBox(txtCapacidad))
                {
                    MessageBox.Show("La capacidad es requerida.");
                    txtCapacidad.Focus();
                    return false;
                }

                return true;
        }
        

        // Método para validar que la fecha no sea anterior a la fecha actual
        public bool ValidarFechaNoPasada(DateTime fechaSeleccionada)
        {
            return fechaSeleccionada >= DateTime.Now.Date;
        }

        public static void ValidarYCorregirIdentificador(TextBox textBoxIdentificador)
        {
            string identificador = textBoxIdentificador.Text;

            // Primero, eliminamos espacios en blanco al inicio y al final
            identificador = identificador.Trim();

            // Luego, nos aseguramos de que no exceda la longitud máxima permitida
            if (identificador.Length > 10)
            {
                identificador = identificador.Substring(0, 10);
            }

            // Reemplazamos cualquier carácter que no sea letra, número o espacio con una cadena vacía
            identificador = Regex.Replace(identificador, @"[^a-zA-Z0-9\s]", "");

            // Finalmente, actualizamos el texto del TextBox solo si es necesario
            if (textBoxIdentificador.Text != identificador)
            {
                textBoxIdentificador.Text = identificador;
                // Mover el cursor al final del texto
                textBoxIdentificador.SelectionStart = identificador.Length;
            }
        }

        public static void ValidarYCorregirPrecio(TextBox textBoxPrecio)
        {
            string precioTexto = textBoxPrecio.Text;

            // Eliminar caracteres no permitidos (manteniendo dígitos, punto decimal y borrando otros caracteres)
            precioTexto = Regex.Replace(precioTexto, @"[^\d.]", "");

            // Verificar que solo tenga un punto decimal y no más de dos dígitos después del punto
            if (precioTexto.Contains('.'))
            {
                var partes = precioTexto.Split('.');
                if (partes.Length == 2)
                {
                    precioTexto = partes[0] + "." + partes[1].Substring(0, Math.Min(2, partes[1].Length));
                }
            }

            // Limitar la parte entera a 4 dígitos
            var puntoIndex = precioTexto.IndexOf('.');
            if (puntoIndex > 4)
            {
                precioTexto = precioTexto.Substring(0, 4) + precioTexto.Substring(puntoIndex);
            }
            else if (puntoIndex == -1 && precioTexto.Length > 4)
            {
                precioTexto = precioTexto.Substring(0, 4);
            }

            // Asignar el valor corregido al TextBox
            textBoxPrecio.Text = precioTexto;
            textBoxPrecio.SelectionStart = textBoxPrecio.Text.Length;
        }

        public static void ValidarYCorregirNombreServicio(TextBox textBoxNombre)
        {
            string nombre = textBoxNombre.Text;

            // Eliminar caracteres que no sean letras o espacios
            nombre = Regex.Replace(nombre, @"[^a-zA-ZñÑ\s]", "");

            // Ajustar la longitud para que esté dentro del rango permitido
            if (nombre.Length > 20)
            {
                nombre = nombre.Substring(0, 20);
            }
            else if (nombre.Length < 5 && nombre.Length > 0)
            {
                // Si el nombre es demasiado corto, pero no está vacío, no lo modificamos aquí
                // Dejar esta validación para cuando el usuario termine de escribir
            }

            // Actualizar el texto del TextBox solo si es necesario
            if (textBoxNombre.Text != nombre)
            {
                textBoxNombre.Text = nombre;
                // Mover el cursor al final del texto
                textBoxNombre.SelectionStart = nombre.Length;
            }
        }


        public static void ValidarYCorregirDescripcion(TextBox textBoxDescripcion)
        {
            string descripcion = textBoxDescripcion.Text;

            // Eliminar caracteres especiales no permitidos, manteniendo letras, números, espacios, comas, puntos y puntos y coma
            descripcion = Regex.Replace(descripcion, @"[^a-zA-ZñÑ0-9\s,.;]", "");

            // Ajustar la descripción para que no exceda los 300 caracteres
            if (descripcion.Length > 300)
            {
                descripcion = descripcion.Substring(0, 300);
            }

            // Aplicar los cambios al TextBox, si es necesario
            if (textBoxDescripcion.Text != descripcion)
            {
                textBoxDescripcion.Text = descripcion;
                // Mover el cursor al final del texto
                textBoxDescripcion.SelectionStart = descripcion.Length;
            }
        }
        public static void ValidarNumerosMenoresQueCien(TextBox textBox)
        {
            textBox.KeyPress += (sender, e) =>
            {
                // Permite el control de teclas de retroceso
                if (e.KeyChar == (char)Keys.Back)
                {
                    return; // Permite la acción predeterminada (borrar)
                }

                // Rechaza cualquier tecla que no sea un dígito y evita ceros al inicio si no hay otro número
                if (!char.IsDigit(e.KeyChar) || (textBox.Text.Length == 0 && e.KeyChar == '0'))
                {
                    e.Handled = true; // Rechaza el resto de teclas
                    return;
                }

                // Concatena el nuevo caracter al final del texto actual del TextBox para validar el número resultante
                string textoCompleto = textBox.Text.Insert(textBox.SelectionStart, e.KeyChar.ToString());

                // Intenta convertir el texto completo a número y comprueba si es mayor que 99
                if (int.TryParse(textoCompleto, out int numero) && numero > 99)
                {
                    e.Handled = true; // Rechaza el número si es mayor que 99
                }
                else if (textBox.Text.StartsWith("0"))
                {
                    // Evita ceros al inicio si ya hay un cero y se está intentando ingresar otro número
                    e.Handled = true;
                }
            };

        }


        //Valdiaciones de moncada
        //Validacion Login Usuario y Contrasena
        //Validacion FMRcliente

        public static bool ValidarLongitudMinima(string texto, int minLength)
        {
            return !string.IsNullOrWhiteSpace(texto) && texto.Trim().Length >= minLength;
        }

        public static string EliminarEspacios(string texto)
        {
            return Regex.Replace(texto, @"\s+", "");
        }

        public static void ValidarNombreApellidoTextBox(TextBox txt)
        {
            // Limita la longitud del texto a 50 caracteres
            if (txt.Text.Length > 30)
            {
                txt.Text = txt.Text.Substring(0, 30);
            }

            // Permite solo letras, un solo espacio y apóstrofes, incluyendo la ñ y Ñ
            txt.Text = Regex.Replace(txt.Text, @"[^a-zA-ZñÑ'\s]", "");

            // Elimina espacios múltiples y asegúrate de que solo haya un espacio
            txt.Text = Regex.Replace(txt.Text, @"\s+", " ");

            // Elimina espacios al principio
            txt.Text = txt.Text.TrimStart();

            // Elimina secuencias de tres caracteres idénticos
            txt.Text = Regex.Replace(txt.Text, @"(.)\1\1", "$1$1");

            // Asegúrate de que la primera letra de cada palabra sea mayúscula
            txt.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt.Text.ToLower());

            // Establece la posición del cursor al final del texto
            txt.SelectionStart = txt.Text.Length;
        }


        public static void ValidarEmailTextBox(TextBox txtEmail)
        {
            // Eliminar espacios en blanco inmediatamente
            var emailSinEspacios = txtEmail.Text.Replace(" ", "");

            // Asignar el texto sin espacios al TextBox
            txtEmail.Text = emailSinEspacios;

            // Verificar si el email cumple con el patrón de un correo electrónico válido
            bool esEmailValido = Regex.IsMatch(emailSinEspacios, @"^[a-zA-Z0-9!#$%&'*+/=?^_`{|}~.-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");

            // Verificar longitud mínima y máxima
            if (emailSinEspacios.Length < 6 || emailSinEspacios.Length > 254)
            {
                esEmailValido = false;
            }

            // Verificar que contenga exactamente un símbolo '@'
            int atCount = emailSinEspacios.Count(c => c == '@');
            if (atCount != 1)
            {
                esEmailValido = false;
            }

            // Separar en parte local y dominio
            string[] emailParts = emailSinEspacios.Split('@');
            if (emailParts.Length != 2)
            {
                esEmailValido = false;
            }
            else
            {
                // Verificar longitud de la parte local (mínimo 3 caracteres)
                string localPart = emailParts[0];
                if (localPart.Length < 3 || localPart.Length > 64)
                {
                    esEmailValido = false;
                }

                // Verificar longitud del dominio
                string domainPart = emailParts[1];
                if (domainPart.Length < 4 || domainPart.Length > 253)
                {
                    esEmailValido = false;
                }

                // Verificar que el dominio contenga al menos un punto y que no sea el primero o el último carácter
                if (!domainPart.Contains('.') || domainPart.StartsWith(".") || domainPart.EndsWith("."))
                {
                    esEmailValido = false;
                }

                // Verificar que las etiquetas del dominio sean válidas
                string[] domainLabels = domainPart.Split('.');
                foreach (string label in domainLabels)
                {
                    if (label.Length < 2 || !Regex.IsMatch(label, @"^[a-zA-Z0-9-]+$") || label.StartsWith("-") || label.EndsWith("-"))
                    {
                        esEmailValido = false;
                        break;
                    }
                }

                // Verificar que el dominio principal tenga al menos 2 caracteres
                if (domainLabels.Length < 2 || domainLabels[0].Length < 2)
                {
                    esEmailValido = false;
                }

                // Verificar que el dominio final tenga al menos 2 caracteres
                string lastDomainLabel = domainLabels.Last();
                if (lastDomainLabel.Length < 2 || !Regex.IsMatch(lastDomainLabel, @"^[a-zA-Z]{2,}$"))
                {
                    esEmailValido = false;
                }
            }

            // Cambiar el color de fondo del TextBox según si el email es válido o no
            txtEmail.BackColor = esEmailValido || string.IsNullOrEmpty(emailSinEspacios) ? System.Drawing.Color.LightGray : System.Drawing.Color.LightCoral;

            // Colocar el cursor al final del texto del TextBox
            txtEmail.SelectionStart = txtEmail.Text.Length;
        }

        public static void ValidarLugarProcedenciaTextBox(TextBox txt)
        {
            if (txt == null) return;

            // Limitar la longitud del texto a 30 caracteres
            txt.MaxLength = 30;

            // Permite solo letras y espacios y elimina caracteres no deseados
            txt.Text = new string(txt.Text.Where(c => char.IsLetter(c) || c == ' ').ToArray());

            // Asegúrate de que el texto no supere el límite de 30 caracteres
            if (txt.Text.Length > 30)
            {
                txt.Text = txt.Text.Substring(0, 30);
            }

            // Elimina caracteres repetidos más de dos veces consecutivas
            txt.Text = Regex.Replace(txt.Text, @"(.)\1{2,}", "$1$1");

            // Elimina espacios en blanco seguidos
            txt.Text = Regex.Replace(txt.Text, @"\s+", " ");

            // Establece la posición del cursor al final del texto
            txt.SelectionStart = txt.Text.Length;
        }



        public static bool ValidarEmpresaTextBox(TextBox txtEmpresa)
        {
            string textoValidado = new string(txtEmpresa.Text.Where(c => char.IsLetter(c) || c == ' ').ToArray());

            if (textoValidado.Length > 50)
            {
                textoValidado = textoValidado.Substring(0, 50);
            }

            // Elimina caracteres repetidos más de dos veces consecutivas
            textoValidado = Regex.Replace(textoValidado, @"(.)\1{2,}", "$1$1");

            // Elimina espacios en blanco seguidos
            textoValidado = Regex.Replace(textoValidado, @"\s+", " ");

            // Actualiza el TextBox solo si es necesario para evitar el parpadeo innecesario y el movimiento del cursor
            if (txtEmpresa.Text != textoValidado)
            {
                int cursorPosition = txtEmpresa.SelectionStart; // Guarda la posición del cursor
                txtEmpresa.Text = textoValidado;

                // Restaura la posición del cursor
                txtEmpresa.SelectionStart = cursorPosition <= textoValidado.Length ? cursorPosition : textoValidado.Length;
            }

            // Valida que el campo tenga un mínimo de 3 caracteres si no está vacío
            if (!string.IsNullOrWhiteSpace(txtEmpresa.Text) && txtEmpresa.Text.Length < 3)
            {
                return false;
            }

            return true;
        }


        public static string ValidarUsuario(string texto)
        {
            // Eliminar espacios en blanco y números
            texto = new string((texto.Where(c => char.IsLetter(c) && !char.IsDigit(c))).ToArray());

            // Asegurarse de que el texto no está vacío y la primera letra es mayúscula
            if (texto.Length > 0 && !char.IsUpper(texto[0]))
            {
                texto = char.ToUpper(texto[0]) + texto.Substring(1);
            }

            // Asegurar que las letras después de la primera sean minúsculas
            if (texto.Length > 1)
            {
                texto = texto[0] + texto.Substring(1).ToLower();
            }

            // Truncar a 20 caracteres si es necesario
            if (texto.Length > 20)
            {
                texto = texto.Substring(0, 20);
            }

            return texto;
        }


        public static string ValidarContrasena(string texto)
        {
            // Eliminar espacios en blanco y caracteres especiales
            texto = new string((texto.Where(c => char.IsLetterOrDigit(c))).ToArray());

            // Asegurarse de que la primera letra es mayúscula
            if (texto.Length > 0 && char.IsLower(texto[0]))
            {
                texto = char.ToUpper(texto[0]) + texto.Substring(1);
            }

            // Truncar a 20 caracteres si es necesario
            if (texto.Length > 20)
            {
                texto = texto.Substring(0, 20);
            }

            return texto;
    }
        public void GeneralKeyPressHandler(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Permitir hasta dos caracteres consecutivos repetidos
            if (textBox.Text.Length > 1 && textBox.Text[textBox.Text.Length - 1] == e.KeyChar && textBox.Text[textBox.Text.Length - 2] == e.KeyChar)
            {
                e.Handled = true; // Impedir que se ingrese el mismo carácter consecutivo más de dos veces
            }

            // Permitir solo un espacio en blanco consecutivo
            if (e.KeyChar == ' ' && textBox.Text.Length > 0 && textBox.Text[textBox.Text.Length - 1] == ' ')
            {
                e.Handled = true; // Impedir que se ingrese más de un espacio consecutivo
            }
        }
        public void Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Si el primer carácter es un cero o un punto, impedir la entrada
            if (textBox.Text.Length == 0 && (e.KeyChar == '0' || e.KeyChar == '.'))
            {
                e.Handled = true; // Impedir que el primer carácter sea un cero o un punto
                return;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.')
            {
                if (textBox.Text.Contains('.'))
                {
                    e.Handled = true; // Impedir que se ingrese otro punto
                }
            }
            // Permitir solo dígitos, puntos y teclas de control
            else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Impedir cualquier otra tecla
            }
        }

    }


}

    



        


    

