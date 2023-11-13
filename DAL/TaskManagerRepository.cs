using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class TaskManagerRepository
    {
        string fileName = "FILE_TASK.txt";

        public string Guardar(Tarea task)
        {
            var escritor = new StreamWriter(fileName, true);
            escritor.WriteLine(task.ToString());
            escritor.Close();
            return $"\nSE REGISTRÓ EXITOSAMENTE LA TAREA CON ID : {task.idTask}";
        }

        public List<Tarea> Consultar()
        {
            var TareaList = new List<Tarea>();
            try
            {
                var lector = new StreamReader(fileName);
                while (!lector.EndOfStream)
                {
                    TareaList.Add(Map(lector.ReadLine()));
                }
                lector.Close();
                return TareaList;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public Tarea Buscar(int Id)
        {
            List<Tarea> tareas = Consultar();
            return tareas.FirstOrDefault(l => l.idTask == Id);
        }

        public bool Eliminar(int Id)
        {
            try
            {
                var tareasList = Consultar();
                if (tareasList != null)
                {
                    var TareaAEliminar = tareasList.FirstOrDefault(e => e.idTask == Id);
                    if (TareaAEliminar != null)
                    {
                        tareasList.Remove(TareaAEliminar);
                        using (var escritor = new StreamWriter(fileName, false))
                        {
                            foreach (var establecimiento in tareasList)
                            {
                                escritor.WriteLine(establecimiento.ToString());
                            }
                        }
                        return true;
                    }
                }
            }
            catch (Exception)
            {

            }
            return false;
        }

        private Tarea Map(string linea)
        {
            Tarea obj = new Tarea();
            obj.idTask = int.Parse(linea.Split(';')[0]);
            obj.descripcion = linea.Split(';')[1];
            obj.categoria.nombre_categoria = linea.Split(';')[2];
            obj.fecha = linea.Split(';')[3];
            obj.estado = linea.Split(';')[4];

            return obj;
        }

        public void EliminarTask(int idtask)
        {
            try
            {
                List<Tarea> tareas = Consultar();
                FileStream file = new FileStream(fileName, FileMode.Create);
                file.Close();

                foreach (var item in tareas)
                {
                    if (item.idTask != idtask)
                    {
                        Guardar(item);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar la Tarea: {ex.Message}");
            }
        }
        public int ObtenerUltimoId()
        {
            int ultimoId = 0;
            try
            {
                if (File.Exists(fileName))
                {
                    var lector = new StreamReader(fileName);
                    while (!lector.EndOfStream)
                    {
                        string linea = lector.ReadLine();
                        Tarea tarea = Map(linea);
                        ultimoId = tarea.idTask;
                    }
                    lector.Close();
                }
                // Incrementa el ID después de obtenerlo del archivo
                ultimoId++;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener el último ID: {ex.Message}");
            }
            return ultimoId;
        }
        public void ActualizarEstadoTarea(int idTarea)
        {
            try
            {
                var tareas = Consultar();

                // Busca la tarea con el ID 
                var tareaUpdate = tareas.FirstOrDefault(t => t.idTask == idTarea);

                if (tareaUpdate != null)
                {
                    // Actualiza el estado de la tarea
                    tareaUpdate.estado = "COMPLETE";

                    // Guarda la lista actualizada en el archivo
                    using (var escritor = new StreamWriter(fileName, false))
                    {
                        foreach (var tarea in tareas)
                        {
                            escritor.WriteLine(tarea.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar el estado de la tarea: {ex.Message}");
            }
        }




    }
}
