using System;
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
                comando.CommandText = "select D.Id,D.Titulo, D.FechaLanzamiento as 'Año de Lanzamiento', D.CantidadCanciones as 'Cantidad de Canciones', D.UrlImagenTapa, E.descripcion as Estilo, T.Descripcion as 'Tipo de Edición', D.IdEstilo, D.IdTipoEdicion  from DISCOS D, ESTILOS E, TIPOSEDICION T where D.IdEstilo = E.Id AND D.IdTipoEdicion =T.Id And D.Activo = 1";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Disco aux = new Disco();
                    aux.IdDisco = (int)lector["Id"];
                    aux.Titulo = (string)lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)lector["Año de Lanzamiento"];
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

                throw ex;
            }

             
        }

        public void Agregar(Disco discoAAgregar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("insert into DISCOS(Titulo, FechaLanzamiento, CantidadCanciones, IdEstilo, IdTipoEdicion, UrlImagenTapa, Activo) values ('" + discoAAgregar.Titulo + "'," + "'" + discoAAgregar.FechaLanzamiento.ToString("yyyy-MM-dd hh:mm:ss") + "'," + discoAAgregar.CantCanciones + ", @IdEstilo, @IdTipoEdicion, @UrlImagenTapa, @Activo)");
                datos.SetearParametro("@IdEstilo", discoAAgregar.TipoEstilo.IdEstilo);
                datos.SetearParametro("@IdTipoEdicion", discoAAgregar.TipoEdicion.IdTipoEdicion);
                datos.SetearParametro("@UrlImagenTapa", discoAAgregar.UrlImagenTapa);
                datos.SetearParametro("@Activo", discoAAgregar.Activo);


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

        public void Modificar(Disco discoAmodificar)
        {

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("update DISCOS set Titulo = @Titulo, FechaLanzamiento = @FLanzamiento, CantidadCanciones = @CantCanciones, UrlImagenTapa = @url, IdEstilo = @Estilo, IdTipoEdicion = @Edicion where id = @Id");

                datos.SetearParametro("@Titulo", discoAmodificar.Titulo);
                datos.SetearParametro("@FLanzamiento",discoAmodificar.FechaLanzamiento);
                datos.SetearParametro("@CantCanciones", discoAmodificar.CantCanciones);
                datos.SetearParametro("@url", discoAmodificar.UrlImagenTapa);
                datos.SetearParametro("@Estilo", discoAmodificar.TipoEstilo.IdEstilo);
                datos.SetearParametro("@Edicion", discoAmodificar.TipoEdicion.IdTipoEdicion);
                datos.SetearParametro("@Id", discoAmodificar.IdDisco);

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

        public void EliminarFisico(int id)
        {
                AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("delete from DISCOS where id = @id");
                datos.SetearParametro("@id",id);
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

        public void EliminarLogico(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("update DISCOS set Activo = 0 where id = @id");
                datos.SetearParametro("@id", id);
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

        public List<Disco> Filtrar(string campo, string criterio, string filtro)
        {
            List<Disco> listaDiscosconFiltroAvanzado = new List<Disco>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string Consulta = "select D.Id,D.Titulo, D.FechaLanzamiento as 'Fecha de Lanzamiento', D.CantidadCanciones as 'Cantidad de Canciones', D.UrlImagenTapa, E.descripcion as Estilo, T.Descripcion as 'Tipo de Edición', D.IdEstilo, D.IdTipoEdicion  from DISCOS D, ESTILOS E, TIPOSEDICION T where D.IdEstilo = E.Id AND D.IdTipoEdicion =T.Id And D.Activo = 1 AND ";

                switch (campo)
                {
                    case "Año de Lanzamiento":
                        {

                            switch (criterio)
                            {

                                case "Mayor a...":

                                    Consulta += "YEAR(FechaLanzamiento) > " + filtro;

                                    break;

                                case "Menor a...":
                                    Consulta += "YEAR(FechaLanzamiento) < " + filtro;

                                    break;

                                default: //en caso de que sea el mismo número

                                    Consulta += "YEAR(FechaLanzamiento) = " + filtro;

                                    break;

                            }

                        }
                        break;


                    case "Nombre":
                        {
                            switch (criterio)
                            {

                                case "Comienza con...":

                                    Consulta += "Titulo like '"+ filtro + "%'";

                                    break;

                                case "Termina con...":

                                    Consulta += "Titulo like  '%" + filtro + "'";

                                    break;

                                default: // contiene
                                    {

                                        Consulta += "Titulo like '%" + filtro + "%' ";

                                        break;
                                    }

                            }



                            break;
                        }


                    case "Estilo":
                        {

                            switch (criterio)
                            {

                                case "Comienza con...":

                                    Consulta += "E.Descripcion like '" + filtro + "%'";

                                    break;

                                case "Termina con...":

                                    Consulta += "E.Descripcion like  '%" + filtro + "'";

                                    break;

                                default: // contiene
                                    {

                                        Consulta += "E.Descripcion like '%" + filtro + "%' ";

                                        break;
                                    }

                            }


                            break;
                        }

                    default: // switch principal.
                        {

                        } break;
                        
                } 
               
                datos.SetearConsulta(Consulta);
                datos.EjecutarLectura();


                while (datos.Lector.Read())
                {
                    Disco aux = new Disco();
                    aux.IdDisco = (int)datos.Lector["Id"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)datos.Lector["Fecha de Lanzamiento"];
                    aux.CantCanciones = (int)datos.Lector["Cantidad de Canciones"];

                    if (!(datos.Lector["UrlImagenTapa"] is DBNull))
                    { //si el urlImagen no es Null que intente leer la url  

                        aux.UrlImagenTapa = (string)datos.Lector["UrlImagenTapa"];

                    }
                    aux.TipoEstilo = new Estilo();
                    aux.TipoEstilo.IdEstilo = (int)datos.Lector["IdEstilo"];
                    aux.TipoEstilo.DescripcionEstilo = (string)datos.Lector["Estilo"]; // string por la descripción

                    aux.TipoEdicion = new Edicion();
                    aux.TipoEdicion.IdTipoEdicion = (int)datos.Lector["IdTipoEdicion"];
                    aux.TipoEdicion.DescripcionTipoEdicion = (string)datos.Lector["Tipo de Edición"];

                    listaDiscosconFiltroAvanzado.Add(aux);
                }

                return listaDiscosconFiltroAvanzado;

                // aca se hace el return

            } // fin del try
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }





}
