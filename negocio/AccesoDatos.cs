using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public SqlDataReader Lector //atributo para leer el lector que es private
        {
            get { return lector; }
        }

        public AccesoDatos()//constructor
        {

            conexion = new SqlConnection("server=.\\SQLEXPRESS;database=DISCOS_DB;integrated security = true");
            comando = new SqlCommand();
        }


        public void SetearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;


        }

        public void EjecutarLectura()
        {

            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void EjecutarAccion() //para el insert del setear consulta en el método Agregar, como es insert no se puede ejecutar lectura.
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void SetearParametro(string nombre, object valor) //para mandar los paramétros de Estilo y Edición(los id)
        {

            comando.Parameters.AddWithValue(nombre, valor);
        
        
        
        }

        public void CerrarConexion()
        {
            if (lector != null)
            {
                lector.Close();
            }

            conexion.Close();
        }


    }
}
