using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public class ConexionDB
    {
        private static ConexionDB conexion = null;

        public ConexionDB()
        {
        }

        public OracleConnection CrearConexion()
        {
            OracleConnection cadena = new OracleConnection();
            try
            {
                cadena.ConnectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))
                                          (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=c##user_dev;Password=task;";
            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;
        }

        public static ConexionDB getInstancia()
        {
            if (conexion == null)
            {
                conexion = new ConexionDB();
            }
            return conexion;
        }

    }
}
