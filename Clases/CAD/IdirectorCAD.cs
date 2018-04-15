using System;
using System.Collections.Generic;
using System.Text;
using Clases.EN;

namespace Clases.CAD
{
    public interface IdirectorCAD
    {
        void anyadirDirector(int id);
        void borrarDirector(int id);
        directorEN mostrarDirector(int id);
        void modificarDirector(int id);
        bool existe(int id);
    }
}
