using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Categoria
    {
        public int id_categoria { get; set; }
        public string nombre_categoria { get; set; }

        public Categoria() {}

        public Categoria(int id_categoria, string nombre_categoria)
        {
            this.id_categoria = id_categoria;
            this.nombre_categoria = nombre_categoria;
        }
    }
}
