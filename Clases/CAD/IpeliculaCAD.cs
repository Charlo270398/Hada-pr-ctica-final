using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clases.EN;

namespace CAD
{
    public interface IpeliculaCAD
    {
        void anyadirPelicula(peliculaEN pelicula);
        void borrarPelicula(peliculaEN pelicula);
        List<peliculaEN> mostrarPeliculas(peliculaEN pelicula);
        void modificarPelicula(peliculaEN pelicula);
        bool existe(peliculaEN pelicula);
    }
}
