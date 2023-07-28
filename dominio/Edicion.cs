using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Edicion
    {
        public int IdTipoEdicion { get; set; }

        public string DescripcionTipoEdicion { get; set; }

        public override string ToString()
        {
            return DescripcionTipoEdicion;
        }
    }
}
