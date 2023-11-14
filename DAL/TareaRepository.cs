using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Entity;
using System.Data;

namespace DAL
{
    public class TareaRepository : ConexionDB
    {
        private CategoriaRepository categoriaRepository = new CategoriaRepository();

        public TareaRepository() : base()
        {

        }
        public DataTable ListarCategorias()
        {
            DataTable tabla = new DataTable();
            AbrirConexion();
            try
            {
                using (OracleCommand comando = conexion.CreateCommand())
                {
                    comando.CommandText = "ListarCategorias";
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.Add("p_cursor", OracleDbType.RefCursor, ParameterDirection.Output);

                    using (OracleDataReader leerFilas = comando.ExecuteReader())
                    {
                        tabla.Load(leerFilas);
                    }
                }

                return tabla;
            }
            catch (Exception)
            {
                CerrarConexion();
                throw;
            }
        }
//        SELECT t.idTask, t.descripcion, t.fecha, t.estado, c.nombre_categoria
//FROM tareas t
//INNER JOIN categorias c ON t.id_categoria = c.id_categoria;

        public string InsertarTarea(Tarea tarea)
        {
            try
            {
                string ssql = "INSERT INTO tareas (DESCRIPCION, FECHA_FINALIZADO, ESTADO, ID_CATEGORIA) VALUES (:descripcion, :fecha, :estado, :categoria)";
                AbrirConexion();
                OracleCommand orclCmd = conexion.CreateCommand();
                orclCmd.CommandText = ssql;

                orclCmd.Parameters.Add(new OracleParameter(":descripcion", tarea.descripcion));
                orclCmd.Parameters.Add(new OracleParameter(":fecha_finalizado", tarea.fecha));
                orclCmd.Parameters.Add(new OracleParameter(":estado", tarea.estado));
                orclCmd.Parameters.Add(new OracleParameter(":categoria", tarea.categoria.id_categoria));

                int i = orclCmd.ExecuteNonQuery();

                CerrarConexion();

                if (i > 0)
                {
                    return $"SE AGREGÓ LA TAREA {tarea.descripcion}";
                }
                else
                {
                    return "NO SE PUDO AGREGAR LA TAREA.";
                }
            }
            catch (Exception )
            {
                throw;
            }
            
        }

        public string EliminarTarea(int id)
        {
            try
            {
                string ssql = "DELETE FROM Tareas WHERE IDTASK = :id";
                AbrirConexion();
                OracleCommand cmd = conexion.CreateCommand();
                cmd.CommandText = ssql;

                cmd.Parameters.Add(new OracleParameter(":id", id));

                int i = cmd.ExecuteNonQuery();
                CerrarConexion();

                if (i > 0)
                {
                    return $"SE ELIMINO LA TAREA CON ID --> {id}";
                }
                else
                {
                    return "NO SE ENCONTRÓ NINGUNA TAREA CON EL ID ESPECIFICADO.";
                }
            }
            catch (Exception ex)
            {
                return "ERROR AL ELIMNAR: " + ex.Message;
            }
        }

        //public string EditarTarea(Tarea tarea)
        //{
        //    string ssql = "UPDATE Tareas SET Descripcion = :descripcion, Categoria = :categoria, Fecha = :fecha, Estado = :estado WHERE IDTASK = :id";
        //    AbrirConexion();
        //    OracleCommand cmd = conexion.CreateCommand();
        //    cmd.CommandText = ssql;

        //    cmd.Parameters.Add(new OracleParameter(":descripcion", tarea.descripcion));
        //    cmd.Parameters.Add(new OracleParameter(":categoria", tarea.categoria));
        //    cmd.Parameters.Add(new OracleParameter(":fecha", tarea.fecha));
        //    cmd.Parameters.Add(new OracleParameter(":estado", tarea.estado));
        //    cmd.Parameters.Add(new OracleParameter(":id", tarea.idTask));

        //    int i = cmd.ExecuteNonQuery();
        //    CerrarConexion();

        //    if (i == 1)
        //    {
        //        return $"SE ACTUALIZÓ LA TAREA CON LA DESCRIPCION --> {tarea.descripcion}";
        //    }
        //    else if (i == 0)
        //    {
        //        return "NO SE ENCONTRÓ UNA TAREA CON EL ID ESPECIFICADO.";
        //    }
        //    else
        //    {
        //        return "ERROR AL ACTUALIZAR LA TAREA. SE ACTUALIZARON MULTIPLES REGISTROS.";
        //    }
        //}

        public List<Tarea> ObtenerTodasTareas()
        {
            List<Tarea> listaTareas = new List<Tarea>();
            string ssql = "SELECT * FROM Tareas";

            AbrirConexion();
            OracleCommand cmd = conexion.CreateCommand();
            cmd.CommandText = ssql;

            OracleDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                listaTareas.Add(MapearTarea(rdr));
            }

            rdr.Close();
            CerrarConexion();

            return listaTareas;
        }

        private Tarea MapearTarea(OracleDataReader reader)
        {
            Tarea tarea = new Tarea();

            tarea.idTask = Convert.ToInt32(reader["ID_TASK"]);
            tarea.descripcion = Convert.ToString(reader["DESCRIPCION"]);

            //categoria
            //int id_categoria = Convert.ToInt32(reader["ID_CATEGORIA"]);
            //tarea.categoria = Obtenercategoria(id_categoria);

            tarea.fecha = Convert.ToString(reader["FECHA_FINALIZADO"]);
            tarea.estado = Convert.ToString(reader["ESTADO"]);

            return tarea;
        }

        private Categoria Obtenercategoria(int id_categora)
        {
            return categoriaRepository.ObtenerTodos().Find(p => p.id_categoria == id_categora);
        }
    }
}

