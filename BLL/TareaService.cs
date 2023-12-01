using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class TareaService
    {
        private TareaRepository repository = new TareaRepository();

        public string insertarTarea(Tarea tarea)
        {
            return repository.InsertarTarea(tarea);
        }
        public string eliminarTarea(int id,int id_usuario)
        {
            return repository.EliminarTarea(id,id_usuario);
        }
        public List<Tarea> ObtenerTareas(int id_usuario)
        {
            return repository.ConsultarTareas(id_usuario);
        }
        public List<Tarea> FiltrarTareasPorFecha(DateTime fechaSeleccionada,int id_usuario)
        {
            return repository.FiltrarTareasPorFecha(fechaSeleccionada,id_usuario);
        }
        public string EliminarTareasCompletas(int id_usuario)
        {
            try
            {
                repository.EliminarTareasCompletas(id_usuario);
                return "Todas las tareas completadas se eliminaron correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar tareas completadas: " + ex.Message;
            }
        }

        public string CambiarEstadoTarea(int id)
        {
            try
            {
                repository.CambiarEstadoTarea(id);
                return "TASK COMPLETE.";
            }
            catch (Exception ex)
            {
                return "ERROR AL ACTUALIZAR EL ESTADO: " + ex.Message;
            }
        }

    }
}
