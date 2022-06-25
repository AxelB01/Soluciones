using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombres { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public string Cargo { get; set; } = string.Empty;
        public double Sueldo { get; set; }
        public double AFP
        {
            get
            {
                return Math.Round((Sueldo * 0.0287), 2);
            }
        }
        public double SFS
        {
            get
            {
                return Math.Round((Sueldo * 0.0304), 2);
            }
        }
        public double TD
        {
            get
            {
                return Math.Round((AFP + SFS), 2);
            }
        }

        [DisplayName("Neto")]
        public double SueldoNeto
        {
            get
            {
                return Math.Round((Sueldo - TD), 2);
            }
        }
    }
}
