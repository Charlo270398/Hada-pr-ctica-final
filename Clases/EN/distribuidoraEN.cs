using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CAD;

namespace Clases.EN
{
    public class distribuidoraEN
    {
        private int idDis;
        public int IdDis { get { return idDis; } set { idDis = value; } }

        private string nombre;
        public string Nombre { get { return nombre; } set { nombre = value; } }

        public distribuidoraEN()
        {
            IdDis = -1;
        }
        public distribuidoraEN(int id, string nombre){
            IdDis = id;
            this.Nombre = nombre;
        }
        public void anyadirDistribuidora()
        {
            try
            {
                DistribuidoraCAD dist = new DistribuidoraCAD();
                dist.anyadirDistribuidora(this);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void borrarDistribuidora()
        {
            try
            {
                DistribuidoraCAD dist = new DistribuidoraCAD();
                dist.borrarDistribuidora(this.idDis);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void modificarDistribuidora()
        {
            try
            {
                DistribuidoraCAD dist = new DistribuidoraCAD();
                dist.modificarDistribuidora(this);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public distribuidoraEN mostrarDistribuidora()
        {
            try
            {
                DistribuidoraCAD dist = new DistribuidoraCAD();
                return dist.mostrarDistribuidora(this.idDis);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<distribuidoraEN> listaDistribuidoras()
        {
            try
            {
                DistribuidoraCAD dist = new DistribuidoraCAD();
                return dist.mostrarListaDistribuidora();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}