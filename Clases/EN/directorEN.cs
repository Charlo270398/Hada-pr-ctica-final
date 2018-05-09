using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CAD;


namespace Clases.EN
{
    public class directorEN
    {
        private int idD;
        public int IdD { get { return idD; } set { idD = value; } }

        private string nombre;
        public string Nombre { get { return nombre; } set { nombre = value; } }

        private string apellidos;
        public string Apellidos { get { return apellidos; } set { apellidos = value; } }

        private string nacionalidad;
        public string Nacionalidad { get { return nacionalidad; } set { nacionalidad = value; } }

        public directorEN()
        {
            this.idD = -1;
        }
        public directorEN(string nombre, string apellidos, string nacionalidad)
        {
            this.idD = -1;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.nacionalidad = nacionalidad;
        }

        public void anyadirDirector()
        {
            try
            {
                directorCAD dir = new directorCAD();
                dir.anyadirDirector(this);

            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
        public void borrarDirector()
        {
            try
            {
                directorCAD dir = new directorCAD();
                dir.borrarDirector(this.idD);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public directorEN mostrarDirector()
        {
            try
            {
                directorCAD dir = new directorCAD();
                return dir.mostrarDirector(this);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void modificarDirector()
        {
            try
            {
                directorCAD dir = new directorCAD();
                dir.modificarDirector(this);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
