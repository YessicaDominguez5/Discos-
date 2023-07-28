﻿using System;
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
    public partial class FormDiscos : Form
    {
        private List<Disco> listaGuardadaDeDiscos;
        public FormDiscos()
        {
            InitializeComponent();
        }

        private void FormDiscos_Load(object sender, EventArgs e)
        {
            DiscosNegocio negocio = new DiscosNegocio();
            listaGuardadaDeDiscos = negocio.Listar();
            dgvDiscos.DataSource = listaGuardadaDeDiscos;
            dgvDiscos.Columns["UrlImagenTapa"].Visible = false;
            cargarImagen(listaGuardadaDeDiscos[0].UrlImagenTapa); //imagen del primer elemento de la lista
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
    }
}