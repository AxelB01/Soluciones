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

namespace WinFormsApp.Peliculas
{
    public partial class RegistroPelicula : Form
    {
        public Pelicula _pelicula;
        public int _id = 0;
        public RegistroPelicula(Pelicula? pelicula, int id)
        {
            InitializeComponent();

            _pelicula = pelicula ?? (new());
            _id = id;
        }

        private void RegistroPelicula_Load(object sender, EventArgs e)
        {
            txtTitulo.Text = _pelicula.Titulo;
            txtDirector.Text = _pelicula.Director;
            txtEscritor.Text = _pelicula.Escritor;
            txtGenero.Text = _pelicula.Genero;
            txtDuracion.Text = _pelicula.DuracionMinutos.ToString();
            txtClasificacion.Text = _pelicula.Clasificacion;
            txtProductora.Text = _pelicula.Productora;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (Int32.TryParse(txtDuracion.Text, out int duracion))
            {
                _pelicula.DuracionMinutos = duracion;
            }
            else
            {
                string titulo = "Error";
                string mensaje = "La cantidad ingresada en \"Duración\" es incorrecta";
                MessageBox.Show(mensaje, titulo);
                return;
            }

            _pelicula.Titulo = txtTitulo.Text.ToUpper().Trim();
            _pelicula.Director = txtDirector.Text.ToUpper().Trim();
            _pelicula.Escritor = txtEscritor.Text.ToUpper().Trim();
            _pelicula.Genero = txtGenero.Text.ToUpper().Trim();
            _pelicula.Clasificacion = txtClasificacion.Text.ToUpper().Trim();
            _pelicula.Productora = txtProductora.Text.ToUpper().Trim();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
