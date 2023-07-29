using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    internal class EdicionNegocio
    {
        public List<Edicion> listar()
        {
			List<Edicion> listaedicion = new List<Edicion>();	
			AccesoDatos datos = new AccesoDatos();
			try
			{
                datos.SetearConsulta("select Id, Descripcion from TIPOSEDICION");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Edicion aux = new Edicion();
                    aux.IdTipoEdicion = (int)datos.Lector["Id"];
                    aux.DescripcionTipoEdicion = (string)datos.Lector["Description"];

                    listaedicion.Add(aux);

                }

                return listaedicion;
                
			}
			catch (Exception ex)
			{

				throw;
			}
            finally
            {
                datos.CerrarConexion();

            }


        }
    }
}
