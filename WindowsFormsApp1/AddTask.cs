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
        CategoriaService serviceCategorias = new CategoriaService();

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

                Categoria categoriaSeleccionada = (Categoria)cmbCategoria.SelectedItem;

                if (string.IsNullOrWhiteSpace(descripcion) || string.IsNullOrWhiteSpace(fechaFinalizacion))
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de agregar una tarea.");
                    return;
                }
                else
                {
                    if (dtpFecha.Value < DateTime.Now)
                    {
                        MessageBox.Show("No se puede registrar una tarea con fecha menor a la actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        Tarea tarea = new Tarea
                        {
                            descripcion = descripcion,
                            fecha = dtpFecha.Value,
                            estado = "PENDING",
                            categoria = categoriaSeleccionada
                        };

                        var mssg = service.insertarTarea(tarea);

                        MessageBox.Show(mssg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        txtDescripcion.Text = "";        //CLEAN COMBOBOX
                        dtpFecha.Value = DateTime.Now;   //FECHA ACTUALIZADA
                        cmbCategoria.SelectedIndex = -1; //CLEAN COMBOBOX
                    }
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
            ObtenerCategorias();
        }

        private void ObtenerCategorias()
        {
            try
            {
                List<Categoria> categorias = serviceCategorias.ObtenerCategorias();

                // Asigna la lista de categorías al ComboBox
                cmbCategoria.DataSource = categorias;
                cmbCategoria.DisplayMember = "nombre_categoria";
                cmbCategoria.ValueMember = "id_categoria";
                cmbCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorías: " + 
                    ex.Message);
            }
        }


    }
}

