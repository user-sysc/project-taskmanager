using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Usuario
    {
        public int id_usuario { get; set; }
        public string P_Nombre { get; set; }
        public string S_Nombre { get; set; }
        public string P_Apellido { get; set; }
        public string S_Apellido { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }

        public Usuario() { }
        public Usuario(int id_usuario, string P_Nombre, string S_Nombre, string P_Apellido, string S_Apellido, string Email, string Clave)
        {
            this.id_usuario = id_usuario;
            this.P_Nombre = P_Nombre;
            this.S_Nombre = S_Nombre;
            this.P_Apellido = P_Apellido;
            this.S_Apellido = S_Apellido;
            this.Email = Email;
            this.Clave = Clave;
        }
        public override string ToString()
        {
            return $"{id_usuario};{P_Nombre};{S_Nombre};{P_Apellido};{S_Apellido};{Email};{Clave};";
        }
    }
}
