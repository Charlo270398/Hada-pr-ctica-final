using System;
using System.Collections.Generic;
using System.Text;
using Clases.EN;

namespace Clases.CAD
{
    public class actorCAD : IactorCAD
    {
        public actorCAD()
        {

        }
        public void anyadirActor(int id) { }
        public void borrarActor(int id) { }
        public actorEN mostrarActor(int id) { return null; }
        public void modificarActor(int id) { }
        public bool existe(int id) { return false; }
    }
}
