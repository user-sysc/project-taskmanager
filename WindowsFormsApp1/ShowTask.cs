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
            // OBTENEMOS LA LISTA DE TAREAS DESDE SERVICE
            List<Tarea> tareas = TMS.Consultar();

            dataview_show.Rows.Clear();

            // ASIGNAMOS MANUALMENTE LOS VALORES A LAS COLUMNAS 
            foreach (Tarea tarea in tareas)
            {
                int rowIndex = dataview_show.Rows.Add();
                dataview_show.Rows[rowIndex].Cells["ColumnID"].Value = tarea.idTask;
                dataview_show.Rows[rowIndex].Cells["ColumnDescripcion"].Value = tarea.descripcion;
                dataview_show.Rows[rowIndex].Cells["ColumnFecha"].Value = tarea.fecha;
                dataview_show.Rows[rowIndex].Cells["ColumnEstado"].Value = tarea.estado;
            }
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

        private void dataview_show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
