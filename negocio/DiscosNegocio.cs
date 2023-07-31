﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using negocio;

namespace negocio
{
    public class DiscosNegocio
    {
        public List<Disco> Listar() {

            List<Disco> listaDiscos = new List<Disco>();

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS;database=DISCOS_DB;integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select IdDisco,Titulo, FechaLanzamiento as 'Fecha de Lanzamiento', CantidadCanciones as 'Cantidad de Canciones', UrlImagenTapa, E.descripcion as Estilo, T.Descripcion as 'Tipo de Edición', D.IdEstilo, D.IdTipoEdicion  from DISCOS D, ESTILOS E, TIPOSEDICION T where IdEstilo = E.Id AND IdTipoEdicion =T.Id\r\n";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Titulo = (string)lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)lector["Fecha de Lanzamiento"];
                    aux.CantCanciones = (int)lector["Cantidad de Canciones"];

                    if (!(lector["UrlImagenTapa"] is DBNull)) { //si el urlImagen no es Null que intente leer la url  
                    
                    aux.UrlImagenTapa = (string)lector["UrlImagenTapa"];
                    
                    }
                    aux.TipoEstilo = new Estilo();
                    aux.TipoEstilo.IdEstilo = (int)lector["IdEstilo"];
                    aux.TipoEstilo.DescripcionEstilo = (string)lector["Estilo"]; // string por la descripción

                    aux.TipoEdicion = new Edicion();
                    aux.TipoEdicion.IdTipoEdicion = (int)lector["IdTipoEdicion"];
                    aux.TipoEdicion.DescripcionTipoEdicion = (string)lector["Tipo de Edición"];

                    listaDiscos.Add(aux);
                }

                conexion.Close();
                return listaDiscos;
            }
            catch (Exception ex)
            {

                throw;
            }


        }

        public void Agregar(Disco discoAAgregar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("insert into DISCOS(Titulo, FechaLanzamiento, CantidadCanciones, IdEstilo, IdTipoEdicion, UrlImagenTapa) values ('" + discoAAgregar.Titulo + "'," + "'" + discoAAgregar.FechaLanzamiento.ToString("yyyy-MM-dd hh:mm:ss") + "'," + discoAAgregar.CantCanciones + ", @IdEstilo, @IdTipoEdicion, @UrlImagenTapa)");
                datos.SetearParametro("@IdEstilo", discoAAgregar.TipoEstilo.IdEstilo);
                datos.SetearParametro("@IdTipoEdicion", discoAAgregar.TipoEdicion.IdTipoEdicion);
                datos.SetearParametro("@UrlImagenTapa", discoAAgregar.UrlImagenTapa);


                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }

        
        } 

        public void Modificar(Disco discoAmodificar) { 
        
        
        }
    }
      

         
       
    
}
