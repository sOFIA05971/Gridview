using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gridview
{
    internal class Pelicula      
    {
        public Pelicula() { }
        public Pelicula(string director, int anio, string clasificacion)
        {
            Director = director;
            Anio = anio;
            Clasificacion = clasificacion;
        }

        public string Director { get; set; }
        public int Anio { get; set; }
        public string Clasificacion { get; set; }
    }
}
