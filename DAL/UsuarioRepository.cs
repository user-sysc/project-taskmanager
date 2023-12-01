using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using Entity;
using System.Data;

namespace DAL
{
    public class UsuarioRepository : ConexionDB
    {

        public string InsertarUsuario(Usuario usuario)
        {
            OracleConnection sqlCon = new OracleConnection();
            try
            {
                sqlCon = ConexionDB.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("prc_InsertarUser", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("usuario", OracleDbType.Varchar2).Value = usuario.usuario;
                comando.Parameters.Add("email", OracleDbType.Varchar2).Value = usuario.Email;
                comando.Parameters.Add("clave", OracleDbType.Varchar2).Value = usuario.Clave;
                sqlCon.Open();
                comando.ExecuteReader();
                return "Se registró el usuario " + usuario.usuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        public int ObtenerIdUsuario(string email)
        {
            OracleConnection sqlCon = new OracleConnection();
            try
            {
                sqlCon = ConexionDB.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("prc_get_id_usuario", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("u_email", OracleDbType.Varchar2).Value = email;
                comando.Parameters.Add("u_id_usuario", OracleDbType.Decimal).Direction = ParameterDirection.Output;

                sqlCon.Open();
                comando.ExecuteNonQuery();

                int idUsuario = ((OracleDecimal)comando.Parameters["u_id_usuario"].Value).ToInt32();

                return idUsuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }


        public bool ValidarUsuario(string email, string clave)
        {
            OracleConnection sqlCon = new OracleConnection();
            try
            {
                sqlCon = ConexionDB.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("prc_validarUsuario", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("u_email", OracleDbType.Varchar2).Value = email;
                comando.Parameters.Add("u_clave", OracleDbType.Varchar2).Value = clave;
                comando.Parameters.Add("usuario_encontrado", OracleDbType.Int32).Direction = ParameterDirection.Output;
                sqlCon.Open();
                comando.ExecuteNonQuery();

                int usuarioEncontrado = ((OracleDecimal)comando.Parameters["usuario_encontrado"].Value).ToInt32();

                return usuarioEncontrado > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }
        public bool ValidarEmail(string email)
        {
            OracleConnection sqlCon = new OracleConnection();
            try
            {
                sqlCon = ConexionDB.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("prc_validarEmail", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("u_email", OracleDbType.Varchar2).Value = email;
                comando.Parameters.Add("cuenta_encontrada", OracleDbType.Int32).Direction = ParameterDirection.Output;
                sqlCon.Open();
                comando.ExecuteNonQuery();

                int cuentaEncontrada = ((OracleDecimal)comando.Parameters["cuenta_encontrada"].Value).ToInt32();

                return cuentaEncontrada > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        public List<Usuario> MostrarUsuarios()
        {
            OracleDataReader reader;
            OracleConnection sqlCon = new OracleConnection();
            List<Usuario> list = new List<Usuario>();
            try
            {
                sqlCon = ConexionDB.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("SELECT * FROM Usuarios", sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(map(reader));
                }
                reader.Close();

                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }
        private Usuario map(OracleDataReader reader)
        {
            Usuario usuario = new Usuario();

            usuario.id_usuario = Convert.ToInt32(reader["id_usuario"]);
            usuario.Email = Convert.ToString(reader["email"]);
            usuario.Clave = Convert.ToString(reader["clave"]);
            
            return usuario;
        }
    }
}
