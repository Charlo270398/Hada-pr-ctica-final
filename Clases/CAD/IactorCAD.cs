using System;
using System.Collections.Generic;
using System.Text;
using Clases.EN;

namespace Clases.CAD
{
    public interface IactorCAD
    {
        void anyadirActor(int id);
        void borrarActor(int id);
        actorEN mostrarActor(int id);
        void modificarActor(int id);
        bool existe(int id); 
    }
}
