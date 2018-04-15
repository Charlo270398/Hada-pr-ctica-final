using System;
using System.Collections.Generic;
using System.Text;
using Clases.EN;

namespace Clases.CAD
{
    public interface IdistribuidoraCAD
    {
        void anyadirDistribuidora(int id);
        void borrarDistribuidora(int id);
        distribuidoraEN mostrarDistribuidora(int id);
        void modificarDistribuidora(int id);
        bool existe(int id);
    }
}
