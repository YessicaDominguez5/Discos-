using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class EstilosNegocio
    {
        public List<Estilo> listar()
        {
            List<Estilo> listaestilo = new List<Estilo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("select Id, Descripcion from ESTILOS ");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Estilo aux = new Estilo();
                    aux.IdEstilo = (int)datos.Lector["Id"];
                    aux.DescripcionEstilo = (string)datos.Lector["Descripcion"];

                    listaestilo.Add(aux);   

                }

                return listaestilo;
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
