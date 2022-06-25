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

namespace WinFormsApp.Pila
{
    public partial class StackForm : Form
    {
        Stack<Libro> _librosRegistrados;
        public StackForm(Stack<Libro> librosRegistrados)
        {
            InitializeComponent();
            _librosRegistrados = librosRegistrados;
        }

        private void LoadData(Stack<Libro>? consultaLibros)
        {
            BindingList<Libro> bindingList = new();

            if (consultaLibros != null)
            {
                foreach (var item in consultaLibros)
                {
                    bindingList.Add(item);
                }
            }
            else
            {
                bindingList = new(_librosRegistrados.ToList());
            }

            BindingSource source = new()
            {
                DataSource = bindingList
            };
            librosGridView.DataSource = source;
        }

        private void StackForm_Load(object sender, EventArgs e)
        {
            LoadData(_librosRegistrados);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var nombreLibro = txtAgregar.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(nombreLibro))
            {
                var message = "Debe ingresar el nombre del libro";
                var title = "Error";

                MessageBox.Show(message, title);
                return;
            }

            var id = _librosRegistrados.Count > 0 ? _librosRegistrados.Max(a => a.Id) + 1 : 1;

            var libro = new Libro
            {
                Id = id,
                Nombre = nombreLibro
            };

            _librosRegistrados.Push(libro);
            txtAgregar.Text = "";
            LoadData(_librosRegistrados);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_librosRegistrados.Count > 0)
            {
                var message = $"¿Seguro qué quieres eliminar el registro con el ID:{_librosRegistrados.Peek().Id}?";
                var title = "Advertencia";

                DialogResult dialogResult = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    _librosRegistrados.Pop();
                }
                LoadData(_librosRegistrados);
            }
        }
    }
}
