
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
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaAdvenceTileButton1 = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnCotizar = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnLogOut = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnConsultarFechas = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.btnReserva = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.AnimacionInicio = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.panelInicio = new System.Windows.Forms.Panel();
            this.lblBienvenida = new Guna.UI.WinForms.GunaLabel();
            this.panelInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Gadugi", 42.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(817, 31);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(192, 69);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = "label3";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(795, 113);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(61, 22);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "label4";
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick);
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1113, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 13;
            // 
            // gunaAdvenceTileButton1
            // 
            this.gunaAdvenceTileButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceTileButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceTileButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceTileButton1.CheckedImage")));
            this.gunaAdvenceTileButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceTileButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceTileButton1.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceTileButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.Image = global::ReservasFINCASA.Properties.Resources.ConsultaReservaciones;
            this.gunaAdvenceTileButton1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaAdvenceTileButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton1.Location = new System.Drawing.Point(965, 405);
            this.gunaAdvenceTileButton1.Name = "gunaAdvenceTileButton1";
            this.gunaAdvenceTileButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.OnHoverImage = null;
            this.gunaAdvenceTileButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton1.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gunaAdvenceTileButton1.Radius = 15;
            this.gunaAdvenceTileButton1.Size = new System.Drawing.Size(126, 130);
            this.gunaAdvenceTileButton1.TabIndex = 17;
            this.gunaAdvenceTileButton1.Text = "Consultar reservas";
            this.gunaAdvenceTileButton1.Click += new System.EventHandler(this.gunaAdvenceTileButton1_Click_1);
            // 
            // btnCotizar
            // 
            this.btnCotizar.AnimationHoverSpeed = 0.07F;
            this.btnCotizar.AnimationSpeed = 0.03F;
            this.btnCotizar.BackColor = System.Drawing.Color.Transparent;
            this.btnCotizar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCotizar.BorderColor = System.Drawing.Color.Black;
            this.btnCotizar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnCotizar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCotizar.CheckedForeColor = System.Drawing.Color.White;
            this.btnCotizar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnCotizar.CheckedImage")));
            this.btnCotizar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnCotizar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCotizar.FocusedColor = System.Drawing.Color.Empty;
            this.btnCotizar.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotizar.ForeColor = System.Drawing.Color.White;
            this.btnCotizar.Image = global::ReservasFINCASA.Properties.Resources.Cotizacion;
            this.btnCotizar.ImageSize = new System.Drawing.Size(52, 52);
            this.btnCotizar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCotizar.Location = new System.Drawing.Point(775, 405);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCotizar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCotizar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCotizar.OnHoverImage = null;
            this.btnCotizar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCotizar.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCotizar.Radius = 15;
            this.btnCotizar.Size = new System.Drawing.Size(126, 130);
            this.btnCotizar.TabIndex = 16;
            this.btnCotizar.Text = "Realiza una cotización";
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.AnimationHoverSpeed = 0.07F;
            this.btnLogOut.AnimationSpeed = 0.03F;
            this.btnLogOut.BaseColor = System.Drawing.Color.White;
            this.btnLogOut.BorderColor = System.Drawing.Color.Black;
            this.btnLogOut.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnLogOut.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnLogOut.CheckedForeColor = System.Drawing.Color.White;
            this.btnLogOut.CheckedImage = null;
            this.btnLogOut.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnLogOut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogOut.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogOut.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Image = global::ReservasFINCASA.Properties.Resources.LogOutIcono3;
            this.btnLogOut.ImageSize = new System.Drawing.Size(52, 52);
            this.btnLogOut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLogOut.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLogOut.Location = new System.Drawing.Point(1092, 645);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnLogOut.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogOut.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogOut.OnHoverImage = null;
            this.btnLogOut.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLogOut.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogOut.Size = new System.Drawing.Size(66, 65);
            this.btnLogOut.TabIndex = 15;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnConsultarFechas
            // 
            this.btnConsultarFechas.AnimationHoverSpeed = 0.07F;
            this.btnConsultarFechas.AnimationSpeed = 0.03F;
            this.btnConsultarFechas.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultarFechas.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConsultarFechas.BorderColor = System.Drawing.Color.Black;
            this.btnConsultarFechas.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnConsultarFechas.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnConsultarFechas.CheckedForeColor = System.Drawing.Color.White;
            this.btnConsultarFechas.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnConsultarFechas.CheckedImage")));
            this.btnConsultarFechas.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnConsultarFechas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConsultarFechas.FocusedColor = System.Drawing.Color.Empty;
            this.btnConsultarFechas.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarFechas.ForeColor = System.Drawing.Color.White;
            this.btnConsultarFechas.Image = global::ReservasFINCASA.Properties.Resources.fechasconsulta;
            this.btnConsultarFechas.ImageSize = new System.Drawing.Size(52, 52);
            this.btnConsultarFechas.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnConsultarFechas.Location = new System.Drawing.Point(965, 205);
            this.btnConsultarFechas.Name = "btnConsultarFechas";
            this.btnConsultarFechas.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnConsultarFechas.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnConsultarFechas.OnHoverForeColor = System.Drawing.Color.White;
            this.btnConsultarFechas.OnHoverImage = null;
            this.btnConsultarFechas.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnConsultarFechas.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConsultarFechas.Radius = 15;
            this.btnConsultarFechas.Size = new System.Drawing.Size(126, 130);
            this.btnConsultarFechas.TabIndex = 14;
            this.btnConsultarFechas.Text = "Consultar fechas";
            this.btnConsultarFechas.Click += new System.EventHandler(this.btnConsultarFechas_Click);
            // 
            // btnReserva
            // 
            this.btnReserva.AnimationHoverSpeed = 0.07F;
            this.btnReserva.AnimationSpeed = 0.03F;
            this.btnReserva.BackColor = System.Drawing.Color.Transparent;
            this.btnReserva.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReserva.BorderColor = System.Drawing.Color.Black;
            this.btnReserva.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnReserva.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnReserva.CheckedForeColor = System.Drawing.Color.White;
            this.btnReserva.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnReserva.CheckedImage")));
            this.btnReserva.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnReserva.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReserva.FocusedColor = System.Drawing.Color.Empty;
            this.btnReserva.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserva.ForeColor = System.Drawing.Color.White;
            this.btnReserva.Image = global::ReservasFINCASA.Properties.Resources.Iconoreserva;
            this.btnReserva.ImageSize = new System.Drawing.Size(52, 52);
            this.btnReserva.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnReserva.Location = new System.Drawing.Point(775, 205);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnReserva.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReserva.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReserva.OnHoverImage = null;
            this.btnReserva.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnReserva.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReserva.Radius = 15;
            this.btnReserva.Size = new System.Drawing.Size(126, 130);
            this.btnReserva.TabIndex = 12;
            this.btnReserva.Text = "Realiza una reservación";
            this.btnReserva.Click += new System.EventHandler(this.gunaAdvenceTileButton1_Click);
            // 
            // AnimacionInicio
            // 
            this.AnimacionInicio.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_BLEND;
            this.AnimacionInicio.Interval = 900;
            this.AnimacionInicio.TargetControl = this;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.panelInicio;
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = this;
            // 
            // panelInicio
            // 
            this.panelInicio.BackgroundImage = global::ReservasFINCASA.Properties.Resources.FondoInicioNuevo1;
            this.panelInicio.Controls.Add(this.lblBienvenida);
            this.panelInicio.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInicio.Location = new System.Drawing.Point(0, 0);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Size = new System.Drawing.Size(713, 708);
            this.panelInicio.TabIndex = 18;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenida.Font = new System.Drawing.Font("Gadugi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(27, 55);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(205, 38);
            this.lblBienvenida.TabIndex = 19;
            this.lblBienvenida.Text = "¡Bienvenido!";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1158, 708);
            this.Controls.Add(this.gunaAdvenceTileButton1);
            this.Controls.Add(this.btnCotizar);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnConsultarFechas);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.btnReserva);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.panelInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.panelInicio.ResumeLayout(false);
            this.panelInicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}