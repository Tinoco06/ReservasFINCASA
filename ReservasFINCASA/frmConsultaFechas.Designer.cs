
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
            this.btnSiguienteMes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(948, 621);
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
            // btnSiguienteMes
            // 
            this.btnSiguienteMes.BackColor = System.Drawing.Color.Transparent;
            this.btnSiguienteMes.FlatAppearance.BorderSize = 0;
            this.btnSiguienteMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguienteMes.Image = global::ReservasFINCASA.Properties.Resources.FlechaAdelanteCalendario;
            this.btnSiguienteMes.Location = new System.Drawing.Point(622, 592);
            this.btnSiguienteMes.Name = "btnSiguienteMes";
            this.btnSiguienteMes.Size = new System.Drawing.Size(70, 53);
            this.btnSiguienteMes.TabIndex = 18;
            this.btnSiguienteMes.UseVisualStyleBackColor = false;
            this.btnSiguienteMes.Click += new System.EventHandler(this.btnSiguienteMes_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::ReservasFINCASA.Properties.Resources.FlechaAtrasCalendario;
            this.button1.Location = new System.Drawing.Point(524, 592);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 53);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmConsultaFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1142, 669);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSiguienteMes);
            this.Controls.Add(this.LBDATE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LBDATE;
        private System.Windows.Forms.Button btnSiguienteMes;
        private System.Windows.Forms.Button button1;
    }
}