using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clases.EN;



namespace CAD
{
    public class usuarioCAD : IusuarioCAD
    {
        public usuarioCAD()
        {

        }
        public void anyadirUsuario(string email){}
        public void borrarUsuario(string email){}
        public usuarioEN mostrarUsuario(string email){ return null; }
        public void modificarUsuario(string email){}
        public bool existe(string email) { return false; }


    }
}
