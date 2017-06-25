using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Hospedaje.Clases
{
    class ClassConexion
    {
        public SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Hospedaje_DB"].ConnectionString);
    }
}
