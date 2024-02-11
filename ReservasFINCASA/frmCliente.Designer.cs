
namespace ReservasFINCASA
{
    partial class frmCliente
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
            this.btnSeleccionFechas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1096, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Formulario para iniciar la reserva, con los datos del cliente y tipo de cabaña.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSeleccionFechas
            // 
            this.btnSeleccionFechas.Location = new System.Drawing.Point(500, 344);
            this.btnSeleccionFechas.Name = "btnSeleccionFechas";
            this.btnSeleccionFechas.Size = new System.Drawing.Size(232, 48);
            this.btnSeleccionFechas.TabIndex = 3;
            this.btnSeleccionFechas.Text = "Siguiente (Selección de fechas)";
            this.btnSeleccionFechas.UseVisualStyleBackColor = true;
            this.btnSeleccionFechas.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 583);
            this.Controls.Add(this.btnSeleccionFechas);
            this.Controls.Add(this.label1);
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeleccionFechas;
    }
}