using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CAD;


namespace  Clases.EN
{
   public  class usuarioEN
    {
        private string email;
        public string Email { get { return email; } set { email = value; } }

        private string contrasenya;
        public string Contrasenya { get { return contrasenya; } set { contrasenya = value; } }

        private string nombre;
        public string Nombre { get { return nombre; } set { nombre = value; } }

        private string apellidos;
        public string Apellidos { get { return apellidos; } set { apellidos = value; } }

        private string fechaA;
        public string FechaA { get { return fechaA; } set { fechaA = value; } }

        private bool Admin;
        public bool AdMin { get { return Admin; } set { Admin = value; } }

        private int pais;
        public int Pais { get { return pais; } set { pais = value; } }

        public usuarioEN()
        {

        }
        public usuarioEN(string email, string contraseña)
        {
            this.email = email;
            this.Contrasenya = contrasenya;
        }
        public void anyadirUsuario()
        {

            usuarioCAD user = new usuarioCAD();
            try
            {
                user.anyadirUsuario(this);
            }
            catch (Exception e)  
            {
                throw new Exception(e.Message);
            }

        }
        public void borrarUsuario()
        {

        }
        public void cargarUsuario()
        {
            usuarioCAD user = new usuarioCAD();
            try
            {
                usuarioEN aux = user.mostrarUsuario(email);
                email = aux.email;
                nombre = aux.nombre;
                apellidos = aux.apellidos;
                contrasenya = aux.contrasenya;
                pais = aux.pais;
                fechaA = aux.fechaA;
                Admin = aux.Admin;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
        public void hacerAdmin()
        {
            usuarioCAD user = new usuarioCAD();
            try
            {
                 user.hacerAdmin(this.email);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
        public bool existe()
        {
            usuarioCAD user = new usuarioCAD();
            try
            {
               return user.existe(this);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void modificarDatos()
        {
            usuarioCAD user = new usuarioCAD();
            try
            {
                user.modificarDatos(this);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void modificarContraseña()
        {
            usuarioCAD user = new usuarioCAD();
            try
            {
                user.modificarContraseña(this);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
