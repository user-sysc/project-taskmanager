using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Tarea
    {
        public int idTask { get; set; }
        public string descripcion { get; set; }
        public string fechaCreacion { get; set; }
        public string estado { get; set; }
        
        public Tarea() { }
        public Tarea(int idTask, string descripcion, string fechaCreacion, string estado)
        {
            this.idTask = idTask;
            this.descripcion = descripcion;
            this.fechaCreacion = fechaCreacion;
            this.estado = estado;
        }
        public override string ToString()
        {
            return $"{idTask};{descripcion};{fechaCreacion};{estado};";
        }
    }
}
