using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenDB.Data
{
    public class Conexion
    {
        private string connection;
        #region "Método para retornar cadena de conexión"
        //Al invocar al método conStrin, se retornará la cadena de conexión proveniente de App.config
        public string conStrin(string olimpicosDB)
        {
            connection = ConfigurationManager.ConnectionStrings[olimpicosDB].ConnectionString;

            return connection;
        }
        #endregion
    }
}
