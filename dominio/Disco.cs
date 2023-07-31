
using System;
using System.Collections.Generic;
using System.ComponentModel; //para el DisplayName, Nombre correcto de columna
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Disco
    {
        public int IdDisco { get; set; }

        [DisplayName("Título")]
        public string Titulo { get; set; }

        [DisplayName("Fecha de Lanzamiento")]
        public DateTime FechaLanzamiento { get; set; }

        [DisplayName("Cantidad de Canciones")]
        public int CantCanciones { get; set;  }

        public string UrlImagenTapa { get; set; }

        [DisplayName("Estilo")]
        public Estilo TipoEstilo { get; set;}

        [DisplayName("Tipo de Edición")]
        public Edicion TipoEdicion{ get; set; }

       
    }
}
