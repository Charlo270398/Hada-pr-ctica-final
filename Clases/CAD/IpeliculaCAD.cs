using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clases.EN;

namespace CAD
{
    public interface IpeliculaCAD
    {
        void anyadirPelicula(int id);
        void borrarPelicula(int id);
        peliculaEN mostrarPelicula(int id);
        void modificarPelicula(int id);
        bool existe(int id);
    }
}
