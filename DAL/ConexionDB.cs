using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DAL
{
    class ConexionDB
    {
        protected OracleConnection conexion = null;    // = new OracleConnection();
        protected string cadena = "user id=system;password=123456789;data source=" +
                                "(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)" +
                                "(HOST=127.0.0.1)(PORT=1521))(CONNECT_DATA=" +
                                "(SERVICE_NAME=XE)))";

        public BasedatosORACLE()
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

        //NORIEGA
        //private static DAL_Conexion conexion = null;

        //public DAL_Conexion()
        //{
        //}

        //public OracleConnection CrearConexion()
        //{
        //    OracleConnection cadena = new OracleConnection();
        //    try
        //    {
        //        cadena.ConnectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))
        //                                  (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=C##vital;Password=vital;";
        //    }
        //    catch (Exception ex)
        //    {
        //        cadena = null;
        //        throw ex;
        //    }
        //    return cadena;
        //}

        //public static DAL_Conexion getInstancia()
        //{
        //    if (conexion == null)
        //    {
        //        conexion = new DAL_Conexion();
        //    }
        //    return conexion;
        //}
    }
}
