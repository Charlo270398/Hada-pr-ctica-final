using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clases.EN;

namespace CAD
{
    public interface ItransaccionSerieCAD
    {
        void alquilar(int idSerie, string email);
        void devolver(int id);
        void comprar(int idSerie, string email);
        void modificarCompra(int id);
        transaccionSerieEN modificarAlquiler(int id, string email);
        transaccionSerieEN mostrarTransaccion(int id, string email);
        bool existe(int id);
    }
}
