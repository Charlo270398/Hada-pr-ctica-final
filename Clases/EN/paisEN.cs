using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CAD;





//Le voy a hacer un cambio muy tonto a la clase esta 
// para comprobar que la rama y demás por fin tiran... 
// de una vez por todas

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
        public paisEN(string nombre)
        {
            idPais = -1;
            pais = nombre;
        }
        public paisEN(int id)
        {
            idPais = id;
            pais = "";
        }

        public paisEN mostrarNombrePais()
        {
            paisCAD pais = new paisCAD();
            return pais.mostrarPais(this.idPais);
      
        }
        public paisEN mostrarIdPais()
        {
            paisCAD pais = new paisCAD();
            return pais.mostrarIdPais(this.Pais);
        }

        public List<string> mostrarListaNombresPaises()
        {
            paisCAD pais = new paisCAD();
            return pais.mostrarListaPaises();

        }

    }
}