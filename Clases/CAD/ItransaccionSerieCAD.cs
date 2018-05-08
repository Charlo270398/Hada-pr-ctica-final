using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clases.EN;

namespace CAD
{
    public interface ItransaccionSerieCAD
    {
        void alquilar(int id);
        void devolver(int id);
        void comprar(int id);
        void modificarCompra(int id);
        void modificarAlquiler(int id);
        transaccionSerieEN mostrarTransaccion(int id);
        bool existe(int id);
    }
}
