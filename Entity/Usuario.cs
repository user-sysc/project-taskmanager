using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Usuario
    {
        public int id_usuario { get; set; }
        public string usuario { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }

        public Usuario() { }
        public Usuario(int id_usuario, string usuario, string Email, string Clave)
        {
            this.id_usuario = id_usuario;
            this.usuario = usuario;
            this.Email = Email;
            this.Clave = Clave;
        }
        public override string ToString()
        {
            return $"{id_usuario};{usuario};{Email};{Clave};";
        }
    }
}
