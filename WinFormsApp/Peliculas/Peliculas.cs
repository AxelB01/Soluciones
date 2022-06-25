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
    public partial class Peliculas : Form
    {
        Pelicula[] _peliculasRegistradas;
        public Peliculas(Pelicula[] peliculasRegistradas)
        {
            InitializeComponent();
            _peliculasRegistradas = peliculasRegistradas;
        }

        private void Peliculas_Load(object sender, EventArgs e)
        {
            LoadData(_peliculasRegistradas);
        }

        private void LoadData(Pelicula[] consultaPeliculas)
        {
            BindingList<Pelicula> peliculas = new();

            foreach (var item in consultaPeliculas)
            {
                if (item != null)
                {
                    peliculas.Add(item);
                }
            }

            var source = new BindingSource
            {
                DataSource = peliculas
            };
            peliculasGridView.DataSource = source;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var id = 0;

            foreach (var item in _peliculasRegistradas)
            {
                if (item != null)
                {
                    id++;
                }
            }

            if (id < 10)
            {
                using var registroForm = new RegistroPelicula(null, id);
                var resultado = registroForm.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    _peliculasRegistradas[id] = registroForm._pelicula;
                    LoadData(_peliculasRegistradas);
                }
            }
            else
            {
                string titulo = "Error";
                string mensaje = "El registro está completo!";

                MessageBox.Show(mensaje, titulo);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var consultaPeliculas = _peliculasRegistradas;

            var buscar = txtBuscar.Text.ToUpper().Trim();
            if (buscar.Length > 0)
            {
                consultaPeliculas = _peliculasRegistradas
                .Where(a => a != null)
                .Where(a => a.Titulo.Contains(buscar))
                .ToArray();
            }
            
            LoadData(consultaPeliculas);
        }

        private void peliculasGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (peliculasGridView.CurrentRow != null)
                {
                    contextMenuStrip1.Show(peliculasGridView, new Point(e.X, e.Y));
                }
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pelicula = (Pelicula)peliculasGridView.CurrentRow.DataBoundItem;
            var index = Array.IndexOf(_peliculasRegistradas, pelicula);

            using var registroForm = new RegistroPelicula(pelicula, index);
            var resultado = registroForm.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                _peliculasRegistradas[index] = registroForm._pelicula;
                LoadData(_peliculasRegistradas);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string titulo = "Registro Imprimido";
            string mensaje = "El registro ha sido imprimido correctamente!";

            var items = 0;

            foreach (var item in _peliculasRegistradas)
            {
                if (item != null)
                {
                    items++;
                }
            }

            if (items > 0)
            {
                var nombreDocumento = @"C:\Users\Axel Bernard\Documents\UCE\UCE(C6)\Analisis y Optimizacion de Algoritmos (ISW-132-1)\Lista Peliculas.txt";

                using (var fs = new FileStream(nombreDocumento, FileMode.Create, FileAccess.Write))
                {
                    using (var sw = new StreamWriter(fs))
                    {
                        sw.WriteLine("Listado de películas y series");

                        foreach (var item in _peliculasRegistradas)
                        {
                            if (item != null)
                            {
                                sw.WriteLine($"\nTítulo: {item.Titulo} \nDirector: {item.Director} \nEscritor: {item.Escritor} \nGénero: {item.Genero} \nDuración en minutos: {item.DuracionMinutos} minutos " +
                                         $"\nClasificación: {item.Clasificacion} \nProductora: {item.Productora}");
                            }
                        }
                    }
                }
            }
            else
            {
                titulo = "Advertensia!";
                mensaje = "No existen registro para exportar...";
            }

            MessageBox.Show(mensaje, titulo);
        }
    }
}
