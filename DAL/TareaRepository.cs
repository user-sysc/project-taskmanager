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
    public class TareaRepository : ConexionDB
    {
        private CategoriaRepository categoriaRepository = new CategoriaRepository();

        public string InsertarTarea(Tarea tarea)
        {
            OracleConnection sqlCon = new OracleConnection();
            try
            {
                sqlCon = ConexionDB.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("prc_InsertarTarea", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("descripcion", OracleDbType.Varchar2).Value = tarea.descripcion;
                comando.Parameters.Add("fecha", OracleDbType.Date).Value = tarea.fecha;
                comando.Parameters.Add("estado", OracleDbType.Varchar2).Value = tarea.estado;
                comando.Parameters.Add("id_categoria", OracleDbType.Decimal).Value = tarea.categoria.id_categoria;
                

                sqlCon.Open();
                comando.ExecuteReader();
                return "Se agrego la tarea " + tarea.descripcion;
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

        public List<Tarea> ConsultarTareas()
        {
            OracleDataReader reader;
            OracleConnection sqlCon = new OracleConnection();
            List<Tarea> listaTareas = new List<Tarea>();
            try
            {
                sqlCon = ConexionDB.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("ConsultarTareas", sqlCon); 
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add(new OracleParameter("Resultados", OracleDbType.RefCursor, ParameterDirection.Output));

                sqlCon.Open();
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    listaTareas.Add(MapearTarea(reader)); 
                }
                return listaTareas;
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

        public string EliminarTarea(int idTarea)
        {
            OracleConnection sqlCon = new OracleConnection();
            try
            {
                sqlCon = ConexionDB.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("prc_eliminarTarea", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("t_id_task", OracleDbType.Decimal).Value = idTarea;

                comando.Parameters.Add("eliminacion_exitosa", OracleDbType.Decimal).Direction = ParameterDirection.Output;
                sqlCon.Open();

                comando.ExecuteNonQuery();
                OracleDecimal eliminacionExitosa = (OracleDecimal)comando.Parameters["eliminacion_exitosa"].Value;
                if (eliminacionExitosa.ToInt32() == 1)
                {
                    return "Se eliminó la tarea correctamente";
                }
                else
                {
                    return "No se puede eliminar la tarea, verifique el ID de la tarea";
                }
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

        public void EliminarTareasCompletas()
        {
            OracleConnection sqlCon = new OracleConnection();
            try
            {
                sqlCon = ConexionDB.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("prc_eliminarTareasCompletas", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                sqlCon.Open();
                comando.ExecuteNonQuery();
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

        public void CambiarEstadoTarea(int idTarea)
        {
            OracleConnection sqlCon = new OracleConnection();
            try
            {
                sqlCon = ConexionDB.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("prc_CambiarEstadoTarea", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                //ID_TAREA
                comando.Parameters.Add("t_id_tarea", OracleDbType.Int32).Value = idTarea;
                //NUEVO_ESTADO
                comando.Parameters.Add("t_nuevo_estado", OracleDbType.Varchar2).Value = "COMPLETE";

                sqlCon.Open();
                comando.ExecuteNonQuery();
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

        public List<Tarea> FiltrarTareasPorFecha(DateTime fechaSeleccionada)
        {
            OracleConnection sqlCon = new OracleConnection();
            List<Tarea> tareasFiltradas = new List<Tarea>();

            try
            {
                sqlCon = ConexionDB.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("FiltrarTareasPorFecha", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                //FECHA_SELECCIONADA Y ID_USUARIO
                comando.Parameters.Add("t_fecha_seleccionada", OracleDbType.Date).Value = fechaSeleccionada;
                comando.Parameters.Add("resultados", OracleDbType.RefCursor, ParameterDirection.Output);

                sqlCon.Open();
                OracleDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    tareasFiltradas.Add(MapearTarea(reader));
                }

                return tareasFiltradas;
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


        public string ObtenerEstadoTareaPorId(int idTarea)
        {
            OracleConnection sqlCon = new OracleConnection();

            try
            {
                sqlCon = ConexionDB.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("ObtenerEstadoTareaPorId", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                //comando.Parameters.Add("email", OracleDbType.Varchar2).Value = email;

                comando.Parameters.Add("t_id_tarea", OracleDbType.Decimal).Value = idTarea;

                comando.Parameters.Add("t_estado", OracleDbType.Varchar2).Direction = ParameterDirection.Output;

                sqlCon.Open();
                comando.ExecuteNonQuery();

                string estado = Convert.ToString(comando.Parameters["p_estado"].Value);

                return estado;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el estado de la tarea: {ex.Message}");
                return "ERROR";
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }



        private Categoria Obtenercategoria(int id_categora)
        {
            return categoriaRepository.MostrarCategorias().Find(t => t.id_categoria == id_categora);
        }

        private Tarea MapearTarea(OracleDataReader reader)
        {
            Tarea tarea = new Tarea();

            tarea.idTask = Convert.ToInt32(reader["Id_Task"]);
            tarea.descripcion = Convert.ToString(reader["Descripcion"]);
            tarea.fecha = Convert.ToDateTime(reader["Fecha"]);
            tarea.estado = Convert.ToString(reader["Estado"]);

            int id_categoria = Convert.ToInt32(reader["Id_Categoria"]);
            tarea.categoria = Obtenercategoria(id_categoria);

            return tarea;
        }
    }
}

