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
    public partial class DeleteTask : Form
    {
        TaskManagerService TMS = new TaskManagerService();

        public DeleteTask()
        {
            InitializeComponent();
        }

        private void DeleteTask_Load(object sender, EventArgs e)
        {

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //RECUPERAMOS LA INFORMACION INGRESADA POR EL USUARIO
            string ID = txtId_delete.Text;
            if (string.IsNullOrWhiteSpace(ID))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de agregar una tarea.");
                txtId_delete.Text = "";
                return;
            }
            else if (!int.TryParse(txtId_delete.Text, out int id) || string.IsNullOrWhiteSpace(txtId_delete.Text))
            {
                MessageBox.Show("Ingrese un ID de tarea válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId_delete.Text = "";
                return;
            }
            else
            {
                string message = TMS.EliminarTask(id);
                MessageBox.Show(message, "Resultado de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId_delete.Text = "";
            }

        }
    }
}
