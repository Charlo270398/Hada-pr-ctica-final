using System;
using System.Collections.Generic;
using System.Text;
using Clases.EN;

namespace Clases.CAD
{
    public interface IserieCAD
    {
        void anyadirSerie(serieEN serie);
        void borrarSerie(int id);
        serieEN mostrarSerie(serieEN serie);
        serieEN mostrarSerieId(int idSerie);
        List <serieEN> mostrarListaSeries(serieEN serie);
        void modificarSerie(serieEN serie);
        bool existe(serieEN serie);
    }
}
