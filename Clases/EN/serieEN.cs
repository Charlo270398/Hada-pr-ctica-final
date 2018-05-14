using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clases.CAD;

namespace Clases.EN
{
    public class serieEN
    {
        private int idS;
        public int IdS { get { return idS; } set { idS = value; } }

        private string titulo;
        public string Titulo { get { return titulo; } set { titulo = value; } }

        private string sinopsis;
        public string Sinopsis { get { return sinopsis; } set { sinopsis = value; } }

        private string fechaE;
        public string FechaE { get { return fechaE; } set { fechaE = value; } }

        private float precioC;
        public float PrecioC { get { return precioC; } set { precioC = value; } }

        private float precioA;
        public float PrecioA { get { return precioA; } set { precioA = value; } }

        private string imagen;
        public string Imagen { get { return imagen; } set { imagen = value; } }

        public serieEN()
        {
            idS = -1;
        }

        public serieEN(int id, string nombre)
        {
            IdS = id;
            Titulo = nombre;
        }
        public serieEN(int id, string titulo, string fecha, string sinopsis, float precioC, float precioA, string imagen)
        {
            IdS = id;
            Titulo = titulo;
            this.fechaE = fecha;
            this.sinopsis = sinopsis;
            this.precioA = precioA;
            this.precioC = precioC;
            this.imagen = imagen;
        }
        public void anyadirSerie()
        {
            serieCAD p = new serieCAD();
            p.anyadirSerie(this);
        }
        public void borrarSerie()
        {
            try
            {
                serieCAD p = new serieCAD();
                p.borrarSerie(this.idS);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void mostrarSerie()
        {

        }
        public void modificarSerie()
        {

        }

    }
}
