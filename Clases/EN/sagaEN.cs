using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAD;

namespace Clases.EN
{
    public class sagaEN
    {
        private int idSaga;
        public int IDsaga { get { return idSaga; } set { idSaga = value; } }

        private string nombre;
        public string Nombre { get { return nombre; } set { nombre = value; } }

        private string descripcion;
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }

        public sagaEN()
        {
            idSaga = -1;
        }

        public sagaEN(int id, string nombre, string desc)
        {
            this.idSaga = id;
            this.nombre = nombre;
            this.descripcion = desc;
        }

        public void anyadirSaga()
        {
            try
            {
                sagaCAD s = new sagaCAD();
                s.anyadirSaga(this);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void borrarSaga()
        {
            try
            {
                sagaCAD s = new sagaCAD();
                s.borrarSaga(this.idSaga);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void mostrarSaga()
        {

        }
        public void modificarSaga()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<peliculaEN> mostrarPeliculasSaga()
        {
            try
            {
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<sagaEN> listaSagas()
        {
            sagaCAD s = new sagaCAD();
            try
            {
                return s.listaSagas();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
