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
        TareaService service;

        public ShowTask()
        {
            InitializeComponent();
            TMS = new TaskManagerService();
            service = new TareaService();

            CargarTareas(); 
        }
        private void CargarTareas()
        {
            try
            {
                List<Tarea> tareas = TMS.Consultar();
                //List<Tarea> tareas = service.ObtenerTareas();
                dataview_show.Rows.Clear();

                foreach (Tarea tarea in tareas)
                {
                    int rowIndex = dataview_show.Rows.Add();
                    dataview_show.Rows[rowIndex].Cells["ColumnID"].Value = tarea.idTask;
                    dataview_show.Rows[rowIndex].Cells["ColumnDescripcion"].Value = tarea.descripcion;
                    dataview_show.Rows[rowIndex].Cells["ColumnCategoria"].Value = tarea.categoria;
                    dataview_show.Rows[rowIndex].Cells["ColumnFecha"].Value = tarea.fecha;
                    dataview_show.Rows[rowIndex].Cells["ColumnEstado"].Value = tarea.estado;
                }
            }
            catch (Exception)
            {
                throw;
            }  
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal formPrincipal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();
            if (formPrincipal != null)
            {
                formPrincipal.BringToFront();
            }
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {   
            if (int.TryParse(txtBoxShow.Text, out int idTarea))
            {
                string estadoActual = ObtenerEstadoTarea(idTarea);
                if (estadoActual == "PENDING")
                {
                    TMS.ActualizarEstadoTarea(idTarea);

                    CargarTareas();

                    txtBoxShow.Text = " ";

                    MessageBox.Show("TASK COMPLETE", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(estadoActual == "COMPLETE")
                {
                    MessageBox.Show("La tarea ya se encuentra en estado COMPLETED.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Ingrese un ID de tarea válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese el id de la tarea a marcar como COMPLETE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBoxShow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // SI NO ES UN NUMERO DALE REVER PA, SOLO ACEPTA DIGITOS
                e.Handled = true;
            }
        }
        private string ObtenerEstadoTarea(int idTarea)
        {
            foreach (DataGridViewRow fila in dataview_show.Rows)
            {
                if (fila.Cells["ColumnID"].Value != null)
                {
                    int id = Convert.ToInt32(fila.Cells["ColumnID"].Value);
                    if (id == idTarea)
                    {
                        return Convert.ToString(fila.Cells["ColumnEstado"].Value);
                    }
                }
            }
            return "NO ENCONTRADO";
        }
    }
}
