using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CAD;







namespace Clases.EN
{
    public class paisEN
    {
        private int idPais;
        public int IdPais { get { return idPais; } set { idPais = value; } }

        private string pais;
        public string Pais { get { return pais; } set { pais = value; } }

        public paisEN()
        {
            idPais = -1;
            pais = "No existe";
        }

        public void mostrarPais()
        {
            paisCAD pais = new paisCAD();
            paisEN mostrar = new paisEN();
            mostrar = pais.mostrarNombrePais(this.idPais);
            mostrarPais();
        }

    }
}