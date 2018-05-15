using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clases.EN;

namespace CAD
{
    public interface ItransaccionPeliculaCAD
    {

        void alquilar(int id);
        void devolver(int id);
        void comprar(int id, string email);
        void modificarCompra(int id);
        void modificarAlquiler(int id);
        transaccionPeliculaEN mostrarTransaccion(int id);
        bool existe(int id);
    }
}
