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
        void borrarPelicula(int pelicula);
        List<peliculaEN> mostrarListaPeliculas(peliculaEN pelicula);
        List<peliculaEN> mostrarListaPeliculasDirector(int idDir);
        List<peliculaEN> mostrarListaPeliculasDistribuidora(int idDir);
        peliculaEN mostrarPelicula(peliculaEN pelicula);
        void modificarPelicula(peliculaEN pelicula);
        bool existe(peliculaEN pelicula);

        int idPelicula(string nombre);

        List<peliculaEN> mostrarUltimosEstrenos();
        peliculaEN mostrarPeliculaRandom();
    }
}
