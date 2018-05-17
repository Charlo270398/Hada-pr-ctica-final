using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CAD;

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

        public transaccionPeliculaEN()
        {

        }

        public transaccionPeliculaEN(int id, string email)
        {
            this.email = email;
            this.idP = id;
        }

        public void alquilarPelicula()
        {
            transaccionPeliculaCAD t = new transaccionPeliculaCAD();
            try
            {
                t.alquilar(this.idP, this.email);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void devolverPelicula()
        {

        }
        public void comprarPelicula()
        {
            transaccionPeliculaCAD t = new transaccionPeliculaCAD();
            try
            {
                t.comprar(this.idP, this.email);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void modificarCompraPelicula()
        {

        }
        public void modificarAlquilerPelicula()
        {

        }
        public transaccionPeliculaEN mostrarTransaccionPelicula()
        {
            transaccionPeliculaCAD t = new transaccionPeliculaCAD();
            try
            {
               return t.mostrarTransaccion(this.idP, this.email);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}