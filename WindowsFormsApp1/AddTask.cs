using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace WindowsFormsApp1
{
    public partial class AddTask : Form
    {
        TaskManagerService TMS = new TaskManagerService();

        public AddTask()
        {
            InitializeComponent();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // RECUPERAMOS LA INFORMACION DIGITADA POR EL USUARIO
            string descripcion = txtDescripcion.Text;
            string fechaFinalizacion = dtpFecha.Value.ToString("dd/MM/yyyy");

            if (string.IsNullOrWhiteSpace(descripcion) || string.IsNullOrWhiteSpace(fechaFinalizacion))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de agregar una tarea.");
                return;
            }
            else
            {
                int id = TMS.ObtenerIdTask();
                
                Tarea nuevaTarea = new Tarea
                {
                    idTask = id,
                    descripcion = descripcion,
                    fecha = fechaFinalizacion,
                    estado = "PENDING"
                };
                // PERSISTENCIA EN EL FILE
                TMS.Guardar(nuevaTarea);
                MessageBox.Show("La tarea se agregó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescripcion.Text = ""; //para limpiar la caja de descripcion
                dtpFecha.ResetText(); //para limpiar el data timer

            }
        }


       

    }
}

