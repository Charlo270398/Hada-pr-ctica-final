using System;
using System.Collections.Generic;
using System.Text;
using Clases.EN;

namespace Clases.CAD
{
    public interface IdirectorCAD
    {
        void anyadirDirector(directorEN director);
        void borrarDirector(directorEN director);
        List<directorEN> mostrarListaDirectores(directorEN director);
        directorEN mostrarDirector(directorEN director);
        void modificarDirector(directorEN director);
        bool existe(directorEN director);
    }
}
