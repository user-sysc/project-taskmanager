using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace WindowsFormsApp1
{
    public partial class Register : Form
    {
        UsuarioService service = new UsuarioService();

        public Register()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Login formPrincipal = Application.OpenForms.OfType<Login>().FirstOrDefault();
            if (formPrincipal != null)
            {
                formPrincipal.BringToFront();
            }

            txtb_user.Text = "";
            txtb_email.Text = "";
            txtb_pass.Text = "";
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            // RECUPERAMOS LA INFORMACION DIGITADA POR EL USUARIO
            string user = txtb_user.Text;
            string email = txtb_email.Text;
            string clave = txtb_pass.Text;

            if (string.IsNullOrWhiteSpace(txtb_user.Text) || string.IsNullOrWhiteSpace(txtb_email.Text) || string.IsNullOrWhiteSpace(txtb_pass.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de registrarse.");
                return;
            }
            else
            {
                bool cuentaExistente = service.ValidarEmail(email);
                if (cuentaExistente)
                {
                    MessageBox.Show("Ya existe una cuenta con el correo electrónico proporcionado. Por favor, inicie sesión en lugar de registrarse nuevamente.");
                    return;
                }

                Usuario usuario = new Usuario
                {
                    usuario = user,
                    Email = email,
                    Clave = clave
                };

                var msg = service.insertarUser(usuario);
                MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
                Login formPrincipal = Application.OpenForms.OfType<Login>().FirstOrDefault();
                if (formPrincipal != null)
                {
                    formPrincipal.BringToFront();
                }
            }
        }

        private void pb_mostrar_Click(object sender, EventArgs e)
        {
            //PictureBox lo mandamos al frente
            pb_ocultar.BringToFront();
            //Mostramos la contraseña
            txtb_pass.PasswordChar = '\0';
        }

        private void pb_ocultar_Click(object sender, EventArgs e)
        {
            //PictureBox lo mandamos al frente para mostrarlo
            pb_mostrar.BringToFront();
            //Ocultamos la contraseña
            txtb_pass.PasswordChar = '*';
        }

        private void Register_Load(object sender, EventArgs e)
        {
            txtb_pass.PasswordChar = '*';
        }
    }
}
