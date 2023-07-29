namespace Discos
{
    partial class frmAltaDisco
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelFechaLanzamiento = new System.Windows.Forms.Label();
            this.labelCantCanciones = new System.Windows.Forms.Label();
            this.tboxTitulo = new System.Windows.Forms.TextBox();
            this.tboxCantCanciones = new System.Windows.Forms.TextBox();
            this.dtpFechaLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(24, 69);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(38, 13);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Título:";
            // 
            // labelFechaLanzamiento
            // 
            this.labelFechaLanzamiento.AutoSize = true;
            this.labelFechaLanzamiento.Location = new System.Drawing.Point(24, 124);
            this.labelFechaLanzamiento.Name = "labelFechaLanzamiento";
            this.labelFechaLanzamiento.Size = new System.Drawing.Size(118, 13);
            this.labelFechaLanzamiento.TabIndex = 1;
            this.labelFechaLanzamiento.Text = "Fecha de Lanzamiento:";
            // 
            // labelCantCanciones
            // 
            this.labelCantCanciones.AutoSize = true;
            this.labelCantCanciones.Location = new System.Drawing.Point(24, 188);
            this.labelCantCanciones.Name = "labelCantCanciones";
            this.labelCantCanciones.Size = new System.Drawing.Size(119, 13);
            this.labelCantCanciones.TabIndex = 2;
            this.labelCantCanciones.Text = "Cantidad de canciones:";
            // 
            // tboxTitulo
            // 
            this.tboxTitulo.Location = new System.Drawing.Point(111, 62);
            this.tboxTitulo.Name = "tboxTitulo";
            this.tboxTitulo.Size = new System.Drawing.Size(254, 20);
            this.tboxTitulo.TabIndex = 3;
            // 
            // tboxCantCanciones
            // 
            this.tboxCantCanciones.Location = new System.Drawing.Point(176, 181);
            this.tboxCantCanciones.Name = "tboxCantCanciones";
            this.tboxCantCanciones.Size = new System.Drawing.Size(189, 20);
            this.tboxCantCanciones.TabIndex = 4;
            // 
            // dtpFechaLanzamiento
            // 
            this.dtpFechaLanzamiento.Location = new System.Drawing.Point(162, 118);
            this.dtpFechaLanzamiento.Name = "dtpFechaLanzamiento";
            this.dtpFechaLanzamiento.Size = new System.Drawing.Size(203, 20);
            this.dtpFechaLanzamiento.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(94, 283);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(93, 24);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(213, 283);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 24);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAltaDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 371);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dtpFechaLanzamiento);
            this.Controls.Add(this.tboxCantCanciones);
            this.Controls.Add(this.tboxTitulo);
            this.Controls.Add(this.labelCantCanciones);
            this.Controls.Add(this.labelFechaLanzamiento);
            this.Controls.Add(this.labelTitulo);
            this.MaximumSize = new System.Drawing.Size(459, 410);
            this.MinimumSize = new System.Drawing.Size(459, 410);
            this.Name = "frmAltaDisco";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Disco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelFechaLanzamiento;
        private System.Windows.Forms.Label labelCantCanciones;
        private System.Windows.Forms.TextBox tboxTitulo;
        private System.Windows.Forms.TextBox tboxCantCanciones;
        private System.Windows.Forms.DateTimePicker dtpFechaLanzamiento;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}