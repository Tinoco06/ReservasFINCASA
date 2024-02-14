
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.LabelHora = new System.Windows.Forms.Label();
            this.LabelFecha = new System.Windows.Forms.Label();
            this.FechayHora = new System.Windows.Forms.Timer(this.components);
            this.btnSalir = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnConsultaReserva = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnFechas = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnReservacion = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnCotizacion = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.panelFondo = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnSalir);
            this.panelMenu.Controls.Add(this.LabelFecha);
            this.panelMenu.Controls.Add(this.LabelHora);
            this.panelMenu.Controls.Add(this.btnConsultaReserva);
            this.panelMenu.Controls.Add(this.btnFechas);
            this.panelMenu.Controls.Add(this.btnReservacion);
            this.panelMenu.Controls.Add(this.btnCotizacion);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenu.Location = new System.Drawing.Point(698, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(428, 630);
            this.panelMenu.TabIndex = 1;
            // 
            // LabelHora
            // 
            this.LabelHora.AutoSize = true;
            this.LabelHora.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHora.Location = new System.Drawing.Point(165, 31);
            this.LabelHora.Name = "LabelHora";
            this.LabelHora.Size = new System.Drawing.Size(93, 32);
            this.LabelHora.TabIndex = 5;
            this.LabelHora.Text = "label1";
            // 
            // LabelFecha
            // 
            this.LabelFecha.AutoSize = true;
            this.LabelFecha.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFecha.Location = new System.Drawing.Point(72, 88);
            this.LabelFecha.Name = "LabelFecha";
            this.LabelFecha.Size = new System.Drawing.Size(71, 25);
            this.LabelFecha.TabIndex = 6;
            this.LabelFecha.Text = "label1";
            // 
            // FechayHora
            // 
            this.FechayHora.Enabled = true;
            this.FechayHora.Tick += new System.EventHandler(this.FechayHora_Tick);
            // 
            // btnSalir
            // 
            this.btnSalir.AnimationHoverSpeed = 0.07F;
            this.btnSalir.AnimationSpeed = 0.03F;
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BaseColor = System.Drawing.Color.Transparent;
            this.btnSalir.BorderColor = System.Drawing.Color.Black;
            this.btnSalir.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSalir.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSalir.CheckedForeColor = System.Drawing.Color.White;
            this.btnSalir.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.CheckedImage")));
            this.btnSalir.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSalir.FocusedColor = System.Drawing.Color.Empty;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = global::ReservasFINCASA.Properties.Resources.SalirInicio;
            this.btnSalir.ImageSize = new System.Drawing.Size(52, 52);
            this.btnSalir.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSalir.Location = new System.Drawing.Point(367, 567);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSalir.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSalir.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSalir.OnHoverImage = null;
            this.btnSalir.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSalir.OnPressedColor = System.Drawing.Color.Black;
            this.btnSalir.Size = new System.Drawing.Size(58, 60);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultaReserva
            // 
            this.btnConsultaReserva.AnimationHoverSpeed = 0.07F;
            this.btnConsultaReserva.AnimationSpeed = 0.03F;
            this.btnConsultaReserva.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultaReserva.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnConsultaReserva.BorderColor = System.Drawing.Color.Black;
            this.btnConsultaReserva.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnConsultaReserva.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnConsultaReserva.CheckedForeColor = System.Drawing.Color.White;
            this.btnConsultaReserva.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnConsultaReserva.CheckedImage")));
            this.btnConsultaReserva.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnConsultaReserva.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConsultaReserva.FocusedColor = System.Drawing.Color.Empty;
            this.btnConsultaReserva.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaReserva.ForeColor = System.Drawing.Color.White;
            this.btnConsultaReserva.Image = global::ReservasFINCASA.Properties.Resources.BotonConsultaReserva;
            this.btnConsultaReserva.ImageSize = new System.Drawing.Size(52, 52);
            this.btnConsultaReserva.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnConsultaReserva.Location = new System.Drawing.Point(239, 349);
            this.btnConsultaReserva.Name = "btnConsultaReserva";
            this.btnConsultaReserva.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnConsultaReserva.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnConsultaReserva.OnHoverForeColor = System.Drawing.Color.White;
            this.btnConsultaReserva.OnHoverImage = null;
            this.btnConsultaReserva.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnConsultaReserva.OnPressedColor = System.Drawing.Color.Black;
            this.btnConsultaReserva.Radius = 50;
            this.btnConsultaReserva.Size = new System.Drawing.Size(145, 145);
            this.btnConsultaReserva.TabIndex = 4;
            this.btnConsultaReserva.Text = "Consultar reservas";
            this.btnConsultaReserva.Click += new System.EventHandler(this.btnConsultaReserva_Click);
            // 
            // btnFechas
            // 
            this.btnFechas.AnimationHoverSpeed = 0.07F;
            this.btnFechas.AnimationSpeed = 0.03F;
            this.btnFechas.BackColor = System.Drawing.Color.Transparent;
            this.btnFechas.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnFechas.BorderColor = System.Drawing.Color.Black;
            this.btnFechas.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnFechas.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnFechas.CheckedForeColor = System.Drawing.Color.White;
            this.btnFechas.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnFechas.CheckedImage")));
            this.btnFechas.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnFechas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFechas.FocusedColor = System.Drawing.Color.Empty;
            this.btnFechas.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechas.ForeColor = System.Drawing.Color.White;
            this.btnFechas.Image = global::ReservasFINCASA.Properties.Resources.BotonConsultaCalendario;
            this.btnFechas.ImageSize = new System.Drawing.Size(52, 52);
            this.btnFechas.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnFechas.Location = new System.Drawing.Point(239, 175);
            this.btnFechas.Name = "btnFechas";
            this.btnFechas.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnFechas.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFechas.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFechas.OnHoverImage = null;
            this.btnFechas.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnFechas.OnPressedColor = System.Drawing.Color.Black;
            this.btnFechas.Radius = 50;
            this.btnFechas.Size = new System.Drawing.Size(145, 145);
            this.btnFechas.TabIndex = 2;
            this.btnFechas.Text = "Consultar fechas";
            this.btnFechas.Click += new System.EventHandler(this.btnFechas_Click);
            // 
            // btnReservacion
            // 
            this.btnReservacion.AnimationHoverSpeed = 0.07F;
            this.btnReservacion.AnimationSpeed = 0.03F;
            this.btnReservacion.BackColor = System.Drawing.Color.Transparent;
            this.btnReservacion.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnReservacion.BorderColor = System.Drawing.Color.Black;
            this.btnReservacion.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnReservacion.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnReservacion.CheckedForeColor = System.Drawing.Color.White;
            this.btnReservacion.CheckedImage = global::ReservasFINCASA.Properties.Resources.BotonReserva;
            this.btnReservacion.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnReservacion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReservacion.FocusedColor = System.Drawing.Color.Empty;
            this.btnReservacion.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservacion.ForeColor = System.Drawing.Color.White;
            this.btnReservacion.Image = global::ReservasFINCASA.Properties.Resources.BotonReserva;
            this.btnReservacion.ImageSize = new System.Drawing.Size(52, 52);
            this.btnReservacion.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnReservacion.Location = new System.Drawing.Point(56, 175);
            this.btnReservacion.Name = "btnReservacion";
            this.btnReservacion.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnReservacion.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReservacion.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReservacion.OnHoverImage = null;
            this.btnReservacion.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnReservacion.OnPressedColor = System.Drawing.Color.Black;
            this.btnReservacion.Radius = 50;
            this.btnReservacion.Size = new System.Drawing.Size(145, 145);
            this.btnReservacion.TabIndex = 1;
            this.btnReservacion.Text = "Realizar una reservación";
            this.btnReservacion.Click += new System.EventHandler(this.btnReservacion_Click);
            // 
            // btnCotizacion
            // 
            this.btnCotizacion.AnimationHoverSpeed = 0.07F;
            this.btnCotizacion.AnimationSpeed = 0.03F;
            this.btnCotizacion.BackColor = System.Drawing.Color.Transparent;
            this.btnCotizacion.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnCotizacion.BorderColor = System.Drawing.Color.Black;
            this.btnCotizacion.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnCotizacion.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCotizacion.CheckedForeColor = System.Drawing.Color.White;
            this.btnCotizacion.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnCotizacion.CheckedImage")));
            this.btnCotizacion.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnCotizacion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCotizacion.FocusedColor = System.Drawing.Color.Empty;
            this.btnCotizacion.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotizacion.ForeColor = System.Drawing.Color.White;
            this.btnCotizacion.Image = global::ReservasFINCASA.Properties.Resources.BotonCotizaciones;
            this.btnCotizacion.ImageSize = new System.Drawing.Size(52, 52);
            this.btnCotizacion.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCotizacion.Location = new System.Drawing.Point(56, 349);
            this.btnCotizacion.Name = "btnCotizacion";
            this.btnCotizacion.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCotizacion.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCotizacion.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCotizacion.OnHoverImage = null;
            this.btnCotizacion.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCotizacion.OnPressedColor = System.Drawing.Color.Black;
            this.btnCotizacion.Radius = 50;
            this.btnCotizacion.Size = new System.Drawing.Size(145, 145);
            this.btnCotizacion.TabIndex = 3;
            this.btnCotizacion.Text = "Realizar una cotización";
            this.btnCotizacion.Click += new System.EventHandler(this.btnCotizacion_Click);
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
        private Guna.UI.WinForms.GunaAdvenceTileButton btnReserva;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnConsultarFechas;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnLogOut;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnCotizar;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton1;
        private Guna.UI.WinForms.GunaAnimateWindow AnimacionInicio;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
        private System.Windows.Forms.Panel panelInicio;
        private Guna.UI.WinForms.GunaLabel lblBienvenida;
        private System.Windows.Forms.Panel panelFondo;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnReservacion;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnFechas;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnCotizacion;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnConsultaReserva;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label LabelFecha;
        private System.Windows.Forms.Label LabelHora;
        private System.Windows.Forms.Timer FechayHora;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnSalir;
    }
}