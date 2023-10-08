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
    public partial class ShowTask : Form
    {
        TaskManagerService TMS;
        public ShowTask()
        {
            InitializeComponent();
            TMS = new TaskManagerService();

            CargarTareas(); // Llamamos el metodo para cargar las tareas en el DataGridView
        }

        private void CargarTareas()
        {
            List<Tarea> tareas = TMS.Consultar();

            // Asignar la lista de tareas al DataGridView
            dataview_show.DataSource = tareas;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            // Muestra el formulario principal (FormPrincipal) si no está ya visible
            FormPrincipal formPrincipal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();
            if (formPrincipal != null)
            {
                formPrincipal.BringToFront();
            }
        }

        private void ShowTask_Load(object sender, EventArgs e)
        {
            
        }
    }
}
