using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases.EN;

namespace CAD
{
    public class transaccionPeliculaCAD : ItransaccionPeliculaCAD
    {
        public transaccionPeliculaCAD()
        {

        }
        public void alquilar(int id) { }
        public void devolver(int id) { }
        public void comprar(int id) { }
        public void modificarCompra(int id) { }
        public void modificarAlquiler(int id) { }
        public transaccionPeliculaEN mostrarTransaccion(int id) { return null; }
        public bool existe(int id) { return false; }
    }
}
