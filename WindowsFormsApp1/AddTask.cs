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
        TareaService service = new TareaService();
        
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
            try
            {
                // RECUPERAMOS LA INFORMACION DIGITADA POR EL USUARIO
                string descripcion = txtDescripcion.Text.ToUpper();
                string fechaFinalizacion = dtpFecha.Value.ToString("dd/MM/yyyy");
                //string categoria = cmbCategoria.Text.ToUpper();

                Categoria categoriaSeleccionada = cmbCategoria.SelectedItem as Categoria;


                if (string.IsNullOrWhiteSpace(descripcion) || string.IsNullOrWhiteSpace(fechaFinalizacion))
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de agregar una tarea.");
                    return;
                }
                else
                {

                    Tarea nuevaTarea = new Tarea
                    {
                        descripcion = descripcion,
                        categoria = categoriaSeleccionada,
                        fecha = fechaFinalizacion,
                        estado = "PENDING"
                    };

                    service.insertarTarea(nuevaTarea);

                    MessageBox.Show("La tarea se agregó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    txtDescripcion.Text = "";        //CLEAN COMBOBOX
                    dtpFecha.Value = DateTime.Now;   //FECHA ACTUALIZADA
                    cmbCategoria.SelectedIndex = -1; //CLEAN COMBOBOX
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar la tarea " + ex.Message);
            }
        }

        private void AddTask_Load(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Now;
            CargarCategoriasEnComboBox();

        }
        private void CargarCategoriasEnComboBox()
        {
            try
            {
                // Llama al método ListarCategorias para obtener las categorías
                TareaService obj = new TareaService();
                DataTable categorias = obj.listarCategorias();

                // Asigna la fuente de datos al ComboBox con el datasource
                cmbCategoria.DataSource = categorias;

                // Especificó qué columnas mostrar en el ComboBox
                cmbCategoria.DisplayMember = "nombre_categoria";  

                // Asignó el valor de la columna de identificación 
                cmbCategoria.ValueMember = "id_categoria";  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorías: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                
            }
        }

    }
}

