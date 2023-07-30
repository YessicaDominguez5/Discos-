using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace Discos
{
    public partial class frmAltaDisco : Form
    {
        public frmAltaDisco()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Disco nuevoDisco= new Disco();
            DiscosNegocio negocio = new DiscosNegocio();

            try
            {
                nuevoDisco.Titulo = tboxTitulo.Text;
                nuevoDisco.FechaLanzamiento = DateTime.Parse(dtpFechaLanzamiento.Text);
                nuevoDisco.CantCanciones = int.Parse(tboxCantCanciones.Text);
                nuevoDisco.UrlImagenTapa = tboxUrlImagen.Text;
                nuevoDisco.TipoEstilo = (Estilo)cboxEstilo.SelectedItem;
                nuevoDisco.TipoEdicion = (Edicion)cboxEdicion.SelectedItem;
                
                negocio.Agregar(nuevoDisco);

                MessageBox.Show("Agregado Exitosamente");
                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaDisco_Load(object sender, EventArgs e)
        {
             EstilosNegocio estiloNegocio = new EstilosNegocio();
            EdicionNegocio edicionNegoxcio = new EdicionNegocio();  
            try
            {
                cboxEstilo.DataSource = estiloNegocio.listar();
                cboxEdicion.DataSource = edicionNegoxcio.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pboxDiscoNuevo.Load(imagen); //va cambiando la imagen según el item seleccionado

            }
            catch (Exception)
            {

                pboxDiscoNuevo.Load("http://www.carsaludable.com.ar/wp-content/uploads/2014/03/default-placeholder.png");
            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

            cargarImagen(tboxUrlImagen.Text);

        }
    }
}
