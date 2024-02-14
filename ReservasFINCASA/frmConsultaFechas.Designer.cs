
namespace ReservasFINCASA
{
    partial class frmConsultaFechas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaFechas));
            this.btnFacturar = new System.Windows.Forms.Button();
            this.daycontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LBDATE = new System.Windows.Forms.Label();
            this.btnAnterior = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnSiguiente = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SuspendLayout();
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(880, 638);
            this.btnFacturar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(183, 24);
            this.btnFacturar.TabIndex = 4;
            this.btnFacturar.Text = "Proceder a la facturación.";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.button1_Click);
            // 
            // daycontainer
            // 
            this.daycontainer.Location = new System.Drawing.Point(46, 81);
            this.daycontainer.Name = "daycontainer";
            this.daycontainer.Size = new System.Drawing.Size(1031, 508);
            this.daycontainer.TabIndex = 5;
            this.daycontainer.Paint += new System.Windows.Forms.PaintEventHandler(this.daycontainer_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Domingo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(827, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Viernes";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(691, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Jueves";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(534, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Miércoles";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(375, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Martes";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(227, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Lunes";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(988, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Sábado";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // LBDATE
            // 
            this.LBDATE.AutoSize = true;
            this.LBDATE.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBDATE.Location = new System.Drawing.Point(534, 20);
            this.LBDATE.Name = "LBDATE";
            this.LBDATE.Size = new System.Drawing.Size(82, 19);
            this.LBDATE.TabIndex = 17;
            this.LBDATE.Text = "MES AÑO";
            this.LBDATE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAnterior
            // 
            this.btnAnterior.AnimationHoverSpeed = 0.07F;
            this.btnAnterior.AnimationSpeed = 0.03F;
            this.btnAnterior.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAnterior.BorderColor = System.Drawing.Color.Black;
            this.btnAnterior.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAnterior.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAnterior.CheckedForeColor = System.Drawing.Color.White;
            this.btnAnterior.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAnterior.CheckedImage")));
            this.btnAnterior.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAnterior.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAnterior.FocusedColor = System.Drawing.Color.Empty;
            this.btnAnterior.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.Color.White;
            this.btnAnterior.Image = global::ReservasFINCASA.Properties.Resources.FlechaAtrasCalendario;
            this.btnAnterior.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAnterior.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAnterior.Location = new System.Drawing.Point(849, 592);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAnterior.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAnterior.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAnterior.OnHoverImage = null;
            this.btnAnterior.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAnterior.OnPressedColor = System.Drawing.Color.Black;
            this.btnAnterior.Size = new System.Drawing.Size(111, 41);
            this.btnAnterior.TabIndex = 9;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.AnimationHoverSpeed = 0.07F;
            this.btnSiguiente.AnimationSpeed = 0.03F;
            this.btnSiguiente.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSiguiente.BorderColor = System.Drawing.Color.Black;
            this.btnSiguiente.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSiguiente.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSiguiente.CheckedForeColor = System.Drawing.Color.White;
            this.btnSiguiente.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.CheckedImage")));
            this.btnSiguiente.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSiguiente.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSiguiente.FocusedColor = System.Drawing.Color.Empty;
            this.btnSiguiente.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Image = global::ReservasFINCASA.Properties.Resources.FlechaAdelanteCalendario;
            this.btnSiguiente.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSiguiente.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSiguiente.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSiguiente.Location = new System.Drawing.Point(966, 592);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSiguiente.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSiguiente.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSiguiente.OnHoverImage = null;
            this.btnSiguiente.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSiguiente.OnPressedColor = System.Drawing.Color.Black;
            this.btnSiguiente.Size = new System.Drawing.Size(111, 41);
            this.btnSiguiente.TabIndex = 8;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // frmConsultaFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1142, 669);
            this.Controls.Add(this.LBDATE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.daycontainer);
            this.Controls.Add(this.btnFacturar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmConsultaFechas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCalendario";
            this.Load += new System.EventHandler(this.frmConsultaFechas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.FlowLayoutPanel daycontainer;
        private Guna.UI.WinForms.GunaAdvenceButton btnSiguiente;
        private Guna.UI.WinForms.GunaAdvenceButton btnAnterior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LBDATE;
    }
}