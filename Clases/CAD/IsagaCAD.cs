using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases.EN;

namespace CAD
{
    interface IsagaCAD
    {
        void anyadirSaga(sagaEN saga);
        void borrarSaga(int id);
        sagaEN mostrarSaga(int id);
        void modificarSaga(sagaEN saga);
        bool existe(sagaEN saga);
        List<sagaEN> listaSagas();
    }
}
