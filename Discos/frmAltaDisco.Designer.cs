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
            this.lblEstilo = new System.Windows.Forms.Label();
            this.lblTipoEdicion = new System.Windows.Forms.Label();
            this.cboxEstilo = new System.Windows.Forms.ComboBox();
            this.cboxEdicion = new System.Windows.Forms.ComboBox();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.tboxUrlImagen = new System.Windows.Forms.TextBox();
            this.pboxDiscoNuevo = new System.Windows.Forms.PictureBox();
            this.btnImagen = new System.Windows.Forms.Button();
            this.labelFormatoIncorrecto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDiscoNuevo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(105, 65);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(38, 13);
            this.labelTitulo.TabIndex = 5;
            this.labelTitulo.Text = "Título:";
            // 
            // labelFechaLanzamiento
            // 
            this.labelFechaLanzamiento.AutoSize = true;
            this.labelFechaLanzamiento.Location = new System.Drawing.Point(25, 108);
            this.labelFechaLanzamiento.Name = "labelFechaLanzamiento";
            this.labelFechaLanzamiento.Size = new System.Drawing.Size(118, 13);
            this.labelFechaLanzamiento.TabIndex = 1;
            this.labelFechaLanzamiento.Text = "Fecha de Lanzamiento:";
            // 
            // labelCantCanciones
            // 
            this.labelCantCanciones.AutoSize = true;
            this.labelCantCanciones.Location = new System.Drawing.Point(25, 148);
            this.labelCantCanciones.Name = "labelCantCanciones";
            this.labelCantCanciones.Size = new System.Drawing.Size(119, 13);
            this.labelCantCanciones.TabIndex = 2;
            this.labelCantCanciones.Text = "Cantidad de canciones:";
            // 
            // tboxTitulo
            // 
            this.tboxTitulo.Location = new System.Drawing.Point(176, 65);
            this.tboxTitulo.Name = "tboxTitulo";
            this.tboxTitulo.Size = new System.Drawing.Size(254, 20);
            this.tboxTitulo.TabIndex = 0;
            // 
            // tboxCantCanciones
            // 
            this.tboxCantCanciones.Location = new System.Drawing.Point(176, 141);
            this.tboxCantCanciones.Name = "tboxCantCanciones";
            this.tboxCantCanciones.Size = new System.Drawing.Size(254, 20);
            this.tboxCantCanciones.TabIndex = 2;
            this.tboxCantCanciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxCantCanciones_KeyPress);
            this.tboxCantCanciones.Leave += new System.EventHandler(this.tboxCantCanciones_Leave);
            // 
            // dtpFechaLanzamiento
            // 
            this.dtpFechaLanzamiento.Location = new System.Drawing.Point(176, 102);
            this.dtpFechaLanzamiento.Name = "dtpFechaLanzamiento";
            this.dtpFechaLanzamiento.Size = new System.Drawing.Size(254, 20);
            this.dtpFechaLanzamiento.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(176, 349);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(93, 24);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(337, 349);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 24);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Location = new System.Drawing.Point(109, 237);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(35, 13);
            this.lblEstilo.TabIndex = 8;
            this.lblEstilo.Text = "Estilo:";
            // 
            // lblTipoEdicion
            // 
            this.lblTipoEdicion.AutoSize = true;
            this.lblTipoEdicion.Location = new System.Drawing.Point(60, 278);
            this.lblTipoEdicion.Name = "lblTipoEdicion";
            this.lblTipoEdicion.Size = new System.Drawing.Size(84, 13);
            this.lblTipoEdicion.TabIndex = 9;
            this.lblTipoEdicion.Text = "Tipo de Edición:";
            // 
            // cboxEstilo
            // 
            this.cboxEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxEstilo.FormattingEnabled = true;
            this.cboxEstilo.Location = new System.Drawing.Point(176, 229);
            this.cboxEstilo.Name = "cboxEstilo";
            this.cboxEstilo.Size = new System.Drawing.Size(254, 21);
            this.cboxEstilo.TabIndex = 4;
            // 
            // cboxEdicion
            // 
            this.cboxEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxEdicion.FormattingEnabled = true;
            this.cboxEdicion.Location = new System.Drawing.Point(176, 270);
            this.cboxEdicion.Name = "cboxEdicion";
            this.cboxEdicion.Size = new System.Drawing.Size(254, 21);
            this.cboxEdicion.TabIndex = 5;
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Location = new System.Drawing.Point(85, 191);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(58, 13);
            this.lblUrlImagen.TabIndex = 10;
            this.lblUrlImagen.Text = "Url Imagen";
            // 
            // tboxUrlImagen
            // 
            this.tboxUrlImagen.Location = new System.Drawing.Point(176, 184);
            this.tboxUrlImagen.Name = "tboxUrlImagen";
            this.tboxUrlImagen.Size = new System.Drawing.Size(254, 20);
            this.tboxUrlImagen.TabIndex = 3;
          
            this.tboxUrlImagen.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // pboxDiscoNuevo
            // 
            this.pboxDiscoNuevo.Location = new System.Drawing.Point(534, 65);
            this.pboxDiscoNuevo.Name = "pboxDiscoNuevo";
            this.pboxDiscoNuevo.Size = new System.Drawing.Size(241, 226);
            this.pboxDiscoNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxDiscoNuevo.TabIndex = 11;
            this.pboxDiscoNuevo.TabStop = false;
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(450, 180);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(32, 27);
            this.btnImagen.TabIndex = 12;
            this.btnImagen.Text = "->";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // labelFormatoIncorrecto
            // 
            this.labelFormatoIncorrecto.AutoSize = true;
            this.labelFormatoIncorrecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormatoIncorrecto.ForeColor = System.Drawing.Color.Red;
            this.labelFormatoIncorrecto.Location = new System.Drawing.Point(436, 146);
            this.labelFormatoIncorrecto.Name = "labelFormatoIncorrecto";
            this.labelFormatoIncorrecto.Size = new System.Drawing.Size(13, 16);
            this.labelFormatoIncorrecto.TabIndex = 13;
            this.labelFormatoIncorrecto.Text = "*";
            this.labelFormatoIncorrecto.Visible = false;
            // 
            // frmAltaDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 477);
            this.Controls.Add(this.labelFormatoIncorrecto);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.pboxDiscoNuevo);
            this.Controls.Add(this.tboxUrlImagen);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.cboxEdicion);
            this.Controls.Add(this.cboxEstilo);
            this.Controls.Add(this.lblTipoEdicion);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dtpFechaLanzamiento);
            this.Controls.Add(this.tboxCantCanciones);
            this.Controls.Add(this.tboxTitulo);
            this.Controls.Add(this.labelCantCanciones);
            this.Controls.Add(this.labelFechaLanzamiento);
            this.Controls.Add(this.labelTitulo);
            this.Name = "frmAltaDisco";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Disco";
            this.Load += new System.EventHandler(this.frmAltaDisco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxDiscoNuevo)).EndInit();
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
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.Label lblTipoEdicion;
        private System.Windows.Forms.ComboBox cboxEstilo;
        private System.Windows.Forms.ComboBox cboxEdicion;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.TextBox tboxUrlImagen;
        private System.Windows.Forms.PictureBox pboxDiscoNuevo;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.Label labelFormatoIncorrecto;
    }
}