using WinFormsApp.Models;

namespace WinFormsApp
{
    public partial class MenuPrincipal : Form
    {
        Pelicula[] peliculasRegistradas;
        List<Empleado> empleadosRegistrados;
        LinkedList<Estudiante> estudiantesRegistrados;
        Queue<Libro> librosRegistrados;
        Stack<Libro> librosRegistradosPila;

        public MenuPrincipal()
        {
            InitializeComponent();

            peliculasRegistradas = new Pelicula[10];
            empleadosRegistrados = new List<Empleado>();
            estudiantesRegistrados = new LinkedList<Estudiante>();
            librosRegistrados = new Queue<Libro>();
            librosRegistradosPila = new Stack<Libro>();
        }

        private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Peliculas.Peliculas peliculas = new(peliculasRegistradas);
            peliculas.ShowDialog();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados.Empleados empleados = new(empleadosRegistrados);
            empleados.ShowDialog();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaEnlazada.ListaEnlazada listaEnlazada = new(estudiantesRegistrados);
            listaEnlazada.ShowDialog();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cola.QueueForm queueForm = new(librosRegistrados);
            queueForm.ShowDialog();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pila.StackForm stackForm = new(librosRegistradosPila);
            stackForm.ShowDialog();
        }
    }
}
