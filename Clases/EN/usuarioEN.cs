﻿using System;
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

        private string tipoU;
        public string TipoU { get { return tipoU; } set { tipoU = value; } }

        private int pais;
        public int Pais { get { return pais; } set { pais = value; } }

        public void anyadirUsuario()
        {
            usuarioCAD user = new usuarioCAD();
            user.anyadirUsuario(this);

        }
        public void borrarUsuario()
        {

        }
        public void mostrarUsuario()
        {

        }
        public void modificarUsuario()
        {

        }

    }
}
