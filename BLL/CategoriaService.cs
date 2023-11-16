using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class CategoriaService
    {
        private CategoriaRepository repository = new CategoriaRepository();

        public List<Categoria> ObtenerCategorias()
        {
            return repository.MostrarCategorias();
        }
    }
}
