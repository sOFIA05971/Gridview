using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gridview
{
    internal class Genero : Pelicula
    {
        public Genero() { }

        public Genero(string director, int anio, string clasificacion,string género, string duracion)
            : base(director, anio, clasificacion)
        {
            Género = género;
            Duracion = duracion;
        }
        
        public string Género { get; set; }
        public string Duracion { get; set; }
    }
}
