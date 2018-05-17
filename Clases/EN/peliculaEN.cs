using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CAD;

namespace Clases.EN
{
    public class peliculaEN
    {
        private int idP;
        public int IdP { get { return idP; } set { idP = value; } }
  
        private string nombreP;
        public string NombreP { get { return nombreP; } set { nombreP = value; } }

        private int duracion;
        public int Duracion { get { return duracion; } set { duracion = value; } }

        private string sinopsis;
        public string Sinopsis { get { return sinopsis; } set { sinopsis = value; } }

        private string fechaE;
        public string FechaE { get { return fechaE; } set { fechaE = value; } }

        private float precioC;
        public float PrecioC { get { return precioC; } set { precioC = value; } }

        private float precioA;
        public float PrecioA { get { return precioA; } set { precioA = value; } }

        private int idDir;
        public int IdDir { get { return idDir; } set { idDir = value; } }

        private int idDist;
        public int IdDist { get { return idDist; } set { idDist = value; } }

        private int idSaga;
        public int IdSaga { get { return idSaga; } set { idSaga = value; } }

        private string imagen;
        public string Imagen { get { return imagen; } set { imagen = value; } }

        private string trailer;
        public string Trailer { get { return trailer; } set { trailer = value; } }

        public peliculaEN(int id, string nombre)
        {
            IdP = id;
            NombreP = nombre;
        }
        public peliculaEN(int id, string nombre, int duracion, string fecha, string sinopsis, float precioC, float precioA, int idDis, int idDir, string imagen, int idSag, string trailer)
        {
            IdP = id;
            NombreP = nombre;
            this.duracion = duracion;
            this.fechaE = fecha;
            this.sinopsis = sinopsis;
            this.precioA = precioA;
            this.precioC = precioC;
            this.idDir = IdDir;
            this.idDist = IdDist;
            this.imagen = imagen;
            this.idSaga = idSag;
            this.trailer = trailer;
        }
        public peliculaEN()
        {
            IdP = -1;
        }

        public void anyadirPelicula()
        {
            try
            {
                peliculaCAD p = new peliculaCAD();
                p.anyadirPelicula(this);
                
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void borrarPelicula()
        {
            try
            {
                peliculaCAD p = new peliculaCAD();
                p.borrarPelicula(this.idP);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public peliculaEN mostrarPelicula()
        {
            try
            {
                peliculaCAD p = new peliculaCAD();
                return p.mostrarPelicula(this);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void modificarPelicula()
        {
            try
            {
                peliculaCAD p = new peliculaCAD();
                p.modificarPelicula(this);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<peliculaEN> mostrarListaPeliculas()
        {
            try
            {
                peliculaCAD p = new peliculaCAD();
                return p.mostrarListaPeliculas(this);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<peliculaEN> mostrarListaTodasPeliculas()
        {
            try
            {
                peliculaCAD p = new peliculaCAD();
                this.nombreP = "%";
                return p.mostrarListaPeliculas(this);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<actorEN> mostrarListaActores()
        {
            try
            {
                peliculaCAD p = new peliculaCAD();

                return null;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public peliculaEN peliculaMasNueva()
        {
            try
            {
                DateTime nueva = DateTime.Parse("1900-01-01");
                peliculaEN devolver = new peliculaEN();
                peliculaCAD p = new peliculaCAD();
                List<peliculaEN> lista = p.mostrarListaPeliculas(this);
                for(int i = 0; i<lista.Count; i++)
                {
                    DateTime time = DateTime.Parse(lista[i].fechaE);
                    if (time>nueva)
                    {
                        nueva = time;
                        devolver = lista[i];
                    }
                }
                return devolver;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public peliculaEN peliculaRandom()
        {
            try
            {
                peliculaCAD p = new peliculaCAD();
                return p.mostrarPeliculaRandom();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
