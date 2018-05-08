using System;
using System.Collections.Generic;
using System.Text;
using Clases.EN;

namespace CAD
{
    public interface IdirectorCAD
    {
        void anyadirDirector(directorEN director);
        void borrarDirector(int id);
        List<directorEN> mostrarListaDirectores(directorEN director);
        directorEN mostrarDirector(directorEN director);
        void modificarDirector(directorEN director);
        bool existe(directorEN director);
    }
}
