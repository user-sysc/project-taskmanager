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
        //TaskManagerService TMS = new TaskManagerService();
        TareaService service = new TareaService();

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

            foreach (Tarea tarea in service.ObtenerTareas())
            {
                DateTime fechaTarea = tarea.fecha;

                if (fechaTarea.Date == fechaSeleccionada.Date)
                {
                    tareasFiltradas.Add(tarea); //Agregamos nuestra fecha a nuestra lista de tareasFiltradas
                }
            }

            return tareasFiltradas;
        }
        private void ActualizarGridView(List<Tarea> tareasFiltradas)
        {
            //dataview_filter.Rows.Clear();
            dataview_filter.Rows.Clear();
            dataview_filter.Columns.Clear();
            if (dataview_filter.ColumnCount == 0)
            {
                dataview_filter.Columns.Add("ID TASK", "ID TASK");
                dataview_filter.Columns.Add("DESCRIPCION", "DESCRIPCION");
                dataview_filter.Columns.Add("CATEGORIA", "CATEGORIA");
                dataview_filter.Columns.Add("FECHA FINALIZADO", "FECHA FINALIZADO");
                dataview_filter.Columns.Add("ESTADO", "ESTADO");
            }
            var tareas = tareasFiltradas;
            foreach (var tarea in tareas)
            {
                dataview_filter.Rows.Add(
                    tarea.idTask,
                    tarea.descripcion,
                    tarea.categoria.nombre_categoria,
                    tarea.fecha.ToString("dd/MM/yyyy"),
                    tarea.estado
                    );
            }
        }

        private void FilterTask_Load(object sender, EventArgs e)
        {
            dtpFechaFilter.Value = DateTime.Now;
        }
    }
}
