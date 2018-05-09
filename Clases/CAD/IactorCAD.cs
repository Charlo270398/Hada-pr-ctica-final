using System;
using System.Collections.Generic;
using System.Text;
using Clases.EN;

namespace CAD
{
    public interface IactorCAD
    {
        void anyadirActor(actorEN actor);
        void borrarActor(int id);
        actorEN mostrarActor(int id);
        List <actorEN> mostrarListaActores(actorEN actor);
        void modificarActor(actorEN actor);
        bool existe(actorEN actor);
        List<peliculaEN> peliculasActor(int id);
    }
}
