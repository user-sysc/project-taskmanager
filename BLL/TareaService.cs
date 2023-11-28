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
        public string eliminarTarea(int id)
        {
            return repository.EliminarTarea(id);
        }
        public List<Tarea> ObtenerTareas()
        {
            return repository.ConsultarTareas();
        }
        public List<Tarea> FiltrarTareasPorFecha(DateTime fechaSeleccionada)
        {
            return repository.FiltrarTareasPorFecha(fechaSeleccionada);
        }
        public string EliminarTareasCompletas()
        {
            try
            {
                repository.EliminarTareasCompletas();
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
