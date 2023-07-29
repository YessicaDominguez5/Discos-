using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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

        public void CerrarConexion()
        {
            if (lector != null) { lector.Close(); }

            conexion.Close();
        }


    }
}
