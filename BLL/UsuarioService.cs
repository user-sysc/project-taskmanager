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
    public class UsuarioService
    {
        private UsuarioRepository repository = new UsuarioRepository();

        public string insertarUser(Usuario usuario)
        {
            return repository.InsertarUsuario(usuario);
        }
        public int ObtenerIdUsuario(string email)
        {
            return repository.ObtenerIdUsuario(email);
        }
        public bool ValidarUsuario(string email, string clave)
        {
            return repository.ValidarUsuario(email, clave);
        }
        public bool ValidarEmail(string email)
        {
            return repository.ValidarEmail(email);
        }
        public List<Usuario> ObtenerUsuarios()
        {
            return repository.MostrarUsuarios();
        }
    }
}
