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
        public CategoriaRepository() : base()
        {

        }
        public string InsertarCategoria(Categoria categoria)
        {
            // Utiliza una sentencia INSERT sin mencionar el campo ID, ya que es una secuencia.
            string ssql = "INSERT INTO categorias (nombre_categoria) VALUES (:nombre)";

            // Abre la conexión a la base de datos
            AbrirConexion();
            OracleCommand orclCmd1 = conexion.CreateCommand();
            orclCmd1.CommandText = ssql;

            // Crea el parámetro para el nombre
            orclCmd1.Parameters.Add(new OracleParameter(":nombre", categoria.nombre_categoria));

            int i = orclCmd1.ExecuteNonQuery();

            // Cierra la conexión
            CerrarConexion();

            // Verifica el valor de 'i' para determinar si la inserción se realizó con éxito
            if (i > 0)
            {
                return "SE AGREGÓ LA CATEGORIA " + categoria.nombre_categoria;
            }
            else
            {
                return "NO SE PUDO AGREGAR LA CATEGORIA.";
            }
        }
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
