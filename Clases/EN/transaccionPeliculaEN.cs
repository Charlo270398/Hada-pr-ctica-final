using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases.EN
{
    public class transaccionPeliculaEN
    {
        private int idP;
        public int IdP { get { return idP; } set { idP = value; } }

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

        public void alquilarPelicula()
        {

        }
        public void devolverPelicula()
        {

        }
        public void comprarPelicula()
        {

        }
        public void modificarCompraPelicula()
        {

        }
        public void modificarAlquilerPelicula()
        {

        }
        public void mostrarTransaccionPelicula()
        {

        }

    }
}