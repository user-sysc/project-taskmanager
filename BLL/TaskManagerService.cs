using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class TaskManagerService
    {
        TaskManagerRepository TaskDAL = null;
        public List<Tarea> TareaList = null;

        public TaskManagerService()
        {
            TaskDAL = new TaskManagerRepository();
            TareaList = TaskDAL.Consultar();
        }

        public String Guardar(Tarea task)
        {
            if (task == null)
            {
                return "ERROR... No se Puede Agregar Tareas Nulos o Sin Informacion.";
            }
            var msg = (TaskDAL.Guardar(task));
            TareaList = TaskDAL.Consultar();
            return msg;
        }
        public List<Tarea> Consultar()
        {
            return TaskDAL.Consultar();
        }
        public void MostrarTareas()
        {
            try
            {
                TareaList = TaskDAL.Consultar();

                if (TareaList.Count > 0)
                {
                    Console.WriteLine("Lista de Tareas registradas:");
                    foreach (var task in TareaList)
                    {
                        Console.WriteLine("------------------------------------------------");

                        Console.WriteLine($"Identificación Tarea: {task.idTask}");
                        Console.WriteLine($"Descripcion Tarea   : {task.descripcion}");
                        Console.WriteLine($"Fecha Creacion      : {task.fecha}");
                        Console.WriteLine($"Estado              : {task.estado}");
                    }
                }
                else
                {
                    Console.WriteLine("No hay tareas registradas.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al mostrar las Tareas: {ex.Message}");
                Console.WriteLine($"No hay tareas registradas");
            }
        }
        public string EliminarTask(int idTask)
        {
            try
            {
                Tarea task = TaskDAL.Buscar(idTask);

                if (task != null)
                {
                    TaskDAL.EliminarTask(idTask);
                    return $"\nSe eliminó la Tarea con Id: {idTask} satisfactoriamente.";
                }
                else
                {
                    return $"\nNo se encontró ninguna Tarea con el id: {idTask}.";
                }
            }
            catch (Exception ex)
            {
                return $"Error al eliminar la Tarea: {ex.Message}";
            }
        }
        public Tarea FiltrarPorId(int id)
        {
            return TareaList.FirstOrDefault(task => task.idTask == id);
        }
        public int ObtenerIdTask()
        {
            return TaskDAL.ObtenerUltimoId();
        }
    }
}
