using dominio;
using negocio;
using System;
using System.IO;
using System.Windows.Forms;
using System.Configuration;

namespace Discos
{
    public partial class frmAltaDisco : Form
    {
        private Disco disco = null;
        private OpenFileDialog archivo = null;
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
                if (disco == null) // NUEVO DISCO (VACIO)
                {

                    Disco disco = new Disco();

                    disco.Titulo = tboxTitulo.Text;
                    disco.FechaLanzamiento = DateTime.Parse(dtpFechaLanzamiento.Text);
                    disco.CantCanciones = int.Parse(tboxCantCanciones.Text);
                    disco.UrlImagenTapa = tboxUrlImagen.Text;
                    disco.TipoEstilo = (Estilo)cboxEstilo.SelectedItem;
                    disco.TipoEdicion = (Edicion)cboxEdicion.SelectedItem;
                    disco.Activo = true;

                    negocio.Agregar(disco);

                    MessageBox.Show("Agregado Exitosamente");
                }
                else if (disco.IdDisco != 0) // MODIFICAR UN DISCO EXISTENTE
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

                if(archivo != null && !(tboxUrlImagen.Text.ToUpper().Contains("HTTP")))
                {

                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["Discos-app"] + archivo.SafeFileName); //[key] + nombre del archivo 
                                                                                                                        //guarda la imagen seleccionada en la carpeta 

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
                cboxEstilo.SelectedIndex = -1;

                cboxEdicion.DataSource = edicionNegoxcio.listar();
                cboxEdicion.ValueMember = "IdTipoEdicion";
                cboxEdicion.DisplayMember = "DescripcionTipoEdicion";
                cboxEdicion.SelectedIndex = -1;

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
         
        private void btnImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog(); //para levantar una imagen, abre una nueva ventana
            archivo.Filter = "jpg|*.jpg;|png|*.png"; // tipo de archivo que quiero que permita traer
            
            if(archivo.ShowDialog() == DialogResult.OK) //si le diste ok en la imagen a cargar
            {
                tboxUrlImagen.Text = archivo.FileName; //guarda la ruta de la imagen
                cargarImagen(archivo.FileName);


                //guardar la imagen
                //poner ruta en App config
                //para leer esa ruta desde el App config -> Add References, Assemblies, System Configurations, Agregar using system.configuration  

                //File.Copy(archivo.FileName, ConfigurationManager.AppSettings["Discos-app"] + archivo.SafeFileName); //[key] + nombre del archivo 
                //guarda la imagen seleccionada en la carpeta 
                // Se guarda al momento de Aceptar

            }

        }

        private void tboxCantCanciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b') //Permite ue borre
            {
                e.Handled = false; // permite modificación del TextBox
                
                labelFormatoIncorrecto.Visible = false;
                return;
            }
            if (tboxCantCanciones.Text.Length > 2)
            {
                e.Handled = true;
               
                labelFormatoIncorrecto.Visible = true;
            } else
            {
                if(!char.IsNumber(e.KeyChar))
                {
                    e.Handled = true; //No permite modificación del TextBox

                    labelFormatoIncorrecto.Visible = true;
                } else
                {
                    
                    labelFormatoIncorrecto.Visible = false;
                    e.Handled = false;
                }
            }
        }

        private void tboxCantCanciones_Leave(object sender, EventArgs e)
        {
            labelFormatoIncorrecto.Visible = false;
        }

      
    }
}
