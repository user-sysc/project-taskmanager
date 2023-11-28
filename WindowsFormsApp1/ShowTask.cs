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
        TareaService service;

        public ShowTask()
        {
            InitializeComponent();
            service = new TareaService();
            //CargarTareas();
            MostrarTareas();
        }

        private void MostrarTareas()
        {
            dataview_show.Rows.Clear();
            dataview_show.Columns.Clear();
            if (dataview_show.ColumnCount == 0)
            {
                dataview_show.Columns.Add("ID TASK", "ID TASK");
                dataview_show.Columns.Add("DESCRIPCION", "DESCRIPCION");
                dataview_show.Columns.Add("CATEGORIA", "CATEGORIA");
                dataview_show.Columns.Add("FECHA FINALIZADO", "FECHA FINALIZADO");
                dataview_show.Columns.Add("ESTADO", "ESTADO");
            }
            var tareas = service.ObtenerTareas();
            foreach (var tarea in tareas)
            {
                dataview_show.Rows.Add(
                    tarea.idTask,
                    tarea.descripcion,
                    tarea.categoria.nombre_categoria,
                    tarea.fecha.ToString("dd/MM/yyyy"),
                    tarea.estado
                    );
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
                    service.CambiarEstadoTarea(idTarea);

                    MostrarTareas();

                    txtBoxShow.Text = " ";

                    MessageBox.Show("TASK COMPLETE", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(estadoActual == "COMPLETE")
                {
                    MessageBox.Show("La tarea ya se encuentra en estado COMPLETE.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (fila.Cells["ID TASK"].Value != null)
                {
                    int id = Convert.ToInt32(fila.Cells["ID TASK"].Value);
                    if (id == idTarea)
                    {
                        return Convert.ToString(fila.Cells["ESTADO"].Value);
                    }
                }
            }
            return "NO ENCONTRADO";
        }
    }
}
