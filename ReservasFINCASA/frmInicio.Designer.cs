
namespace ReservasFINCASA
{
    partial class frmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnReserva = new System.Windows.Forms.Button();
            this.btnConsultaFechas = new System.Windows.Forms.Button();
            this.btnCotización = new System.Windows.Forms.Button();
            this.btnConsultarReservaciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1041, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Formulario de inicio, en el que se encontraán distintas opciones";
            // 
            // btnReserva
            // 
            this.btnReserva.Location = new System.Drawing.Point(482, 199);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(175, 52);
            this.btnReserva.TabIndex = 2;
            this.btnReserva.Text = "Realizar una reservación";
            this.btnReserva.UseVisualStyleBackColor = true;
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // btnConsultaFechas
            // 
            this.btnConsultaFechas.Location = new System.Drawing.Point(482, 274);
            this.btnConsultaFechas.Name = "btnConsultaFechas";
            this.btnConsultaFechas.Size = new System.Drawing.Size(175, 52);
            this.btnConsultaFechas.TabIndex = 3;
            this.btnConsultaFechas.Text = "Consultar fechas";
            this.btnConsultaFechas.UseVisualStyleBackColor = true;
            this.btnConsultaFechas.Click += new System.EventHandler(this.btnConsultaFechas_Click);
            // 
            // btnCotización
            // 
            this.btnCotización.Location = new System.Drawing.Point(482, 418);
            this.btnCotización.Name = "btnCotización";
            this.btnCotización.Size = new System.Drawing.Size(175, 52);
            this.btnCotización.TabIndex = 4;
            this.btnCotización.Text = "Asistente de cotizaciones";
            this.btnCotización.UseVisualStyleBackColor = true;
            this.btnCotización.Click += new System.EventHandler(this.btnCotización_Click);
            // 
            // btnConsultarReservaciones
            // 
            this.btnConsultarReservaciones.Location = new System.Drawing.Point(482, 344);
            this.btnConsultarReservaciones.Name = "btnConsultarReservaciones";
            this.btnConsultarReservaciones.Size = new System.Drawing.Size(175, 52);
            this.btnConsultarReservaciones.TabIndex = 5;
            this.btnConsultarReservaciones.Text = "Consultar clientes y reservaciones";
            this.btnConsultarReservaciones.UseVisualStyleBackColor = true;
            this.btnConsultarReservaciones.Click += new System.EventHandler(this.btnConsultarReservaciones_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 583);
            this.Controls.Add(this.btnConsultarReservaciones);
            this.Controls.Add(this.btnCotización);
            this.Controls.Add(this.btnConsultaFechas);
            this.Controls.Add(this.btnReserva);
            this.Controls.Add(this.label1);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReserva;
        private System.Windows.Forms.Button btnConsultaFechas;
        private System.Windows.Forms.Button btnCotización;
        private System.Windows.Forms.Button btnConsultarReservaciones;
    }
}