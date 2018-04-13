using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases.EN;

namespace CAD
{
    interface IusuarioCAD
    {
        public void anyadirUsuario(string email);
        public void borrarUsuario(string email);
        public void mostrarUsuario(string email);
        public void modificarUsuario(string email);
    }
}
