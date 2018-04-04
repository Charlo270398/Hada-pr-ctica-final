using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CAD;

namespace Videoclub.CAD
{
    class clienteCAD : IclienteCAD
    {
        private bbdd bd;
        private SqlConnection con; 

        public clienteCAD()
        {
            bd = new bbdd();
            con = bd.getConexion;
        }


    }
}
