using System;
using System.Collections.Generic;
using System.Text;
using Clases.EN;

namespace CAD
{
    public interface IdistribuidoraCAD
    {
        void anyadirDistribuidora(distribuidoraEN distribuidora);
        void borrarDistribuidora(int id);
        List <distribuidoraEN> mostrarListaDistribuidora();
        distribuidoraEN mostrarDistribuidora(int id);
        void modificarDistribuidora(distribuidoraEN distribuidora);
        bool existe(int id);
    }
}
