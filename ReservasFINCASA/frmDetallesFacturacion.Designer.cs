namespace ReservasFINCASA
{
    partial class frmDetallesFacturacion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCantidadServicios = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbServicioAdicional = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvCabanhas = new System.Windows.Forms.DataGridView();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCabanha = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFinEstadía = new System.Windows.Forms.DateTimePicker();
            this.dtpInicioEstadia = new System.Windows.Forms.DateTimePicker();
            this.btnVolverCliente = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCabanhas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cmbCantidadServicios);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbServicioAdicional);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dgvCabanhas);
            this.panel1.Controls.Add(this.txtSubtotal);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCabanha);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpFinEstadía);
            this.panel1.Controls.Add(this.dtpInicioEstadia);
            this.panel1.Location = new System.Drawing.Point(134, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 606);
            this.panel1.TabIndex = 0;
            // 
            // cmbCantidadServicios
            // 
            this.cmbCantidadServicios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCantidadServicios.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCantidadServicios.FormattingEnabled = true;
            this.cmbCantidadServicios.Location = new System.Drawing.Point(348, 515);
            this.cmbCantidadServicios.Name = "cmbCantidadServicios";
            this.cmbCantidadServicios.Size = new System.Drawing.Size(199, 24);
            this.cmbCantidadServicios.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(345, 495);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Cantidad de servicios";
            // 
            // cmbServicioAdicional
            // 
            this.cmbServicioAdicional.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbServicioAdicional.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbServicioAdicional.FormattingEnabled = true;
            this.cmbServicioAdicional.Location = new System.Drawing.Point(30, 515);
            this.cmbServicioAdicional.Name = "cmbServicioAdicional";
            this.cmbServicioAdicional.Size = new System.Drawing.Size(199, 24);
            this.cmbServicioAdicional.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 495);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Servicio adicional";
            // 
            // dgvCabanhas
            // 
            this.dgvCabanhas.BackgroundColor = System.Drawing.Color.White;
            this.dgvCabanhas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCabanhas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCabanhas.Location = new System.Drawing.Point(27, 276);
            this.dgvCabanhas.Name = "dgvCabanhas";
            this.dgvCabanhas.Size = new System.Drawing.Size(517, 129);
            this.dgvCabanhas.TabIndex = 31;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BackColor = System.Drawing.Color.White;
            this.txtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubtotal.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(358, 216);
            this.txtSubtotal.Multiline = true;
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(186, 20);
            this.txtSubtotal.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(355, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Subtotal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(213, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "*";
            // 
            // txtCabanha
            // 
            this.txtCabanha.BackColor = System.Drawing.Color.White;
            this.txtCabanha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCabanha.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCabanha.Location = new System.Drawing.Point(27, 216);
            this.txtCabanha.Multiline = true;
            this.txtCabanha.Name = "txtCabanha";
            this.txtCabanha.Size = new System.Drawing.Size(186, 20);
            this.txtCabanha.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(188, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(206, 21);
            this.label12.TabIndex = 26;
            this.label12.Text = "Detalles del hospedaje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Cabaña";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(419, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(168, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fin de la estadía";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(419, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Inicio de la estadía";
            // 
            // dtpFinEstadía
            // 
            this.dtpFinEstadía.CalendarFont = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinEstadía.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtpFinEstadía.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinEstadía.Location = new System.Drawing.Point(171, 133);
            this.dtpFinEstadía.Name = "dtpFinEstadía";
            this.dtpFinEstadía.Size = new System.Drawing.Size(242, 25);
            this.dtpFinEstadía.TabIndex = 1;
            // 
            // dtpInicioEstadia
            // 
            this.dtpInicioEstadia.CalendarFont = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicioEstadia.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtpInicioEstadia.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicioEstadia.Location = new System.Drawing.Point(171, 77);
            this.dtpInicioEstadia.Name = "dtpInicioEstadia";
            this.dtpInicioEstadia.Size = new System.Drawing.Size(242, 25);
            this.dtpInicioEstadia.TabIndex = 0;
            // 
            // btnVolverCliente
            // 
            this.btnVolverCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnVolverCliente.FlatAppearance.BorderSize = 0;
            this.btnVolverCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVolverCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVolverCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverCliente.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverCliente.Image = global::ReservasFINCASA.Properties.Resources.FlechaAtras;
            this.btnVolverCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVolverCliente.Location = new System.Drawing.Point(0, 538);
            this.btnVolverCliente.Name = "btnVolverCliente";
            this.btnVolverCliente.Size = new System.Drawing.Size(99, 93);
            this.btnVolverCliente.TabIndex = 27;
            this.btnVolverCliente.Text = "Anterior";
            this.btnVolverCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVolverCliente.UseVisualStyleBackColor = false;
            this.btnVolverCliente.Click += new System.EventHandler(this.btnVolverCliente_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.Color.Transparent;
            this.btnFacturar.FlatAppearance.BorderSize = 0;
            this.btnFacturar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFacturar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturar.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Image = global::ReservasFINCASA.Properties.Resources.IrFacturacion;
            this.btnFacturar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFacturar.Location = new System.Drawing.Point(709, 538);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(99, 93);
            this.btnFacturar.TabIndex = 28;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(188, 449);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 21);
            this.label10.TabIndex = 39;
            this.label10.Text = "Detalles del servicios";
            // 
            // frmDetallesFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReservasFINCASA.Properties.Resources.FondoDetalles;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1126, 630);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.btnVolverCliente);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDetallesFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetallesFacturacion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCabanhas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpInicioEstadia;
        private System.Windows.Forms.DateTimePicker dtpFinEstadía;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCabanha;
        private System.Windows.Forms.DataGridView dgvCabanhas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbCantidadServicios;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbServicioAdicional;
        private System.Windows.Forms.Button btnVolverCliente;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Label label10;
    }
}