using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videoclub.EN
{
    class peliculaEN
    {
        private int id;
        public int Id { get { return id; } set { id = value; } }

        private string nombre;
        public string Nombre { get { return nombre; } set { nombre = value; } }

        private string descripcion;
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }

        private int duracion;
        public int Duracion { get { return duracion; } set { duracion = value; } }

        private int valoracion;
        public int Valoracion { get { return valoracion; } set { valoracion = value; } }

        private int edadR;
        public int EdadR { get { return edadR; } set { edadR = value; } }
    }
}
