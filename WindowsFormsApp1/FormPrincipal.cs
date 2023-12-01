using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.checklist__32_; //ICON
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); // BOTON CERRAR VENTANA
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;  // BOTON MINIMIZAR VENTANA
        }
        //METODO PARA ABRIR EL FORMULARIO DENTRO DE UN PANEL
        public void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault(); //Busca el formulario
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AbrirFormulario<AddTask>(); //BOTON ADD
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            AbrirFormulario<DeleteTask>(); // BOTON DELETE
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FilterTask>(); // BOTON FILTER
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ShowTask>(); // BOTON SHOW
        }

        private void imgbtn_Click(object sender, EventArgs e)
        {
            string urlGitHub = "https://github.com/user-sysc/project-taskmanager";

            System.Diagnostics.Process.Start(urlGitHub);

        }

    }
}
