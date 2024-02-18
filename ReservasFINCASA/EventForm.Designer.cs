namespace ReservasFINCASA
{
    partial class EventForm
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
            this.txtFechaInicio = new System.Windows.Forms.TextBox();
            this.txtEvento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFechaFin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Location = new System.Drawing.Point(84, 54);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(210, 20);
            this.txtFechaInicio.TabIndex = 0;
            // 
            // txtEvento
            // 
            this.txtEvento.Location = new System.Drawing.Point(84, 152);
            this.txtEvento.Name = "txtEvento";
            this.txtEvento.Size = new System.Drawing.Size(210, 20);
            this.txtEvento.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha inicio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Evento";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(257, 191);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 31);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha fin";
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.Location = new System.Drawing.Point(84, 102);
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Size = new System.Drawing.Size(210, 20);
            this.txtFechaFin.TabIndex = 5;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 245);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFechaFin);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEvento);
            this.Controls.Add(this.txtFechaInicio);
            this.Name = "EventForm";
            this.Text = "EventForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFechaInicio;
        private System.Windows.Forms.TextBox txtEvento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFechaFin;
    }
}