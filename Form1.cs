using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Tarea_semana_1___Gestion_Tareas
{
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            private void btnAgregarTarea_Click(object sender, EventArgs e)
            {
                if (txtTarea.Text != "")
                {
                    lstTareas.Items.Add(txtTarea.Text);
                    txtTarea.Text = "";
                    MessageBox.Show("Se ha añadido la tarea");
                }
                else
                {
                    MessageBox.Show("Ingrese una tarea para añadirla");
                }
            }

            private void btnEliminarTarea_Click(object sender, EventArgs e)
            {
                if (lstTareas.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione una tarea para eliminar");
                }
                else
                {
                    lstTareas.Items.RemoveAt(lstTareas.SelectedIndex);
                    MessageBox.Show("Tarea Eliminada correctamente");
                }

            }

            private void btnLimpiarLista_Click(object sender, EventArgs e)
            {
                lstTareas.Items.Clear();
                MessageBox.Show("Se han eliminado todas las tareas");
            }
        }
    }