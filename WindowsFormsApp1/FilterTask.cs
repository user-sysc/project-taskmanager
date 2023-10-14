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
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class FilterTask : Form
    {
        TaskManagerService TMS = new TaskManagerService();
        public FilterTask()
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

        private void btnFilter_Click(object sender, EventArgs e)
        {

            DateTime fechaSeleccionada = dtpFechaFilter.Value;
            List<Tarea> tareasFiltradas = RealizarFiltradoPorFecha(fechaSeleccionada);

            if (tareasFiltradas.Count == 0)
            {
                dataview_filter.Rows.Clear();
                MessageBox.Show("No hay tareas registradas para la fecha seleccionada.", "Sin tareas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ActualizarGridView(tareasFiltradas);
            }
            dtpFechaFilter.Value = DateTime.Now;

        }

        private List<Tarea> RealizarFiltradoPorFecha(DateTime fechaSeleccionada)
        {
            List<Tarea> tareasFiltradas = new List<Tarea>();

            foreach (Tarea tarea in TMS.Consultar()) 
            {
                DateTime fechaTarea = DateTime.ParseExact(tarea.fecha, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                if (fechaTarea.Date == fechaSeleccionada.Date)
                {
                    tareasFiltradas.Add(tarea); //Agregamos nuestra fecha a nuestra lista de tareasFiltradas
                }
            }

            return tareasFiltradas;
        }
        private void ActualizarGridView(List<Tarea> tareasFiltradas)
        {
            dataview_filter.Rows.Clear();
            foreach (Tarea tarea in tareasFiltradas)
            {
                int rowIndex = dataview_filter.Rows.Add();
                dataview_filter.Rows[rowIndex].Cells["ColumnID"].Value = tarea.idTask;
                dataview_filter.Rows[rowIndex].Cells["ColumnDescripcion"].Value = tarea.descripcion;
                dataview_filter.Rows[rowIndex].Cells["ColumnCategoria"].Value = tarea.categoria;
                dataview_filter.Rows[rowIndex].Cells["ColumnFecha"].Value = tarea.fecha;
                dataview_filter.Rows[rowIndex].Cells["ColumnEstado"].Value = tarea.estado;
            }
        }

        private void FilterTask_Load(object sender, EventArgs e)
        {
            dtpFechaFilter.Value = DateTime.Now;
        }
    }
}
