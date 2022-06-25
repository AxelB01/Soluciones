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

namespace WinFormsApp.Empleados
{
    public partial class Empleados : Form
    {
        List<Empleado> _empleadosRegistrados;
        public Empleados(List<Empleado> empleadosRegistrados)
        {
            InitializeComponent();
            _empleadosRegistrados = empleadosRegistrados;
        }

        private void LoadData(List<Empleado> consultaEmpleados)
        {
            BindingList<Empleado> empleados = new();

            foreach (var item in consultaEmpleados)
            {
                empleados.Add(item);
            }

            var source = new BindingSource
            {
                DataSource = empleados
            };
            empleadosGridView.DataSource = source;
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            LoadData(_empleadosRegistrados);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var searchTerm = txtBuscar.Text.Trim().ToUpper();
            _ = int.TryParse(searchTerm, out int id);

            List<Empleado> consultaEmpleados = new();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                consultaEmpleados = _empleadosRegistrados
                .Where(r =>
                r.Id == id ||
                (r.Nombres + ' ' + r.Apellidos).Contains(searchTerm)
                ).ToList();
            }
            else
            {
                consultaEmpleados = _empleadosRegistrados;
            }

            LoadData(consultaEmpleados);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using var registroForm = new RegistroEmpleado(null);
            var result = registroForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                var empleado = registroForm._empleado;
                empleado.Id = _empleadosRegistrados.Count + 1;

                _empleadosRegistrados.Add(empleado);
            }
            LoadData(_empleadosRegistrados);
        }

        private void empleadosGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (empleadosGridView.CurrentRow != null)
                {
                    contextMenuStrip1.Show(empleadosGridView, new Point(e.X, e.Y));
                }
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var empleado = (Empleado)empleadosGridView.CurrentRow.DataBoundItem;

            using var registroForm = new RegistroEmpleado(empleado);
            var result = registroForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                var empleadoForm = registroForm._empleado;

                var registro = _empleadosRegistrados
                    .First(r => r.Id == empleadoForm.Id);

                registro.Nombres = empleadoForm.Nombres;
                registro.Apellidos = empleadoForm.Apellidos;
                registro.Cargo = empleadoForm.Cargo;
                registro.Sueldo = empleadoForm.Sueldo;
            }
            LoadData(_empleadosRegistrados);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var empleado = (Empleado)empleadosGridView.CurrentRow.DataBoundItem;

            var message = $"¿Seguro qué quieres eliminar el registro con el ID:{empleado.Id}?";
            var title = "Confirmación";

            DialogResult dr = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                _empleadosRegistrados.Remove(empleado);
            }
            LoadData(_empleadosRegistrados);
        }
    }
}
