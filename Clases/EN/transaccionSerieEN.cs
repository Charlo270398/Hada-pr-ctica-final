using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void alquilarSerie()
        {

        }
        public void devolverSerie()
        {

        }
        public void comprarSerie()
        {

        }
        public void modificarCompraSerie()
        {

        }
        public void modificarAlquilerSerie()
        {

        }
        public void mostrarTransaccionSerie()
        {

        }

    }
}