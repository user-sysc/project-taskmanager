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

        

        public List<Categoria> ObtenerTodos()
        {
            List<Categoria> list = new List<Categoria>();
            string ssql = "SELECT * FROM categorias";

            AbrirConexion();
            OracleCommand cmd = conexion.CreateCommand();
            cmd.CommandText = ssql;

            OracleDataReader Rdr = cmd.ExecuteReader();

            while (Rdr.Read())
            {
                list.Add(map(Rdr));
            }
            Rdr.Close();
            CerrarConexion();

            return list;

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
