﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class AuthManager
    {
        private static int usuarioActualId;

        public void IniciarSesion(int userId)
        {
            usuarioActualId = userId;
        }

        public int ObtenerUsuarioActual()
        {
            return usuarioActualId;
        }
    }

}
