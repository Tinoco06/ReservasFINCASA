namespace ReservasFINCASA
{
    partial class FrmFechasParaReservas
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
            this.dtpFinEstadia = new System.Windows.Forms.DateTimePicker();
            this.dgvCabanasDisponibles = new System.Windows.Forms.DataGridView();
            this.dtpInicioEstadia = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.bntConsultarReservas = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolverCalendario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCabanasDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFinEstadia
            // 
            this.dtpFinEstadia.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinEstadia.Location = new System.Drawing.Point(80, 220);
            this.dtpFinEstadia.Name = "dtpFinEstadia";
            this.dtpFinEstadia.Size = new System.Drawing.Size(417, 34);
            this.dtpFinEstadia.TabIndex = 1;
            // 
            // dgvCabanasDisponibles
            // 
            this.dgvCabanasDisponibles.AllowUserToAddRows = false;
            this.dgvCabanasDisponibles.AllowUserToDeleteRows = false;
            this.dgvCabanasDisponibles.AllowUserToResizeColumns = false;
            this.dgvCabanasDisponibles.AllowUserToResizeRows = false;
            this.dgvCabanasDisponibles.BackgroundColor = System.Drawing.Color.White;
            this.dgvCabanasDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCabanasDisponibles.Location = new System.Drawing.Point(80, 292);
            this.dgvCabanasDisponibles.Name = "dgvCabanasDisponibles";
            this.dgvCabanasDisponibles.RowHeadersWidth = 51;
            this.dgvCabanasDisponibles.RowTemplate.Height = 24;
            this.dgvCabanasDisponibles.Size = new System.Drawing.Size(660, 299);
            this.dgvCabanasDisponibles.TabIndex = 3;
            // 
            // dtpInicioEstadia
            // 
            this.dtpInicioEstadia.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicioEstadia.Location = new System.Drawing.Point(80, 127);
            this.dtpInicioEstadia.Name = "dtpInicioEstadia";
            this.dtpInicioEstadia.Size = new System.Drawing.Size(417, 34);
            this.dtpInicioEstadia.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha final";
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
            this.btnMinimizar.Location = new System.Drawing.Point(705, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(47, 43);
            this.btnMinimizar.TabIndex = 44;
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
            this.btnCerrar.Location = new System.Drawing.Point(754, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(47, 43);
            this.btnCerrar.TabIndex = 43;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // bntConsultarReservas
            // 
            this.bntConsultarReservas.FlatAppearance.BorderSize = 0;
            this.bntConsultarReservas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bntConsultarReservas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bntConsultarReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntConsultarReservas.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntConsultarReservas.Image = global::ReservasFINCASA.Properties.Resources.BuscarReservaBoton;
            this.bntConsultarReservas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bntConsultarReservas.Location = new System.Drawing.Point(577, 58);
            this.bntConsultarReservas.Name = "bntConsultarReservas";
            this.bntConsultarReservas.Size = new System.Drawing.Size(138, 113);
            this.bntConsultarReservas.TabIndex = 2;
            this.bntConsultarReservas.Text = "Consultar";
            this.bntConsultarReservas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bntConsultarReservas.UseVisualStyleBackColor = true;
            this.bntConsultarReservas.Click += new System.EventHandler(this.bntConsultarReservas_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = global::ReservasFINCASA.Properties.Resources.limpiarCampos;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiar.Location = new System.Drawing.Point(577, 171);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(138, 113);
            this.btnLimpiar.TabIndex = 45;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVolverCalendario
            // 
            this.btnVolverCalendario.BackColor = System.Drawing.Color.Transparent;
            this.btnVolverCalendario.FlatAppearance.BorderSize = 0;
            this.btnVolverCalendario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVolverCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverCalendario.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverCalendario.Image = global::ReservasFINCASA.Properties.Resources.FlechaAtras;
            this.btnVolverCalendario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVolverCalendario.Location = new System.Drawing.Point(1, 623);
            this.btnVolverCalendario.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolverCalendario.Name = "btnVolverCalendario";
            this.btnVolverCalendario.Size = new System.Drawing.Size(116, 102);
            this.btnVolverCalendario.TabIndex = 46;
            this.btnVolverCalendario.Text = "Regresar";
            this.btnVolverCalendario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVolverCalendario.UseVisualStyleBackColor = false;
            this.btnVolverCalendario.Click += new System.EventHandler(this.btnVolverCalendario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(513, 21);
            this.label3.TabIndex = 47;
            this.label3.Text = "Seleccione las fechas para realizar una consulta de cabañas";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FrmFechasParaReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 726);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVolverCalendario);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpInicioEstadia);
            this.Controls.Add(this.dgvCabanasDisponibles);
            this.Controls.Add(this.bntConsultarReservas);
            this.Controls.Add(this.dtpFinEstadia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFechasParaReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFechasParaReservas";
            this.Load += new System.EventHandler(this.FrmFechasParaReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCabanasDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpFinEstadia;
        private System.Windows.Forms.Button bntConsultarReservas;
        private System.Windows.Forms.DataGridView dgvCabanasDisponibles;
        private System.Windows.Forms.DateTimePicker dtpInicioEstadia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolverCalendario;
        private System.Windows.Forms.Label label3;
    }
}