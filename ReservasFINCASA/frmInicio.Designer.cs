
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
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.bntConsultaFechas = new System.Windows.Forms.Button();
            this.btnAgregarServicio = new System.Windows.Forms.Button();
            this.btnAgregarCabanha = new System.Windows.Forms.Button();
            this.btnReservacion = new System.Windows.Forms.Button();
            this.btnCotizaciones = new System.Windows.Forms.Button();
            this.btnConsultaReserva = new System.Windows.Forms.Button();
            this.LabelFecha = new System.Windows.Forms.Label();
            this.LabelHora = new System.Windows.Forms.Label();
            this.btnSalirLogIn = new System.Windows.Forms.Button();
            this.FechayHora = new System.Windows.Forms.Timer(this.components);
            this.panelFondo = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnMinimizar);
            this.panelMenu.Controls.Add(this.btnCerrar);
            this.panelMenu.Controls.Add(this.bntConsultaFechas);
            this.panelMenu.Controls.Add(this.btnAgregarServicio);
            this.panelMenu.Controls.Add(this.btnAgregarCabanha);
            this.panelMenu.Controls.Add(this.btnReservacion);
            this.panelMenu.Controls.Add(this.btnCotizaciones);
            this.panelMenu.Controls.Add(this.btnConsultaReserva);
            this.panelMenu.Controls.Add(this.LabelFecha);
            this.panelMenu.Controls.Add(this.LabelHora);
            this.panelMenu.Controls.Add(this.btnSalirLogIn);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenu.Location = new System.Drawing.Point(698, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(428, 630);
            this.panelMenu.TabIndex = 1;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Gadugi", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.Location = new System.Drawing.Point(328, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(47, 43);
            this.btnMinimizar.TabIndex = 17;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(381, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(47, 43);
            this.btnCerrar.TabIndex = 16;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // bntConsultaFechas
            // 
            this.bntConsultaFechas.FlatAppearance.BorderSize = 0;
            this.bntConsultaFechas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.bntConsultaFechas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bntConsultaFechas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bntConsultaFechas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntConsultaFechas.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntConsultaFechas.Image = global::ReservasFINCASA.Properties.Resources.DisponibleFecha;
            this.bntConsultaFechas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bntConsultaFechas.Location = new System.Drawing.Point(234, 140);
            this.bntConsultaFechas.Name = "bntConsultaFechas";
            this.bntConsultaFechas.Size = new System.Drawing.Size(165, 114);
            this.bntConsultaFechas.TabIndex = 14;
            this.bntConsultaFechas.Text = "Consultar fechas";
            this.bntConsultaFechas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bntConsultaFechas.UseVisualStyleBackColor = true;
            this.bntConsultaFechas.Click += new System.EventHandler(this.btnConsultaFechas_Click);
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.FlatAppearance.BorderSize = 0;
            this.btnAgregarServicio.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.btnAgregarServicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgregarServicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAgregarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarServicio.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarServicio.Image = global::ReservasFINCASA.Properties.Resources.ServicioExtra;
            this.btnAgregarServicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarServicio.Location = new System.Drawing.Point(234, 444);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(165, 114);
            this.btnAgregarServicio.TabIndex = 13;
            this.btnAgregarServicio.Text = "Agregar nuevo servicio";
            this.btnAgregarServicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarServicio.UseVisualStyleBackColor = true;
            this.btnAgregarServicio.Click += new System.EventHandler(this.btnAgregarServicio_Click);
            // 
            // btnAgregarCabanha
            // 
            this.btnAgregarCabanha.FlatAppearance.BorderSize = 0;
            this.btnAgregarCabanha.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.btnAgregarCabanha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgregarCabanha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAgregarCabanha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCabanha.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCabanha.Image = global::ReservasFINCASA.Properties.Resources.agregarCabanha;
            this.btnAgregarCabanha.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarCabanha.Location = new System.Drawing.Point(44, 444);
            this.btnAgregarCabanha.Name = "btnAgregarCabanha";
            this.btnAgregarCabanha.Size = new System.Drawing.Size(165, 114);
            this.btnAgregarCabanha.TabIndex = 12;
            this.btnAgregarCabanha.Text = "Agregar nueva cabaña";
            this.btnAgregarCabanha.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarCabanha.UseVisualStyleBackColor = true;
            this.btnAgregarCabanha.Click += new System.EventHandler(this.btnAgregarCabanha_Click);
            // 
            // btnReservacion
            // 
            this.btnReservacion.FlatAppearance.BorderSize = 0;
            this.btnReservacion.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.btnReservacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReservacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReservacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservacion.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservacion.Image = global::ReservasFINCASA.Properties.Resources.BotonReserva;
            this.btnReservacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReservacion.Location = new System.Drawing.Point(44, 140);
            this.btnReservacion.Name = "btnReservacion";
            this.btnReservacion.Size = new System.Drawing.Size(165, 114);
            this.btnReservacion.TabIndex = 11;
            this.btnReservacion.Text = "Realizar una reservación";
            this.btnReservacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReservacion.UseVisualStyleBackColor = true;
            this.btnReservacion.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCotizaciones
            // 
            this.btnCotizaciones.FlatAppearance.BorderSize = 0;
            this.btnCotizaciones.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.btnCotizaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCotizaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCotizaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCotizaciones.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotizaciones.Image = global::ReservasFINCASA.Properties.Resources.BotonCotizaciones;
            this.btnCotizaciones.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCotizaciones.Location = new System.Drawing.Point(234, 289);
            this.btnCotizaciones.Name = "btnCotizaciones";
            this.btnCotizaciones.Size = new System.Drawing.Size(165, 114);
            this.btnCotizaciones.TabIndex = 10;
            this.btnCotizaciones.Text = "Realizar cotización";
            this.btnCotizaciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCotizaciones.UseVisualStyleBackColor = true;
            this.btnCotizaciones.Click += new System.EventHandler(this.btnCotizaciones_Click);
            // 
            // btnConsultaReserva
            // 
            this.btnConsultaReserva.FlatAppearance.BorderSize = 0;
            this.btnConsultaReserva.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.btnConsultaReserva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnConsultaReserva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConsultaReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaReserva.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaReserva.Image = global::ReservasFINCASA.Properties.Resources.BotonConsultaReserva;
            this.btnConsultaReserva.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsultaReserva.Location = new System.Drawing.Point(44, 289);
            this.btnConsultaReserva.Name = "btnConsultaReserva";
            this.btnConsultaReserva.Size = new System.Drawing.Size(165, 114);
            this.btnConsultaReserva.TabIndex = 9;
            this.btnConsultaReserva.Text = "Consultar reservas y facturar";
            this.btnConsultaReserva.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultaReserva.UseVisualStyleBackColor = true;
            this.btnConsultaReserva.Click += new System.EventHandler(this.btnConsultaReserva_Click_1);
            // 
            // LabelFecha
            // 
            this.LabelFecha.AutoSize = true;
            this.LabelFecha.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFecha.Location = new System.Drawing.Point(72, 88);
            this.LabelFecha.Name = "LabelFecha";
            this.LabelFecha.Size = new System.Drawing.Size(93, 32);
            this.LabelFecha.TabIndex = 6;
            this.LabelFecha.Text = "label1";
            // 
            // LabelHora
            // 
            this.LabelHora.AutoSize = true;
            this.LabelHora.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHora.Location = new System.Drawing.Point(165, 31);
            this.LabelHora.Name = "LabelHora";
            this.LabelHora.Size = new System.Drawing.Size(114, 40);
            this.LabelHora.TabIndex = 5;
            this.LabelHora.Text = "label1";
            // 
            // btnSalirLogIn
            // 
            this.btnSalirLogIn.BackColor = System.Drawing.Color.White;
            this.btnSalirLogIn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalirLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirLogIn.Image = global::ReservasFINCASA.Properties.Resources.SalirInicio;
            this.btnSalirLogIn.Location = new System.Drawing.Point(357, 556);
            this.btnSalirLogIn.Name = "btnSalirLogIn";
            this.btnSalirLogIn.Size = new System.Drawing.Size(68, 71);
            this.btnSalirLogIn.TabIndex = 15;
            this.btnSalirLogIn.UseVisualStyleBackColor = false;
            this.btnSalirLogIn.Click += new System.EventHandler(this.btnSalirLogIn_Click);
            // 
            // FechayHora
            // 
            this.FechayHora.Enabled = true;
            this.FechayHora.Tick += new System.EventHandler(this.FechayHora_Tick);
            // 
            // panelFondo
            // 
            this.panelFondo.BackgroundImage = global::ReservasFINCASA.Properties.Resources.Fondofincasa;
            this.panelFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFondo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFondo.Location = new System.Drawing.Point(0, 0);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(692, 630);
            this.panelFondo.TabIndex = 0;
            // 
            // frmInicio
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1126, 630);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer horafecha;
        private System.Windows.Forms.Panel panelInicio;
        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label LabelFecha;
        private System.Windows.Forms.Label LabelHora;
        private System.Windows.Forms.Timer FechayHora;
        private System.Windows.Forms.Button btnConsultaReserva;
        private System.Windows.Forms.Button btnCotizaciones;
        private System.Windows.Forms.Button btnReservacion;
        private System.Windows.Forms.Button btnAgregarCabanha;
        private System.Windows.Forms.Button btnAgregarServicio;
        private System.Windows.Forms.Button bntConsultaFechas;
        private System.Windows.Forms.Button btnSalirLogIn;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
    }
}