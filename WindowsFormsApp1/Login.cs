using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        private UsuarioService service = new UsuarioService();
        private AuthManager authManager = new AuthManager();
        
        public Login()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.checklist__32_; //ICON
        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;  // BOTON MINIMIZAR VENTANA
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit(); // BOTON CERRAR VENTANA
        }

        private void linkLabel_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register formRegister = new Register();
            AbrirFormulario(formRegister);

            txtB_email.Text = "";
            txtB_pass.Text = "";
        }
        private void AbrirFormulario(Form formulario)
        {
            Form formExistente = panel_login.Controls.OfType<FormPrincipal>().FirstOrDefault();

            if (formExistente != null)
            {
                formExistente.Hide();
            }

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panel_login.Controls.Add(formulario);
            panel_login.Tag = formulario;
            formulario.Show();
            formulario.BringToFront();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // RECUPERAMOS LA INFORMACION DIGITADA POR EL USUARIO
            string email = txtB_email.Text;
            string clave = txtB_pass.Text;

            if (string.IsNullOrWhiteSpace(txtB_email.Text) || string.IsNullOrWhiteSpace(txtB_pass.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de iniciar sesión.");
                return;
            }
            else
            {
                int usuarioEncontrado = Convert.ToInt32(service.ValidarUsuario(email, clave));
                int id_user = service.ObtenerIdUsuario(email);

                if (usuarioEncontrado > 0)
                {
                    // Guardamos el ID del usuario, gracias a nuestra clase autenticacion manager
                    authManager.IniciarSesion(id_user);

                    FormPrincipal home = new FormPrincipal();
                    home.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas. Por favor, verifique su email y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void picb_mostrar_Click(object sender, EventArgs e)
        {
            //PictureBox lo mandamos al frente
            picb_ocultar.BringToFront();
            //Mostramos la contraseña
            txtB_pass.PasswordChar = '\0';

        }

        private void picb_ocultar_Click(object sender, EventArgs e)
        {
            //PictureBox lo mandamos al frente para mostrarlo
            picb_mostrar.BringToFront();
            //Ocultamos la contraseña
            txtB_pass.PasswordChar = '*';
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtB_pass.PasswordChar = '*';
        }
    }
}
