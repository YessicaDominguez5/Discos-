using dominio;
using negocio;
using System;
using System.Windows.Forms;

namespace Discos
{
    public partial class frmAltaDisco : Form
    {
        private Disco disco = null;
        public frmAltaDisco()
        {
            InitializeComponent();
        }
        public frmAltaDisco(Disco disco)
        {
            InitializeComponent();
            this.disco = disco;
            Text = "Modificar Disco"; // para que el text del formulario Modificar sea Modificar Disco.
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            DiscosNegocio negocio = new DiscosNegocio();

            try
            {
                if (disco == null) // si queres agregar el disco esta en null
                {

                    Disco disco = new Disco();

                    disco.Titulo = tboxTitulo.Text;
                    disco.FechaLanzamiento = DateTime.Parse(dtpFechaLanzamiento.Text);
                    disco.CantCanciones = int.Parse(tboxCantCanciones.Text);
                    disco.UrlImagenTapa = tboxUrlImagen.Text;
                    disco.TipoEstilo = (Estilo)cboxEstilo.SelectedItem;
                    disco.TipoEdicion = (Edicion)cboxEdicion.SelectedItem;

                    negocio.Agregar(disco);

                    MessageBox.Show("Agregado Exitosamente");
                }
                else if (disco.IdDisco != 0)
                {

                    disco.Titulo = tboxTitulo.Text;
                    disco.FechaLanzamiento = DateTime.Parse(dtpFechaLanzamiento.Text);
                    disco.CantCanciones = int.Parse(tboxCantCanciones.Text);
                    disco.UrlImagenTapa = tboxUrlImagen.Text;
                    disco.TipoEstilo = (Estilo)cboxEstilo.SelectedItem;
                    disco.TipoEdicion = (Edicion)cboxEdicion.SelectedItem;

                    negocio.Modificar(disco);
                    MessageBox.Show("Modificado Exitosamente");

                }


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
                cboxEstilo.ValueMember = "IdEstilo";
                cboxEstilo.DisplayMember = "DescripcionEstilo";

                cboxEdicion.DataSource = edicionNegoxcio.listar();
                cboxEdicion.ValueMember = "IdTipoEdicion";
                cboxEdicion.DisplayMember = "DescripcionTipoEdicion";

                if (disco != null)
                {// si se apreta modificar el formulario tiene que estar cargados con los datos del disco seleccionado

                    tboxTitulo.Text = disco.Titulo;
                    dtpFechaLanzamiento.Text = disco.FechaLanzamiento.ToString();
                    tboxCantCanciones.Text = disco.CantCanciones.ToString();
                    tboxUrlImagen.Text = disco.UrlImagenTapa;
                    cargarImagen(disco.UrlImagenTapa);
                    cboxEstilo.SelectedValue = disco.TipoEstilo.IdEstilo;
                    cboxEdicion.SelectedValue = disco.TipoEdicion.IdTipoEdicion;

                }
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
