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
        public DateTime fecha { get; set; }
        public string estado { get; set; }
        public Categoria categoria { get; set; }
        
        
        public Tarea() { }

        public Tarea(int idTask, string descripcion, Categoria categoria, DateTime fecha, string estado)
        {
            this.idTask = idTask;
            this.descripcion = descripcion;
            this.fecha = fecha;
            this.estado = estado;
            this.categoria = categoria;
        }
    }
}
