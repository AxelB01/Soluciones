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
    public partial class RegistroEmpleado : Form
    {
        public Empleado _empleado;
        public RegistroEmpleado(Empleado? empleado)
        {
            InitializeComponent();
            _empleado = empleado ?? new();
        }

        private void RegistroEmpleado_Load(object sender, EventArgs e)
        {
            txtNombres.Text = _empleado.Nombres;
            txtApellidos.Text = _empleado.Apellidos;
            txtCargo.Text = _empleado.Cargo;
            txtSueldo.Text = _empleado.Sueldo.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtSueldo.Text, out double sueldo))
            {
                _empleado.Sueldo = sueldo;
            }
            else
            {
                var message = "Debe ingresar una cantidad válida para el sueldo";
                var title = "Error";

                MessageBox.Show(message, title);
                return;
            }

            _empleado.Nombres = txtNombres.Text.ToUpper();
            _empleado.Apellidos = txtApellidos.Text.ToUpper();
            _empleado.Cargo = txtCargo.Text.ToUpper();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
