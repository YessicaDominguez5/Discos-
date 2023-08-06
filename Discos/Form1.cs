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
            cBoxCampo.Items.Add("Nombre");
            cBoxCampo.Items.Add("Fecha de Lanzamiento");
            cBoxCampo.Items.Add("Estilo");
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvDiscos.CurrentRow != null)
            {

            Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem; // De la grilla de discos en la fila actual guardar en Seleccionado el objeto enlazado

            cargarImagen(seleccionado.UrlImagenTapa);

            }
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
                OcultarColumnas();
                

                cargarImagen(listaGuardadaDeDiscos[0].UrlImagenTapa); //imagen del primer elemento de la lista

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
            private void OcultarColumnas()
            {
                dgvDiscos.Columns["UrlImagenTapa"].Visible = false;
                dgvDiscos.Columns["IdDisco"].Visible = false;
            }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaDisco agregarDisco = new frmAltaDisco();
            agregarDisco.ShowDialog();
            Cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Disco seleccionado;
            seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
            frmAltaDisco  modificarDisco = new frmAltaDisco(seleccionado);
            modificarDisco.ShowDialog();
            Cargar();

        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            Eliminar(true);
        }

        private void Eliminar(bool logico = false)//= false para que sea un valor opcional
        {

            DiscosNegocio negocio = new DiscosNegocio();
            Disco seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro que desea Eliminar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;

                    if(logico)
                    {

                        negocio.EliminarLogico(seleccionado.IdDisco);

                    }
                    else
                    {

                    negocio.EliminarFisico(seleccionado.IdDisco);


                    }
                    Cargar();

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DiscosNegocio negocio = new DiscosNegocio();
            try
            {
            string _Campo = cBoxCampo.SelectedItem.ToString();
            string _Criterio = cboBoxCriterio.SelectedItem.ToString();
            string _Filtro = tBoxFiltroAvanzado.Text;

                dgvDiscos.DataSource = negocio.Filtrar(_Campo, _Criterio, _Filtro);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void tBoxFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Disco> discosFiltrados;

            string filtro = tBoxFiltro.Text;

            if (filtro.Length >= 3)
            {
                discosFiltrados = listaGuardadaDeDiscos.FindAll(x => x.Titulo.ToUpper().Contains(filtro.ToUpper()) || x.TipoEstilo.DescripcionEstilo.ToUpper().Contains(filtro.ToUpper()));//Tipo For each para ir buscando uno a uno que coincida con el nombre ingresado en el TextBox

            }
            else
            {

                discosFiltrados = listaGuardadaDeDiscos;



            }
            dgvDiscos.DataSource = null;
            dgvDiscos.DataSource = discosFiltrados;
            OcultarColumnas();

        }

        private void cBoxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cBoxCampo.SelectedItem.ToString();

            if(opcion == "Fecha de Lanzamiento")
            {
                
                cboBoxCriterio.Items.Clear();
                cboBoxCriterio.Items.Add("Mayor a...");
                cboBoxCriterio.Items.Add("Menor a...");
                cboBoxCriterio.Items.Add("Igual a...");


            }else
            {
                cboBoxCriterio.Items.Clear();
                cboBoxCriterio.Items.Add("Comienza con...");
                cboBoxCriterio.Items.Add("Termina con...");
                cboBoxCriterio.Items.Add("Contiene...");
            }


           
        }

        
    }
    
}
