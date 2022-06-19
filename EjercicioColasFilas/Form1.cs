using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjercicioColasFilas.Models;

namespace EjercicioColasFilas
{
    public partial class Form1 : Form
    {
        List<Panel> panels = new List<Panel>();
        Queue<string> queue = new Queue<string>();
        Stack<string> stack = new Stack<string>();
        LinkedList<string> linkedList = new LinkedList<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panels.Add(panelCola);
            panels.Add(panelPila);
            panels.Add(panelListaEnlazada);

            //Bring the first panel to the front
            panels.Find(x => x.Name == "panelCola").BringToFront();
        }

        private void registroColaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panels.Find(x => x.Name == "panelCola").BringToFront();
        }

        private void btnColaAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCola.Text))
            {
                var title = "Alerta";
                var text = "Debe completar llenar el campo de texto";
                MessageBox.Show(text, title);
            }

            if (!string.IsNullOrEmpty(textBoxCola.Text))
            {
                var text = textBoxCola.Text;
                queue.Enqueue(text.ToUpper().Trim());
                textBoxCola.Text = "";
            }

            FillGridViewCola();
        }

        private void btnColaEliminar_Click(object sender, EventArgs e)
        {
            if (queue.Count > 0)
            {
                var title = "Alerta";
                var message = $"¿Seguro que desea eliminar el libro: {queue.Peek()}?";
                var buttons = MessageBoxButtons.YesNo;
                DialogResult dialog = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    queue.Dequeue();
                }
            }

            FillGridViewCola();
        }

        public void FillGridViewCola()
        {
            var bindingList = new BindingList<Libro>();
            var index = 1;
            foreach (var item in queue)
            {
                var libro = new Libro
                {
                    Id = index,
                    Nombre = item
                };
                bindingList.Add(libro);
                index++;
            }
            var source = new BindingSource(bindingList, null);
            dataGridViewCola.DataSource = source;
        }

        private void registroPilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panels.Find(x => x.Name == "panelPila").BringToFront();
        }

        private void btnPilaAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPila.Text))
            {
                var title = "Alerta";
                var text = "Debe completar llenar el campo de texto";
                MessageBox.Show(text, title);
            }

            if (!string.IsNullOrEmpty(textBoxPila.Text))
            {
                var text = textBoxPila.Text;
                stack.Push(text.ToUpper().Trim());
                textBoxPila.Text = "";
            }

            FillGridViewPila();
        }

        private void btnPilaEliminar_Click(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                var title = "Alerta";
                var message = $"¿Seguro que desea eliminar el libro: {stack.Peek()}?";
                var buttons = MessageBoxButtons.YesNo;
                DialogResult dialog = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    stack.Pop();
                }
            }

            FillGridViewPila();
        }

        public void FillGridViewPila()
        {
            var bindingList = new BindingList<Libro>();
            var index = 1;
            foreach (var item in stack)
            {
                var libro = new Libro
                {
                    Id = index,
                    Nombre = item
                };
                bindingList.Add(libro);
                index++;
            }
            var source = new BindingSource(bindingList, null);
            dataGridViewPila.DataSource = source;
        }

        private void listasEnlazadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panels.Find(x => x.Name == "panelListaEnlazada").BringToFront();
        }

        private void btnListaEnlazadaAgregarPrimero_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxListaEnlazada.Text))
            {
                var title = "Alerta";
                var text = "Debe completar llenar el campo de texto";
                MessageBox.Show(text, title);
            }

            if (!string.IsNullOrEmpty(textBoxListaEnlazada.Text))
            {
                var text = textBoxListaEnlazada.Text;
                linkedList.AddFirst(text.ToUpper().Trim());
                textBoxListaEnlazada.Text = "";
            }

            FillGridViewListaEnlazada();
        }

        private void btnListaEnlazadaAgregarUltimo_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxListaEnlazada.Text))
            {
                var title = "Alerta";
                var text = "Debe completar llenar el campo de texto";
                MessageBox.Show(text, title);
            }

            if (!string.IsNullOrEmpty(textBoxListaEnlazada.Text))
            {
                var text = textBoxListaEnlazada.Text;
                linkedList.AddLast(text.ToUpper().Trim());
                textBoxListaEnlazada.Text = "";
            }

            FillGridViewListaEnlazada();
        }

        public void FillGridViewListaEnlazada()
        {
            var bindingList = new BindingList<Estudiante>();
            var index = 1;
            foreach (var item in linkedList)
            {
                var estudiante = new Estudiante
                {
                    Id = index,
                    Nombre = item
                };
                bindingList.Add(estudiante);
                index++;
            }
            var source = new BindingSource(bindingList, null);
            dataGridViewListaEnlazada.DataSource = source;
        }

        private void dataGridViewListaEnlazada_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dataGridViewListaEnlazada.CurrentCell = dataGridViewListaEnlazada.Rows[e.RowIndex].Cells[0];
                dataGridViewListaEnlazada.Rows[e.RowIndex].Selected = true;

                contextMenuListaEnlazada.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void moverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var estudiante = (Estudiante)dataGridViewListaEnlazada.CurrentRow.DataBoundItem;

            LinkedListNode<string> linkedListNode = linkedList.Find(estudiante.Nombre);
            linkedList.Remove(linkedListNode);
            linkedList.AddLast(estudiante.Nombre);

            FillGridViewListaEnlazada();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var estudiante = (Estudiante)dataGridViewListaEnlazada.CurrentRow.DataBoundItem;

            var message = $"¿Seguro que desea eliminar el estudiante: {estudiante.Nombre}, con el ID: {estudiante.Id}?";
            var tittle = "Alerta";
            var buttons = MessageBoxButtons.YesNo;

            DialogResult dialogResult = MessageBox.Show(message, tittle, buttons);

            if (dialogResult == DialogResult.Yes)
            {
                LinkedListNode<string> linkedListNode = linkedList.Find(estudiante.Nombre);
                linkedList.Remove(linkedListNode);
            }

            FillGridViewListaEnlazada();
        }
    }
}
