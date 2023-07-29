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

                negocio.Agregar(nuevoDisco);

                MessageBox.Show("Agregado Exitosamente");
                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
