using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases.EN;

namespace CAD
{
    public interface ItransaccionSerieCAD
    {
        void alquilar();
        void devolver();
        void comprar();
        void modificarCompra();
        void modificarAlquiler();
        transaccionSerieEN mostrarTransaccion();
    }
}
