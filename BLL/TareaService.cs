using System;
using System.Collections.Generic;
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
            return repository.ObtenerTodasTareas();
        }
    }
}
