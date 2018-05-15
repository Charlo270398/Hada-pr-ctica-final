using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Clases.EN;

namespace CAD
{
    public class transaccionSerieCAD : ItransaccionSerieCAD
    {
        public transaccionSerieCAD()
        {

        }
        public void alquilar(int id) { }
        public void devolver(int id) { }
        public void comprar(int id) {

        }
        public void modificarCompra(int id) { }
        public void modificarAlquiler(int id) { }
        public transaccionSerieEN mostrarTransaccion(int id) { return null; }
        public bool existe(int id) { return false; }
    }
}
