using System;
using System.Collections.Generic;
using System.Text;
using Clases.EN;

namespace Clases.CAD
{
    public interface IserieCAD
    {
        void anyadirSerie(int id);
        void borrarSerie(int id);
        serieEN mostrarSerie(int id);
        void modificarSerie(int id);
        bool existe(int id);
    }
}
