using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases.EN;

namespace CAD
{
    public class peliculaCAD : IpeliculaCAD
    {
        public peliculaCAD()
        {

        }
        public void anyadirPelicula(int id);
        public void borrarPelicula(int id);
        public peliculaEN mostrarPelicula(int id);
        public void modificarPelicula(int id);  
        
    }
}
