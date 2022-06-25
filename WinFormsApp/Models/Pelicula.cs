using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Models
{
    public class Pelicula
    {
        [DisplayName("Título")]
        public string Titulo { get; set; } = String.Empty;
        public string Director { get; set; } = String.Empty;
        public string Escritor { get; set; } = String.Empty;
        [DisplayName("Género")]
        public string Genero { get; set; } = String.Empty;
        [DisplayName("Duración")]
        public int DuracionMinutos { get; set; } = 0;
        [DisplayName("Clasificación")]
        public string? Clasificacion { get; set; } = String.Empty;
        public string? Productora { get; set; } = String.Empty;
    }
}
