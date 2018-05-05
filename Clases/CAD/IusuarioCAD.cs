using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clases.EN;

namespace CAD
{
    interface IusuarioCAD
    {
        void anyadirUsuario(string email);
        void borrarUsuario(string email);
        usuarioEN mostrarUsuario(string email);
        void modificarUsuario(string email);
        bool existe(string email);
    }
}
