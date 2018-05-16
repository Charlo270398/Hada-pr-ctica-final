using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clases.EN;

namespace CAD
{
    public interface ItransaccionPeliculaCAD
    {

        void alquilar(int id, string email);
        void devolver(int id, string email);
        void comprar(int id, string email);
        void modificarCompra(int id);
        void modificarAlquiler(int id);
        transaccionPeliculaEN mostrarTransaccion(int id, string email);
        bool existe(int id);

        List<int> eliminarAlquiladas(string email);
 
    }
}
