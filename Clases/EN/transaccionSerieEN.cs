using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CAD;

namespace Clases.EN
{
    public class transaccionSerieEN
    {
        private int idS;
        public int IdS { get { return idS; } set { idS = value; } }

        private string email;
        public string Email { get { return email; } set { email = value; } }

        private bool alquiler;
        public bool Alquiler { get { return alquiler; } set { alquiler = value; } }

        //Fecha compra
        private string fechaC;
        public string FechaC { get { return fechaC; } set { fechaC = value; } }
        //Fecha fin alquiler; NULL si es compra
        private string fechaF;
        public string FechaF { get { return fechaF; } set { fechaF = value; } }

        public transaccionSerieEN()
        {

        }

        public transaccionSerieEN(int id, string email)
        {
            this.email = email;
            this.idS = id;
        }

        public void alquilarSerie()
        {
            transaccionSerieCAD t = new transaccionSerieCAD();
            try
            {
                t.alquilar(this.idS, this.email);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void devolverSerie()
        {

        }
        public void comprarSerie()
        {
            transaccionSerieCAD t = new transaccionSerieCAD();
            try
            {
                t.comprar(this.idS, this.email);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void modificarCompraSerie()
        {

        }
        public void modificarAlquilerSerie()
        {

        }
        public transaccionSerieEN mostrarTransaccionSerie()
        {
            transaccionSerieCAD t = new transaccionSerieCAD();
            try
            {
                return t.mostrarTransaccion(this.idS, this.email);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}