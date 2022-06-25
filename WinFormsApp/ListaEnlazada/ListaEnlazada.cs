using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Models;

namespace WinFormsApp.ListaEnlazada
{
    public partial class ListaEnlazada : Form
    {
        LinkedList<Estudiante> _estudiantesRegistrados;
        public ListaEnlazada(LinkedList<Estudiante> estudiantes)
        {
            InitializeComponent();
            _estudiantesRegistrados = estudiantes;
        }

        public void LoadData(LinkedList<Estudiante> consultaEstudiantes)
        {
            BindingList<Estudiante> estudiantes = new();

            foreach (var item in consultaEstudiantes)
            {
                estudiantes.Add(item);
            }

            BindingSource source = new();
            source.DataSource = estudiantes;

            estudiantesGridView.DataSource = source;
        }

        private void ListaEnlazada_Load(object sender, EventArgs e)
        {
            LoadData(_estudiantesRegistrados);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var searchTerm = txtBuscar.Text.Trim().ToUpper();
            var estudiantes = _estudiantesRegistrados.Where(a => a.Nombre.Contains(searchTerm))
                .OrderBy(a => a.Id)
                .ToArray();
            LinkedList<Estudiante> linkedListFiltered = new(estudiantes);
            LoadData(linkedListFiltered);
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            var nombreEstudiante = txtEstudiante.Text.Trim().ToUpper();
            if (!string.IsNullOrEmpty(nombreEstudiante))
            {
                var estudiante = new Estudiante
                {
                    Id = _estudiantesRegistrados.Count > 0 ? _estudiantesRegistrados.Max(a => a.Id) + 1 : 1,
                    Nombre = nombreEstudiante
                };

                _estudiantesRegistrados.AddFirst(estudiante);
            }
            else
            {
                var message = "Debe ingresar un nombre para el estudiante";
                var title = "Error";

                MessageBox.Show(message, title);
            }

            LoadData(_estudiantesRegistrados);
            txtEstudiante.Text = "";
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            var nombreEstudiante = txtEstudiante.Text.Trim().ToUpper();
            if (!string.IsNullOrEmpty(nombreEstudiante))
            {
                var estudiante = new Estudiante
                {
                    Id = _estudiantesRegistrados.Count > 0 ? _estudiantesRegistrados.Max(a => a.Id) + 1 : 1,
                    Nombre = nombreEstudiante
                };

                _estudiantesRegistrados.AddLast(estudiante);
            }
            else
            {
                var message = "Debe ingresar un nombre para el estudiante";
                var title = "Error";

                MessageBox.Show(message, title);
            }

            LoadData(_estudiantesRegistrados);
            txtEstudiante.Text = "";
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var estudiante = (Estudiante)estudiantesGridView.CurrentRow.DataBoundItem;

            var message = $"¿Seguro qué quieres eliminar el registro con el ID:{estudiante.Id}?";
            var title = "Advertencia";

            DialogResult dr = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                _estudiantesRegistrados.Remove(estudiante);
            }

            LoadData(_estudiantesRegistrados);
        }

        private void moverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var estudiante = (Estudiante)estudiantesGridView.CurrentRow.DataBoundItem;

            _estudiantesRegistrados.Remove(estudiante);

            estudiante.Id = _estudiantesRegistrados.Count > 0 ? _estudiantesRegistrados.Max(a => a.Id) + 1 : 1;
            _estudiantesRegistrados.AddLast(estudiante);

            LoadData(_estudiantesRegistrados);
        }

        private void estudiantesGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (estudiantesGridView.CurrentRow != null)
                {
                    contextMenuStrip1.Show(estudiantesGridView, new Point(e.X, e.Y));
                }
            }
        }

    }
}
