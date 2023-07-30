using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Discos
{
    public partial class FormDiscos : Form
    {
        private List<Disco> listaGuardadaDeDiscos;
        public FormDiscos()
        {
            InitializeComponent();
        }

        private void FormDiscos_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem; // De la grilla de discos en la fila actual guardar en Seleccionado el objeto enlazado

            cargarImagen(seleccionado.UrlImagenTapa);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbImagen.Load(imagen); //va cambiando la imagen según el item seleccionado

            }
            catch (Exception)
            {

                pbImagen.Load("http://www.carsaludable.com.ar/wp-content/uploads/2014/03/default-placeholder.png");
            }

        }
        private void Cargar()
        {
            DiscosNegocio negocio = new DiscosNegocio();
            try
            {
                listaGuardadaDeDiscos = negocio.Listar();
                dgvDiscos.DataSource = listaGuardadaDeDiscos;
                dgvDiscos.Columns["UrlImagenTapa"].Visible = false;
                cargarImagen(listaGuardadaDeDiscos[0].UrlImagenTapa); //imagen del primer elemento de la lista

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaDisco altaDisco = new frmAltaDisco();
            altaDisco.ShowDialog();
            Cargar();
        }
    }
}
