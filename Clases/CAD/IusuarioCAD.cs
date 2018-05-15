using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clases.EN;

namespace CAD
{
    interface IusuarioCAD
    {
        void anyadirUsuario(usuarioEN user);
        void borrarUsuario(usuarioEN user);
        usuarioEN mostrarUsuario(string email);
        void modificarUsuario(usuarioEN user);
        bool existe(usuarioEN user);
        List<usuarioEN> listaUsuarios();
        void hacerAdmin(string email);
    }
}
