
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Disco
    {
        public string Titulo { get; set; }
        public DateTime FechaLanzamiento { get; set; }

        public int CantCanciones { get; set;  }

        public string UrlImagenTapa { get; set; }

        public Estilo TipoEstilo { get; set;}

        public Edicion TipoEdicion{ get; set; }
    }
}
