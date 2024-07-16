
namespace ReservasFINCASA
{
    partial class frmFactura
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCAI = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtClienteDNI = new System.Windows.Forms.TextBox();
            this.txtFechaFactura = new System.Windows.Forms.TextBox();
            this.dgvDetalleFactura = new System.Windows.Forms.DataGridView();
            this.txtImporteExonerado = new System.Windows.Forms.TextBox();
            this.lblImporteExonerado = new System.Windows.Forms.Label();
            this.txtImporteExento = new System.Windows.Forms.TextBox();
            this.lblImporteExento = new System.Windows.Forms.Label();
            this.txtImporteGravado15 = new System.Windows.Forms.TextBox();
            this.lblImporteGravado15 = new System.Windows.Forms.Label();
            this.txtImporteGravado18 = new System.Windows.Forms.TextBox();
            this.lblImporteGravado18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtImporteTurismo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtISV15 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtISV18 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTotalAPagar = new System.Windows.Forms.TextBox();
            this.lblFactura = new System.Windows.Forms.Label();
            this.txtIdentificativoSAG = new System.Windows.Forms.TextBox();
            this.lblIdentificativoSAG = new System.Windows.Forms.Label();
            this.txtRegistroExonerado = new System.Windows.Forms.TextBox();
            this.lblRegistroExonerado = new System.Windows.Forms.Label();
            this.txtNumeroExento = new System.Windows.Forms.TextBox();
            this.lblNumeroExento = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(215, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(386, 27);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "JUSTINIANO TINOCO HERNANDEZ";
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
            this.btnMinimizar.Location = new System.Drawing.Point(890, 27);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(47, 43);
            this.btnMinimizar.TabIndex = 31;
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
            this.btnCerrar.Location = new System.Drawing.Point(952, 27);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(47, 43);
            this.btnCerrar.TabIndex = 30;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(511, 27);
            this.label2.TabIndex = 32;
            this.label2.Text = "INVERSIONES FINCASA CABAÑAS DEL CAMPO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(498, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "San Pedro Zacapa, Barrio Flor del campo, Calle Principal.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(213, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(352, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "Cel: 9983-4387  RTN: 16231964003382";
            // 
            // lblCAI
            // 
            this.lblCAI.AutoSize = true;
            this.lblCAI.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCAI.Location = new System.Drawing.Point(3, 138);
            this.lblCAI.Name = "lblCAI";
            this.lblCAI.Size = new System.Drawing.Size(327, 17);
            this.lblCAI.TabIndex = 35;
            this.lblCAI.Text = "CAI: 65E063-68CABC-6E43B8-26D787-EB6DB9-70";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(529, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "FECHA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 18);
            this.label7.TabIndex = 37;
            this.label7.Text = "CLIENTE:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(529, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 18);
            this.label8.TabIndex = 38;
            this.label8.Text = "RTN:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(71, 171);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(396, 27);
            this.txtNombreCliente.TabIndex = 39;
            // 
            // txtClienteDNI
            // 
            this.txtClienteDNI.Enabled = false;
            this.txtClienteDNI.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteDNI.Location = new System.Drawing.Point(593, 177);
            this.txtClienteDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClienteDNI.Name = "txtClienteDNI";
            this.txtClienteDNI.Size = new System.Drawing.Size(312, 27);
            this.txtClienteDNI.TabIndex = 40;
            this.txtClienteDNI.TextChanged += new System.EventHandler(this.txtClienteDNI_TextChanged);
            // 
            // txtFechaFactura
            // 
            this.txtFechaFactura.Enabled = false;
            this.txtFechaFactura.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaFactura.Location = new System.Drawing.Point(593, 133);
            this.txtFechaFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFechaFactura.Name = "txtFechaFactura";
            this.txtFechaFactura.Size = new System.Drawing.Size(236, 27);
            this.txtFechaFactura.TabIndex = 42;
            // 
            // dgvDetalleFactura
            // 
            this.dgvDetalleFactura.AllowUserToAddRows = false;
            this.dgvDetalleFactura.AllowUserToDeleteRows = false;
            this.dgvDetalleFactura.AllowUserToResizeColumns = false;
            this.dgvDetalleFactura.AllowUserToResizeRows = false;
            this.dgvDetalleFactura.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalleFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleFactura.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalleFactura.Location = new System.Drawing.Point(4, 210);
            this.dgvDetalleFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDetalleFactura.MultiSelect = false;
            this.dgvDetalleFactura.Name = "dgvDetalleFactura";
            this.dgvDetalleFactura.RowHeadersVisible = false;
            this.dgvDetalleFactura.RowHeadersWidth = 51;
            this.dgvDetalleFactura.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDetalleFactura.RowTemplate.Height = 24;
            this.dgvDetalleFactura.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvDetalleFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDetalleFactura.ShowCellErrors = false;
            this.dgvDetalleFactura.ShowCellToolTips = false;
            this.dgvDetalleFactura.ShowEditingIcon = false;
            this.dgvDetalleFactura.ShowRowErrors = false;
            this.dgvDetalleFactura.Size = new System.Drawing.Size(901, 235);
            this.dgvDetalleFactura.TabIndex = 43;
            this.dgvDetalleFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleFactura_CellContentClick);
            // 
            // txtImporteExonerado
            // 
            this.txtImporteExonerado.Enabled = false;
            this.txtImporteExonerado.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporteExonerado.Location = new System.Drawing.Point(756, 507);
            this.txtImporteExonerado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImporteExonerado.Name = "txtImporteExonerado";
            this.txtImporteExonerado.Size = new System.Drawing.Size(149, 29);
            this.txtImporteExonerado.TabIndex = 45;
            this.txtImporteExonerado.TextChanged += new System.EventHandler(this.txtImporteExonerado_TextChanged);
            // 
            // lblImporteExonerado
            // 
            this.lblImporteExonerado.AutoSize = true;
            this.lblImporteExonerado.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteExonerado.Location = new System.Drawing.Point(577, 512);
            this.lblImporteExonerado.Name = "lblImporteExonerado";
            this.lblImporteExonerado.Size = new System.Drawing.Size(162, 17);
            this.lblImporteExonerado.TabIndex = 44;
            this.lblImporteExonerado.Text = "IMPORTE EXONERADO L";
            // 
            // txtImporteExento
            // 
            this.txtImporteExento.Enabled = false;
            this.txtImporteExento.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporteExento.Location = new System.Drawing.Point(756, 545);
            this.txtImporteExento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImporteExento.Name = "txtImporteExento";
            this.txtImporteExento.Size = new System.Drawing.Size(149, 29);
            this.txtImporteExento.TabIndex = 47;
            // 
            // lblImporteExento
            // 
            this.lblImporteExento.AutoSize = true;
            this.lblImporteExento.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteExento.Location = new System.Drawing.Point(612, 550);
            this.lblImporteExento.Name = "lblImporteExento";
            this.lblImporteExento.Size = new System.Drawing.Size(131, 17);
            this.lblImporteExento.TabIndex = 46;
            this.lblImporteExento.Text = "IMPORTE EXENTO L";
            // 
            // txtImporteGravado15
            // 
            this.txtImporteGravado15.Enabled = false;
            this.txtImporteGravado15.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporteGravado15.Location = new System.Drawing.Point(756, 591);
            this.txtImporteGravado15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImporteGravado15.Name = "txtImporteGravado15";
            this.txtImporteGravado15.Size = new System.Drawing.Size(149, 34);
            this.txtImporteGravado15.TabIndex = 49;
            // 
            // lblImporteGravado15
            // 
            this.lblImporteGravado15.AutoSize = true;
            this.lblImporteGravado15.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteGravado15.Location = new System.Drawing.Point(563, 598);
            this.lblImporteGravado15.Name = "lblImporteGravado15";
            this.lblImporteGravado15.Size = new System.Drawing.Size(178, 17);
            this.lblImporteGravado15.TabIndex = 48;
            this.lblImporteGravado15.Text = "IMPORTE GRAVADO 15% L";
            // 
            // txtImporteGravado18
            // 
            this.txtImporteGravado18.Enabled = false;
            this.txtImporteGravado18.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporteGravado18.Location = new System.Drawing.Point(756, 634);
            this.txtImporteGravado18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImporteGravado18.Name = "txtImporteGravado18";
            this.txtImporteGravado18.Size = new System.Drawing.Size(149, 34);
            this.txtImporteGravado18.TabIndex = 51;
            // 
            // lblImporteGravado18
            // 
            this.lblImporteGravado18.AutoSize = true;
            this.lblImporteGravado18.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteGravado18.Location = new System.Drawing.Point(561, 641);
            this.lblImporteGravado18.Name = "lblImporteGravado18";
            this.lblImporteGravado18.Size = new System.Drawing.Size(178, 17);
            this.lblImporteGravado18.TabIndex = 52;
            this.lblImporteGravado18.Text = "IMPORTE GRAVADO 18% L";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(561, 687);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(185, 17);
            this.label12.TabIndex = 54;
            this.label12.Text = "IMPORTE DE TURISMO 4% L";
            // 
            // txtImporteTurismo
            // 
            this.txtImporteTurismo.Enabled = false;
            this.txtImporteTurismo.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporteTurismo.Location = new System.Drawing.Point(756, 679);
            this.txtImporteTurismo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImporteTurismo.Name = "txtImporteTurismo";
            this.txtImporteTurismo.Size = new System.Drawing.Size(149, 34);
            this.txtImporteTurismo.TabIndex = 53;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(676, 726);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 17);
            this.label14.TabIndex = 56;
            this.label14.Text = "ISV 15% L";
            // 
            // txtISV15
            // 
            this.txtISV15.Enabled = false;
            this.txtISV15.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISV15.Location = new System.Drawing.Point(756, 726);
            this.txtISV15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtISV15.Name = "txtISV15";
            this.txtISV15.Size = new System.Drawing.Size(149, 34);
            this.txtISV15.TabIndex = 55;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(676, 774);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 17);
            this.label15.TabIndex = 58;
            this.label15.Text = "ISV 18% L";
            // 
            // txtISV18
            // 
            this.txtISV18.Enabled = false;
            this.txtISV18.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISV18.Location = new System.Drawing.Point(756, 767);
            this.txtISV18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtISV18.Name = "txtISV18";
            this.txtISV18.Size = new System.Drawing.Size(149, 34);
            this.txtISV18.TabIndex = 57;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(590, 818);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(156, 20);
            this.label16.TabIndex = 60;
            this.label16.Text = "TOTAL A PAGAR L";
            // 
            // txtTotalAPagar
            // 
            this.txtTotalAPagar.Enabled = false;
            this.txtTotalAPagar.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAPagar.Location = new System.Drawing.Point(755, 810);
            this.txtTotalAPagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalAPagar.Name = "txtTotalAPagar";
            this.txtTotalAPagar.Size = new System.Drawing.Size(150, 34);
            this.txtTotalAPagar.TabIndex = 59;
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactura.Location = new System.Drawing.Point(4, 502);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(382, 20);
            this.lblFactura.TabIndex = 61;
            this.lblFactura.Text = "LA FACTURA ES BENEFICIO DE TODOS \"EXIJALA\"";
            // 
            // txtIdentificativoSAG
            // 
            this.txtIdentificativoSAG.Enabled = false;
            this.txtIdentificativoSAG.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificativoSAG.Location = new System.Drawing.Point(356, 630);
            this.txtIdentificativoSAG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdentificativoSAG.Name = "txtIdentificativoSAG";
            this.txtIdentificativoSAG.Size = new System.Drawing.Size(181, 29);
            this.txtIdentificativoSAG.TabIndex = 67;
            // 
            // lblIdentificativoSAG
            // 
            this.lblIdentificativoSAG.AutoSize = true;
            this.lblIdentificativoSAG.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificativoSAG.Location = new System.Drawing.Point(5, 634);
            this.lblIdentificativoSAG.Name = "lblIdentificativoSAG";
            this.lblIdentificativoSAG.Size = new System.Drawing.Size(241, 17);
            this.lblIdentificativoSAG.TabIndex = 66;
            this.lblIdentificativoSAG.Text = "N° Identificativo del registro de la SAG";
            // 
            // txtRegistroExonerado
            // 
            this.txtRegistroExonerado.Enabled = false;
            this.txtRegistroExonerado.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistroExonerado.Location = new System.Drawing.Point(355, 595);
            this.txtRegistroExonerado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRegistroExonerado.Name = "txtRegistroExonerado";
            this.txtRegistroExonerado.Size = new System.Drawing.Size(181, 29);
            this.txtRegistroExonerado.TabIndex = 65;
            // 
            // lblRegistroExonerado
            // 
            this.lblRegistroExonerado.AutoSize = true;
            this.lblRegistroExonerado.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroExonerado.Location = new System.Drawing.Point(5, 599);
            this.lblRegistroExonerado.Name = "lblRegistroExonerado";
            this.lblRegistroExonerado.Size = new System.Drawing.Size(319, 17);
            this.lblRegistroExonerado.TabIndex = 64;
            this.lblRegistroExonerado.Text = "N° Correlativo de constancia de registro exonerado";
            this.lblRegistroExonerado.Click += new System.EventHandler(this.lblRegistroExonerado_Click);
            // 
            // txtNumeroExento
            // 
            this.txtNumeroExento.Enabled = false;
            this.txtNumeroExento.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroExento.Location = new System.Drawing.Point(355, 558);
            this.txtNumeroExento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeroExento.Name = "txtNumeroExento";
            this.txtNumeroExento.Size = new System.Drawing.Size(181, 29);
            this.txtNumeroExento.TabIndex = 63;
            this.txtNumeroExento.TextChanged += new System.EventHandler(this.txtNumeroExento_TextChanged);
            // 
            // lblNumeroExento
            // 
            this.lblNumeroExento.AutoSize = true;
            this.lblNumeroExento.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroExento.Location = new System.Drawing.Point(3, 562);
            this.lblNumeroExento.Name = "lblNumeroExento";
            this.lblNumeroExento.Size = new System.Drawing.Size(266, 17);
            this.lblNumeroExento.TabIndex = 62;
            this.lblNumeroExento.Text = "N° Correlativo de orden de compra exenta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ReservasFINCASA.Properties.Resources.logoparafactura;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 98);
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = global::ReservasFINCASA.Properties.Resources.ImprimirFactura;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimir.Location = new System.Drawing.Point(260, 699);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(149, 119);
            this.btnImprimir.TabIndex = 68;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Image = global::ReservasFINCASA.Properties.Resources.casa;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInicio.Location = new System.Drawing.Point(71, 699);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(4);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(123, 114);
            this.btnInicio.TabIndex = 29;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 869);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtIdentificativoSAG);
            this.Controls.Add(this.lblIdentificativoSAG);
            this.Controls.Add(this.txtRegistroExonerado);
            this.Controls.Add(this.lblRegistroExonerado);
            this.Controls.Add(this.txtNumeroExento);
            this.Controls.Add(this.lblNumeroExento);
            this.Controls.Add(this.lblFactura);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtTotalAPagar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtISV18);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtISV15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtImporteTurismo);
            this.Controls.Add(this.lblImporteGravado18);
            this.Controls.Add(this.txtImporteGravado18);
            this.Controls.Add(this.txtImporteGravado15);
            this.Controls.Add(this.lblImporteGravado15);
            this.Controls.Add(this.txtImporteExento);
            this.Controls.Add(this.lblImporteExento);
            this.Controls.Add(this.txtImporteExonerado);
            this.Controls.Add(this.lblImporteExonerado);
            this.Controls.Add(this.dgvDetalleFactura);
            this.Controls.Add(this.txtFechaFactura);
            this.Controls.Add(this.txtClienteDNI);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCAI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmFactura";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFactura";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCAI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtClienteDNI;
        private System.Windows.Forms.TextBox txtFechaFactura;
        private System.Windows.Forms.DataGridView dgvDetalleFactura;
        private System.Windows.Forms.TextBox txtImporteExonerado;
        private System.Windows.Forms.Label lblImporteExonerado;
        private System.Windows.Forms.TextBox txtImporteExento;
        private System.Windows.Forms.Label lblImporteExento;
        private System.Windows.Forms.TextBox txtImporteGravado15;
        private System.Windows.Forms.Label lblImporteGravado15;
        private System.Windows.Forms.TextBox txtImporteGravado18;
        private System.Windows.Forms.Label lblImporteGravado18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtImporteTurismo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtISV15;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtISV18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTotalAPagar;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.TextBox txtIdentificativoSAG;
        private System.Windows.Forms.Label lblIdentificativoSAG;
        private System.Windows.Forms.TextBox txtRegistroExonerado;
        private System.Windows.Forms.Label lblRegistroExonerado;
        private System.Windows.Forms.TextBox txtNumeroExento;
        private System.Windows.Forms.Label lblNumeroExento;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}