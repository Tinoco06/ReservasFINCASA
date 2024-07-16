namespace ReservasFINCASA
{
    partial class frmAbrirReserva
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDetalleReserva = new System.Windows.Forms.DataGridView();
            this.btnVolverCliente = new System.Windows.Forms.Button();
            this.txtBuscarDNI = new ReservasFINCASA.Placeholder();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.White;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Gadugi", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.Location = new System.Drawing.Point(975, -1);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(47, 43);
            this.btnMinimizar.TabIndex = 32;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(1021, -1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(47, 43);
            this.btnCerrar.TabIndex = 31;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 68);
            this.label1.TabIndex = 33;
            this.label1.Text = "Por favor, elija la reserva \r\nque desea ver o modificar";
            // 
            // dgvDetalleReserva
            // 
            this.dgvDetalleReserva.AllowUserToAddRows = false;
            this.dgvDetalleReserva.AllowUserToDeleteRows = false;
            this.dgvDetalleReserva.AllowUserToResizeColumns = false;
            this.dgvDetalleReserva.AllowUserToResizeRows = false;
            this.dgvDetalleReserva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDetalleReserva.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalleReserva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleReserva.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalleReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleReserva.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalleReserva.Location = new System.Drawing.Point(38, 164);
            this.dgvDetalleReserva.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetalleReserva.Name = "dgvDetalleReserva";
            this.dgvDetalleReserva.ReadOnly = true;
            this.dgvDetalleReserva.RowHeadersWidth = 51;
            this.dgvDetalleReserva.Size = new System.Drawing.Size(991, 313);
            this.dgvDetalleReserva.TabIndex = 34;
            this.dgvDetalleReserva.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleReserva_CellClick);
            
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
            this.btnVolverCliente.Location = new System.Drawing.Point(3, 485);
            this.btnVolverCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolverCliente.Name = "btnVolverCliente";
            this.btnVolverCliente.Size = new System.Drawing.Size(132, 108);
            this.btnVolverCliente.TabIndex = 35;
            this.btnVolverCliente.Text = "Regresar";
            this.btnVolverCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVolverCliente.UseVisualStyleBackColor = false;
            this.btnVolverCliente.Click += new System.EventHandler(this.btnVolverCliente_Click);
            // 
            // txtBuscarDNI
            // 
            this.txtBuscarDNI.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarDNI.ForeColor = System.Drawing.Color.DimGray;
            this.txtBuscarDNI.Location = new System.Drawing.Point(38, 123);
            this.txtBuscarDNI.Name = "txtBuscarDNI";
            this.txtBuscarDNI.PlaceHolder = "Ingrese número de DNI del cliente.";
            this.txtBuscarDNI.Size = new System.Drawing.Size(484, 34);
            this.txtBuscarDNI.TabIndex = 36;
            this.txtBuscarDNI.Text = "Ingrese número de DNI del cliente.";
            this.txtBuscarDNI.TextChanged += new System.EventHandler(this.txtBuscarDNI_TextChanged);
            // 
            // frmAbrirReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ReservasFINCASA.Properties.Resources.NuevoFondoAbrirReserva;
            this.ClientSize = new System.Drawing.Size(1065, 593);
            this.Controls.Add(this.txtBuscarDNI);
            this.Controls.Add(this.btnVolverCliente);
            this.Controls.Add(this.dgvDetalleReserva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAbrirReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAbrirReserva";
            this.Load += new System.EventHandler(this.frmAbrirReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDetalleReserva;
        private System.Windows.Forms.Button btnVolverCliente;
        private Placeholder txtBuscarDNI;
    }
}