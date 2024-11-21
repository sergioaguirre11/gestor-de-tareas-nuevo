using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionador_de_tareas
{
    public partial class Gestor : Form
    {
        private List<Tarea> Tareas = new List<Tarea>();

        public Gestor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public class Tarea
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
            public int Flag { get; set; }
           
        }
        private void ActualizarDataGridView(List<Tarea> tareas = null)
        {
            // Update the data source based on the provided list (optional)
            dataGridView1.DataSource = tareas ?? Tareas; // Use Tareas if tareas is null
        }

        private void RefrescaDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Tareas;

        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNombre.Text) || string.IsNullOrEmpty(TxtDescripcion.Text) || string.IsNullOrEmpty(TxtFlag.Text))
            {
                MessageBox.Show("Por favor, ingrese un valor en el campo.");
            }
            else if (!int.TryParse(TxtFlag.Text, out int flagValue) || (flagValue != 0 && flagValue != 1))
            {
                MessageBox.Show("El campo Flag solo debe contener 0 o 1.");
            }
            else
            {
                Tarea nuevaTarea = new Tarea
                {
                    Id = Tareas.Count + 1,
                    Nombre = TxtNombre.Text,
                    Descripcion = TxtDescripcion.Text,
                    Flag = Convert.ToInt32(TxtFlag.Text)
                };
                Tareas.Add(nuevaTarea);
                ActualizarDataGridView();
                RefrescaDataGridView();
                TxtNombre.Clear();
                TxtDescripcion.Clear();
                TxtFlag.Clear();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int indice = dataGridView1.SelectedRows[0].Index;
                Tarea tareaSeleccionada = Tareas[indice];

                // Verificar si el flag es 0
                if (tareaSeleccionada.Flag == 0)
                {
                    Tareas.RemoveAt(indice);
                    ActualizarDataGridView();
                }
                else
                {
                    MessageBox.Show("Solo se pueden eliminar tareas ya concluidas.");
                }
                RefrescaDataGridView();
            }
            else
            {
                MessageBox.Show("Seleccione una tarea para eliminar.");
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNombre.Text) || string.IsNullOrEmpty(TxtDescripcion.Text) || string.IsNullOrEmpty(TxtFlag.Text))
            {
                MessageBox.Show("Por favor, ingrese un valor en el campo.");
            }
            else if (!int.TryParse(TxtFlag.Text, out int flagValue) || (flagValue != 0 && flagValue != 1))
            {
                MessageBox.Show("El campo Flag solo debe contener 0 o 1.");
            }
            else
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int indice = dataGridView1.SelectedRows[0].Index;
                    Tarea TarealSeleccionada = Tareas[indice];
                    ActualizarDataGridView();
                    RefrescaDataGridView();
                    // Aquí puedes mostrar un formulario para editar los datos de la persona
                    // y luego actualizar la lista de personas
                }
                else
                {
                    MessageBox.Show("Seleccione una tarea para modificar.");
                }
            }
        }

        private void BtnTa_Click(object sender, EventArgs e)
        {
            List<Tarea> tareasActivas = Tareas.Where(t => t.Flag == 1).ToList();
            ActualizarDataGridView(tareasActivas);
        }

        private void btnTi_Click(object sender, EventArgs e)
        {
            List<Tarea> tareasActivas = Tareas.Where(t => t.Flag == 0).ToList();
            ActualizarDataGridView(tareasActivas);
        }

        private void Btnt_Click(object sender, EventArgs e)
        {
            ActualizarDataGridView();
        }
    }

}
