using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gridview
{
    internal class Acciones
    {
        List<Genero> Lgeneros = new List<Genero>
        {
            new Genero ("Del Toro",2016,"C","Comedia","1h"),
            new Genero ("Cuaron",2011,"B15","Thriller","1h 30 min"),
            new Genero ("Greta G",2023,"B","Suspenso","2 hora"),
            new Genero ("James wan",2025,"D","Terror","2h 45min"),
            new Genero ("James Gun",2005,"B12","Romance","1h"),
        };

        public List<Genero>mostrarG()
        {
            return Lgeneros;
        }
    }
}
