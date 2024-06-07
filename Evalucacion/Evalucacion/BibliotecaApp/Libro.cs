using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp
{
    public class Libro
    {
        public string Titulo { get; set; }
        public Autor Autor { get; set; }
        public List<Capitulo> Capitulos { get; set; } = new List<Capitulo>();

        public Libro(string titulo, Autor autor)
        {
            Titulo = titulo;
            Autor = autor;
        }
    }
}