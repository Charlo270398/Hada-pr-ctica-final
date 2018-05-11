using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CAD;





namespace Clases.EN
{
    public class actorEN
    {
        private int idAc;
        public int IdAc { get { return idAc; } set { idAc = value; } }

        private string nombre;
        public string Nombre { get { return nombre; } set { nombre = value; } }

        private string apellidos;
        public string Apellidos { get { return apellidos; } set { apellidos = value; } }

        private string fechaNac;
        public string FechaNac { get { return fechaNac; } set { fechaNac = value; } }

        private string pais;
        public string Pais { get { return pais; } set { pais = value; } }

        public actorEN()
        {

        }
        public actorEN(int id, string nombre)
        {
            this.idAc = id;
            this.nombre = nombre;

        }
        public actorEN(int id, string nombre, string apellidos, string fecha, string pais)
        {
            this.idAc = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNac = fecha;
            this.pais = pais;

        }
        public void anyadirActor()
        {
            actorCAD actor = new actorCAD();
            try
            {
                actor.anyadirActor(this);
            }catch(Exception ex)
            {
                throw new Exception (ex.Message);
            }
        }
        public void borrarActor()
        {
            actorCAD actor = new actorCAD();
            try
            {
                actor.borrarActor(this.idAc);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public actorEN mostrarActor()
        {
            actorCAD actor = new actorCAD();
            try
            {
                return actor.mostrarActor(this.idAc);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void modificarActor()
        {
            actorCAD actor = new actorCAD();
            try
            {
                actor.modificarActor(this);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<peliculaEN> mostrarPeliculasActor()
        {
            actorCAD actor = new actorCAD();
            try
            {
                //return peliculasactorCAD
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}