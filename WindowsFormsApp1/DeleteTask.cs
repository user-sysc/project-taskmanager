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
        //TaskManagerService TMS = new TaskManagerService();
        TareaService service = new TareaService();

        public DeleteTask()
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

            //RECUPERAMOS LA INFORMACION INGRESADA POR EL USUARIO
            string ID = txtId_delete.Text;
            if (string.IsNullOrWhiteSpace(ID))
            {
                MessageBox.Show("Por favor, complete el campo antes de eliminar una tarea.");
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
                string message = service.eliminarTarea(id);
                MessageBox.Show(message, "Resultado de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId_delete.Text = "";
            }

        }

        private void txtId_delete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // SI NO ES UN NUMERO DALE REVER PA, SOLO ACEPTA DIGITOS
                e.Handled = true;
            }
        }

        private void btnDeleteTaskC_Click(object sender, EventArgs e)
        {

            string msg = service.EliminarTareasCompletas();
            
            MessageBox.Show(msg, "Resultado de Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
