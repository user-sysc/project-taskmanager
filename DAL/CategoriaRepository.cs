using Entity;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoriaRepository:ConexionDB
    {
        public CategoriaRepository() : base() {}


        public List<Categoria> MostrarCategorias()
        {
            OracleDataReader reader;
            OracleConnection sqlCon = new OracleConnection();
            List<Categoria> list = new List<Categoria>();
            try
            {
                sqlCon = ConexionDB.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("SELECT * FROM Categorias", sqlCon);
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

        private Categoria map(OracleDataReader reader)
        {
            Categoria categoria = new Categoria();

            categoria.id_categoria = Convert.ToInt32(reader["id_categoria"]);
            categoria.nombre_categoria = Convert.ToString(reader["nombre_categoria"]);

            return categoria;
        }
    }
}
