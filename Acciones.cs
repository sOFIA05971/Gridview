using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
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

        Genero g = new Genero();

        public List<Genero> mostrarG()
        {
            return Lgeneros;
        }

        public bool EliminarAnio(int anio)
        {
            try
            {
                var objetoeliminar = Lgeneros.Find(x => x.Anio == anio);
                if (objetoeliminar != null)
                {
                    Lgeneros.Remove(objetoeliminar);
                    return true;
                }
                return false;

            }
            catch (Exception)
            {
                return false;

            }
        }

        public bool AgregarA(string director, int anio, string clasificacion, string género, string duracion)
        {
            try
            {
                Lgeneros.Add(new Genero( g.Director= director, g.Anio = anio, g.Clasificacion = clasificacion, g.Género = género, g.Duracion= duracion));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ActualizarG(string director, int anio, string clasificacion, string género, string duracion)
        {
            try
            {
                var objetoActualizar = Lgeneros.Find(x => x.Anio == anio);
                if (objetoActualizar != null)
                {
                    objetoActualizar.Director = director;
                    objetoActualizar.Clasificacion = clasificacion;
                    objetoActualizar.Género = género;
                    objetoActualizar.Duracion = duracion;
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
