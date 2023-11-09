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
        protected OracleConnection conexion = null;    // = new OracleConnection();
        protected string cadena = "user id=user_dev2;password=admin;data source=" +
                                "(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)" +
                                "(HOST=127.0.0.1)(PORT=1521))(CONNECT_DATA=" +
                                "(SERVICE_NAME=XE)))";

        public ConexionDB()
        {
            conexion = new OracleConnection(cadena);
        }
        public string AbrirConexion()
        {
            conexion.Open();
            return conexion.State.ToString();
        }

        public string CerrarConexion()
        {
            conexion.Close();
            return conexion.State.ToString();
        }
    }
}
