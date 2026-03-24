using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private GestorTareas miGestor;

        public Form1()
        {
            InitializeComponent();

            miGestor = new GestorTareas();
        }

        private void ActualizarPantalla()
        {
            lstTareas.DataSource = null;

            lstTareas.DataSource = miGestor.ObtenerTodas();

            lblContadorTareas.Text = "Tareas totales: " + miGestor.ObtenerTodas().Count.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("Pon un título");
                return;
            }


            Tarea t = new Tarea(txtTitulo.Text, txtDescripcion.Text, dtpFecha.Value);


            miGestor.AgregarTarea(t);


            ActualizarPantalla();

            txtTitulo.Clear();
            txtDescripcion.Clear();

            chkPrioridadAlta.Checked = false;
            cmbCategoria.SelectedIndex = -1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Tarea seleccionada = (Tarea)lstTareas.SelectedItem;


            if (seleccionada != null)
            {

                miGestor.EliminarTarea(seleccionada);
                ActualizarPantalla();

            }
            else
            {
                MessageBox.Show("Selecciona una tarea");
            }
        }

        private void btnCompletar_Click(object sender, EventArgs e)
        {
            Tarea seleccionada = (Tarea)lstTareas.SelectedItem;

            if (seleccionada != null)
            {

                seleccionada.Completada = true;
                ActualizarPantalla();
            }
            else
            {
                MessageBox.Show("Selecciona una tarea");
            }
        }


        private void Form1_Load(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void chkPrioridadAlra_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            
            txtTitulo.Clear();
            txtDescripcion.Clear();

            
            chkPrioridadAlta.Checked = false;

            
            cmbCategoria.SelectedIndex = -1;
        }


    }

}