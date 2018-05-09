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

        public void mostrarNombrePais()
        {
            paisCAD pais = new paisCAD();
            paisEN mostrar = new paisEN();
            mostrar = pais.mostrarPais(this.idPais);
            this.Pais = mostrar.Pais;
            
        }
        public void mostrarIdPais()
        {
            paisCAD pais = new paisCAD();
            paisEN mostrar = new paisEN();
            mostrar = pais.mostrarIdPais(this.Pais);
            this.IdPais = mostrar.IdPais;
        }

    }
}